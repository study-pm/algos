// Подсчитать количество целых чисел среди a, b, c.

namespace Console_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "real numbers separated by a space";
            try
            {
                Console.Write("Enter {0}: ", msg);
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

                double[] numbers = new double[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    numbers[i] = double.Parse(input[i]);
                }

                int count = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 1 == 0) count++;
                }

                Console.WriteLine("Number of integers is: " + count);

                File.WriteAllText("result.txt", "Number of integers is: " + count);
                Console.WriteLine(File.ReadAllText("result.txt"));
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Invalid input (must be {msg}): " + exc.Message);

                string[] errInfo = {
                    $"Error: Invalid input (must be {msg})",
                    "Type: " + exc.GetType().Name,
                    "Message: " + exc.Message,
                    "Stack trace: " + exc.StackTrace
                };
                File.WriteAllLines("error.txt", errInfo);
                string[] err = File.ReadAllLines("error.txt");
                foreach(string line in err)
                {
                    Console.WriteLine(line);
                };
            }
        }
    }
}
