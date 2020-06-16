using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            Vert VertL = new Vert(0, 24, 0, "*");
            VertL.Draw();

            Gor GorD = new Gor(0, 78, 24, "*");
            GorD.Draw();

            Vert VertR = new Vert(0, 24, 78, "*");
            VertR.Draw();

            Gor GorUp = new Gor(0, 78, 0, "*");
            GorUp.Draw();

            Point p = new Point(4, 5, "*");
            Snake snake = new Snake(p, 4, Direction.right);
            //Point p = new Point(5, 6, "+");
            //p.Draw();
            //Console.ReadLine();
                     
            
        }     
            
            
        
    }
}
