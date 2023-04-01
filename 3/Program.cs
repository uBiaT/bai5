using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace asdasd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (double y = 15; y > -15; y -= 0.1)
            //{
            //    for (double x = -15; x < 15; x += 0.05)
            //    {
            //        double a = x * x + y * y - 1;
            //        Console.Write(a * a * a - x * x * y * y * y <= 0.0 ? "*" : " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            int size = 7; // adjust the size of the carrot here

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size - i; j++)
                    Console.Write(" ");

                for (int k = 1; k <= i; k++)
                    Console.Write("*");

                Console.WriteLine();
            }

            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(" ");

                for (int k = 1; k <= size - i; k++)
                    Console.Write("*");

                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}

