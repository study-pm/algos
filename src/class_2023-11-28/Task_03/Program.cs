using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a natural number: ");
            /*
            string input = Console.ReadLine();
            string output = "";
            foreach (char symbol in input)
            {
                string t = "";
                output = t + symbol + output;
            }
            int result = int.Parse(output);
            Console.WriteLine("Result is " + result);
            */

            int input = int.Parse(Console.ReadLine());
            int dividend = input;
            int result = 0;
            while (dividend != 0)
            {
                result *= 10;
                result += dividend % 10;
                dividend /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
