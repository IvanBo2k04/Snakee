using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public string sum;

        public Point(int _x, int _y, string _sum)
        {
            x = _x;
            y = _y;
            sum = _sum;
        }
        public Point()
        {

        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sum);
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sum = p.sum;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.right)
            {
                x = x + offset;
            }
            else if (direction == Direction.left)
            {
                x = x - offset;
            }
            else if (direction == Direction.up)
            {
                y = y + offset;
            }
            else if (direction == Direction.down)
            {
                y = y - offset;
            }
        }



        public override string ToString()
        {
            return x + ", " + y + ", " + sum;
        }
    }
}

