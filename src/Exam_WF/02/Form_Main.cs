/* Вычислить значение функции y = (3n!-4m!)/(3 * (5 - m)!),
 * где n, m вводятся с клавиатуры.
 * Для вычисления факториала числа использовать рекурсивную функцию
 * k! = 1, if k = 0,
 * k! = k * (k-1)!, if k >= 1
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_02
{
    public partial class Form_Main : Form
    {
        CultureInfo ci = CultureInfo.GetCultureInfo("ru-RU");

        uint m = 0;
        uint n = 0;
        // Факториа́л — функция, определённая на множестве неотрицательных целых чисел.
        static double Factorial(uint k)
        {
            if (k == 0) return 1;
            return k * Factorial(--k);
        }
        public Form_Main()
        {
            InitializeComponent();

            textBox_m.Validating += ValidateInt;
        }
        private void ValidateInt(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            int dummy;
            e.Cancel = !int.TryParse(tb.Text, out dummy);
            tb.Select(0, tb.Text.Length);
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            if (m > 5)
            {
                MessageBox.Show("Значение m должно быть в диапазоне от 0 до 5");
                return;
            }

            double y = (3 * Factorial(n) - 4 * Factorial(m)) / (3 * Factorial(5 - m));
            textBox_y.Text = string.Format(ci, "{0:N2}", y);
        }

        private void textBox_m_TextChanged(object sender, EventArgs e)
        {
            uint.TryParse(textBox_m.Text, out m);
        }

        private void textBox_n_TextChanged(object sender, EventArgs e)
        {
            uint.TryParse(textBox_n.Text, out n);
        }
    }
}
