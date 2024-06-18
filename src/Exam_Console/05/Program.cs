/* Вычислить расстояние между двумя точками с координатами (х1, у1) и (х2, у2).
 * Координаты точек должны вводиться пользователем.
 */

namespace Console_05
{
    internal class Program
    {
        public static double[] ParseCoordinates(string val)
        {
            string[] input = val.Split(' ');
            double[] point = new double[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                point[i] = double.Parse(input[i]);
            }
            return point;
        }
        public static double GetDistance(double[] a, double[] b)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += Math.Pow(b[i] - a[i], 2);
            }
            return Math.Sqrt(sum);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first point coordinates separated by a space: ");
                double[] point1 = ParseCoordinates(Console.ReadLine());
                Console.Write("Enter the second point coordinates separated by a space: ");
                double[] point2 = ParseCoordinates(Console.ReadLine());

                Console.WriteLine($"Distance between points is: {GetDistance(point1, point2): .##}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input: " + e.Message);
            }
        }
    }
}

// https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/
/* Sample data
 * Input: A(-1, 3) и B(6,2);
 * Output: AB = 5√2 = 7.07; Closest is A.
 *
 * Input: A(2, -2) и B(0, 1)
 * Output: AB = √13 = 3.61; Closest is B.
 *
 * Input: A(-1, 3, 3) и B(6, 2, -2)
 * Output: AB = 5√3 = 8.66; Closest is A.
 *
 * Input: B(3, 1, 3) и B(0, -3, 3)
 * Output: AB = 5; Closest is B.
 *
 * Input: A(3, 0, -4) и B(0, 0, 5)
 * Output: AB = 9,49; Equally remote.
 */
