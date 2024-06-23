namespace _01
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_A = new System.Windows.Forms.Label();
            this.textBox_A_x = new System.Windows.Forms.TextBox();
            this.textBox_A_y = new System.Windows.Forms.TextBox();
            this.textBox_B_y = new System.Windows.Forms.TextBox();
            this.textBox_B_x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_summary = new System.Windows.Forms.Label();
            this.textBox_distance = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(6, 27);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(110, 13);
            this.label_A.TabIndex = 0;
            this.label_A.Text = "Координаты точки А";
            // 
            // textBox_A_x
            // 
            this.textBox_A_x.Location = new System.Drawing.Point(122, 24);
            this.textBox_A_x.Name = "textBox_A_x";
            this.textBox_A_x.Size = new System.Drawing.Size(34, 20);
            this.textBox_A_x.TabIndex = 1;
            this.textBox_A_x.Text = "0";
            this.textBox_A_x.TextChanged += new System.EventHandler(this.textBox_A_x_TextChanged);
            // 
            // textBox_A_y
            // 
            this.textBox_A_y.Location = new System.Drawing.Point(162, 24);
            this.textBox_A_y.Name = "textBox_A_y";
            this.textBox_A_y.Size = new System.Drawing.Size(34, 20);
            this.textBox_A_y.TabIndex = 2;
            this.textBox_A_y.Text = "0";
            this.textBox_A_y.TextChanged += new System.EventHandler(this.textBox_A_y_TextChanged);
            // 
            // textBox_B_y
            // 
            this.textBox_B_y.Location = new System.Drawing.Point(162, 68);
            this.textBox_B_y.Name = "textBox_B_y";
            this.textBox_B_y.Size = new System.Drawing.Size(34, 20);
            this.textBox_B_y.TabIndex = 5;
            this.textBox_B_y.Text = "0";
            this.textBox_B_y.TextChanged += new System.EventHandler(this.textBox_B_y_TextChanged);
            // 
            // textBox_B_x
            // 
            this.textBox_B_x.Location = new System.Drawing.Point(122, 68);
            this.textBox_B_x.Name = "textBox_B_x";
            this.textBox_B_x.Size = new System.Drawing.Size(34, 20);
            this.textBox_B_x.TabIndex = 4;
            this.textBox_B_x.Text = "0";
            this.textBox_B_x.TextChanged += new System.EventHandler(this.textBox_B_x_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Координаты точки B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Расстояние между точками:";
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(9, 111);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(197, 23);
            this.button_Calculate.TabIndex = 7;
            this.button_Calculate.Text = "Вычислить расстояние";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_A);
            this.groupBox1.Controls.Add(this.button_Calculate);
            this.groupBox1.Controls.Add(this.textBox_A_x);
            this.groupBox1.Controls.Add(this.textBox_A_y);
            this.groupBox1.Controls.Add(this.textBox_B_y);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_B_x);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 156);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_summary);
            this.groupBox2.Controls.Add(this.textBox_distance);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(256, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 156);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // label_summary
            // 
            this.label_summary.AutoSize = true;
            this.label_summary.Location = new System.Drawing.Point(9, 70);
            this.label_summary.Name = "label_summary";
            this.label_summary.Size = new System.Drawing.Size(221, 13);
            this.label_summary.TabIndex = 8;
            this.label_summary.Text = "Точки равноудалены от начала координат";
            // 
            // textBox_distance
            // 
            this.textBox_distance.Location = new System.Drawing.Point(163, 24);
            this.textBox_distance.Name = "textBox_distance";
            this.textBox_distance.ReadOnly = true;
            this.textBox_distance.Size = new System.Drawing.Size(63, 20);
            this.textBox_distance.TabIndex = 7;
            this.textBox_distance.Text = "0.00";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Main";
            this.Text = "01";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.TextBox textBox_A_x;
        private System.Windows.Forms.TextBox textBox_A_y;
        private System.Windows.Forms.TextBox textBox_B_y;
        private System.Windows.Forms.TextBox textBox_B_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_summary;
        private System.Windows.Forms.TextBox textBox_distance;
    }
}

