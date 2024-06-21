using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Massiv
    {
        int size;
        int[] mas;

        public int Size {
            get
            {
                return size;
            }
            set
            {
                if (value < 0){
                    size = 0;
                }
                else size = value;
            }
        }
        public string CreateMas()
        {
            string s = string.Empty;
            if (size == 0) return s;
            else
            {
                Random r = new Random();
                mas = new int[size];

                for (int i = 0; i < size; i++)
                {
                    mas[i] = r.Next(-100, 100);
                    s = s + mas[i].ToString() + " ";
                }
                return s;
            }
        }
        public string SummMas()
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += mas[i];
            }
            return sum.ToString();
        }
        public string ReversMas()
        {
            return string.Join(" ", mas.Reverse());
        }
        public string ChangeElem()
        {
            (mas[2], mas[3]) = (mas[3], mas[2]);
            return string.Join(" ", mas);
        }
    }
}
