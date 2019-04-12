using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLS.Curling {
	public partial class ChangeForm : Form {
		public ChangeForm(int currentEnd, int nEndToPlay, int currentRock)
		{
			InitializeComponent();
			numericUpDownEnds.Minimum = -currentEnd + 1;
			numericUpDownEnds.Maximum = nEndToPlay - currentEnd;
			numericUpDownRocks.Minimum = -currentRock;
			numericUpDownRocks.Maximum = 15 - currentRock;

		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
				
		}
		public TimeSpan DtTeam1
		{
			get {
				return new TimeSpan(0, 1, 30);
			}
		}
		public int DeltaEnds
		{
			get { return (int) numericUpDownEnds.Value; }
		}
		public int DeltaRocks
		{
			get { return (int)numericUpDownRocks.Value; }
		}
	}
}
