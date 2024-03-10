/* Напишите программу, формирующую квадратную матрицу, элементы которой являются натуральными числами, расположенными в порядке возрастания от 1 до n2 согласно приведенной схеме.
 */

namespace Task_05_1
{
    internal class Program
    {
        public static int[,] GetFilledWithNaturals(int n)
        {
            int[,] matrix = new int[n, n];

            int number = 0;

            int row_top = 0;
            int col_top_start = 0;
            int col_top_end = n - 1;

            int col_right = n - 1;
            int row_right_start = 0;
            int row_right_end = n - 1;

            int row_bottom = n - 1;
            int col_bottom_start = n - 1;
            int col_bottom_end = 0;

            int col_left = 0;
            int row_left_start = n - 1;
            int row_left_end = 0;

            int c = 0;
            while (c < n/2)
            {
                for (int j = col_top_start; j < col_top_end; j++)
                {
                    matrix[row_top, j] = ++number;
                }
                row_top++;
                col_top_start++;
                col_top_end--;

                for (int i = row_right_start; i < row_right_end; i++)
                {
                    matrix[i, col_right] = ++number;
                }
                col_right--;
                row_right_start++;
                row_right_end--;

                for (int j = col_bottom_start; j > col_bottom_end; j--)
                {
                    matrix[row_bottom, j] = ++number;
                }
                row_bottom--;
                col_bottom_start--;
                col_bottom_end++;

                for (int i = row_left_start; i > row_left_end; i--)
                {
                    matrix[i, col_left] = ++number;
                }
                col_left++;
                row_left_start--;
                row_left_end++;

                c++;
            }

            // fill in center cell (for odd n)
            if (number != (int)Math.Pow(n, 2))
            {
                int i = n / 2;
                matrix[i, i] = ++number;
            }

            return matrix;
        }
        static void Main()
        {
            try
            {
                Console.Write("Enter a non-negative integer: ");
                int n = int.Parse(Console.ReadLine());

                if (n < 0) throw new Exception("invalid input");

                int[,] matrix = GetFilledWithNaturals(n);
                Task_01.Utils.PrintArray(matrix);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input: must be a non-negative integer.");
            }
        }
    }
}
