using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLS.Curling {
	public partial class ExtraEndRequiredForm : Form {
		public ExtraEndRequiredForm()
		{
			InitializeComponent();
		}

		public bool ExtraEndRequired
		{
			get { return radioButtonYes.Checked; }
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
