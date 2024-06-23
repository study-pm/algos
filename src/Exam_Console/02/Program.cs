/* Даны координаты двух точек A и B. Вычислить расстояние между точками.
 * Определить, какая точка находится ближе к началу координат.
 */

using System.IO;

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

                FileInfo f = new FileInfo("result.txt");
                StreamWriter fOut = new StreamWriter(f.Create());
                fOut.WriteLine("Distance between A and B is: {0: .##}", AB);

                if (AO == BO)
                {
                    Console.WriteLine("Both points are equally remote from the origin.");
                    fOut.WriteLine("Both points are equally remote from the origin.");
                }
                else
                {
                    Console.WriteLine("The closest to the origin point is " + (AO < BO ? nameof(A) : nameof(B)) + ".");
                    fOut.WriteLine("The closest to the origin point is " + (AO < BO ? nameof(A) : nameof(B)) + ".");
                }

                fOut.Close();

                Console.WriteLine("*******" + f.Name + "File Info" + "**************");
                Console.WriteLine("File size: {0}", f.Length);
                Console.WriteLine("Creation: {0}", f.CreationTime);
                Console.WriteLine("Attributes: {0}", f.Attributes.ToString());
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);
                FileInfo f = new FileInfo("error.txt");
                StreamWriter fOut = new StreamWriter(f.Create());
                fOut.WriteLine("Error: Invalid input");
                fOut.WriteLine("Type: " + exc.GetType());
                fOut.WriteLine("Message: " + exc.Message);
                fOut.WriteLine("Stack trace: " + exc.StackTrace);
                fOut.Close();

                // https://learn.microsoft.com/ru-ru/dotnet/api/system.io.file.appendtext?view=net-8.0
                string path = "error.txt";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Hello");
                        sw.WriteLine("And");
                        sw.WriteLine("Welcome");
                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("This");
                    sw.WriteLine("is Extra");
                    sw.WriteLine("Text");
                }

                // Open the file to read from.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
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
