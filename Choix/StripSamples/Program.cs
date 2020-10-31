using System;
using System.Collections.Generic;
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
			string[] temp = new string[args.Length];
			int i = 0;
			foreach(string arg in args)
			{
				//temp[i] = arg.Clone();
			}
			Form1 f = new Form1();
			f.Args = args;
            Application.Run(f);
        }
    }
}
