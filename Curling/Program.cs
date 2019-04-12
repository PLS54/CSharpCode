using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;

namespace PLS.Curling
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try {
				Application.Run(new ExclusiveForm());
			} catch (Exception e) {
				CurlingMessageBox.Show(string.Format("Error \"{0}\" was detected", e.Message), "Exception Detected", Properties.Resources.Alert);
			}
		}
	}
}
