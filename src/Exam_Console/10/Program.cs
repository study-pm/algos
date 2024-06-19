/* Вычислить стоимости покупки с учетом скидки.
 * Скидка в 1% предоставляется, если сумма покупки больше 100 руб.,
 * в 3% - если сумма больше 500 руб.,
 * в 5% - если сумма больше 1000 руб.
 */

using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Console_10
{
    internal class Program
    {
        public struct ENatural
        {
            /// <summary>
            /// Represents extended natural number (all natural integers including zero)
            /// </summary>
            private readonly int _value;
            public ENatural(int value)
            {
                _value = value;
            }
            // Use as: ENatural nat = (ExtNatural)2;
            // public static explicit operator ENatural(int value) => new ENatural(value);
            // Use as: ENatural nat = 2;
            public static implicit operator ENatural(int value) => new ENatural(value);
            // Use as: ENatural nat = 2; double d = nat;
            public static implicit operator double(ENatural value) => value._value;
            public static ENatural operator +(ENatural a, ENatural b) => new ENatural(a._value + b._value);
            public static ENatural operator -(ENatural a, ENatural b) => new ENatural(a._value - b._value);
            public static ENatural operator *(ENatural a, ENatural b) => new ENatural(a._value * b._value);
            public static ENatural operator /(ENatural a, ENatural b) => new ENatural(a._value / b._value);
            public static ENatural operator %(ENatural a, ENatural b) => new ENatural(a._value % b._value);
            public static bool operator >(ENatural a, ENatural b) => a._value > b._value;
            public static bool operator <(ENatural a, ENatural b) => a._value < b._value;
            public static bool operator >=(ENatural a, ENatural b) => a._value >= b._value;
            public static bool operator <=(ENatural a, ENatural b) => a._value <= b._value;
            public static bool operator ==(ENatural a, ENatural b) => a._value == b._value;
            public static bool operator !=(ENatural a, ENatural b) => a._value != b._value;
            public static ENatural Parse(string value)
            {
                int val = int.Parse(value);
                if (val < 0) throw new FormatException($"The input string {value} was not in a correct format: must be a non-negative integer");
                return new ENatural(val);
            }
            public override string ToString() => $"{_value}";
        }
        /// <summary>
        /// Represents non-negative double value
        /// </summary>
        public struct NonNegative
        {
            private readonly double _value;
            public NonNegative(double value)
            {
                _value = value;
            }
            // Use as: NonNegative nat = (NonNegative)2;
            // public static explicit operator ENatural(int value) => new ENatural(value);
            // Use as: ENatural nat = 2;
            public static implicit operator NonNegative(double d) => new NonNegative(d);
            // Use as: ENatural nat = 2; double d = nat;
            public static implicit operator double(NonNegative n) => n._value;
            /// <summary>
            /// Converts the string representation of a number to its double-precision floating-point non-negative number equivalent
            /// <example>
            /// <para/>Method call combined with assignment:
            /// <code>NonNegative n = NonNegative.Parse(input);
            /// </code>
            /// </example>
            /// </summary>
            /// <param name="s">Input string</param>
            /// <returns>A double-precision floating-point non-negative number that is equivalent to the numeric value or symbol specified in s</returns>
            /// <exception cref="ArgumentNullException"></exception>
            /// <exception cref="FormatException"></exception>
            /// <exception cref="OverflowException"></exception>
            public static NonNegative Parse(string s)
            {
                double val = double.Parse(s);
                if (val < 0) throw new FormatException($"The input string {s} was not in a correct format: must be a non-negative number");
                return new NonNegative(val);
            }
            public override string ToString() => $"{_value}";
        }
        static double GetDiscount(double amt)
        {
            return amt switch
            {
                > 1000  => 0.05,
                > 500   => 0.03,
                > 100   => 0.01,
                _       => 0
            };
        }
        static double GetDiscountGen<T>(T amt) where T : struct
        {
            Console.WriteLine("GetDiscountGen: ", amt.ToString());
            return amt switch
            {
                > 1000  => 0.05,
                > 500   => 0.03,
                > 100   => 0.01,
                _       => 0
            };
        }
        static void Main(string[] args)
        {
            // Console output setup
            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("ru-RU");
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            try
            {
                Console.Write("Enter amount: ");
                string input = Console.ReadLine();
                double amount = double.Parse(input);
                NonNegative amt = NonNegative.Parse(input);
                // ENatural amtN = ENatural.Parse(input);
                // Console.WriteLine("AmtN: " + amtN);

                double discount = GetDiscountGen(amt);
                Console.WriteLine("Discount: " + discount);

                if (amount < 0) throw new Exception("Must be a non-negative value");

                double sum = (1 - GetDiscount(amt)) * amt;

                string formatted = string.Format(cultureInfo, "{0:c}", sum);

                Console.WriteLine("Amount regarding discount is: " + formatted);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input: " + e.Message + " " + e.GetType());
            }
        }
    }
}
