using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap bac ma tran: ");
            int n = int.Parse(Console.ReadLine());
            string[,] maTran = new string[n, n];

            Console.WriteLine();

            Random random = new Random();
            int randomNumber = random.Next(1, 99);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    maTran[i, j] = $"({i},{j})";
                    Console.Write($"{maTran[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
