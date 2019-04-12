using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLS.Curling {
	public partial class SettingsForm : Form {
		public SettingsForm()
		{
			InitializeComponent();
			comboBoxEnds.SelectedIndex = Curling.Properties.Settings.Default.EndsToPlaySelectedIndex;
		}

		public int GetNumberOfEndsToPlay1()
		{
			if (comboBoxEnds.SelectedIndex == 0) {
				return 8;
			} else if (comboBoxEnds.SelectedIndex == 1) {
				return 10;
			}
			return -1;
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
			Curling.Properties.Settings.Default.Sound = checkBoxSound.Checked;
			Curling.Properties.Settings.Default.Team1RockColor = buttonColorTeam1.BackColor; ;
			Curling.Properties.Settings.Default.Team2RockColor = buttonColorTeam2.BackColor; ;
			Curling.Properties.Settings.Default.EndsToPlaySelectedIndex = comboBoxEnds.SelectedIndex;
			Curling.Properties.Settings.Default.Save();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void buttonColorTeam1_Click(object sender, EventArgs e)
		{
			ColorDialog col = new ColorDialog();
			col.ShowDialog();
			buttonColorTeam1.BackColor = col.Color;

		}

		private void buttonColorTeam2_Click(object sender, EventArgs e)
		{
			ColorDialog col = new ColorDialog();
			col.ShowDialog();
			buttonColorTeam2.BackColor = col.Color;

		}

		private void buttonColorTeam1_Click_1(object sender, EventArgs e)
		{
			ColorDialog col = new ColorDialog();
			col.ShowDialog();
			buttonColorTeam1.BackColor = col.Color;
		}
	}
}
