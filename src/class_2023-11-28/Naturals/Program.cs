using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naturals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter natural number: ");
                int input = int.Parse(Console.ReadLine());
                int sum = 0;
                if (input < 1)
                {
                    Console.WriteLine("Must be a positive integer.");
                    return;
                }
                for (int i = 0; i <= input; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Sum is {0}", sum);
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input: must be a natural number (positive integer)");
            }
        }
    }
}
