using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLS.Curling {
	public partial class ExclusiveForm : Form {
		public ExclusiveForm()
		{
			InitializeComponent();
		}

		private void ExclusiveForm_Load(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.ShowDialog();
			Close();
		}
	}
}
