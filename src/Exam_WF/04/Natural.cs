using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_04
{
    internal struct Natural
    {
        public uint Value {  get; set; }
        public Natural(uint value) { Value = value; }
        public override string ToString() { return Value.ToString(); }
        public static implicit operator Natural(uint value) {  return new Natural(value); }
        public static implicit operator uint(Natural natural) {  return natural.Value; }
        public static Natural Parse(string s)
        {
            uint res = uint.Parse(s);
            if (res < 1) throw new FormatException($"The input string {s} was not in a correct format. Must be a valid natural number (greater than zero).");
            return new Natural(res);
        }
        public static bool TryParse(string s, out Natural n)
        {
            n = 1;
            try
            {
                n = Natural.Parse(s);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
