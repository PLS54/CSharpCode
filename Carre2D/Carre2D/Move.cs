using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLS.DanseTrad
{
    class Move
    {
        public Point NewPos { get; private set; }
        public int? Angle { get; private set; }
        public Move()
        {
        }
        public Move(Point pos, int? angle = null)
        {
            NewPos = pos;
            Angle = angle;
        }
        public Move(int angle)
        {
            NewPos = new Point(0, 0);
            Angle = angle;
        }
    }
}
