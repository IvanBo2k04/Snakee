using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            pList = new List<Point>();
            for (int a = 0; a < length; a++)
            {
                Point p = new Point(tail);
                p.Move(a, direction);
                pList.Add(p);
            }
        }
    }
}
