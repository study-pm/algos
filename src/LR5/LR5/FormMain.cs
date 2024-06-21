using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LR5
{
    public partial class FormMain : Form
    {
        // private Matrix _matrix;
        Mas Matrix = new Mas();
        public FormMain()
        {
            InitializeComponent();

            // надписи для вывода значения результата подсчета + и - чисел
            label_positiveCountInColumn.Visible = false;
            label_negativeCountInColumn.Visible = false;
            label_positiveCountInRow.Visible = false;
            label_negativeCountInRow.Visible = false;
            label_posCountInCol.Visible = false;
            label_negCountInCol.Visible = false;
            label_posCountInRow.Visible = false;
            label_negCountInRow.Visible = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Mas.n - публичная константа, отвечающая за размерность матрицы
            dataGridView1.RowCount = Mas.n + 1;
            dataGridView1.ColumnCount = Mas.n;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Width = 40;
            }

            dataGridView2.RowCount = Mas.n + 1;
            dataGridView2.ColumnCount = Mas.n;

            for (int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                dataGridView2.Columns[i].Width = 40;
            }

            // отключаем возможность внесения пользователем своих строк, из-за этого кол-во строк установлено как n+1
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;


            // dataGridView_matrixSrc.AllowUserToAddRows = false;

            //создадим таблицу вывода товаров с колонками
            //Название, Цена, Остаток



            /*
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Название"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "name"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Цена";
            column2.Name = "price";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Остаток";
            column3.Name = "count";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);

            dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

            for (int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                dataGridView1.Rows.Add("Пример 1, Товар " + i, i * 1000, i);
            }

            for (int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения каждой ячейки по имени (можно использовать индекс 0, 1, 2 вместо имен)
                dataGridView1.Rows.Add();
                dataGridView1["name", dataGridView1.Rows.Count - 1].Value = "Пример 2, Товар " + i;
                dataGridView1["price", dataGridView1.Rows.Count - 1].Value = i * 1000;
                dataGridView1["count", dataGridView1.Rows.Count - 1].Value = i;
            }

            //А теперь простой пройдемся циклом по всем ячейкам
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                {
                    //Значения ячеек хряняться в типе object
                    //это позволяет хранить любые данные в таблице
                    object o = dataGridView1[j, i].Value;
                }
            }
            */
        }

        private void button_createMatrix_Click(object sender, EventArgs e)
        {
            Matrix.CreateMatr();                // заполняем элементы матрицы сгенерированными значениями
            Matrix.PrintMatr(dataGridView1);    // выводим результат в таблицу 1

            /*
            _matrix = new Matrix(new int[] { 5, 5 });

            for (int i = 0; i < _matrix.ColumnCount; i++)
            {
                dataGridView_matrixSrc.Columns.Add(new DataGridViewColumn()
                {
                    CellTemplate = new DataGridViewTextBoxCell(),
                    Frozen = true,
                    ReadOnly = true,
                    Width = 40,
                });
            }

            for (int j = 0; j < _matrix.RowCount; j++)
            {
                dataGridView_matrixSrc.Rows.Add();
                // dataGridView_matrixSrc.Rows.Add(_matrix.Value[j, 0], _matrix.Value[j, 1], _matrix.Value[j, 2], _matrix.Value[j, 3], _matrix.Value[j, 4]);
            }
            */

        }

        private void button_doubleMatrix_Click(object sender, EventArgs e)
        {
            Matrix.DoubleMatr();                // удваиваем матрицу
            Matrix.PrintMatr(dataGridView2);    // выводим результат в таблицу 2
        }
    }
}
