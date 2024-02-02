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
