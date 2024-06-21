using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class Matrix
    {
        public int[,] Value;
        public int ColumnCount
        {
            get {
                return Value.GetLength(1);
            }
        }
        public int RowCount
        {
            get
            {
                return Value.GetLength(0);
            }
        }
        public Matrix(int[] size)
        {
            Value = new int[size[0], size[1]];
            Random random = new Random();
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    Value[i, j] = random.Next(-100, 100);
                }
            }
        }
    }
}
