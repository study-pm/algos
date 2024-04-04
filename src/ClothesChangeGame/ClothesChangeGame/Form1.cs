using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothesChangeGame.Properties;

namespace ClothesChangeGame
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_Clouds_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Clouds.Checked == true)
            {
                pictureBox_Clouds.Image = Resources.clouds;
            }
            else
            {
                pictureBox_Clouds.Image = null;
            }

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            label_CharacterName.Text = textBox_Name.Text;
        }

        private void textBox_Motto_TextChanged(object sender, EventArgs e)
        {
            label_Motto.Text = textBox_Motto.Text;
        }

        private void checkBox_Name_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Name.Enabled = checkBox_Name.Checked;
        }

        private void checkBox_Table_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Table.Checked)
            {
                pictureBox_Clouds.Image = Resources.table;
            }

        }
    }
}
