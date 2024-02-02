/*  Посчитать количество чисел кратных 7 и 13 в диапазоне от -1000 до 1000.
 *  Если таких чисел нет, вывести соответветствующее сообщение.
 *  Вывести на экран числа и их количество.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = -1000;
            int end = 1000;
            int current = start;
            int quantity = 0;
            while (current <= end)
            {
                if (current % 7 == 0 && current % 13 == 0)
                {
                    quantity++;
                    Console.Write(current + " ");
                }
                current++;
            }
            if (quantity == 0)
            {
                Console.WriteLine("There are no numbers divisible by 7 and 13 in the given range [-1000, 1000]");
            }
            else
            {
                Console.WriteLine("Sum of numbers divisible by 7 and 13 in the given range [-1000, 1000] is {0}", quantity);
            }
        }
    }
}
