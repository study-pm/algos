/* Пользователь загадывает число в диапазоне от [1 до 100].
 * Пользователь загадывает в уме, программа не хранит это число, а пытается его угадать.
 * Программа пытается его угадать (вместо обычного перебора постарайтесь использовать метод бинарного поиска, т.е. делениме отрезка на 2, пока число не будет найдено).
 * Программа может задавать пользователю вопросы: Число равно...?, Число больше...? и, в зависимости от ответа пользователя, принимать решения.
 * Вместо текстовых ответов ДА/НЕТ используйте число 0 - НЕТ и 1 - ДА.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            // Random rnd = new Random();
            int random;
            while (min != max)
            {
                // int random = rnd.Next(min, max);
                random = (min + max) / 2;
                Console.Write("Is it " + random + "? ");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    min = max;
                    break;
                }
                Console.Write("Is it greater? ");
                answer = Console.ReadLine();
                if (answer == "1") min = random;
                else max = random;
            }
        }
    }
}
