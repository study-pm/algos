/* Даны три числа расположить их по убыванию.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three numbers separated by space: ");
            string[] strArr = Console.ReadLine().Split(' ');
            double[] numbers = new double[] { double.Parse(strArr[0]), double.Parse(strArr[1]), double.Parse(strArr[2]) };

            double min = Math.Min(numbers[0], numbers[1]);
            min = Math.Min(min, numbers[2]);

            double max = Math.Max(numbers[0], numbers[1]);
            max = Math.Max(max, numbers[2]);

            double mean = (numbers[0] + numbers[1] + numbers[2]) - (min + max);

            Console.WriteLine($"Numbers ordered ascendent: {min}, {mean}, {max}");

        }
    }
}
