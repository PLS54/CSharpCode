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

            const string originalFile = @"files.txt";
            const string doneFile = @"passées.txt";
            //    
            string[] originalFileContent = ReadTextFile(originalFile);
            string[] doneContent = ReadTextFile(doneFile);
            //
            // Remove done from original list
            //
            Array.Sort(doneContent);
            int drawCount = 0;
            foreach(string s in originalFileContent) {
                if (Array.BinarySearch(doneContent, s) < 0) {
                    drawCount++;
                }
            }
            if (drawCount == 0) {
                textBoxChoix.Text = "Toutes finies";
                return;
            }
            int count = 0;
            String[] drawFrom = new String[drawCount];
            foreach (string s in originalFileContent)
            {
                if (Array.BinarySearch(doneContent, s) < 0) {
                    drawFrom[count++] = s;
                }
            }
            //
            // Do the draw
            //
            textBoxChoix.Text = drawFrom[DateTime.Now.Millisecond % drawFrom.Length];
            File.AppendAllText(doneFile, doneContent.Length == 0 ? textBoxChoix.Text : Environment.NewLine + textBoxChoix.Text);
        }

        private static string[] ReadTextFile(string filename)
        {
            int counter = 0;
            string line;
            string[] theFileContent;
            if (!File.Exists(filename)) {
                return new String[0];
            }
            using (StreamReader file = new System.IO.StreamReader(filename)) {
                while ((line = file.ReadLine()) != null) {
                    counter++;
                }
            }
            theFileContent = new String[counter];
            counter = 0;
            using (StreamReader file = new System.IO.StreamReader(filename)) {
                while ((line = file.ReadLine()) != null) {
                    theFileContent[counter++] = line;
                }
            }
            return theFileContent;
        }
    }
}
