/* Осуществить ввод пользовательности целых чисел.
 * Определить, сколько из них и какие принимают наибольшее значение.
 * Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int? max = null;
            int count = 0;
            do
            {
                Console.Write("Enter integer number: ");
                input = int.Parse(Console.ReadLine());
                if (input == 0) break;
                if (max == null) max = input;
                if (max == input)
                {
                    count++;
                }
                else if (max < input)
                {
                    max = input;
                    count = 1;
                }
            }
            while (input != 0);
            Console.WriteLine($"Maximum is {max}, repeated {count} times");
        }
    }
}
