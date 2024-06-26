/* Вычислить расстояние между двумя точками с координатами (х1, у1) и (х2, у2).
 * Координаты точек должны вводиться пользователем.
 */

using System.Globalization;

namespace Console_05
{
    internal struct Point
    {
        public double[] Coordinates;
        public int Rank;
        public double OriginDistance;
        public Point(double[] coordinates)
        {
            this.Coordinates = coordinates;
            this.Rank = coordinates.Length;
            this.OriginDistance = Point.GetDistance(coordinates, new double[coordinates.Length]);
        }
        public static Point Parse(string s)
        {
            string separator = " ";
            if (s.Contains(",")) separator = ",";
            else if (s.Contains(";")) separator = ";";

            string[] input = s.Split(separator, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            double[] coordinates = new double[input.Length];
            for (uint i = 0; i < input.Length; i++)
            {
                coordinates[i] = double.Parse(input[i]);
            }
            return new Point(coordinates);
        }
        public static double GetDistance(double[] a, double[] b)
        {
            double sum = 0;
            for (uint i = 0; i < a.Length; i++)
            {
                sum += Math.Pow(b[i] - a[i], 2);
            }
            return Math.Sqrt(sum);
        }
        public static double GetDistance(Point a, Point b)
        {
            double sum = 0;
            for (uint i = 0; i < a.Rank; i++)
            {
                sum += Math.Pow(b.Coordinates[i] - a.Coordinates[i], 2);
            }
            return Math.Sqrt(sum);
        }
    }
    internal class Program
    {
        public static double[] ParseCoordinates(string val)
        {
            string[] input = val.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
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
            CultureInfo ci = CultureInfo.GetCultureInfo("ru-Ru");
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string msg = "Enter the point coordinates separated by a space, colon or semicolon: ";
            try
            {
                Console.Write(msg);
                string input1 = Console.ReadLine();
                double[] point1 = ParseCoordinates(input1);
                Point pt1 = Point.Parse(input1);

                Console.Write(msg);
                string input2 = Console.ReadLine();
                double[] point2 = ParseCoordinates(input2);
                Point pt2 = Point.Parse(input2);

                Console.WriteLine($"Distance between points is: {GetDistance(point1, point2): .##}");

                string path = "result.txt";
                File.WriteAllText(path, Point.GetDistance(pt1, pt2).ToString());
                Console.WriteLine("Read from file: " + File.ReadAllText(path));

                StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Unicode);
                sw.WriteLine("Appendage");
                sw.Close();

                using (StreamReader sr = new StreamReader(path))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine($"{line}");
                    }
                    Console.WriteLine(sr.ReadLine());
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);

                string path = "error.txt";
                string[] err =
                {
                    "Timestamp: " + DateTime.Now.ToString(ci),
                    "Error: Invalid input",
                    "Type: " + exc.GetType().Name,
                    "Message: " + exc.Message,
                    "Stack trace: " + exc.StackTrace,
                };

                File.WriteAllLines(path, err);
                string[] e = File.ReadAllLines(path);
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
