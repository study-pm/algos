using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rectangle sides separated by space: ");
            string[] strArr = Console.ReadLine().Split(' ');
            double[] sideArr = new double[] { double.Parse(strArr[0]), double.Parse(strArr[1]) };

            double perimeter = (sideArr[0] + sideArr[1]) * 2;
            double square = sideArr[0] * sideArr[1];
            double diagonal = Math.Sqrt(Math.Pow(sideArr[0], 2) + Math.Pow(sideArr[1], 2));

            Console.WriteLine($"Rectangle perimeter is {perimeter}, square is {square}, diagonal is {diagonal}");
        }
    }
}
