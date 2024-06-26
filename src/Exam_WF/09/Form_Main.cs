/* Вывести таблицу степеней числа m^n, где n изменяется от -10 до 10,
 * m - целое число, вводится с клавиатуры.
 * Для вычисления степени числа использовать рекурсивную функцию.
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

namespace WF_09
{
    public partial class Form_Main : Form
    {
        private readonly int[] range = { -10, 10 };
        private int count = 0;
        public Form_Main()
        {
            InitializeComponent();
        }

        private double GetPower(double a, int k)
        {
            if (k == 0) return 1;
            if (k < 0) return GetPower(1/a, -k);
            return a * GetPower(a, --k);
        }
        private void Submit()
        {
            try
            {
                int m = int.Parse(textBox_m.Text);
                double[] power = new double[count];
                for (int i = 0, n = range[0]; n <= range[1]; i++, n++)
                {
                    power[i] = GetPower(m, n);
                    dataGridView_out[i, 0].Value = n;
                    dataGridView_out[i, 1].Value = power[i].ToString(power[i] == 0 ? "N0" : "#.#######", CultureInfo.GetCultureInfo("ru-RU"));
                }
                ToggleOut(true);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void ToggleOut(bool isOn)
        {
            dataGridView_out.Visible = isOn;
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ToggleOut(false);
            for (int i = range[0]; i <= range[1]; i++) count++;
            dataGridView_out.RowCount = 2;
            dataGridView_out.ColumnCount = count;
        }


        private void textBox_m_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Submit();
        }
        private void textBox_m_TextChanged(object sender, EventArgs e)
        {
            ToggleOut(false);
            Control ctrl = sender as Control;
            errorProvider_m.Clear();
            try
            {
                int.Parse(ctrl.Text);
                ctrl.BackColor = Color.LightGreen;
            }
            catch
            {
                ctrl.BackColor = Color.LightPink;
            }
        }
        private void textBox_m_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = sender as Control;
            ctrl.BackColor = Color.White;
            try
            {
                int.Parse(ctrl.Text);
                errorProvider_m.Clear();
            }
            catch (Exception exc)
            {
                errorProvider_m.SetError(ctrl, exc.Message);
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            Submit();
        }
    }
}
