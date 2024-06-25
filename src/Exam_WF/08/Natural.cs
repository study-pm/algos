using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_08
{
    internal struct Natural
    {
        public uint Value { get; set; }
        public Natural(uint value) { Value = value; }
        public override string ToString() => Value.ToString();
        public static implicit operator Natural(uint value) => new Natural(value);
        public static implicit operator uint(Natural n) => n.Value;
        public static implicit operator int(Natural n) => (int)n.Value;
        public static Natural Parse(string s)
        {
            uint parsed = uint.Parse(s);
            if (parsed < 1) throw new FormatException($"The input string {s} was not in the correct format. Must be greater than zero.");
            return new Natural(parsed);
        }
    }
}
