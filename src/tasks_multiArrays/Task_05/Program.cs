/* Дана прямоугольная матрица размерности MxN.
 * Найти максимальный элемент массива, минимальный и среднее арифметическое
 */

using System.ComponentModel.DataAnnotations;
using Task_03;

namespace Task_05
{
    public class Matrix : Task_04.Matrix
    {
        public Matrix(double[,] input) : base(input) { }
        public Matrix(int[,] input) : base(input) { }

        private (dynamic value, (int, int)[] indices)? Max = null;
        private dynamic Mean = null;
        private (dynamic value, (int, int)[] indices)? Min = null;

        public (dynamic value, (int, int)[] indices) GetMax()
        {
            dynamic max = Value[0, 0];
            List<(int, int)> maxIndices = new List<(int, int)>() { (0, 0) };
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    if (Value[i, j] > max)
                    {
                        maxIndices.Clear();
                        max = Value[i, j];
                    }
                    if (Value[i, j] == max)
                    {
                        maxIndices.Add((i, j));
                    }
                }
            }
            return (max, maxIndices.ToArray());
        }
        public double GetMean()
        {
            dynamic sum = 0;
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++) sum += Value[i, j];
            }
            return (double)sum / (RowCount * ColCount);
        }
        public (dynamic value, (int, int)[] indices) GetMin()
        {
            dynamic min = Value[0, 0];
            List<(int, int)> minIndices = new List<(int, int)>() { (0, 0) };
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    if (Value[i, j] < min)
                    {
                        minIndices.Clear();
                        min = Value[i, j];
                    }
                    if (Value[i, j] == min)
                    {
                        minIndices.Add((i, j));
                    }
                }
            }
            return (min, minIndices.ToArray());
        }

        public dynamic Maximum {
            get {
                Max ??= GetMax();
                return Max;
            }
        }
        public double MeanVal
        {
            get
            {
                Mean ??= GetMean();
                return Mean;
            }
        }
        public dynamic Minimum
        {
            get
            {
                Min ??= GetMin();
                return Min;
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            int M = 10;
            int N = 6;

            // For integers
            int[,] ints = Matrix.Generate(new int[] { M, N }, new int[] { -1024, 1024 }, dupesUpperBound: 8);

            int max = ints[0, 0];
            List<(int, int)> maxIndices = new List<(int, int)>() { (0, 0) };
            int min = ints[0, 0];
            List<(int, int)> minIndices = new List<(int, int)>() { (0, 0) };
            int sum = 0;

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (ints[i, j] > max)
                    {
                        maxIndices.Clear();
                        max = ints[i, j];
                    }
                    if (ints[i, j] == max)
                    {
                        maxIndices.Add((i, j));
                    }
                    if (ints[i, j] < min)
                    {
                        minIndices.Clear();
                        min = ints[i, j];
                    }
                    if (ints[i, j] == min)
                    {
                        minIndices.Add((i, j));
                    }
                    sum += ints[i, j];
                }
            }

            double mean = (double)sum / (ints.GetLength(0) * ints.GetLength(1));

            Dictionary<char, (int, int)[]> highlight_ints = new()
            {
                ['g'] = maxIndices.ToArray(),
                ['r'] = minIndices.ToArray(),
            };

            Console.Write($"Auto-generated matrix of int values: max values are ");
            Task_03.ConsoleExtension.SetColor('g');
            Console.Write("green");
            Console.ResetColor();
            Console.Write($", min values are ");
            Task_03.ConsoleExtension.SetColor('r');
            Console.Write("red");
            Console.Write(".\n\n");

            Matrix matrix_ints = new(ints);
            matrix_ints.Print("|", marked: highlight_ints);

            Console.WriteLine();
            Console.Write("Matrix mean arithmetic value is ");
            Task_03.ConsoleExtension.SetColor('b');
            Console.Write(mean.ToString("N2"));
            Console.ResetColor();

            Console.WriteLine(Environment.NewLine);

            // For doubles
            double[,] doubles = Matrix.Generate(new int[] { M, 5 }, new double[] { -1024.0, 1024.0 }, dupesUpperBound: 8);

            Matrix matrix_doubles = new(doubles);
            int roundingDigits = 2;

            Dictionary<char, (int, int)[]> highlight_doubles = new()
            {
                ['g'] = matrix_doubles.Maximum.Item2,
                ['r'] = matrix_doubles.Minimum.Item2,
            };

            Console.Write($"Auto-generated matrix of double values: max values are ");
            Task_03.ConsoleExtension.SetColor('g');
            Console.Write("green");
            Console.ResetColor();
            Console.Write($", min values are ");
            Task_03.ConsoleExtension.SetColor('r');
            Console.Write("red");
            Console.Write(".\n\n");

            matrix_doubles.Print("|", roundDigits: roundingDigits, marked: highlight_doubles);

            Console.WriteLine();
            Console.Write("Matrix mean arithmetic value is ");
            Task_03.ConsoleExtension.SetColor('b');
            Console.Write(matrix_doubles.MeanVal.ToString("N2"));
            Console.ResetColor();
        }
    }
}
