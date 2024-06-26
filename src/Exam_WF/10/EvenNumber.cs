using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WF_10
{
    internal class EvenNumber : NaturalNumber
    {
        public uint Value { get; set; }
        // @ToFix: Inherit constructor properly from base class
        public EvenNumber(uint value) : base(value) { this.Value = value; }
        public static implicit operator EvenNumber(uint n)
        {
            return Parse(n.ToString());
        }
        public static implicit operator uint(EvenNumber value) { return value.Value; }
        public static EvenNumber operator ++(EvenNumber a)
        {
            a += 2;
            return a;
        }
        public static EvenNumber Parse(string s)
        {
            NaturalNumber n = NaturalNumber.Parse(s);
            if (n % 2 != 0) throw new FormatException($"The input string {s} was not in a correct format. Must be an even number.");
            return new EvenNumber(n.Value);
        }
    }
}
