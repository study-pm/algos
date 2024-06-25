/* Дано натуральное число n (вводится с клавиатуры).
 * Вычислить сумму ряда. 1 + x + x^2/2! + x^3/3! + ... + x^n/n!.
 * Для вычисления факториала числа и возведения числа x в степень написать подпрограммы.
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

namespace WF_07
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private int GetFactorial(int n)
        {
            if (n == 0) return 1;
            return n * GetFactorial(--n);
        }
        private double GetPower(double pBase, int pExp)
        {
            if (pExp == 0) return 1;
            if (pExp < 0) return GetPower(1/pBase, -pExp);
            return pBase * GetPower(pBase, --pExp);
        }
        private double GetSeriesSum(uint n, double x)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += GetPower(x, i)/GetFactorial(i);
            }
            return sum;
        }
        private void Submit()
        {
            try
            {
                Natural n = Natural.Parse(textBox_n.Text);
                double x = double.Parse(textBox_x.Text);
                textBox_result.Text = GetSeriesSum(n, x).ToString("N2", CultureInfo.GetCultureInfo("ru-RU"));
                ToggleOut(true);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void ToggleOut(bool isOn)
        {
            groupBox_out.Visible = isOn;
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ToggleOut(false);
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void textBox_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Submit();
        }

        private void textBox_n_TextChanged(object sender, EventArgs e)
        {
            ToggleOut(false);
            Control ctrl = textBox_n;
            errorProvider_n.Clear();

            try
            {
                Natural.Parse(ctrl.Text);
                ctrl.BackColor = Color.LightGreen;
            }
            catch(Exception exc)
            {
                ctrl.BackColor = Color.LightPink;
            }
        }

        private void textBox_n_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = textBox_n;
            ctrl.BackColor = Color.White;

            try
            {
                Natural.Parse(ctrl.Text);
                errorProvider_n.Clear();
            }
            catch (Exception exc)
            {
                errorProvider_n.SetError(ctrl, exc.Message);
            }
        }

        private void textBox_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Submit();
        }
        private void textBox_x_TextChanged(object sender, EventArgs e)
        {
            ToggleOut(false);
            Control ctrl = textBox_x;
            errorProvider_x.Clear();

            try
            {
                double.Parse(ctrl.Text);
                ctrl.BackColor = Color.LightGreen;
            }
            catch (Exception exc)
            {
                ctrl.BackColor = Color.LightPink;
            }
        }
        private void textBox_x_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = textBox_x;
            ctrl.BackColor = Color.White;

            try
            {
                double.Parse(ctrl.Text);
                errorProvider_x.Clear();
            }
            catch (Exception exc)
            {
                errorProvider_x.SetError(ctrl, exc.Message);
            }
        }

    }
}
