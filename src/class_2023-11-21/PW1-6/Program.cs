using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter triangle apex1 coordinates (x, y) separated by space: ");
            string[] a1 = Console.ReadLine().Split(' ');
            double[] apex1 = new double[] { double.Parse(a1[0]), double.Parse(a1[1]) };

            Console.Write("Enter triangle apex2 coordinates (x, y) separated by space: ");
            string[] a2 = Console.ReadLine().Split(' ');
            double[] apex2 = new double[] { double.Parse(a2[0]), double.Parse(a2[1]) };

            Console.Write("Enter triangle apex3 coordinates (x, y) separated by space: ");
            string[] a3 = Console.ReadLine().Split(' ');
            double[] apex3 = new double[] { double.Parse(a3[0]), double.Parse(a3[1]) };

            double side1 = Math.Sqrt(Math.Pow(apex2[0] - apex1[0], 2) + Math.Pow(apex2[1] - apex1[1], 2));
            double side2 = Math.Sqrt(Math.Pow(apex3[0] - apex2[0], 2) + Math.Pow(apex3[1] - apex2[1], 2));
            double side3 = Math.Sqrt(Math.Pow(apex1[0] - apex3[0], 2) + Math.Pow(apex1[1] - apex3[1], 2));

            double perimeter =  side1 + side2 + side3;
            double phalf = perimeter / 2;

            double square = Math.Sqrt(phalf * (phalf - side1) * (phalf - side2) * (phalf - side3));

            Console.WriteLine("Triangle perimeter is {0}, squre is {1}", perimeter, square);
        }
    }
}
