/* Вычислить значение функции y,
 * где a и x вводятся с клавиатуры.
 * Для вычисления (x2+x+c) написать подпрограмму.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_06
{
    public partial class Form_Main : Form
    {
        private double[] SolveQuadratic(double a = 0, double b = 0, double c = 0)
        {
            double[] roots = Array.Empty<double>();
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                Array.Resize(ref roots, 2);
                for (int i = 0; i < 2; i++)
                {
                    roots[i] = (-b + Math.Sqrt(D) * (i == 0 ? 1 : -1))/(2 * a);
                }
            }
            else if (D == 0)
            {
                Array.Resize(ref roots, 1);
                roots[0] = -b / (2 * a);
            }
            return roots;
        }
        private double SolveTrinomial(double x, double c)
        {
            return x*x + x + c;
        }
        private double GetY(double a, double x)
        {
            return (SolveTrinomial(x, 2) + a * SolveTrinomial(x, 1)) / (x*x + x);
        }
        private void Submit()
        {
            if (!ValidateDouble(textBox_a.Text))
            {
                MessageBox.Show("Must be a valid real number");
                textBox_a.Select(0, textBox_a.Text.Length);
                textBox_a.Focus();
                return;
            }
            if (!ValidateDouble(textBox_x.Text))
            {
                MessageBox.Show("Must be a valid real number");
                textBox_x.Select(0, textBox_x.Text.Length);
                textBox_x.Focus();
                return;
            }
            double a = double.Parse(textBox_a.Text);
            double x = double.Parse(textBox_x.Text);
            if (!ValidateX(x))
            {
                MessageBox.Show("Must not be 0 or -1");
                textBox_x.Select(0, textBox_x.Text.Length);
                textBox_x.Focus();
                return;
            }

            textBox_y.Text = GetY(a, x).ToString("N2", CultureInfo.GetCultureInfo("ru-RU"));
            ToggleOut(true);
        }
        private void ToggleOut(bool isOn)
        {
            groupBox_out.Visible = isOn;
        }
        private bool ValidateDouble(string input)
        {
            if (!double.TryParse(input, out double parsed))
            {
                return false;
            }
            return true;
        }
        private bool ValidateX(double x)
        {
            return x != 0 && x != -1;
        }
        public Form_Main()
        {
            InitializeComponent();

            // Solving x^2 + x equation
            // double[] roots = SolveQuadratic(1, 1);
            // MessageBox.Show(roots.Length.ToString() + ": " + roots[0].ToString() + " " + roots[1].ToString());
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            ToggleOut(false);
        }
        private void textBox_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Submit();
        }

        private void textBox_a_TextChanged(object sender, EventArgs e)
        {
            ToggleOut(false);
            Control ctrl = textBox_a;
            errorProvider_a.Clear();
            if (ValidateDouble(ctrl.Text))
            {
                ctrl.BackColor = Color.LightGreen;
            }
            else
            {
                ctrl.BackColor = Color.LightPink;
            }
        }

        private void textBox_a_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = textBox_a;
            ctrl.BackColor = Color.White;
            if (ValidateDouble(ctrl.Text))
            {
                errorProvider_a.Clear();
            }
            else
            {
                errorProvider_a.SetError(ctrl, "Must be a valid real number");
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            Submit();
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
            if (ValidateDouble(ctrl.Text) && ValidateX(double.Parse(ctrl.Text)))
            {
                ctrl.BackColor = Color.LightGreen;
            }
            else
            {
                ctrl.BackColor = Color.LightPink;
            }
        }
        private void textBox_x_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = textBox_x;
            ctrl.BackColor = Color.White;
            if (!ValidateDouble(ctrl.Text))
            {
                errorProvider_x.SetError(ctrl, "Must be a valid real number");
            }
            else if (!ValidateX(double.Parse(ctrl.Text)))
            {
                errorProvider_x.SetError(ctrl, "Must not be 0 or -1");
            }
            else
            {
                errorProvider_x.Clear();
            }
        }

    }
}
