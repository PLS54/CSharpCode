using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using Sanford.StateMachineToolkit;
using System.Threading;
using System.IO;
using System.Reflection;
using System.Media;
using System.Collections.ObjectModel;

namespace PLS.Curling
{
	using ResGraphic = PLS.Curling.Properties.Resources;
    using System.Runtime.InteropServices;

	public partial class Form1 : Form, ISynchronizeInvoke // ICurlingTimerActionHandler 
	{
        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);
        
        private TimeSpan m_dtTeam1 = new TimeSpan(1, 0, 0);
		private TimeSpan m_dtTeam2 = new TimeSpan(1, 0, 0);
		private DateTime m_timeIn = DateTime.MinValue;
		private int m_numberOfEndsToPlay = 8;
		private int m_timeOutLeftTeam1 = 2;
		private int m_timeOutLeftTeam2 = 2;
		private int m_rockCount = 0;
		private int m_currentEnd = 1;
		private int m_timeOutUsedThisEndTeam1 = 0;
		private int m_timeOutUsedThisEndTeam2 = 0;
		private Collection<ScoreSheetLine> m_scoreSheet = new Collection<ScoreSheetLine>();
		private CurlingTimmerStateMachine m_stateMachine = null;
		delegate void SetTextCallback(string text);

		public Form1()
		{
			StartLoging();
			InitializeComponent();
			SetRockColor();
			buttonDummy.Select();
			ControlBox = false;
			m_numberOfEndsToPlay = NumberOfEndsToPlaySet;
			try {
				ControlBox = TimerUtil.DemoMode;
				if (TimerUtil.DemoMode) {
					Text += " (Demo mode)";
					m_numberOfEndsToPlay = 2;
				}
			} catch (NullReferenceException) {
			}
			SetTimeAllowed();

		}
		private void Form1_Load(object sender, EventArgs e)
		{
			DisplayCurrentTimeInDialog();
			backgroundWorker1.RunWorkerAsync();
		}
	#region TransitionHandler
		private void HandleExitingState(object sender, StateEventArgs e)
		{
			TimerUtil.TraceAndDebugMessage(string.Format("Transition Exiting:\tState ID: {0}", ((CurlingTimmerStateMachine.StateID)(e.StateID)).ToString()), 1);
			switch ((CurlingTimmerStateMachine.StateID)e.StateID) {
				case CurlingTimmerStateMachine.StateID.TimingTeam1:
				case CurlingTimmerStateMachine.StateID.TimingTeam2:
					FixTeamsNewTime((CurlingTimmerStateMachine.StateID) e.StateID);
					break;
			}

		}
		private  void HandleTransitionCompleted(object sender, TransitionCompletedEventArgs e)
		{
			TimerUtil.TraceAndDebugMessage(string.Format("Transition Completed at {0}:\tState ID: {1}\tEvent ID: {2}",
			DateTime.Now,
			((CurlingTimmerStateMachine.StateID)(e.StateID)).ToString(),
			((CurlingTimmerStateMachine.EventID)(e.EventID)).ToString()), 1);
			switch ((CurlingTimmerStateMachine.StateID)e.StateID) {
				case CurlingTimmerStateMachine.StateID.TimingTeam1:
				case CurlingTimmerStateMachine.StateID.TimingTeam2:
					ProcessTimingTeamsEvents();
					break;
				case CurlingTimmerStateMachine.StateID.WaitingForRockReset:
					ProcessWaitingForRockResetEvents();
					break;
				case CurlingTimmerStateMachine.StateID.TimingBetweenEnds:
					ProcessTimingBetweenEndsEvents();
					break;
				case CurlingTimmerStateMachine.StateID.TimeOutDuringEnd:
					ProcessTimeOutDuringEndEvents();
					break;
				case CurlingTimmerStateMachine.StateID.EndOfGame:
					ProcessEndOfGameEvents();
					break;
			}
		}
	#endregion
	#region ProcessEvents
		private void ProcessTimingTeamsEvents()
		{
			if (radioButtonTeam1.Checked) {
				radioButtonTeam2.Visible = false;
			} else {
				radioButtonTeam1.Visible = false;
			}
			radioButtonTeam1.Enabled = false;
			radioButtonTeam2.Enabled = false;
			buttonTimeOut.Enabled = true;

			if ((CurlingTimmerStateMachine.StateID)m_stateMachine.CurrentStateID == (CurlingTimmerStateMachine.StateID.TimingTeam1)) {
				if (m_timeOutLeftTeam1 <= 0) {
					buttonTimeOut.Enabled = false;
				}
				TimerUtil.PlaySound(Properties.Resources.Team1);
				pbTeam1Status.Image = ResGraphic.GreenDot;
				pbTeam2Status.Image = ResGraphic.RedDot;
			} else if ((CurlingTimmerStateMachine.StateID)m_stateMachine.CurrentStateID == (CurlingTimmerStateMachine.StateID.TimingTeam2)) {
				if (m_timeOutLeftTeam2 <= 0) {
					buttonTimeOut.Enabled = false;
				}
				TimerUtil.PlaySound(Properties.Resources.Team2);
				pbTeam2Status.Image = ResGraphic.GreenDot;
				pbTeam1Status.Image = ResGraphic.RedDot;
			}
			SetReferenceTimeIn = DateTime.Now;
			if (m_rockCount++ == 16) {
				m_stateMachine.Send((int)CurlingTimmerStateMachine.EventID.EndFinished, null);
			}
			SetRockCount();
		}
		private void ProcessWaitingForRockResetEvents()
		{
            stopTimingToolStripMenuItem.Enabled = false;
            m_scoreSheet.Add(new ScoreSheetLine(TimeAllowedForGame - TimeForTeam1, TimeAllowedForGame - TimeForTeam2, m_timeOutUsedThisEndTeam1, m_timeOutUsedThisEndTeam2));
			m_timeOutUsedThisEndTeam1 = 0;
			m_timeOutUsedThisEndTeam2 = 0;
			m_rockCount = 0;
			SetRockCount();
			if (EndOfRegularPlay()) {
				HandleExtraEnds();
			}
			TimerUtil.TraceAndDebugMessage("Cancelling", 1);
			backgroundWorker2.CancelAsync();
			buttonTimeIn.Enabled = true;
			buttonTimeOut.Enabled = false;
			radioButtonTeam1.Visible = true;
			radioButtonTeam2.Visible = true;
			radioButtonTeam1.Enabled = true;
			radioButtonTeam2.Enabled = true;
			radioButtonTeam1.Checked = false;
			radioButtonTeam2.Checked = false;
			pbTeam1Status.Image = ResGraphic.YellowDot;
			pbTeam2Status.Image = ResGraphic.YellowDot;
		}
		private void ProcessTimingBetweenEndsEvents()
		{
			SetHammer();
			Opacity = .50;
			Refresh();
			TimeSpan timeout = new TimeSpan(0, 0, 30);
			if ((m_numberOfEndsToPlay == 10 && m_currentEnd == 5) || (m_numberOfEndsToPlay == 8 && m_currentEnd == 4)) {
				timeout = new TimeSpan(0, 5, 0);
			}
			if (m_numberOfEndsToPlay == 1) {
				timeout = new TimeSpan(0, 3, 0);
			}
			ChronometerForm f1 = new ChronometerForm(timeout);
			f1.ShowDialog();
			Opacity = 1.0;
			Refresh();
			buttonTimeIn.Enabled = true;
			buttonTimeOut.Enabled = true;
			radioButtonTeam1.Enabled = false;
			radioButtonTeam2.Enabled = false;
			pbTeam1Status.Image = ResGraphic.YellowDot;
			pbTeam2Status.Image = ResGraphic.YellowDot;
			TimerUtil.TraceAndDebugMessage(string.Format("Completed End {0}", m_currentEnd), 0);
			m_currentEnd++;
			m_stateMachine.Send((int)CurlingTimmerStateMachine.EventID.StartTiming);
		}
		private void ProcessTimeOutDuringEndEvents()
		{
			pbTeam1Status.Image = ResGraphic.YellowDot;
			pbTeam2Status.Image = ResGraphic.YellowDot;
			textBoxTOLeftTeam1.Text = m_timeOutLeftTeam1.ToString();
			textBoxTOLeftTeam2.Text = m_timeOutLeftTeam2.ToString();
//			Opacity = .50;
//			Refresh();
//			{
//			}
			CurlingMessageBox.Show("Press OK when the umpire signals start", "Waiting", Properties.Resources.StartAgain);
//			ChronometerForm f = new ChronometerForm(new TimeSpan(0, 0, 1, 0));
//			f.ShowDialog();
//			Opacity = 1.0;
			Refresh();
			m_rockCount--;
			m_stateMachine.Send((int)CurlingTimmerStateMachine.EventID.StartTiming);
		}
		private void ProcessEndOfGameEvents()
		{
			ControlBox = true;
			buttonTimeIn.Enabled = false;
			buttonTimeOut.Enabled = false;
			pbTeam1Status.Image = ResGraphic.YellowDot;
			pbTeam2Status.Image = ResGraphic.YellowDot;
			radioButtonTeam1.Enabled = false;
			radioButtonTeam2.Enabled = false;
			radioButtonTeam1.Checked = false;
			radioButtonTeam2.Checked = false;
		}
	#endregion
	#region Background Worker
		void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			for (; ; ) {
				BackgroundWorker worker = sender as BackgroundWorker;
				if (worker.CancellationPending) {
					e.Cancel = true;
				} else if (EndOfGame) {
					ControlBox = true;
					e.Cancel = true;
				} else if (m_stateMachine != null) {
					if (m_stateMachine.CurrentStateID == (int)CurlingTimmerStateMachine.StateID.TimingTeam1) {
						//
						// It's on a different thread, so use Invoke.
						//
						SetTextCallback d = new SetTextCallback(SetText1);
						string text1 = TimerUtil.FormatTime(TimeForTeam1 - (DateTime.Now - SetReferenceTimeIn));
						try {
							this.Invoke(d, new object[] { text1 + " (Invoke)" });
						} catch (ObjectDisposedException) {}
					} else if (m_stateMachine.CurrentStateID == (int)CurlingTimmerStateMachine.StateID.TimingTeam2) {
						//
						// It's on a different thread, so use Invoke.
						//
						SetTextCallback d = new SetTextCallback(SetText2);
						string text2 = TimerUtil.FormatTime(TimeForTeam2 - (DateTime.Now - SetReferenceTimeIn));
						try {
							this.Invoke(d, new object[] { text2 + " (Invoke)" });
						} catch (ObjectDisposedException) {}
					}
				}
				System.Threading.Thread.Sleep(TimerUtil.refrehPeriod);
			}
		}
		private void SetText1(string text)
		{
			textBoxTeam1.Text = text;
		}
		private void SetText2(string text)
		{
			textBoxTeam2.Text = text;
		}
		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker worker = sender as BackgroundWorker;
			TimeSpan startTimingDelaySpan = new TimeSpan(0, 0, 0, 0, StartTimingDelay);
			do {
				Thread.Sleep(TimerUtil.refrehPeriod);
				startTimingDelaySpan -= new TimeSpan(0, 0, 0, 0, TimerUtil.refrehPeriod);
				TimerUtil.TraceAndDebugMessage(string.Format("TimeSpan left {0}", startTimingDelaySpan), 1);
			} while (!worker.CancellationPending && (startTimingDelaySpan.CompareTo(new TimeSpan(0)) >= 0));
			if (worker.CancellationPending) {
				e.Cancel = true;
			}
		}
		private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{

			TimerUtil.TraceAndDebugMessage("Completed", 1);
			buttonTimeIn.Click += new System.EventHandler(this.buttonTimeIn_Click);
			KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
		}
	#endregion
	#region Handler
		#region Clicks
        private void buttonTimeIn_Click(object sender, EventArgs e)
		{
			TimerUtil.TraceAndDebugMessage("Button time-in pressed", 1);
			OperatorStartsChangeTiming();
		}
		private void buttonTimeOut_Click(object sender, EventArgs e)
		{
			TimerUtil.TraceAndDebugMessage("Button timeout pressed", 1);
			if ((CurlingTimmerStateMachine.StateID)m_stateMachine.CurrentStateID == (CurlingTimmerStateMachine.StateID.TimingTeam1)) {
				if (m_timeOutLeftTeam1 != 0) {
					m_timeOutLeftTeam1--;
					m_timeOutUsedThisEndTeam1++;
				} else {
					return;
				}
			} else if ((CurlingTimmerStateMachine.StateID) m_stateMachine.CurrentStateID == (CurlingTimmerStateMachine.StateID.TimingTeam2)) {
				if (m_timeOutLeftTeam2 != 0) {
					m_timeOutLeftTeam2--;
					m_timeOutUsedThisEndTeam2++;
				} else {
					return;
				}
			} else {
				return;
			}
			m_stateMachine.Send((int)CurlingTimmerStateMachine.EventID.TimeOut);
			buttonDummy.Select();
			buttonTimeOut.Enabled = false;
		}
		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			TimerUtil.TraceAndDebugMessage(string.Format("Key pressed {0}", e.KeyChar), 1);
			if (e.KeyChar == ' ') {
				Debug.WriteLine("Processing space");
				if (buttonTimeIn.Enabled) {
					OperatorStartsChangeTiming();
				} 
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Debug.WriteLine(string.Format("State is {0}", m_stateMachine.State));
		}
		private void buttonStartTimeInBetweenEnds_Click(object sender, EventArgs e)
		{
			TimerUtil.TraceAndDebugMessage("Button time-in between ends pressed", 1);
			buttonDummy.Select();
			SendStartTiming();
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			backgroundWorker1.CancelAsync();
			if (m_stateMachine != null) {
				m_stateMachine.Dispose();
			}
		}
		#endregion
		#region Menu
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox about = new AboutBox();
			about.ShowDialog();
		}
		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SettingsForm setter = new SettingsForm();
			DialogResult res = setter.ShowDialog();
			if (res == DialogResult.OK) {
				m_numberOfEndsToPlay = NumberOfEndsToPlaySet;
				SetTimeAllowed();
			}
			SetRockColor();
		}
		private void historyToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ScoreSheetForm scoreSheetForm = new ScoreSheetForm(m_scoreSheet);
			scoreSheetForm.ShowDialog();

		}
		private void changeTimigToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChangeForm set = new ChangeForm(m_currentEnd, m_numberOfEndsToPlay, m_rockCount);
			if (set.ShowDialog() == DialogResult.OK) {
				if (m_stateMachine != null) {
					FixTeamsNewTime((CurlingTimmerStateMachine.StateID)m_stateMachine.CurrentStateID);
				}
				m_timeIn = DateTime.Now;
				TimeForTeam1 += set.DtTeam1;
				m_currentEnd += set.DeltaEnds;
				m_rockCount += set.DeltaRocks;
				SetRockCount();
				DisplayCurrentTimeInDialog();
			}

		}
		#endregion
	#endregion
	#region Utilities
		#region General
			private void StartLoging()
			{
				try {
					string fn = string.Format("TraceLog{0:d4}{1:d2}{2:d2}{3:d2}{4:d2}.log", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
						DateTime.Now.Hour, DateTime.Now.Minute);
//					string stName = Assembly.GetExecutingAssembly().GetName().Name;
//					int iPos = Assembly.GetExecutingAssembly().Location.ToUpper().IndexOf(string.Format("{0}.EXE", Assembly.GetExecutingAssembly().GetName().Name.ToUpper()));
//					string st = Assembly.GetExecutingAssembly().Location.Substring(0, iPos - 1);
//					string stLogDirName = string.Format(@"{0}\Logs", st);
					string stLogDirName = string.Format(@"{0}\CurlingTimerLogs", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
					if (!Directory.Exists(stLogDirName)) {
						Directory.CreateDirectory(stLogDirName);
					}
					FileStream fs = new FileStream(string.Format(@"{0}\{1}", stLogDirName, fn), FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
					TraceListener listener = new TextWriterTraceListener(fs);
					listener.TraceOutputOptions = TraceOptions.None;
					Trace.Listeners.Add(listener);
					Trace.AutoFlush = true;
					Trace.TraceInformation("Curling Timer started trace log at {1} version is {0} trace details set at {2}",
						Assembly.GetExecutingAssembly().GetName().Version.ToString(), DateTime.Now, TimerUtil.TraceDetails);
				} catch { }
			}
			private int StartTimingDelay
			{
				get {
					try {
						return (int)Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\PLS Inc.\Timer", "StartTimingDelay", TimerUtil.startTimingDelayDefault);
					} catch {
						return TimerUtil.startTimingDelayDefault;
					}
				}
			}
		#endregion
		#region CurlingGame
			private void SetHammer()
		{
			if (m_stateMachine != null) {
				m_stateMachine.Dispose();
			}
			if (radioButtonTeam1.Checked) {
				m_stateMachine = new CurlingTimmerStateMachine(CurlingTimmerStateMachine.Teams.Team1);
			} else {
				m_stateMachine = new CurlingTimmerStateMachine(CurlingTimmerStateMachine.Teams.Team2);
			}
			m_stateMachine.TransitionCompleted += new TransitionCompletedEventHandler(HandleTransitionCompleted);
			m_stateMachine.ExitingState += new ExitingStateEventHandler(HandleExitingState);
		}
			private bool EndOfGame
			{
				get { return m_currentEnd > m_numberOfEndsToPlay; }
			}
			private bool EndOfRegularPlay()
			{
				return ((m_numberOfEndsToPlay == 10 && m_currentEnd == 10) ||
							(m_numberOfEndsToPlay == 8 && m_currentEnd == 8) ||
							(m_numberOfEndsToPlay == 2 && m_currentEnd == 2) ||
							(m_numberOfEndsToPlay == 1));
			}
			private int NumberOfEndsToPlaySet
			{
				get
				{
					if (Curling.Properties.Settings.Default.EndsToPlaySelectedIndex == 1) {
						return 10;
					}
					return 8;
				}
			}
			private int RockCountTeam1
			{
				get
				{
					int tempRockLeft = 8 - (m_rockCount / 2);
					if (tempRockLeft < 0) {
						tempRockLeft = 0;
					}
					return radioButtonTeam2.Checked && (m_rockCount % 2 > 0) ? (tempRockLeft - 1) : tempRockLeft;
				}
			}
			private int RockCountTeam2
			{
				get
				{
					int tempRockLeft = 8 - (m_rockCount / 2);
					if (tempRockLeft < 0) {
						tempRockLeft = 0;
					}
					return radioButtonTeam1.Checked && (m_rockCount % 2 > 0) ? (tempRockLeft - 1) : tempRockLeft;
				}
			}
			private void SetRockCount()
			{
				int tempRockLeft = 8 - (m_rockCount / 2);
				if (tempRockLeft < 0) {
					tempRockLeft = 0;
				}
				textBoxRocksLeftTeam1.Text = radioButtonTeam2.Checked && (m_rockCount % 2 > 0) ? (tempRockLeft - 1).ToString() : tempRockLeft.ToString();
				textBoxRocksLeftTeam2.Text = radioButtonTeam1.Checked && (m_rockCount % 2 > 0) ? (tempRockLeft - 1).ToString() : tempRockLeft.ToString();
				textBoxCurrentEnd.Text = m_currentEnd.ToString();
			}
			private void SetRockColor()
			{
				textBoxTeam1.BackColor = Curling.Properties.Settings.Default.Team1RockColor;
				textBoxTeam2.BackColor = Curling.Properties.Settings.Default.Team2RockColor;
				textBoxTOLeftTeam1.BackColor = Curling.Properties.Settings.Default.Team1RockColor;
				textBoxTOLeftTeam2.BackColor = Curling.Properties.Settings.Default.Team2RockColor;
				textBoxRocksLeftTeam1.BackColor = Curling.Properties.Settings.Default.Team1RockColor;
				textBoxRocksLeftTeam2.BackColor = Curling.Properties.Settings.Default.Team2RockColor;
			}
			private void HandleExtraEnds()
			{
				pbTeam1Status.Image = ResGraphic.YellowDot;
				pbTeam2Status.Image = ResGraphic.YellowDot;
				ExtraEndRequiredForm extraForm = new ExtraEndRequiredForm();
				extraForm.ShowDialog();
				if (extraForm.ExtraEndRequired) {
					TimeForTeam1 = new TimeSpan(0, 7, 0);
					TimeForTeam2 = new TimeSpan(0, 7, 0);
					DisplayCurrentTimeInDialog();
					m_timeOutLeftTeam1 = 1;
					m_timeOutLeftTeam2 = 1;
					textBoxTOLeftTeam1.Text = m_timeOutLeftTeam1.ToString();
					textBoxTOLeftTeam2.Text = m_timeOutLeftTeam2.ToString();
					m_numberOfEndsToPlay = 1;
				} else {
					m_stateMachine.Send((int)CurlingTimmerStateMachine.EventID.GameDone, null);
				}
			}
		#endregion
		#region Timing
			private void OperatorStartsChangeTiming()
			{
				buttonDummy.Select();
				SendStartTiming();
			}
			private void SendStartTiming()
			{
				KeyPress -= new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
				buttonTimeIn.Click -= new System.EventHandler(this.buttonTimeIn_Click);
				backgroundWorker2.RunWorkerAsync();
				if (radioButtonTeam1.Checked || radioButtonTeam2.Checked) {
					optionsToolStripMenuItem.Enabled = false;
                    stopTimingToolStripMenuItem.Enabled = true;
					if (m_stateMachine == null) {
						SetHammer();
					}
                    SetCursorPos(0, 0);
                    TimerUtil.TraceAndDebugMessage("Sending StartTiming Event to state machine", 1);
					m_stateMachine.Send((int)CurlingTimmerStateMachine.EventID.StartTiming, null);
				} else {
					CurlingMessageBox.Show("Please select the team throwing the last rock", "Operator error", Properties.Resources.SelectLastRock);
				}
			}
			private void DisplayCurrentTimeInDialog()
			{
				textBoxTeam1.Text = TimerUtil.FormatTime(TimeForTeam1);
				textBoxTeam2.Text = TimerUtil.FormatTime(TimeForTeam2);
			}
			private void FixTeamsNewTime(CurlingTimmerStateMachine.StateID stateID)
			{
				if (stateID == CurlingTimmerStateMachine.StateID.TimingTeam1) {
					TimeForTeam1 -= (DateTime.Now - SetReferenceTimeIn);
					if (TimeForTeam1.TotalSeconds < 1) {
						TimeForTeam1 = new TimeSpan(0, 0, 0);
					}
				} else if (stateID == CurlingTimmerStateMachine.StateID.TimingTeam2) {
					TimeForTeam2 -= (DateTime.Now - SetReferenceTimeIn);
					if (TimeForTeam2.TotalSeconds < 1) {
						TimeForTeam2 = new TimeSpan(0, 0, 0);
					}
				}
				SetReferenceTimeIn = DateTime.Now;
				if ((RockCountTeam1 >= 0) && (RockCountTeam2 >= 0)) {
					TimerUtil.TraceAndDebugMessage(string.Format("Team 1 - Time Left {0} | Rocks Left {1} || Team2 - Time Left {2} | rocks Left {3}",
						TimerUtil.FormatTime(TimeForTeam1), RockCountTeam1, TimerUtil.FormatTime(TimeForTeam2), RockCountTeam2), 0);
					if (RockCountTeam1 == RockCountTeam2) {
						TimerUtil.TraceAndDebugMessage(string.Empty, 0);
					}
				}
			}
			public DateTime SetReferenceTimeIn
			{
				get { return m_timeIn; }
				set
				{
					Monitor.Enter(this);
					m_timeIn = value;
					Monitor.Exit(this);
				}
			}
			public TimeSpan TimeForTeam1
			{
				get { return m_dtTeam1; }
				set
				{
					Monitor.Enter(this);
					m_dtTeam1 = value;
					Monitor.Exit(this);
				}
			}
			public TimeSpan TimeForTeam2
			{
				get { return m_dtTeam2; }
				set
				{
					Monitor.Enter(this);
					m_dtTeam2 = value;
					Monitor.Exit(this);
				}
			}
			private TimeSpan TimeAllowedForGame
			{
				get
				{
					TimeSpan retVal;
					switch (m_numberOfEndsToPlay) {
						case 8:
							retVal = new TimeSpan(0, 59, 0);
							break;
						case 10:
							retVal = new TimeSpan(0, 73, 0);
							break;
						case 1:
							retVal = new TimeSpan(0, 7, 0);
							break;
						case 2:
							retVal = new TimeSpan(0, 2, 0);
							break;
						default:
							throw new Exception("Number of play out of range");
					}
					return retVal;
				}
			}
			private void SetTimeAllowed()
			{
				TimeForTeam1 = TimeAllowedForGame;
				TimeForTeam2 = TimeForTeam1;
				DisplayCurrentTimeInDialog();
			}
		#endregion

			private void stopTimingToolStripMenuItem_Click(object sender, EventArgs e)
			{
                if (m_stateMachine == null) {
                    return;
                }
				TimerUtil.TraceAndDebugMessage("Button Stop time pressed", 1);
				m_stateMachine.Send((int)CurlingTimmerStateMachine.EventID.TimeOut);
				buttonDummy.Select();
				buttonTimeOut.Enabled = false;
			}
	#endregion
	}
}
