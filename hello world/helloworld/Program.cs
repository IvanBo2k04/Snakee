using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            int num1 = Int32.Parse(a);
            int num2 = Int32.Parse(b);
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 * num2);
            double average =  (double) (num2 + num1) / 2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
