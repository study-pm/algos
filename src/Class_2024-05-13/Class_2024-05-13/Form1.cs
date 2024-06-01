using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_2024_05_13
{
    
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        Random random = new Random();

        private void Timer_Tick(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            pictureBox1.CreateGraphics().FillEllipse(pen.Brush, 0, 0, 150, 200);
            
        }

    }
}
