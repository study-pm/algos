using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesChangeGame
{
    public class Utils
    {
        public static string Capitalize(string input)
        {
            if (input.Length == 0)
            {
                return input;
            }
            else if (input.Length == 1)
            {
                return char.ToUpper(input[0]) + "";
            }
            else
            {
                return char.ToUpper(input[0]) + input.Substring(1);
            }
        }
    }
}
