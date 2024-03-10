/* Создать 1 из выбранных пользователем типов массивов (одномерный или двумерный).
 * В зависимости от выбора пользователя заполнить его вручную или случайными целыми числами.
 * Размерность массива задает пользователь.
 * Полученный массив вывести на экран.
 */

using System.Drawing;

namespace Task_04
{
    public class Matrix
    {
        public dynamic Value { get; set; }
        public int RowCount { get { return Value.GetLength(0); } }
        public int ColCount { get { return Value.GetLength(1); } }
        public Matrix(dynamic input)
        {
            Value = input;
        }
        public void Print(string divider = "", int paddingSpaces = 1)
        {
            Task_01.Utils.PrintArray(Value, divider, paddingSpaces);
        }
        public static int[] ParseSizeString(string input)
        {
            try
            {
                string[] sizeStr = input.Split(' ');
                int[] size = new int[sizeStr.Length];
                for (int i = 0; i < size.Length; i++)
                {
                    size[i] = int.Parse(sizeStr[i]);
                }
                return size;
            }
            catch (Exception)
            {
                throw new Exception("size");
            }
        }
        public static int[] GetRandomsArray(int length, int[] range)
        {
            return Task_01.Utils.GetRandomsArray(length, range);
        }
        public static int[,] GetRandomsArray(int[] size, int[] range)
        {
            return Task_01.Utils.GetRandomsArray(size[0], size[1], range);
        }
        public static int[] FillIn(int length)
        {
            int[] array = new int[length];
            string[] valuesStr = Console.ReadLine().Split(" ");
            if (valuesStr.Length == 1 && string.IsNullOrEmpty(valuesStr[0]))
            {
                return GetRandomsArray(length, new int[] { -128, 128 });
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(valuesStr[i]);
            }
            return array;
        }
        public static int[,] FillIn(int rowCount, int colCount)
        {
            int[,] matrix = new int[rowCount, colCount];
            string[] valuesStr = Console.ReadLine().Split(" ");
            if (valuesStr.Length == 1 && string.IsNullOrEmpty(valuesStr[0]))
            {
                return GetRandomsArray(new int[] { rowCount, colCount }, new int[] { -128, 128 });
            }
            void ParseRow(int i)
            {
                for (int j = 0; j < matrix.GetLength(1); j++) matrix[i, j] = int.Parse(valuesStr[j]);
            }
            ParseRow(0);
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                valuesStr = Console.ReadLine().Split(" ");
                ParseRow(i);
            }
            return matrix;

        }
        public static dynamic FillIn(int[] size)
        {
            Console.WriteLine("Enter values separated by a space, press Return when done with the current row (empty input will fill in the matrix with auto-generated values):");
            try
            {
                if (size.Length == 1)
                {
                    return FillIn(size[0]);
                }
                else
                {
                    return FillIn(size[0], size[1]);
                }
            }
            catch (Exception e)
            {
                if (e is IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid row length: all rows must be not less than provided lenth");
                    throw;
                }
                if (e is FormatException)
                {
                    Console.WriteLine("Invalid value: all items must be valid integer numbers");
                    throw;
                }
                switch (e.Message)
                {
                    case "rows":
                        Console.WriteLine("Invalid row count: must be a natural number");
                        throw;
                    default:
                        Console.WriteLine("Invalid input");
                        throw;
                }
                throw;
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter matrix size, must be 1 (for one-dimensional) or 2 (for two-dimensional) integers separated by a space: ");
                int[] size = Matrix.ParseSizeString(Console.ReadLine());

                Matrix matrix = new(Matrix.FillIn(size));
                matrix.Print("|");
            }
            catch (Exception e)
            {
                switch(e.Message)
                {
                    case "size":
                        Console.WriteLine("Invalid size: must be 1 or 2 integer numbers separated by a space");
                        break;
                    default:
                        Console.WriteLine("Invalid input: " + e);
                        break;
                }
            }
        }
    }
}
