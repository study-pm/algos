/* Дана прямоугольная матрица размерности MxN.
 * Сформировать одномерный массив, в который занести последние (сверху вниз ) минимальные элементы каждого столбца матрицы.
 */

using Task_03;

namespace Task_04
{
    public class Matrix : Task_03.Matrix
    {
        public Matrix(double[,] input) : base(input) { }
        public Matrix(int[,] input) : base(input) { }
        /// <summary>
        /// Get last (top to bottom) min values for each column
        /// </summary>
        /// <returns>Indices and values</returns>
        public ((int, int)[], dynamic[]) GetLastMinOfColumns()
        {
            (int row, int col)[] indices = new (int, int)[ColCount];
            dynamic[] values = new dynamic[ColCount];

            for (int j = 0; j < ColCount; j++)
            {
                indices[j] = (Value.GetUpperBound(0), j);
                values[j] = Value[Value.GetUpperBound(0), j];
            }

            for (int j = 0; j < ColCount; j++)
            {
                for (int i = Value.GetUpperBound(0); i > -1; i--)
                {
                    if (Value[i, j] < values[j])
                    {
                        indices[j] = (i, j);
                        values[j] = Value[i, j];
                    }
                }
            }
            return (indices, values);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int M = 7;
            int N = 5;

            // For integers
            int[,] ints = Matrix.Generate(new int[] { M, N }, new int[] { -512, 512 }, dupesUpperBound: 7);

            (int row, int col)[] indices_ints = new (int, int)[N];
            int[] values_ints = new int[N];

            for (int j = 0; j < ints.GetLength(1); j++)
            {
                indices_ints[j] = (ints.GetUpperBound(0), j);
                values_ints[j] = ints[ints.GetUpperBound(0), j];
            }

            for (int j = 0; j < ints.GetLength(1); j++)
            {
                for (int i = ints.GetUpperBound(0); i > -1; i--)
                {
                    if (ints[i, j] < values_ints[j])
                    {
                        indices_ints[j] = (i, j);
                        values_ints[j] = ints[i, j];
                    }
                }
            }

            Dictionary<char, (int, int)[]> highlight_ints = new()
            {
                ['r'] = indices_ints,
            };

            string targetValues = "last (top to bottom) min values";

            Console.Write($"Auto-generated matrix of int values: {targetValues} for each column are ");
            Task_03.ConsoleExtension.SetColor('r');
            Console.Write("red");
            Console.ResetColor();
            Console.Write(".\n\n");

            Matrix matrix_ints = new(ints);
            matrix_ints.Print("|", marked: highlight_ints);

            Console.WriteLine();
            Console.WriteLine($"Matrix {targetValues} for each column: " + String.Join(" ", values_ints));
            Console.WriteLine($"Matrix {targetValues} indices for each column: " + String.Join(" ", indices_ints));

            Console.WriteLine(Environment.NewLine);

            // For doubles
            double[,] doubles = Matrix.Generate(new int[] { M, N }, new double[] { -512.0, 512.0 }, dupesUpperBound: 7);

            Matrix matrix_doubles = new(doubles);
            int roundingDigits = 2;

            ((int row, int col)[] indices_doubles, dynamic[] values_doubles) = matrix_doubles.GetLastMinOfColumns();

            Dictionary<char, (int, int)[]> highlight_doubles = new()
            {
                ['r'] = indices_doubles,
            };

            Console.Write($"Auto-generated matrix of double values: {targetValues} for each column are ");
            ConsoleExtension.SetColor('r');
            Console.Write("red");
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
