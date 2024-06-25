using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_07
{
    internal struct Natural
    {
        public uint Value {  get; set; }
        public Natural(uint value) { Value = value; }
        public override string ToString() => Value.ToString();
        public static implicit operator Natural(uint n) { return new Natural(n); }
        public static implicit operator uint(Natural n) { return n.Value; }
        public static Natural Parse(string s)
        {
            uint n = uint.Parse(s);
            if (n < 1) throw new FormatException($"The input string {s} was not in the correct format. Must be a valid natural number (greater than zero).");
            return new Natural(n);
        }
    }
}
