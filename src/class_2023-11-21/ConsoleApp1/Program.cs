using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1 = 1;
            double var2 = 1.0;
            bool var3 = false;
            char var4 = 'c';
            string var5 = "some string";
            Console.WriteLine("Declared variables: {0}, {1}, {2}, {3}, {4}", var1, var2, var3, var4, var5);
            Console.WriteLine($"Declared variables: {var1}, {var2}, {var3}, {var4}, {var5}");

            Random rnd = new Random();
            int a1 = rnd.Next(-100, 100);
            double b1 = rnd.NextDouble();

            // Random integer in full range
            int int1 = rnd.Next();

            // Random integer in range [0, 3000]
            int int2 = rnd.Next(3000);

            // Random integer in range [-50, 50]
            int int3 = rnd.Next(-50, 50);

            // Random real in full range [0, 1]
            double double1 = rnd.NextDouble();

            // Random real in range (-50, 50)
            double double2 = rnd.Next(-50, 49) + rnd.NextDouble();

            // Alternative way (items quantity + left margin)
            double double3 = rnd.NextDouble() * 101 - 50;

            Console.WriteLine($"Randoms are: {int1}, {int2}, {int3}, {double1}, {double2}, {double3}");

            double d1 = Math.Abs(-45);
            double d2 = Math.Round(5.868964, 3);

            // Sin(pi/6)
            double sin = Math.Sin(Math.PI/6);

            // Sqrt(16)
            double sqrt = Math.Sqrt(16);

            // 3^4 (3**4)
            double degree = Math.Pow(3, 4);

            Console.WriteLine($"Values are: {sin}, {sqrt}, {degree}");

            Console.Write("Enter triangle sides separated by ordinary space: ");
            string input = Console.ReadLine();
            string[] strArr = input.Split(' ');
            double[] sideArr = new double[strArr.Length];

            for (int i = 0; i < sideArr.Length; i++)
            {
                sideArr[i] = double.Parse(strArr[i]);
            };

            double square = sideArr[0] * sideArr[1];
            double perimeter = (sideArr[0] + sideArr[1]) * 2;
            double diagonal = Math.Sqrt(Math.Pow(sideArr[0], 2) + Math.Pow(sideArr[1], 2));

            Console.WriteLine($"Rectangle square is {square}, perimeter is {perimeter}, diagonal is {diagonal}");
        }

    }
}
