using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace PLS.Curling {
	public partial class ScoreSheetForm : Form {
		Collection<ScoreSheetLine> m_sca = null;
		public ScoreSheetForm(Collection<ScoreSheetLine> sca)
		{
			InitializeComponent();
			m_sca = sca;
			PopulateGrid(sca);
		}

		private void PopulateGrid(Collection<ScoreSheetLine> sca)
		{
			int iEnd = 1;
			dataGridView1.Rows.Clear();
			foreach (ScoreSheetLine sc in sca) {
				if (sc != null) {
					dataGridView1.Rows.Add();
					dataGridView1.Rows[iEnd - 1].Cells[0].Value = iEnd.ToString();
					dataGridView1.Rows[iEnd - 1].Cells[1].Value = TimerUtil.FormatTime((TimeSpan)sc.TimeUsedTeam1);
					dataGridView1.Rows[iEnd - 1].Cells[3].Value = TimerUtil.FormatTime((TimeSpan)sc.TimeUsedTeam2);
					dataGridView1.Rows[iEnd - 1].Cells[2].Value = sc.TimeoutLeftTeam1.ToString();
					dataGridView1.Rows[iEnd - 1].Cells[4].Value = sc.TimeoutLeftTeam2.ToString();
					iEnd++;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
