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
            ResetForm();
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

            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView2.ScrollBars = ScrollBars.None;


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
            ClearDataGrid(dataGridView2);

            Matrix.CreateMatr();                // заполняем элементы матрицы сгенерированными значениями
            Matrix.PrintMatr(dataGridView1);    // выводим результат в таблицу 1

            ToggleControls(true);

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

        private void button_tripleColumn_Click(object sender, EventArgs e)
        {
            Matrix.MultiplyColumn(1, 3);
            Matrix.PrintMatr(dataGridView2);
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            Matrix = new Mas();

            ResetForm();

            // Matrix.PrintMatr(dataGridView1);
            /*
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            */
        }
        private void ClearDataGrid(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; ++i)
            {
                for (int j = 0; j < dgv.Columns.Count; ++j)
                {
                    //Значения ячеек хряняться в типе object
                    //это позволяет хранить любые данные в таблице
                    dgv[j, i].Value = "";
                }
            }
        }
        private void ResetForm()
        {
            ClearDataGrid(dataGridView1);
            ClearDataGrid(dataGridView2);

            ToggleControls(false);
            ToggleLabels(false);

        }
        private void ToggleControls(bool isOn)
        {
            button_doubleMatrix.Enabled = isOn;
            button_tripleColumn.Enabled = isOn;
            button_zeroesAboveMain.Enabled = isOn;
            button_countInColumn.Enabled = isOn;
            button_countInRow.Enabled = isOn;
        }
        private void ToggleLabels(bool isOn)
        {
            label_positiveCountInColumn.Visible = isOn;
            label_negativeCountInColumn.Visible = isOn;
            label_positiveCountInRow.Visible = isOn;
            label_negativeCountInRow.Visible = isOn;
            label_posCountInCol.Visible = isOn;
            label_negCountInCol.Visible = isOn;
            label_posCountInRow.Visible = isOn;
            label_negCountInRow.Visible = isOn;
        }

        private void button_zeroesAboveMain_Click(object sender, EventArgs e)
        {
            Matrix.SetZeroesAboveMain();
            Matrix.PrintMatr(dataGridView2);
        }
        private void button_countInColumn_Click(object sender, EventArgs e)
        {
            int[] count = Matrix.CountElements(new int[] {0, 5}, new int[] {0, 1});
            label_posCountInCol.Text = count[0].ToString();
            label_negCountInCol.Text = count[1].ToString();
            label_positiveCountInColumn.Visible = true;
            label_posCountInCol.Visible = true;
            label_negativeCountInColumn.Visible = true;
            label_negCountInCol.Visible = true;
        }

        private void button_countInRow_Click(object sender, EventArgs e)
        {
            int[] count = Matrix.CountElements(new int[] { 0, 1 }, new int[] { 0, 5 });
            label_posCountInRow.Text = count[0].ToString();
            label_negCountInRow.Text = count[1].ToString();
            label_positiveCountInRow.Visible = true;
            label_posCountInRow.Visible = true;
            label_negativeCountInRow.Visible = true;
            label_negCountInRow.Visible = true;
        }
    }
}
