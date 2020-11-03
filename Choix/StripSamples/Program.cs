using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StripSamples
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			if (args.Length > 0) {
				Form1.RemoveSamples(args[0]);
				ProcessStartInfo pci = new ProcessStartInfo();
				pci.FileName = @"C:\Program Files\Newsbin\newsbinpro64.exe";
				pci.Arguments = $"\"{args[0]}\"";
				//pci.CreateNoWindow = true;
				//pci.UseShellExecute = false;
				//pci.WindowStyle = ProcessWindowStyle.Minimized;

				Process.Start(pci);

			}
			else
			{
				Application.Run(new Form1());
			}
		}
    }
}
