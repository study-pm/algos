/* Дано натуральное число n.
 * Найти и вывести все числа в интервале от 1 до (n-1),
 * у которых произведение всех цифр совпадает с суммой цифр данного числа.
 * Если таких чисел нет, то вывести информацию об этом.
 * Для вычисления  произведения цифр числа составить подпрограмму.
 * 
 * Например, n = 44
 * Сумма цифр числа n: 4+4=8.
 * Интервал: от 1 до 43.
 * Результат: 18 (1*8=8), 24 (2*4=8), 42 (4*2=8).
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_03
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();

            dataGridView_output.AllowUserToAddRows = false;
            dataGridView_output.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView_output.Visible = false;
            label_sum.Visible = false;
            textBox_sum.Visible = false;
        }
        private void Clear()
        {
            dataGridView_output.Visible = false;
        }
        private void GenerateOutput(uint sum, (uint, uint)[] series)
        {

            label_sum.Visible = true;
            textBox_sum.Visible = true;

            textBox_sum.Text = sum.ToString();

            dataGridView_output.Visible = true;

            // dataGridView_output.ColumnCount = series.Length;
            dataGridView_output.RowCount = 1;
            dataGridView_output.Columns[0].HeaderText = series[0].Item1.ToString();
            dataGridView_output.Columns[0].ReadOnly = true;
            dataGridView_output.Columns[0].Width = 40;
            dataGridView_output[0, 0].Value = series[0].Item2;

            for (int i = 1; i < series.Length; i++)
            {
                dataGridView_output.Columns.Add(new DataGridViewColumn()
                {
                    CellTemplate = new DataGridViewTextBoxCell(),
                    HeaderText = series[i].Item1.ToString(),
                    ReadOnly = true,
                    Width = 40,
                });
                dataGridView_output[i, 0].Value = series[i].Item2;
            }

            Label label_output = new Label()
            {
                Location = new Point(10, 100),
                Name = "label_output",
                Text = "Result",
            };
            Controls.Add(label_output);

            string text = String.Join(" ", series);
            TextBox textBox_ouput = new TextBox()
            {
                Location = new Point(10, 125),
                Name = "textBox_ouput",
                Text = text,
                Width = 250,
            };
            this.Controls.Add(textBox_ouput);
        }
        private (uint, uint)[] Process(Natural n)
        {
            uint digitSum = (new MagicalNumber(n)).DigitSum;

            uint[] range = { 1, n };
            (uint Number, uint Sum)[] sumArr = Array.Empty<(uint, uint)>();
            for (uint i = 0, j = range[0]; j < range[1]; i++, j++)
            {
                MagicalNumber number = j;
                if (number.DigitProduct == digitSum)
                {
                    Array.Resize(ref sumArr, sumArr.Length + 1);
                    sumArr[sumArr.GetUpperBound(0)] = (j, number.DigitProduct);
                }
            }
            return sumArr;
        }
        private bool Validate(string input)
        {
            if (!Natural.TryParse(input, out Natural output))
            {
                errorProvider_name.SetError(textBox_n, "Must be a valid natural number");
                return false;
            }
            errorProvider_name.Clear();
            return true;
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            /*
            Label label_n = new Label()
            {
                Location = new Point(10, 30),
                Name = "label_n",
                Text = "Enter n (must be a natural number)",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = 170,
                Height = 15,
            };
            TextBox textBox_n = new TextBox()
            {
                Location = new Point(160, 30),
                Name = "textBox_n",
            };

            groupBox_input.Controls.Add(label_n);
            groupBox_input.Controls.Add(textBox_n);
            */
        }

        private void textBox_n_TextChanged(object sender, EventArgs e)
        {
            Validate(textBox_n.Text);
            Clear();
        }
        private void textBox_n_Validating(object sender, CancelEventArgs e)
        {
            /*
            if (String.IsNullOrEmpty(textBox_n.Text))
            {
                errorProvider_name.SetError(textBox_n, "Must be a value");
            }
            if (textBox_n.Text.Length < 5)
            {
                errorProvider_name.SetError(textBox_n, "Must be a value");
            }
            */
            Validate(textBox_n.Text);
        }

        private void textBox_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!Validate(textBox_n.Text))
                {
                    MessageBox.Show("Must be a valid natural number.");
                    return;
                }

                Natural n = Natural.Parse(textBox_n.Text);
                GenerateOutput((new MagicalNumber(n)).DigitSum, Process(n));
            }
        }
    }
}
