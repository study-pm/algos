/* Ввести по строкам с клавиатуры двумерный массив (3×4) и вычислить сумму его элементов по столбцам. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_19
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private void Submit()
        {
            try
            {
                for (int j = 0; j < dataGridView_in.ColumnCount; j++)
                {
                    double sum = 0;
                    for (int i = 0; i < dataGridView_in.RowCount; i++)
                    {
                        sum += double.Parse(dataGridView_in[j, i].Value.ToString());
                    }
                    dataGridView_out[j, 0].Value = sum;
                }
                ToggleOut(true);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Invalid input: all cells must be provided with valid data");
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

            dataGridView_in.ColumnCount = 3;
            dataGridView_in.RowCount = 4;

            dataGridView_out.ColumnCount = 3;
            dataGridView_out.RowCount = 1;

            for (int i = 0; i < dataGridView_in.ColumnCount; i++)
            {
                dataGridView_in.Columns[i].HeaderText = dataGridView_out.Columns[i].HeaderText = i.ToString();
                dataGridView_in.Columns[i].SortMode = dataGridView_out.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dataGridView_in.RowCount; i++)
            {
                dataGridView_in.Rows[i].HeaderCell.Value = i.ToString();
            }

            dataGridView_in.AllowUserToAddRows = false;
            dataGridView_out.AllowUserToAddRows = false;
        }

        private void dataGridView_in_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ToggleOut(false);
            try
            {
                double.Parse(dataGridView_in.CurrentCell.Value.ToString());
                errorProvider_in.Clear();
                dataGridView_in.CurrentCell.Style.BackColor = Color.LightGreen;
            }
            catch(Exception exc)
            {
                errorProvider_in.SetError(dataGridView_in, exc.Message);
                dataGridView_in.CurrentCell.Style.BackColor = Color.LightPink;
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            Submit();
        }
    }
}
