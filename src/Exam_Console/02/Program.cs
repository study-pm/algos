/* Даны координаты двух точек A и B. Вычислить расстояние между точками.
 * Определить, какая точка находится ближе к началу координат.
 */

namespace Console_02
{
    struct Point : IComparable
    {
        private double[] _coordinates = Array.Empty<double>();
        public double[] Coordinates {
            get {
                return _coordinates;
            }
        }
        private double _length = 0;
        public double Length
        {
            get
            {
                return _length;
            }
        }
        public Point(double[] coordinates)
        {
            Array.Copy(coordinates, this._coordinates, coordinates.Length);
            _length = GetLength(coordinates);
        }
        static public double GetLength(double[] coordinates)
        {
            double sum = 0;
            foreach (var coordinate in coordinates)
            {
                sum += Math.Pow(coordinate, 2);
            }
            return sum;
        }
        static public double[] ConvertStringToDoubleArr(string input)
        {
            string[] inputArr = input.Split(' ');
            double[] point = new double[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                point[i] = Convert.ToDouble(inputArr[i]);
            }
            return point;
        }
        public int CompareTo(object obj)
        {
            // Point b = obj as Point;
            Point b = (Point)obj;
            if (this.Length == b.Length) return 0;
            else if (this.Length > b.Length) return 1;
            else return -1;
        }
    }
    internal class Program
    {
        static double GetDistance(double[] A, double[] B)
        {
            double sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += Math.Pow(B[i] - A[i], 2);
            }
            return Math.Sqrt(sum);
        }
        static double[] ConvertToDouble(string val)
        {
            string[] input = val.Split(' ');
            double[] point = new double[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                point[i] = Convert.ToDouble(input[i]);
            }
            return point;
        }
        static void Main()
        {
            try
            {
                Console.Write("Enter the A position coordinates separated by a space: ");
                double[] A = ConvertToDouble(Console.ReadLine());
                Console.Write("Enter the B position coordinates separated by a space: ");
                double[] B = ConvertToDouble(Console.ReadLine());

                double[] O = new double[A.Length];

                double AB = GetDistance(A, B);
                double AO = GetDistance(A, O);
                double BO = GetDistance(B, O);

                Console.WriteLine("Distance between A and B is: {0: .##}", AB);
                if (AO == BO)
                {
                    Console.WriteLine("Both points are equally remote from the origin.");
                }
                else
                {
                    Console.WriteLine("The closest to the origin point is " + (AO < BO ? nameof(A) : nameof(B)) + ".");
                }
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
