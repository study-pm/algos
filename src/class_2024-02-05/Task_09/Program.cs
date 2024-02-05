/* В заданном массиве найти максимальный элемент. Элементы, стоящие после максимального элемента заменить нулями.
 */

namespace Task_09
{
    public class Utils
    {
        public static int[] GetArrayExtremeValueAndIndex(int[] array, bool isMax = true)
        {
            int value = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (isMax ? array[i] > value : array[i] < value)
                {
                    value = array[i];
                    index = i;
                }
            }

            return new int[] {value, index };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] array = Task_05.Utils.GetRandomIntArray(n);

            int[] maxValueIndex = Utils.GetArrayExtremeValueAndIndex(array);

            // Output
            Console.WriteLine("Source array items: " + String.Join(' ', array));
            Console.WriteLine($"Source array max value is {maxValueIndex[0]} for index {maxValueIndex[1]}");

            for (int i = maxValueIndex[1]+1; i < array.Length; i++)
            {
                array[i] = 0;
            }

            Console.WriteLine("Result array items: " + String.Join(' ', array));
        }
    }
}
