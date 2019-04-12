using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace PLS.Curling {
	public partial class CurlingMessageBox : Form {
		public CurlingMessageBox()
		{
			InitializeComponent();
		}

		public static int Show(string stMessage, string stTitle, Stream soundStream)
		{
			CurlingMessageBox cm = new CurlingMessageBox();
			cm.textBoxText.Text = stMessage;
			cm.Text = stTitle;
			TimerUtil.PlaySound(soundStream);
			cm.ShowDialog();
			return 0;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
