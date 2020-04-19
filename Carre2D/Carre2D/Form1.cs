using PLS.DanseTrad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
	public partial class Form1 : Form
	{
		private Danseur[] Danseurs {get; set;}
		private Tuple<double, double>[] Circle { get; set; }
		public Form1()
		{
			InitializeComponent();
			Circle = new Tuple<double, double>[72];
			int index = 0;
			for (int angle = 0; angle < 360; angle += 5)
			{
				double angRad = (Math.PI / 180.0) * angle;
				Circle[index++] = new Tuple<double, double>(Math.Cos(angRad), Math.Sin(angRad));
			}
			Danseurs = new Danseur[8];
			Danseurs[0] = new Danseur(Color.Blue, new Point(100, 100), 0, Circle);
			Danseurs[1] = new Danseur(Color.Pink, new Point(80, 10), 0, Circle);
			Danseurs[2] = new Danseur(Color.Blue, new Point(10, 50), 0, Circle);
			Danseurs[3] = new Danseur(Color.Pink, new Point(60, 50), 0, Circle);
			Danseurs[4] = new Danseur(Color.Blue, new Point(10, 90), 0, Circle);
			Danseurs[5] = new Danseur(Color.Pink, new Point(60, 90), 0, Circle);
			Danseurs[6] = new Danseur(Color.Blue, new Point(10, 130), 0, Circle);
			Danseurs[7] = new Danseur(Color.Pink, new Point(60, 130), 0, Circle);



			TimerCallback tcb = Update;
			System.Threading.Timer testTimer = new System.Threading.Timer(tcb, null, 0, 50);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

//		private static int angle = 0;
		private static int index = 0;
		private void Update(Object source)
		{
			Bitmap bmp = new Bitmap(set1.Width, set1.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.Clear(Color.White);
				index %= 72;
				double xScale = Circle[index].Item1;
				double yScale = Circle[index++].Item2;
				//xScale = 1.0;
				//yScale = 1.0;
				Danseur d = Danseurs[0];
				d.CurrentPosition = new Point(150 + (int) Math.Round(100 * xScale), 150 + (int) Math.Round(100 * yScale));
				d.Draw(g, new Point(0, 0), index * 3);
				d = Danseurs[1];
				d.CurrentPosition = new Point(100 + (int)Math.Round(75 * xScale), 100 + (int)Math.Round(75 * yScale));
				d.Draw(g, new Point(0, 0), index * 1);
				foreach (Danseur d1 in Danseurs)
				{
					//d.Draw(g, new Point(1, 0), 0);
				}
			}
			set1.Image = bmp;

		}
		private void button1_Click(object sender, EventArgs e)
		{
			for (int i = 0; i <= 3600; i++)
			{
				Update(null);
				Thread.Sleep(50);
			}
		}
	}
}
