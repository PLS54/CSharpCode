﻿using System;
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
            //string[] originalFileContent = ReadTextFile(originalFile);
            string[] doneContent = ReadTextFile(doneFile);
            string[] originalFileContent = new String[0];
            //
            foreach (string s in Directory.EnumerateDirectories(@"z:")) {
                if (!s.Equals(@"z:$RECYCLE.BIN", StringComparison.InvariantCulture)) {
                    if (s.Equals(@"z:new", StringComparison.InvariantCultureIgnoreCase)) {
                        foreach(string sInner in Directory.EnumerateDirectories(@"z:new")) {
                            AddToArray(ref originalFileContent, sInner);
                        }
                    }
                    else {
                        AddToArray(ref originalFileContent, s);
                    }
                }
                string s1 = s;                   
            }
            //
            // Remove done from original list
            //
            Array.Sort(doneContent);
            String[] drawFrom = new String[0];
            foreach (string s in originalFileContent) {
                if (Array.BinarySearch(doneContent, s) < 0) {
                    Array.Resize<String>(ref drawFrom, drawFrom.Length + 1);
                    drawFrom[drawFrom.Length -1] = s;
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
            textBoxChoix.Text = drawFrom[DateTime.Now.Millisecond % drawFrom.Length];
            textBoxChoix.SelectionStart = textBoxChoix.Text.Length;
            textBoxChoix.DeselectAll();
            if (drawFrom.Length == 1)
            {
                textBoxChoix.BackColor = Color.White;
                textBoxChoix.ForeColor = Color.Red;
                File.Delete(doneFile);
                return;
            }
            File.AppendAllText(doneFile, doneContent.Length == 0 ? textBoxChoix.Text : Environment.NewLine + textBoxChoix.Text);
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
                    theFileContent[theFileContent.Length -1] = line;
                }
            }
            return theFileContent;
        }

        private static void AddToArray(ref string[] ar, String s)
        {
            Array.Resize<String>(ref ar, ar.Length + 1);
            ar[ar.Length - 1] = s.Substring(2).Replace("\\", " - ");
        }
    }
}
