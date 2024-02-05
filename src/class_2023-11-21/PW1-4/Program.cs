/* Дана длина ребра куба. Найти площадь грани, площадь полной поверхности и объем этого куба.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter cube edge length: ");
            double edgeLength = double.Parse(Console.ReadLine());

            double faceSquare = Math.Pow(edgeLength, 2);

            double surfaceSquare = 6 * faceSquare;

            double cubeVolume = Math.Pow(edgeLength, 3);

            Console.WriteLine("Cube face square is {0}, surface square is {1}, volume {2}", faceSquare, surfaceSquare, cubeVolume);

        }
    }
}
