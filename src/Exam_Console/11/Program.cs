/* Даны целые числа А, В.
 * Если числа не равны, то заменить каждое из них одним и тем же числом, равным большему из исходных,
 * а если равны, то заменить числа нулями.
 */

namespace Console_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Enter integer number";
            try
            {
                Console.Write(msg + " A: ");
                int A = int.Parse(Console.ReadLine());

                Console.Write(msg + " B: ");
                int B = int.Parse(Console.ReadLine());

                if (A == B)
                {
                    A = B = 0;
                }
                else
                {
                    int max = Math.Max(A, B);
                    int maximum = A > B ? A : B;
                    A = B = max;
                }
                Console.WriteLine($"A = {A}, B = {B}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input: " + e.Message);
            }
        }
    }
}
