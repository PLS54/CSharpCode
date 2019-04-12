using System;
using System.Collections.Generic;
using System.Text;

namespace PLS.Curling {
	public class ScoreSheetLine {
		private TimeSpan? m_timeUsedTeam1;
		private TimeSpan? m_timeUsedTeam2;
		private int? m_scoredPointsTeam1 = null;
		private int? m_scoredPointsTeam2 = null;
		private int? m_timeoutLeftTeam1 = null;
		private int? m_timeoutLeftTeam2 = null;

		public ScoreSheetLine(TimeSpan timeUsedTeam1, TimeSpan timeUsedTeam2, int timeoutLeftTeam1, int timeoutLeftTeam2)
		{
			m_timeUsedTeam1 = timeUsedTeam1;
			m_timeUsedTeam2 = timeUsedTeam2;
			m_timeoutLeftTeam1 = timeoutLeftTeam1;
			m_timeoutLeftTeam2 = timeoutLeftTeam2;
		}
		public TimeSpan? TimeUsedTeam1
		{
			get { return m_timeUsedTeam1; }
			set { m_timeUsedTeam1 = value; }
		}

		public TimeSpan? TimeUsedTeam2
		{
			get { return m_timeUsedTeam2; }
			set { m_timeUsedTeam2 = value; }
		}

		public int? ScoredPointsTeam1
		{
			get { return m_scoredPointsTeam1; }
			set { m_scoredPointsTeam1 = value; }
		}

		public int? ScoredPointsTeam2
		{
			get { return m_scoredPointsTeam2; }
			set { m_scoredPointsTeam2 = value; }
		}
		public int? TimeoutLeftTeam1
		{
			get { return m_timeoutLeftTeam1; }
			set { m_timeoutLeftTeam1 = value; }
		}

		public int? TimeoutLeftTeam2
		{
			get { return m_timeoutLeftTeam2; }
			set { m_timeoutLeftTeam2 = value; }
		}
	}
}
