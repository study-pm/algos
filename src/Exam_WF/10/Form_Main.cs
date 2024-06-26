/* Вычислить значение функции у=2!+4!+ …+  n!,
 * где n – чётное число, вводится с клавиатуры.
 * Для вычисления факториала числа использовать рекурсивную функцию.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_10
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private uint GetFactorial(uint n)
        {
            if (n == 0) return 1;
            return n * GetFactorial(--n);
        }
        private uint GetY(EvenNumber n)
        {
            uint y = 0;
            for (EvenNumber i = 2; i < n + 1; i++)
            {
                y += GetFactorial(i);
            }
            return y;
        }
        private void Submit()
        {
            try
            {
                uint y = GetY(EvenNumber.Parse(textBox_n.Text));
                textBox_out.Text = y.ToString();
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

        private void textBox_n_TextChanged(object sender, EventArgs e)
        {
            ToggleOut(false);
            Control ctrl = sender as Control;
            errorProvider_n.Clear();
            try
            {
                EvenNumber.Parse(ctrl.Text);
                ctrl.BackColor = Color.LightGreen;
            }
            catch
            {
                ctrl.BackColor = Color.LightPink;
            }
        }

        private void textBox_n_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = sender as Control;
            ctrl.BackColor = Color.White;
            try
            {
                EvenNumber.Parse(ctrl.Text);
                errorProvider_n.Clear();
            }
            catch (Exception exc)
            {
                errorProvider_n.SetError(ctrl, exc.Message);
            }
        }

        private void textBox_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Submit();
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            ToggleOut(false);
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            Submit();
        }
    }
}
