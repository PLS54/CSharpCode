using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml;
using System.Security.Cryptography;
namespace Entropy
{
    enum Color : byte {red = 10, green = 20, yellow =30};
    public partial class Form1 : Form {

		private int m_test = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			System.Nullable<bool> tes = null;
			if (tes == null) {
			}

			bool? f = null;
			string stPath = (string)Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\ImageWare Systemsa\\EPIBUILDER\\6\\Installed", "Location", "");
			string sa = stPath + "test";
			Color myColor = Color.red;
			Type underType = Enum.GetUnderlyingType(typeof(Color));
			Array enumData = Enum.GetValues(typeof(Color));
			for(int i = 0; i < enumData.Length; i++) {
				Console.WriteLine("Name {0} Value {0:D}", enumData.GetValue(i));
			}
			System.Windows.Forms.OpenFileDialog ofd = new OpenFileDialog();
			ofd.ShowDialog();
			Stream s = ofd.OpenFile();
			textBox1.Text = IWS.Crypotography.CalcEntropy.Entropy(s).ToString();
			s.Close();
			RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider();
			byte[] toTest = new byte[50000];
			rnd.GetBytes(toTest);
			double entRnd = IWS.Crypotography.CalcEntropy.Entropy(toTest);
		}

		private static int Add(int a, int b)
		{
			return a + b;
		}
	}
}
