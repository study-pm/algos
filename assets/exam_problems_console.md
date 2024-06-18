# Экзаменационные задачи

## Задание 1
Составить алгоритм  и консольную программу для решения задачи.

### 1. Подсчитать количество целых чисел среди a, b, c.

```mermaid
flowchart TB
START([Начало]) --- data1
data1[/"numbers = [a, b, c]"/] --- process1
process1[count = 0] --- preparation1
preparation1{{i = 0; 3; 1}} --- solution1
preparation1 --- data2
solution1{"numbers[1] % 1 == 0"} --"yes"--> process2
process2[count++] --> preparation1
solution1 --"no"--> preparation1
data2[/count/] --> END
END([Останов])
```

```c#
// Подсчитать количество целых чисел среди a, b, c.

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "real numbers separated by a space";
            try
            {
                Console.Write("Enter {0}: ", msg);
                string[] input = Console.ReadLine().Split();

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
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid input (must be {msg}): " + e.Message);
            }
        }
    }
}
```
