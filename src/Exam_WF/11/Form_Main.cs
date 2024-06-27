/* В массиве целых чисел размерности n (n вводится пользователем) заменить все чётные числа,
 * значения которых меньше среднего арифметического элементов массива на максимальный элемент массива.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_11
{
    public partial class Form_Main : Form
    {
        int[] range = new int[2];
        Random random = new Random();
        readonly int maxN = 500;
        int[] A;
        int[] B;
        private int[] GenerateArray(int n, int[] range)
        {
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = random.Next(range[0], range[1]);
            }
            return res;
        }
        private int GetArrayMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }
        private double GetArrayMean(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }
        private int[] GetArrayReplaced(int[] src)
        {
            int[] res = new int[src.Length];
            int max = GetArrayMax(src);
            double mean = GetArrayMean(src);
            for (int i = 0; i < src.Length; i++)
            {
                if (src[i] % 2 == 0 && src[i] < mean) res[i] = max;
                else res[i] = src[i];
            }
            return res;
        }
        private int[] GetArrayDiff(int[] a, int[] b)
        {
            int[] diff = Array.Empty<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    Array.Resize(ref diff, diff.Length+1);
                    diff[diff.GetUpperBound(0)] = i;
                }
            }
            return diff;
        }
        public Form_Main()
        {
            InitializeComponent();
        }
        private uint Parse(string s)
        {
            uint n = uint.Parse(s);
            if (n > maxN) throw new OverflowException($"The value must be reasonable, not greater than {maxN}.");
            return n;
        }
        private void Submit()
        {
            string errPath = "error.log";
            try
            {
                uint n = Parse(textBox_n.Text);
                A = GenerateArray((int)n, range);
                textBox_A.Text = string.Join(" ", A);
                dataGridView_A.ColumnCount = A.Length;
                dataGridView_A.RowCount = A.Length == 0 ? 0 : 1;

                for (int i = 0; i < n; i++)
                {
                    dataGridView_A.Columns[i].HeaderCell.Value = i.ToString();
                    dataGridView_A.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView_A[i, 0].Value = A[i];
                }
                B = A.Length == 0 ? new int[0] : GetArrayReplaced(A);
                textBox_B.Text = string.Join(" ", B);

                int[] diff = GetArrayDiff(A, B);

                dataGridView_B.ColumnCount = B.Length;
                dataGridView_B.RowCount = B.Length == 0 ? 0 : 1;
                for (int i = 0; i < n; i++)
                {
                    dataGridView_B.Columns[i].HeaderCell.Value = i.ToString();
                    dataGridView_B.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView_B[i, 0].Value = B[i];
                    dataGridView_B[i, 0].Style.BackColor = Color.White;
                    if (diff.Contains(i)) dataGridView_B[i, 0].Style.BackColor = Color.LightCyan;
                }
                ToggleOut(true);
                if (File.Exists(errPath)) File.Delete(errPath);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message + "\n" + "See the \"error.log\" file for details.");
                using (StreamWriter sr = new StreamWriter(errPath, false))
                {
                    sr.WriteLine("Timestamp: " + DateTime.Now.ToString(CultureInfo.GetCultureInfo("ru-RU")));
                    sr.WriteLine("Exception type: " + exc.GetType().Name);
                    sr.WriteLine("Message: " + exc.Message);
                    sr.WriteLine("Stack trac: " + exc.Message);
                }
            }
        }
        private void ToggleOut(bool isOn)
        {
            groupBox_out.Visible = isOn;
            groupBox_output.Visible = isOn;
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            (range[0], range[1]) = (-128, 128);
            dataGridView_A.AllowUserToAddRows = false;
            dataGridView_B.AllowUserToAddRows = false;
            ToggleOut(false);
        }

        private void textBox_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Submit();
        }

        private void textBox_n_TextChanged(object sender, EventArgs e)
        {
            ToggleOut(false);
            Control ctrl = sender as Control;
            errorProvider_n.Clear();
            try
            {
                Parse(ctrl.Text);
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
                Parse(ctrl.Text);
                errorProvider_n.Clear();
            }
            catch (Exception exc)
            {
                errorProvider_n.SetError(ctrl, exc.Message);
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the results files
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text file|*.txt";
            saveFileDialog1.Title = "Save an Text File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine("Original array: " + string.Join(" ", A));
                sw.WriteLine("Altered array: " + string.Join(" ", B));
                sw.Close();
            }
        }
    }
}
