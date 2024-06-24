using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_04
{
    internal struct Magical
    {
        public uint Value {  get; set; }
        public uint DigitProduct { get; }
        public Magical(uint value){
            this.Value = value;
            this.DigitProduct = Magical.GetDigitProduct(value);
        }
        public static implicit operator Magical(uint value) => new Magical(value);
        public static implicit operator uint(Magical value) => value.Value;
        public static uint GetDigitProduct(uint n)
        {
            uint divisible = n;
            uint product = 1;
            while (divisible > 0)
            {
                product *= divisible % 10;
                divisible /= 10;
            }
            return product;
        }
    }
}
