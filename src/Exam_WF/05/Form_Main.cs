/* Вычислить значение функции y = (5^n - 4 * 6^m)/(3 * 2^(-n)),
 * n, m - целые числа, вводятся с клавиатуры.
 * Для вычисления степени числа использовать рекурсивную функцию.
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

namespace WF_05
{
    public partial class Form_Main : Form
    {
        string errMsg = "Must be a valid integer";
        private double GetDegree(double a, double k)
        {
            if (k == 0) return 1;
            else if (k > 0) return a * GetDegree(a, --k);
            else return GetDegree(1/a, -k);
        }
        public Form_Main()
        {
            InitializeComponent();
        }
        private double Process(int m, int n)
        {
            return (GetDegree(5, n) - 4 * GetDegree(6, m))/(3 * GetDegree(2, -n));
        }
        private void Submit()
        {
            if (Validate(textBox_m.Text, textBox_m, errorProvider_m) && Validate(textBox_n.Text, textBox_n, errorProvider_n))
            {
                int m = int.Parse(textBox_m.Text);
                int n = int.Parse(textBox_n.Text);
                double y = Process(m, n);
                textBox_y.Text = y.ToString("N2");
                ToggleOutput(true);
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }
        private void ToggleOutput(bool isOn)
        {
            groupBox_out.Visible = isOn;
        }
        private bool Validate(string s, Control ctrl, ErrorProvider errProv)
        {
            int n;
            if (int.TryParse(s, out n))
            {
                errProv.Clear();
                ctrl.BackColor = Color.LightGreen;
                return true;
            }
            else
            {
                errProv.SetError(ctrl, errMsg);
                ctrl.BackColor = Color.LightPink;
                return false;
            }
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ToggleOutput(false);
        }

        private void textBox_m_TextChanged(object sender, EventArgs e)
        {
            ToggleOutput(false);
            Validate(textBox_m.Text, textBox_m, errorProvider_m);
        }

        private void textBox_m_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Submit();
            }
        }

        private void textBox_n_TextChanged(object sender, EventArgs e)
        {
            ToggleOutput(false);
            Validate(textBox_n.Text, textBox_n, errorProvider_n);
        }

        private void textBox_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Submit();
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            Submit();
        }
    }
}
