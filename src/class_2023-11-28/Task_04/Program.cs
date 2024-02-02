/*  Программа загадывает число в диапазоне [1; 9].
 *  Пользователь вводит число с клавиатуры.
 *  Программа в зависимости от введенного числа выводит в консоль следующее:
 *  - "загаданное число больше";
 *  - "загаданное число меньше";
 *  - "вы угадали" (программа завершает работу).
 *  Если введен 0, вывести "выход из программы" (программа завершает работу)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 9);
            Console.WriteLine("The hidden number: " + random);
            Console.Write("Enter integer in range between 1 and 9: ");
            int input = -1;
            while (input != 0 || input != random)
            {
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    Console.WriteLine("Program exit.");
                    break;
                }
                else if (random > input)
                {
                    Console.Write("The hidden number is greater. ");
                }
                else if (random < input)
                {
                    Console.Write("The hidden number is smaller. ");
                }
                else
                {
                    Console.WriteLine("You guessed the number right!");
                    break;
                }
                Console.Write("Guess again: ");
            }
        }
    }
}
