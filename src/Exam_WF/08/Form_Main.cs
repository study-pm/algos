/* Дан массив А размерности n.
 * Сформировать два новых массива B и C:
 * в массив B записать все положительные элементы массива А,
 * в массив С – все отрицательные.
 * Вывести массивы на экран.
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

namespace WF_08
{
    public partial class Form_Main : Form
    {
        int[] range = { -100, 100 };
        public Form_Main()
        {
            InitializeComponent();
        }
        private int[] GenerateArray(int n)
        {
            Random rnd = new Random();

            int[] result = new int[n];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = rnd.Next(range[0], range[1]);
            }
            return result;
        }
        private int[] ExtractBySign(int[] arr, int sign)
        {
            int[] res = Array.Empty<int>();
            foreach(int item in arr)
            {
                if ((sign == 1 && item > 0) || (sign == -1 && item < 0) || (sign == 0 && item ==0))
                {
                    Array.Resize(ref res, res.Length+1);
                    res[res.Length-1] = item;
                }
            }
            return res;
        }

        private void Submit()
        {
            try
            {
                Natural n = Natural.Parse(textBox_n.Text);
                int[] A = GenerateArray(n);
                textBox_A.Text = String.Join(" ", A);
                int[] B = ExtractBySign(A, 1);
                textBox_B.Text = String.Join(" ", B);
                int[] C = ExtractBySign(A, -1);
                textBox_C.Text = String.Join(" ", C);
                ToggleOut(true);
            }
            catch (Exception exc)
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

        private void textBox_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Submit();
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
            catch(Exception exc)
            {
                errorProvider_n.SetError(ctrl, exc.Message);
            }
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
            catch
            {
                ctrl.BackColor = Color.LightPink;
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            Submit();
        }
    }
}
