/* Составить программу, которая определяет сумму только положительных из введенных трех чисел.
 */

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter three numbers separated by a space: ");
            string[] inputArr = Console.ReadLine().Split();
            double[] numberArr = new double[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++) numberArr[i] = double.Parse(inputArr[i]);

            // Calculation
            double s = 0;
            foreach(double n in numberArr) s += n > 0 ? n : 0;

            // Output
            Console.WriteLine("Sum of positive numbers is: " + s);
        }
    }
}
