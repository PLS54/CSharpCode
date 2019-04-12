using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace CheckMD5Signature {
	public partial class Form1 : Form {
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.ShowDialog();
			textBoxFileName.Text = dlg.FileName;
		}

		private void buttonMD5_Click(object sender, EventArgs e)
		{
			FileStream fs = new FileStream(textBoxFileName.Text, FileMode.Open);
			System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
			System.Security.Cryptography.SHA1CryptoServiceProvider sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
			md5.Initialize();
			sha1.Initialize();
			byte[] md5Hash = md5.ComputeHash(fs);
			fs.Seek(0, SeekOrigin.Begin);
			byte[] sha1Hash = sha1.ComputeHash(fs);
			fs.Close();
			string sMD5 = "";
			string sSHA1 = ""; 
			for (int i = 0; i < md5Hash.Length; i++) {
				sMD5 += string.Format("{0:X2}", md5Hash[i]);
			}
			for (int i = 0; i < sha1Hash.Length; i++) {
				sSHA1 += string.Format("{0:X2}", sha1Hash[i]);
			}
			if (sSHA1.ToUpper() == textBoxSHA1Compare.Text.ToUpper()) {
				textBoxSHA1Compare.ForeColor = Color.Green;
			} else {
				textBoxSHA1Compare.ForeColor = Color.Red;
			}
			if (sMD5.ToUpper() == textBoxMD5Compare.Text.ToUpper()) {
				textBoxMD5Compare.ForeColor = Color.Green;
			} else {
				textBoxMD5Compare.ForeColor = Color.Red;
			}
			textBoxMD5Compare.Text = textBoxMD5Compare.Text.ToUpper();
			textBoxSHA1Compare.Text = textBoxSHA1Compare.Text.ToUpper();
			textBoxCalMd5.Text = sMD5.ToUpper();
			textBoxSHACalc.Text = sSHA1.ToUpper();
		}

		private void textBoxSHACompare_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
