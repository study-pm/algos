using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_10
{
    internal class NaturalNumber
    {
        public uint Value;
        public NaturalNumber(uint value) { Value = value; }
        public override string ToString() { return Value.ToString(); }
        public static implicit operator uint(NaturalNumber n) {  return n.Value; }
        public static implicit operator NaturalNumber(uint n)
        {
            return NaturalNumber.Parse(n.ToString());
        }
        public static NaturalNumber Parse(string s)
        {
            uint res = uint.Parse(s);
            if (res < 1) throw new FormatException($"The inut string {s} was not in a correct format. Must be greater than zero.");
            return new NaturalNumber(res);
        }
    }
}
