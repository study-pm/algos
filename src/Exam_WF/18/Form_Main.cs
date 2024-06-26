/* Ввести по строкам с клавиатуры двумерный массив (4×3) и вычислить сумму его элементов по строкам. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_18
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
                for (int i = 0; i < dataGridView_in.Rows.Count; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < dataGridView_in.Columns.Count; j++)
                    {
                        double val = double.Parse(dataGridView_in[j, i].Value.ToString());
                        sum += val;
                    }
                    dataGridView_out[0, i].Value = sum.ToString();
                }
                ToggleOut(true);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Invalid input: all cells must be provided with values");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Invalid input: " + exc.Message);
            }
        }
        private void ToggleOut(bool isOn)
        {
            dataGridView_out.Visible = isOn;
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ToggleOut(false);

            dataGridView_in.ColumnCount = 4;
            dataGridView_in.RowCount = 4;
            dataGridView_in.AllowUserToAddRows = false;
            for (int i = 0; i < dataGridView_in.RowCount; i++)
            {
                dataGridView_in.Rows[i].HeaderCell.Value = i.ToString();
            }
            for (int i = 0; i < dataGridView_in.ColumnCount; i++)
            {
                dataGridView_in.Columns[i].HeaderCell.Value = i.ToString();
                dataGridView_in.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView_out.ColumnCount = 1;
            dataGridView_out.RowCount = 3;
            dataGridView_out.AllowUserToAddRows = false;
            dataGridView_out.Columns[0].HeaderCell.Value = "Item sum";
            dataGridView_out.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            for (int i = 0; i < dataGridView_out.RowCount; i++)
            {
                dataGridView_out.Rows[i].HeaderCell.Value = i.ToString();
            }
        }

        private void dataGridView_in_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Control ctrl = sender as Control;
            try
            {
                double.Parse(dataGridView_in.CurrentCell.Value.ToString());
                dataGridView_in.CurrentCell.Style.BackColor = Color.LightCyan;
            }
            catch
            {
                dataGridView_in.CurrentCell.Style.BackColor = Color.LightPink;
            }

            // MessageBox.Show(dataGridView_in.CurrentCell.ColumnIndex + " " + dataGridView_in.CurrentCell.Value.ToString());
        }

        private void dataGridView_in_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView_in_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView_in_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            Submit();
        }
    }
}
