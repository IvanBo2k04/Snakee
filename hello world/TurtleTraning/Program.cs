using Microsoft.SmallBasic.Library;

namespace TurtleTraning
{
    class Program
    {
        static void WriteT(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(60);
            Turtle.TurnLeft();
            Turtle.Move(20);
            Turtle.Turn(180);
            Turtle.Move(40);
        }
        static void WriteO(int size)
        {
            for (int i = 0; i < 2; i++)
            {
                Turtle.Move(60);
                Turtle.TurnRight();
                Turtle.Move(20);
                Turtle.TurnRight();
            }

        }
        static void Main(string[] args)
        {

            Turtle.Speed = 10;
            Turtle.X = 200;
            Turtle.Y = 200;

            {
                WriteT(60);

                Turtle.X = 260;
                Turtle.Y = 200;

                Turtle.Angle = 0;

                    WriteO(30);

                }
                Turtle.X = 320;
                Turtle.Y = 200;

                Turtle.Angle = 0;
                Turtle.Move(30);
                for (int i = 0; i < 4; i++)
                {
                    Turtle.TurnRight();
                    Turtle.Move(20);
                }
                Turtle.X = 380;
                Turtle.Y = 200;
                    WriteT(30);

                

                




            }


        }
    }

