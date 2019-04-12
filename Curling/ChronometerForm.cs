using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace PLS.Curling {
	public partial class ChronometerForm : Form {

		DateTime m_dt;
		bool m_fDone = false;
		public ChronometerForm(TimeSpan ts)
		{
			InitializeComponent();
			m_dt = DateTime.Now + ts;
			TimerUtil.TraceAndDebugMessage(string.Format("Entering Chrono for {0}", TimerUtil.FormatTime(ts)), 0);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TimerUtil.TraceAndDebugMessage(string.Format("Exiting Chrono with {0} left", TimerUtil.FormatTime(m_dt - DateTime.Now)), 0);
			m_fDone = true;
			Close();
		}

		void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			System.Threading.Thread.Sleep(250);
		}
		private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (!m_fDone) {
				TimeSpan ts = m_dt - DateTime.Now;
				textBoxTimeLeft.Text = TimerUtil.FormatTime(ts);
				if (ts.CompareTo(new TimeSpan(0, 0, 0)) != 1) {
					TimerUtil.TraceAndDebugMessage("Chrono to 00:00", 0);
					Close();
				} else {
					backgroundWorker2.RunWorkerAsync();
				}
			}
		}

		private void ChronometerForm_Load(object sender, EventArgs e)
		{
			TimerUtil.PlaySound(Properties.Resources.FormLoading);
			backgroundWorker2.RunWorkerAsync();

		}

	}
}
