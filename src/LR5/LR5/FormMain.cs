using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LR5
{
    public partial class FormMain : Form
    {
        private Matrix _matrix;
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_createMatrix_Click(object sender, EventArgs e)
        {
            _matrix = new Matrix(new int[] { 5, 5 });

            dataGridView1.Rows.Add("five", "six", "seven", "eight");
            for (int i = 0; i < 5; i++)
            {
                // Set values for columns with row[i] = xy
                dataGridView1.Rows.Add("23");
            }
        }
    }
}
