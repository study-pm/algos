using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_01
{
    public partial class Form_Main : Form
    {
        Point A = new Point();
        Point B = new Point();
        Point O = new Point();
        public Form_Main()
        {
            InitializeComponent();
        }

        private void textBox_A_x_Click(object sender, EventArgs e)
        {
            A.X = ParseInput(textBox_A_x.Text);
        }
        private float ParseInput(string input)
        {
            float x = 0;
            bool isSuccess = float.TryParse(input, out x);
            if (!isSuccess)
            {
                // MessageBox.Show("Invalid input");
            }
            return x;
        }
        private void textBox_A_x_TextChanged(object sender, EventArgs e)
        {
            A.X = ParseInput(textBox_A_x.Text);
        }
        private void textBox_A_y_TextChanged(object sender, EventArgs e)
        {
            A.Y = ParseInput(textBox_A_y.Text);
        }
        private void textBox_B_x_TextChanged(object sender, EventArgs e)
        {
            B.X = ParseInput(textBox_B_x.Text);
        }

        private void textBox_B_y_TextChanged(object sender, EventArgs e)
        {
            B.Y = ParseInput(textBox_B_y.Text);
        }
        private void button_Calculate_Click(object sender, EventArgs e)
        {
            double AB = Point.GetDistance(A, B);
            double AO = Point.GetDistance(A, O);
            double BO = Point.GetDistance(B, O);
            textBox_distance.Text = string.Format("{0:N2}", AB);
            string text = "Точки равноудалены от начала координат";
            if (AO > BO) text = "Точка B ближе к началу координат";
            else if (AO < BO) text = "Точка A ближе к началу координат";
            label_summary.Text = text;
        }

    }
}

// https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/
/* Sample data
 * Input: A(-1, 3) и B(6,2);
 * Output: AB = 5√2 = 7.07; Closest is A.
 *
 * Input: A(2, -2) и B(0, 1)
 * Output: AB = √13 = 3.61; Closest is B.
 *
 * Input: A(-1, 3, 3) и B(6, 2, -2)
 * Output: AB = 5√3 = 8.66; Closest is A.
 *
 * Input: B(3, 1, 3) и B(0, -3, 3)
 * Output: AB = 5; Closest is B.
 *
 * Input: A(3, 0, -4) и B(0, 0, 5)
 * Output: AB = 9,49; Equally remote.
 */