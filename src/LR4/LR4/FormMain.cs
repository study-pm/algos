using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            groupBox_result.Visible = false;
        }

        private void button_generateArray_Click(object sender, EventArgs e)
        {
            Massiv mas = new Massiv();
            try
            {
                mas.Size = Convert.ToInt32(textBox_sizeInput.Text);
            }
            catch
            {
                MessageBox.Show("Некорректные данные");
                return;
            }
            if (mas.Size == 0)
            {
                MessageBox.Show("Недостаточно элеменов массива");
                return;
            }

            textBox_arrGenerated.Text = mas.CreateMas();
            groupBox_result.Visible = true;

            label_arrSum.Text = mas.SummMas();
            label_arrReverse.Text = mas.ReversMas();
            textBox_arrSwap.Text = mas.ChangeElem();
        }

        private void button_repeat_Click(object sender, EventArgs e)
        {
            groupBox_result.Visible = false;
            textBox_sizeInput.Text = textBox_arrGenerated.Text = "";
        }
    }
}
