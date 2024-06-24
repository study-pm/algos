using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_03
{
    internal struct MagicalNumber
    {
        public uint Value {  get; set; }
        public uint DigitProduct { get; }
        public uint DigitSum { get; }
        public MagicalNumber(uint value) {
            Value = value;
            DigitProduct = GetDigitProduct(Value);
            DigitSum = GetDigitSum(Value);
        }
        public static implicit operator MagicalNumber(uint value) {  return new MagicalNumber(value); }
        public static implicit operator uint(MagicalNumber value) {  return value.Value; }
        public static uint GetDigitProduct(uint value)
        {
            uint product = 1;
            uint divisible = value;
            while (divisible > 0)
            {
                product *= divisible % 10;
                divisible /= 10;
            }
            return product;
        }
        public static uint GetDigitSum(uint value)
        {
            uint sum = 0;
            uint divisible = value;
            while (divisible > 0)
            {
                sum += divisible % 10;
                divisible /= 10;
            }
            return sum;
        }
    }
}
