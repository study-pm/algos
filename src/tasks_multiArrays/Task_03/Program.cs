﻿/* Дана прямоугольная матрица размерности MxN.
 * Сформировать одномерный массив, в который занести первые (сверху вниз) максимальные элементы каждого столбца матрицы.
 */

namespace Task_03
{
    public class ConsoleExtension
    {
        static Dictionary<char, ConsoleColor> colors = new Dictionary<char, ConsoleColor>
        {
            {'w', ConsoleColor.White },
            {'g', ConsoleColor.Green },
            {'d', ConsoleColor.DarkGray },
            {'r', ConsoleColor.Red },
            {'b', ConsoleColor.Blue },
            {'y', ConsoleColor.Yellow },
            {'m', ConsoleColor.Magenta }
        };
        /// <summary>
        /// Set console foreground color
        /// </summary>
        /// <param name="color">Color code</param>
        public static void SetColor(char color = 'w')
        {
            try
            {
                Console.ForegroundColor = colors[color];
            }
            catch
            {
                Console.WriteLine("Invalid color char");
            }
        }
    }
    public class Matrix
    {
        public dynamic Value { get; set; }
        public int RowCount { get { return Value.GetLength(0); } }
        public int ColCount { get { return Value.GetLength(1); } }
        public Matrix(dynamic input) {
            Value = input;
        }
        /// <summary>
        /// Produce random value with the specified range
        /// </summary>
        /// <param name="range">Value range (min and max values)</param>
        /// <returns>Random value with the specified range</returns>
        private static int GetRandomValue(int[] range)
        {
            Random random = new();
            return random.Next(range[0], range[1]);
        }
        private static double GetRandomValue(double[] range)
        {
            Random random = new();
            return random.NextDouble() * (range[1] - range[0]) + range[0];
        }
        /// <summary>
        /// Produce random indices for dupes
        /// </summary>
        /// <param name="rowCount">Number of matrix rows</param>
        /// <param name="dupesUpperBound">Maximum number of dupes</param>
        /// <returns>Random indices</returns>
        private static int[] GenerateDupeIndices(int rowCount, int dupesUpperBound)
        {
            Random random = new Random();

            int dupeCount = random.Next(0, dupesUpperBound <= rowCount ? dupesUpperBound : rowCount);
            int[] dupeIndices = new int[dupeCount];
            for (int j = 0; j < dupeIndices.Length; j++) dupeIndices[j] = random.Next(0, rowCount);

            return dupeIndices;
        }
        /// <summary>
        /// Get matrix filled with random values
        /// </summary>
        /// <param name="dimensions">Number of rows (first index) and columns (second index) as [rowCount, columnCount]</param>
        /// <param name="range">Values range as [min, max]</param>
        /// <param name="dupesUpperBound">Maximum number of auto-generated randomized duplicated values for each column</param>
        /// <returns>New two-dimensional array</returns>
        public static int[,] Generate(int[] dimensions, int[] range, int dupesUpperBound = 5)
        {
            int[,] result = new int[dimensions[0], dimensions[1]];

            for (int j = 0; j < dimensions[1]; j++)
            {
                int[] dupeIndices = GenerateDupeIndices(dimensions[0], dupesUpperBound);
                int dupeValue = GetRandomValue(range);

                for (int i = 0; i < dimensions[0]; i++)
                {
                    result[i, j] = Array.IndexOf(dupeIndices, i) != -1 ? dupeValue : GetRandomValue(range);
                }
            }

            return result;
        }
        public static double[,] Generate(int[] dimensions, double[] range, int dupesUpperBound = 5)
        {
            double[,] result = new double[dimensions[0], dimensions[1]];

            for (int j = 0; j < dimensions[1]; j++)
            {
                int[] dupeIndices = GenerateDupeIndices(dimensions[0], dupesUpperBound);
                double dupeValue = GetRandomValue(range);

                for (int i = 0; i < dimensions[0]; i++)
                {
                    result[i, j] = Array.IndexOf(dupeIndices, i) != -1 ? dupeValue : GetRandomValue(range);
                }
            }

            return result;
        }
        /// <summary>
        /// Get first (top to bottom) max values for each column
        /// </summary>
        /// <returns>Indices and values</returns>
        public ((int, int)[], dynamic[]) GetFirstMaxOfColumns()
        {
            (int row, int col)[] indices = new (int, int)[ColCount];
            dynamic[] values = new dynamic[ColCount];

            for (int j = 0; j < ColCount; j++)
            {
                indices[j] = (0, j);
                values[j] = Value[0, j];
            }

            for (int j = 0; j < ColCount; j++)
            {
                for (int i = 0; i < RowCount; i++)
                {
                    if (Value[i, j] > values[j])
                    {
                        indices[j] = (i, j);
                        values[j] = Value[i, j];
                    }
                }
            }
            return (indices, values);
        }
        /// <summary>
        /// Prints matrix value in pretty format
        /// </summary>
        /// <param name="divider">Column separator (defaults to none)</param>
        /// <param name="paddingSpaces">Cell padding (number of spaces)</param>
        /// <param name="roundDigits">Number of decimal digits (defaults to none - no rounding)</param>
        /// <param name="marked">Matrix indices to be marked with provided color</param>
        public void Print(string divider = "", int paddingSpaces = 1, int? roundDigits = null, Dictionary<char, (int, int)[]>? marked = null)
        {
            static int GetDigitCount(dynamic n) => n.ToString().Length;
            static string GetFillingToMaxWidth(dynamic number, int maxWidth)
            {
                string result = number.ToString();
                int numberLength = result.Length;
                for (int i = 0; i < maxWidth - numberLength; i++)
                {
                    result = " " + result;
                }
                return result;
            }
            int GetMaxDigitCount(dynamic value)
            {
                int maxCount = 0;
                for (int i = 0; i < value.GetLength(0); i++)
                {
                    for (int j = 0; j < value.GetLength(1); j++)
                    {
                        int count = GetDigitCount(roundDigits == null ? value[i, j] : Math.Round(value[i, j], (int)roundDigits));
                        if (count > maxCount) maxCount = count;
                    }
                }
                return maxCount;
            }

            int cellInnerWidth = GetMaxDigitCount(Value);
            string padding = new string(' ', paddingSpaces);

            for (int i = 0; i < Value.GetLength(0); i++)
            {
                for (int j = 0; j < Value.GetLength(1); j++)
                {
                    Console.Write(padding);
                    char colorCode = 'w';
                    if (marked != null)
                    {
                        foreach (var item in marked)
                        {
                            if (Array.IndexOf(item.Value, (i, j)) != -1) colorCode = item.Key;
                        }
                    }
                    ConsoleExtension.SetColor(colorCode);
                    Console.Write(GetFillingToMaxWidth(roundDigits == null ? Value[i, j] : Value[i, j].ToString("N" + (int)roundDigits), cellInnerWidth));
                    Console.ResetColor();
                    ConsoleExtension.SetColor('d');
                    Console.Write(padding + (j != Value.GetLength(1) - 1 ? divider : ""));
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int M = 6;
            int N = 5;

            // For integers
            int[,] ints = Matrix.Generate(new int[] { M, N }, new int[] { -256, 256 }, dupesUpperBound: 6);

            (int row, int col)[] indices_ints = new (int, int)[N];
            int[] values_ints = new int[N];

            for (int j = 0; j < ints.GetLength(1); j++)
            {
                indices_ints[j] = (0, j);
                values_ints[j] = ints[0, j];
            }

            for (int j = 0; j < ints.GetLength(1); j++)
            {
                for (int i = 0; i < ints.GetLength(0); i++)
                {
                    if (ints[i, j] > values_ints[j])
                    {
                        indices_ints[j] = (i, j);
                        values_ints[j] = ints[i, j];
                    }
                }
            }

            Dictionary<char, (int, int)[]> highlight_ints = new Dictionary<char, (int, int)[]>()
            {
                ['g'] = indices_ints,
            };

            string targetValues = "first (top to bottom) max values";

            Console.Write($"Auto-generated matrix of int values: {targetValues} for each column are ");
            ConsoleExtension.SetColor('g');
            Console.Write("green");
            Console.ResetColor();
            Console.Write(".\n\n");

            Matrix matrix_ints = new(ints);
            matrix_ints.Print("|", marked: highlight_ints);

            Console.WriteLine();
            Console.WriteLine($"Matrix {targetValues} for each column: " + String.Join(" ", values_ints));
            Console.WriteLine($"Matrix {targetValues} indices for each column: " + String.Join(" ", indices_ints));

            Console.WriteLine(Environment.NewLine);

            // For doubles
            double[,] doubles = Matrix.Generate(new int[] { M, N }, new double[] { -256.0, 256.0 }, dupesUpperBound: 6);

            Matrix matrix_doubles = new(doubles);
            int roundingDigits = 2;

            ((int row, int col)[] indices_doubles, dynamic[] values_doubles) = matrix_doubles.GetFirstMaxOfColumns();

            Dictionary<char, (int, int)[]> highlight_doubles = new()
            {
                ['g'] = indices_doubles,
            };

            Console.Write($"Auto-generated matrix of double values: {targetValues} for each column are ");
            ConsoleExtension.SetColor('g');
            Console.Write("green");
            Console.ResetColor();
            Console.Write(".\n\n");

            matrix_doubles.Print("|", roundDigits: roundingDigits, marked: highlight_doubles);

            Console.WriteLine();
            Console.Write($"Matrix {targetValues} for each column:");
            foreach (double val in values_doubles) Console.Write(" " + val.ToString("N" + roundingDigits));
            Console.WriteLine();
            Console.WriteLine($"Matrix {targetValues} indices for each column: " + String.Join(" ", indices_doubles));
        }
    }
}
