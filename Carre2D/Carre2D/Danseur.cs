using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLS.DanseTrad
{
	class Danseur
	{
		private Color Couleur { get; set; }
		public Point CurrentPosition { get; set; }
		public Point Origin { get; set; }
		private int Angle { get; set; }
		private Tuple<double, double>[] Circle { get; set; }

		public Danseur(Color couleur, Point position, int angle, Tuple<double, double>[] circle)
		{
			Couleur = couleur;
			CurrentPosition = position;
			Angle = angle;
			Circle = circle;
		}
		private int TranslateX(int size, int index)
		{
			int scale = 10;
			return (int) Math.Round(size * scale * Circle[index].Item1);
		}
		private int TranslateY(int size, int index)
		{
			int scale = 10;
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
				new Point(CurrentPosition.X + TranslateX(3, index0), CurrentPosition.Y + TranslateY(3, index0)),
				new Point(CurrentPosition.X + TranslateX(1, index90), CurrentPosition.Y +TranslateY(1, index90)),
				new Point(CurrentPosition.X + TranslateX(3, index180), CurrentPosition.Y + TranslateY(3, index180)),
				new Point(CurrentPosition.X + TranslateX(1, index270), CurrentPosition.Y + TranslateY(1, index270))
			};
			g.FillClosedCurve(new SolidBrush(Couleur), points);

		}
	}
}
