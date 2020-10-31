using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace StripSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllowDrop = true;
            DragEnter += new DragEventHandler(Form1_DragEnter);
            DragDrop += new DragEventHandler(Form1_DragDrop);

        }
        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Color current = BackColor;
            BackColor = Color.Red;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) {
                Debug.WriteLine(file);
                RemoveSamples(file);
            }
            BackColor = current;
        }

        private static void RemoveSamples(string filename)
        {
            MemoryStream memStream = new MemoryStream(100);
            using (StreamReader sr = File.OpenText(filename)) {
                String s = "";
                while ((s = sr.ReadLine()) != null) {
                    if (!s.StartsWith("<!DOCTYPE ")) {
                        byte[] bLine = Encoding.UTF8.GetBytes(s);
                        memStream.Write(bLine, 0, bLine.Length);
                    }
                }
            }
            memStream.Seek(0, SeekOrigin.Begin);
            XmlDocument doc = new XmlDocument();
            doc.Load(memStream);
            XmlNode files = doc.ChildNodes[1];
            List<XmlNode> nodesToRemove = new List<XmlNode>();
            foreach (XmlNode file in files) {
                string s = file.OuterXml;
                if (file.NodeType == XmlNodeType.Element && file.Name.Equals("file") && (file.Attributes[2].Value.Contains("sample") || file.Attributes[2].Value.Contains("Sample"))) {
                    nodesToRemove.Add(file);
                }

            }
            foreach (XmlNode nodeToRemove in nodesToRemove) {
                files.RemoveChild(nodeToRemove);
            }
            doc.Save(filename);
        }
    }
}
