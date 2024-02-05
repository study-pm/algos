using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter four digit integer number: ");
            int n = int.Parse(Console.ReadLine());

            int a4 = n % 10;
            int a1 = n / 1000;

            int a2 = n % 1000 / 100;

            int a3 = n % 100 / 10;

            int sum = a1 + a2 + a3 + a4;

            Console.WriteLine($"Sum is {sum}");
        }
    }
}
