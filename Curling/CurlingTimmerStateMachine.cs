using System;
using System.Collections.Generic;
using System.Text;
using Sanford.Threading;
using Sanford.StateMachineToolkit;
using System.ComponentModel;
using System.Threading;

namespace PLS.Curling {
	public class CurlingTimmerStateMachine : ActiveStateMachine {

		public enum EventID { Dispose, StartTiming, EndFinished, TimeOut, TimerElapsed, GameDone };

		public enum Teams {Team1, Team2 };

		public enum StateID { InitialState, PlayingEnd, BetweenEnds, TimingTeam1, TimingTeam2, TimeOutDuringEnd, WaitingForRockReset, TimingBetweenEnds, 
			EndOfGame, Disposed };
		private SynchronizationContext m_context;

		public event EnteringStateEventHandler EnteringState;
		public event ExitingStateEventHandler ExitingState;

		public CurlingTimmerStateMachine(Teams team)
		{
			m_context = SynchronizationContext.Current;
			//
			State initalState = new State((int)StateID.InitialState, new ExitHandler(ExitingStates));
			//
			// States in superstate Playing End
			//
			State timingTeam1 = new State((int)StateID.TimingTeam1, new EntryHandler(EnteringStates), new ExitHandler(ExitingStates));
			State timingTeam2 = new State((int)StateID.TimingTeam2, new EntryHandler(EnteringStates), new ExitHandler(ExitingStates));
			State timedOutDuringEnd = new State((int)StateID.TimeOutDuringEnd, new EntryHandler(EnteringStates), new ExitHandler(ExitingStates));
			State playingEnd = new State((int)StateID.PlayingEnd, new EntryHandler(EnteringStates), new ExitHandler(ExitingStates));
			playingEnd.Substates.Add(timingTeam1);
			playingEnd.Substates.Add(timingTeam2);
			playingEnd.HistoryType = HistoryType.Shallow;
			if (team == Teams.Team1) {
				playingEnd.InitialState = timingTeam2;
			} else {
				playingEnd.InitialState = timingTeam1;
			}
			//
			// State in superstate Between Ends
			//
			State betweenEnds = new State((int)StateID.BetweenEnds, new EntryHandler(EnteringStates));
			State waitingForRocksToBeReseted = new State((int)StateID.WaitingForRockReset, new EntryHandler(EnteringStates), new ExitHandler(EnteringStates));
			State timingInBetweenEnds = new State((int)StateID.TimingBetweenEnds, new EntryHandler(EnteringStates), new ExitHandler(ExitingStates));
			betweenEnds.Substates.Add(waitingForRocksToBeReseted);
			betweenEnds.Substates.Add(timingInBetweenEnds);
			betweenEnds.HistoryType = HistoryType.None;
			betweenEnds.InitialState = waitingForRocksToBeReseted;
			//
			State endOfGane = new State((int) StateID.EndOfGame, new EntryHandler(EnteringStates), new ExitHandler(ExitingStates));
			State disposed = new State((int)StateID.Disposed, new EntryHandler(EnteringStates), new ExitHandler(ExitingStates));


			//
			// Transitions between ends and playing end state
			//
			CreateTransition(initalState, playingEnd, EventID.StartTiming);
			CreateTransition(playingEnd, betweenEnds, EventID.EndFinished);
			CreateTransition(betweenEnds, playingEnd, EventID.StartTiming);
			CreateTransition(waitingForRocksToBeReseted, timingInBetweenEnds, EventID.StartTiming);
			//
			// Transitions between trowing teams
			//
			CreateTransition(timingTeam2, timingTeam1, EventID.StartTiming);
			CreateTransition(timingTeam1, timingTeam2, EventID.StartTiming);
			//
			// Transitions timeout called
			//
			CreateTransition(timingTeam1, timedOutDuringEnd, EventID.TimeOut);
			CreateTransition(timingTeam2, timedOutDuringEnd, EventID.TimeOut);
			CreateTransition(timedOutDuringEnd, playingEnd, EventID.StartTiming);
			//
			CreateTransition(betweenEnds, endOfGane, EventID.GameDone);
			Initialize(initalState);
		}
		private void CreateTransition(State from, State to, EventID eventID)
		{
			from.Transitions.Add((int)eventID, new Transition(to));
		}
		private void ExitingStates()
		{
			StateEventArgs e = new StateEventArgs(currentState.ID, ActionResult);
			if (m_context != null) {
				m_context.Post(delegate(object state) 
				{
					OnExitingState(e);
				}, null);
			}
		}
		private void EnteringStates()
		{
			StateEventArgs e = new StateEventArgs(currentState.ID, ActionResult);

			if (m_context != null) {
				m_context.Post(delegate(object state) 
				{
					OnEnteringState(e);
				}, null);
			}
		}
		protected virtual void OnExitingState(StateEventArgs e)
		{
			ExitingStateEventHandler handler = ExitingState;

			if (handler != null) {
				handler(this, e);
			}
		}
		protected virtual void OnEnteringState(StateEventArgs e)
		{
			EnteringStateEventHandler handler = EnteringState;

			if (handler != null) {
				handler(this, e);
			}
		}
		public string State
		{
			get
			{
				return (string)((CurlingTimmerStateMachine.StateID)CurrentStateID).ToString();
			}
		}

	}
	public class StateEventArgs : EventArgs {
		
		private int m_stateID;
		private object m_actionResult = null;
		
		public StateEventArgs(int stateID, object actionResult)
		{
			m_stateID = stateID;
			m_actionResult = actionResult;
		}

		public int StateID
		{
			get { return m_stateID; }
		}


		public object ActionResult
		{
			get { return m_actionResult; }
		}

	}
	public delegate void EnteringStateEventHandler(object sender, StateEventArgs e);
	public delegate void ExitingStateEventHandler(object sender, StateEventArgs e);
}
