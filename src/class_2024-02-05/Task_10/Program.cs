/* В заданном массиве поменять местами наибольший и наименьший элементы.
 */

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] array = Task_05.Utils.GetRandomIntArray(n);

            int[] maxValueIndex = Task_09.Utils.GetArrayExtremeValueAndIndex(array);
            int[] minValueIndex = Task_09.Utils.GetArrayExtremeValueAndIndex(array, false);

            // Output
            Console.WriteLine("Source array items: " + String.Join(' ', array));
            Console.WriteLine($"Source array max value is {maxValueIndex[0]} for index {maxValueIndex[1]}");
            Console.WriteLine($"Source array min value is {minValueIndex[0]} for index {minValueIndex[1]}");

            (array[minValueIndex[1]], array[maxValueIndex[1]]) = (array[maxValueIndex[1]], array[minValueIndex[1]]);

            Console.WriteLine("Result array items: " + String.Join(' ', array));
        }
    }
}
