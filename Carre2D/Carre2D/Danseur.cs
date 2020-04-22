using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLS.DanseTrad
{
	class Danseur
	{
		public Color Couleur { get; set; }
		public Point CurrentPosition { get; set; }
		public Point Origin { get; set; }
		public int Angle { get; set; }
		private Tuple<double, double>[] Circle { get; set; }
		public List<Move> Moves { get; set; }
		public Danseur(Color couleur, Point position, int angle, Tuple<double, double>[] circle)
		{
			Couleur = couleur;
			CurrentPosition = position;
			Angle = angle;
			Circle = circle;
			Moves = new List<Move>();
			Debug.WriteLine($"Danseur creating at {position.X}, {position.Y} coleur {couleur}");
		}
		private int TranslateX(int size, int index)
		{
			int scale = 1;
			return (int) Math.Round(size * scale * Circle[index].Item1);
		}
		private int TranslateY(int size, int index)
		{
			int scale = 1;
			return (int)Math.Round(size * scale * Circle[index].Item2);
		}
		public void Draw(Graphics g, Point translateBy, int turnBy)
		{
			int scale = 10;
			CurrentPosition = new Point(CurrentPosition.X + translateBy.X, CurrentPosition.Y + translateBy.Y);
			int index0 = turnBy % 72;
			int index90 = (turnBy + 18) % 72;
			int index180 = (turnBy + 36) % 72;
			int index270 = (turnBy + 54) % 72;
			//double xScale = scale * Circle[turnBy].Item1;
			//double yScale = scale * Circle[turnBy].Item2;

			Point[] points = {
				new Point(CurrentPosition.X + TranslateX(30, index0), CurrentPosition.Y + TranslateY(30, index0)),
				new Point(CurrentPosition.X + TranslateX(10, index90), CurrentPosition.Y +TranslateY(10, index90)),
				new Point(CurrentPosition.X + TranslateX(30, index180), CurrentPosition.Y + TranslateY(30, index180)),
				new Point(CurrentPosition.X + TranslateX(5, index270), CurrentPosition.Y + TranslateY(5, index270))
			};
			g.FillClosedCurve(new SolidBrush(Couleur), points);
		}
		public void StepToNext(Graphics g)
		{
			Point toPos = new Point(0, 0);
			int angle = Angle;
			if (Moves.Count > 0)
			{
				Move nextMove = Moves[0];
				Moves.RemoveAt(0);
				if (nextMove != null)
				{
					angle = nextMove.Angle == null ? Angle : (int)nextMove.Angle;
					toPos = nextMove.NewPos;
				}
			}
			Draw(g, toPos, angle);
			Angle = angle;
		}
	}
}
