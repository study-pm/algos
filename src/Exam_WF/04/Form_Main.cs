/* Дано натуральное число n.
 * Найти и вывести все числа в интервале от 1 до (n-1),
 * у которых произведение всех цифр совпадает с произведением цифр данного числа.
 * Если таких чисел  нет, то вывести информацию об этом.
 * Для вычисления произведения цифр числа составить подпрограмму.
 *
 * Например, n = 44
 * Произведение цифр числа n: 4 * 4 = 16.
 * Интервал: от 1 до 43.
 * Результат: 28(2 * 8 = 16).
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

namespace WF_04
{
    public partial class Form_Main : Form
    {
        string errMsg = "Must be a valid natural number!";
        public Form_Main()
        {
            InitializeComponent();
        }
        private void GetOutput(uint[] arr)
        {
            textBox_out.Text = arr.Length == 0 ? "No such numbers" : String.Join(", ", arr);
        }
        private uint[] Process(Magical n)
        {
            uint[] res = Array.Empty<uint>();
            for (uint i = 0; i < n; i++)
            {
                if (n.DigitProduct == Magical.GetDigitProduct(i))
                {
                    Array.Resize(ref res, res.Length+1);
                    res[res.GetUpperBound(0)] = i;
                }
            }
            return res;
        }
        private void ToggleOut(bool isOn)
        {
            groupBox_out.Visible = isOn;
        }
        private bool Validate(string input)
        {
            if (Natural.TryParse(input, out Natural n))
            {
                errorProvider_n.Clear();
                return true;
            }
            else
            {
                errorProvider_n.SetError(textBox_n, errMsg);
                return false;
            }
        }
        private void textBox_n_TextChanged(object sender, EventArgs e)
        {
            Validate(textBox_n.Text);
            ToggleOut(false);
        }

        private void textBox_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!Validate(textBox_n.Text))
                {
                    MessageBox.Show(errMsg);
                    return;
                };

                GetOutput(Process((uint)Natural.Parse(textBox_n.Text)));
                ToggleOut(true);
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            ToggleOut(false);
        }
    }
}
