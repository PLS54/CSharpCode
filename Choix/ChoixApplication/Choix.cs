using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Choix : Form
    {

        public Choix()
        {
            InitializeComponent();
        }

        private void Choix_Load(object sender, EventArgs e)
        {
            const string doneFile = @"passées.txt";
            //    
            string[] doneContent = ReadTextFile(doneFile);
            string[] originalFileContent = new String[0];
            //
            foreach (string s in Directory.EnumerateDirectories(@"z:")) {
                if (!s.Equals(@"z:$RECYCLE.BIN", StringComparison.InvariantCulture) && !s.Equals(@"z:System Volume Information", StringComparison.InvariantCultureIgnoreCase)) {
                    if (s.Equals(@"z:new", StringComparison.InvariantCultureIgnoreCase)) {
                        foreach (string sInner in Directory.EnumerateDirectories(@"z:new")) {
							if (!sInner.StartsWith("_", StringComparison.InvariantCultureIgnoreCase))
							{
								AddToArray(ref originalFileContent, sInner);
							}
                        }
                    } else {
                        AddToArray(ref originalFileContent, s);
                    }
                }
            }
            //
            // Remove done from original list
            //
            Array.Sort(doneContent);
            String[] drawFrom = new String[0];
            foreach (string s in originalFileContent) {
                if (Array.BinarySearch(doneContent, s) < 0) {
                    Array.Resize<String>(ref drawFrom, drawFrom.Length + 1);
                    drawFrom[drawFrom.Length - 1] = s;
                }
            }
            //
            // Do the draw
            //
            textBoxChoix.ReadOnly = true;
            if (drawFrom.Length == 0) {
                textBoxChoix.Text = "Pas de fichier source";
                return;
            }
            textBoxChoix.Text = Draw(drawFrom);
            File.AppendAllText(doneFile, doneContent.Length == 0 ? textBoxChoix.Text : Environment.NewLine + textBoxChoix.Text);
            String dirName;
            if (textBoxChoix.Text.StartsWith("new - ")) {
                dirName = String.Format("{0}{1}", @"z:\New\", textBoxChoix.Text.Substring(6));
            } else {
                dirName = String.Format("{0}{1}", @"z:\", textBoxChoix.Text);
            }
            String[] drawFrom1 = new String[0];
            String[] drawFrom2 = new String[0];
            String[] drawFrom3 = new String[0];
            foreach (string s in Directory.EnumerateFiles(dirName)) {
                if (Path.GetFileName(s).StartsWith("1", StringComparison.InvariantCultureIgnoreCase)) {
                    AddToArray(ref drawFrom1, Path.GetFileName(s), false);
                }
                if (Path.GetFileName(s).StartsWith("2", StringComparison.InvariantCultureIgnoreCase)) {
                    AddToArray(ref drawFrom2, Path.GetFileName(s), false);
                }
                if (Path.GetFileName(s).StartsWith("3", StringComparison.InvariantCultureIgnoreCase)) {
                    AddToArray(ref drawFrom3, Path.GetFileName(s), false);
                }
            }
            textBoxChoix.Text = String.Format("{0} -> {1} | {2} | {3}", textBoxChoix.Text, Draw(drawFrom1), Draw(drawFrom2), Draw(drawFrom3));
            textBoxChoix.SelectionStart = textBoxChoix.Text.Length;
            textBoxChoix.DeselectAll();
            if (drawFrom.Length == 1) {
                textBoxChoix.BackColor = Color.White;
                textBoxChoix.ForeColor = Color.Red;
                File.Delete(doneFile);
                return;
            }
        }

        private static String Draw(string[] drawFrom)
        {
            if (drawFrom.Length == 0) {
                return String.Empty;
            }
            return drawFrom[DateTime.Now.Millisecond % drawFrom.Length];
        }
        private static string[] ReadTextFile(string filename)
        {
            string line;
            string[] theFileContent = new String[0];
            if (!File.Exists(filename)) {
                return new String[0];
            }
            using (StreamReader file = new System.IO.StreamReader(filename)) {
                while ((line = file.ReadLine()) != null) {
                    Array.Resize<String>(ref theFileContent, theFileContent.Length + 1);
                    theFileContent[theFileContent.Length - 1] = line;
                }
            }
            return theFileContent;
        }

        private static void AddToArray(ref string[] ar, String s, bool chop = true)
        {
            Array.Resize<String>(ref ar, ar.Length + 1);
            ar[ar.Length - 1] = chop ? s.Substring(2).Replace("\\", " - ") : s;
        }
    }
}
