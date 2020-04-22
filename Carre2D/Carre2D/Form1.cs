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
			const int toEdge = 100;
			const int spacing = 10;
			const int danserWidth = 50;
			int size = set1.Size.Width;
			int toEdgeLong = size - toEdge;
			int center = size / 2;
			//
			int danserDistToCenter = (danserWidth + spacing) / 2;
			int shortSpace = center - danserDistToCenter;
			int longSpace = center + danserDistToCenter;
			//
			Danseurs = new Danseur[8];
			Danseurs[0] = new Danseur(Color.Blue, new Point(shortSpace, toEdgeLong), 36, Circle);
			Danseurs[1] = new Danseur(Color.Pink, new Point(longSpace, toEdgeLong), 36, Circle);

			Danseurs[2] = new Danseur(Color.Blue, new Point(toEdgeLong, longSpace), 54, Circle);
			Danseurs[3] = new Danseur(Color.Pink, new Point(toEdgeLong, shortSpace), 54, Circle);

			Danseurs[4] = new Danseur(Color.Blue, new Point(longSpace, toEdge), 0, Circle);
			Danseurs[5] = new Danseur(Color.Pink, new Point(shortSpace, toEdge), 0, Circle);

			Danseurs[6] = new Danseur(Color.Blue, new Point(toEdge, shortSpace), 18, Circle);
			Danseurs[7] = new Danseur(Color.Pink, new Point(toEdge, longSpace), 18, Circle);

			Update(null);
			TimerCallback tcb = Update;
			System.Threading.Timer testTimer = new System.Threading.Timer(tcb, null, 0, 50);
		}
		private void Form1_Load(object sender, EventArgs e)
		{
		}
		private void Update(Object source)
		{
			//int index = (int)source;
			Bitmap bmp = new Bitmap(set1.Width, set1.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.Clear(Color.White);
				foreach (Danseur danseur in Danseurs)
				{
					danseur.StepToNext(g);
				}
			}
			set1.Image = bmp;
		}
		private void InitializeMoves()
		{
			for (int i = 0; i <= 72; i++)
			{
				Danseurs[0].Moves.Add(null);
				Danseurs[5].Moves.Add(null);
				Danseurs[1].Moves.Add(new Move((i + 36) % 72));
				Danseurs[4].Moves.Add(new Move(new Point(0, 0), i));
			}
			for (int i = 0; i < 150; i += 3)
			{
				Danseurs[0].Moves.Add(new PLS.DanseTrad.Move(new Point(0, -3)));
				Danseurs[1].Moves.Add(new PLS.DanseTrad.Move(new Point(0, -3)));
				Danseurs[4].Moves.Add(null);
				Danseurs[5].Moves.Add(null);
			}
			for (int i = 0; i < 75; i += 3)
			{
				Danseurs[0].Moves.Add(new PLS.DanseTrad.Move(new Point(0, 3)));
				Danseurs[1].Moves.Add(new PLS.DanseTrad.Move(new Point(0, 3)));
				Danseurs[4].Moves.Add(null);
				Danseurs[5].Moves.Add(null);
			}
			for (int i = 0; i < 165; i += 3)
			{
				if (i > 50 && i <= 100)
				{
					Danseurs[4].Moves.Add(new PLS.DanseTrad.Move(new Point(-3, 0)));
					Danseurs[5].Moves.Add(new PLS.DanseTrad.Move(new Point(3, 0)));
				}
				else
				{
					Danseurs[4].Moves.Add(null);
					Danseurs[5].Moves.Add(null);
				}
				Danseurs[0].Moves.Add(new PLS.DanseTrad.Move(new Point(0, -3)));
				Danseurs[1].Moves.Add(new PLS.DanseTrad.Move(new Point(0, -3)));
			}
			for (int i = 0; i < 50; i += 3)
			{
				Danseurs[4].Moves.Add(new PLS.DanseTrad.Move(new Point(3, 0)));
				Danseurs[5].Moves.Add(new PLS.DanseTrad.Move(new Point(-3, 0)));
			}
			int ang0 = Danseurs[0].Angle;
			int ang1 = Danseurs[1].Angle;
			for (int i = 0; i <= 18; i++)
			{
				Danseurs[4].Moves.Add(null);
				Danseurs[5].Moves.Add(null);
				Danseurs[0].Moves.Add(new Move((ang0 + i) % 72));
				Danseurs[1].Moves.Add(new Move((ang1 - i) % 72));
			}
			for (int i = 0; i <= 5; i++)
			{
				Danseurs[4].Moves.Add(null);
				Danseurs[5].Moves.Add(null);
				Danseurs[0].Moves.Add(null);
				Danseurs[1].Moves.Add(null);
			}
			ang0 = Danseurs[0].Angle;
			ang1 = Danseurs[1].Angle;
			for (int i = 0; i <= 18; i++)
			{
				Danseurs[4].Moves.Add(null);
				Danseurs[5].Moves.Add(null);
				Danseurs[0].Moves.Add(new Move((ang0 - i) % 72));
				Danseurs[1].Moves.Add(new Move((ang1 + i) % 72));
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			InitializeMoves();
		}
		private void set1_MouseClick(object sender, MouseEventArgs e)
		{
			Danseur d = Danseurs[((int)numericUpDownNumeroCouple.Value - 1) * 2];
			d.CurrentPosition = new Point(e.X, e.Y);
			Debug.WriteLine($"Mouse X: {e.X} Y: {e.Y}");
			Update(numericUpDownAngle.Value);
		}
	
	}
}
