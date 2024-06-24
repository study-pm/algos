using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_03
{
    internal struct Natural : IParsible
    {
        public uint Value { get; set; }
        public Natural(uint value)
        {
            Value = value;
        }
        public override string ToString() => Value.ToString();
        public static implicit operator Natural(uint u) => new Natural(u);
        public static implicit operator uint(Natural n) => n.Value;
        public static Natural Parse(string input) {
            uint result = uint.Parse(input);
            if (result == 0) throw new ArgumentException("Zero is not a natural number");
            return new Natural(result);
        }
        public static bool TryParse(string input, out Natural output)
        {
            output = new Natural(1);
            try
            {
                output.Value = Natural.Parse(input).Value;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
