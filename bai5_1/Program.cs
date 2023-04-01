using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                //numbers[i] = int.Parse(Console.ReadLine());
                Random random = new Random();
                numbers[i] = random.Next(1,100);
                Console.WriteLine($"Nhap phan tu thu {i + 1}: {numbers[i]}");
            }

            Console.WriteLine();
            Console.WriteLine($"Tong: {numbers.Sum()}");
            Console.WriteLine($"So nho nhat: {numbers.Min()}");
            Console.WriteLine($"So lon nhat: {numbers.Max()}");
            Console.WriteLine($"Trung binh: {numbers.Average()}");

            string result;

            Console.WriteLine();
            Array.Sort(numbers);
            result = string.Join(" < ", numbers );
            Console.WriteLine($"Mang theo thu tu tang dan la: {result}");

            Console.WriteLine();
            Array.Reverse(numbers);
            result = string.Join(" > ", numbers);
            Console.WriteLine($"Mang theo thu tu giam dan la: {result}");

            Console.ReadKey();
        }
    }
}
