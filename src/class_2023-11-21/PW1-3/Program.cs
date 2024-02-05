/* Даны два числа. Найти среднее арифметическое их квадратов и среднее арифметическое их модулей.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PW1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter numbers separated by space: ");
            //string[] strArr = Console.ReadLine().Split(' ');
            //double[] numberArr = new double[strArr.Length];
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    numberArr[i] = double.Parse(strArr[i]);
            //};

            //double getMeanSqr(double[] values)
            //{
            //    double sum = 0;
            //    for (int i = 0; i < values.Length; i++)
            //    {
            //        sum += Math.Pow(values[i], 2);
            //    }
            //    return sum/values.Length;
            //}

            //double getMeanAbs(double[] values)
            //{
            //    double sum = 0;
            //    for (int i = 0; i < values.Length; i++)
            //    {
            //        sum += Math.Abs(values[i]);
            //    }
            //    return sum / values.Length;
            //}

            //double meanSqr = getMeanSqr(numberArr);
            //double meanAbs = getMeanAbs(numberArr);

            Console.Write("Enter first number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double number2 = double.Parse(Console.ReadLine());

            double meanSqr = (Math.Pow(number1, 2) + Math.Pow(number2, 2))/2;
            double meanAbs = (Math.Abs(number1) + Math.Abs(number2))/2;

            Console.WriteLine($"Mean of number squares is: {meanSqr}, mean of number absolute values is: {meanAbs}");

        }
    }
}
