using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR5
{
    internal class Mas
    {
        public const int n = 5;         // Задаем размерность матрицы с помощью константы
        int[,] Matr = new int[n, n];    // Выделяем память под элементы матрицы

        public int[] CountElements(int[] rowRg, int[] colRg)
        {
            int[] count = new int[2];

            for (int i = rowRg[0]; i < rowRg[1]; i++)
            {
                for (int j = colRg[0]; j < colRg[1]; j++)
                {
                    if (Matr[i, j] > 0) count[0]++;
                    else if (Matr[i, j] < 0) count[1]++;
                }
            }
            return count;
        }
        // Метод генерации элементов матрицы
        public void CreateMatr()
        {
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matr[i, j] = rnd.Next(-100, 100);
                }
            }
            return;
        }
        public void DoubleMatr()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matr[i, j] *= 2;
                }
            }
        }
        public void MultiplyColumn(int j, int m)
        {
            for (int i = 0; i < n; i++)
            {
                Matr[i, j] *= m;
            }
        }
        public void SetZeroesAboveMain()
        {
            int c = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = c; j < n; j++)
                {
                    Matr[i, j] = 0;
                }
                c++;
            }
        }
        // Метод вывода матрицы в таблицу, нужно подключить пространство имен, содержащее описание DataGridView
        // using System.Windows.Forms;
        public void PrintMatr(DataGridView dgv) // Передаем, в какую именно таблицу хотим вывести
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Способ 1
                    dgv[j, i].Value = Matr[i, j]; // таблица формируется по столбцам, а матрица по строкам
                    // Способ 2
                    dgv.Rows[i].Cells[j].Value = Matr[i, j];
                }
            }
        }
    }
}
