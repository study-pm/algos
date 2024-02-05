using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter round radius value: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double circleLength = 2 * Math.PI * radius;

            double roundSquare = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Circle length is {0}, round square is {1}", circleLength, roundSquare);
        }
    }
}
