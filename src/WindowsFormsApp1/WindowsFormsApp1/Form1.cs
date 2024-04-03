using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            // ButtonMain.Text = TextBoxMain.Text;
            TextBoxMain.Text = "Button clicked";
            ButtonMain.BackgroundImage = Resources.traffic;
            PictureBoxMain.Image = Resources.images;
        }

        private void TextBoxMain_TextChanged(object sender, EventArgs e)
        {
            ButtonMain.Text = TextBoxMain.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                TextBoxMain.Text = "First option";
            }
            else if (radioButton2.Checked)
            {
                TextBoxMain.Text = "Second option";
            }
        }
    }
}
