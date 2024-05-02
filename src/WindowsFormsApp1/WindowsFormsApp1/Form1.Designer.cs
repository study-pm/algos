namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxMain = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.LabelMain = new System.Windows.Forms.Label();
            this.ButtonMain = new System.Windows.Forms.Button();
            this.PictureBoxMain = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxMain
            // 
            this.TextBoxMain.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextBoxMain.Location = new System.Drawing.Point(41, 75);
            this.TextBoxMain.Name = "TextBoxMain";
            this.TextBoxMain.Size = new System.Drawing.Size(200, 20);
            this.TextBoxMain.TabIndex = 1;
            this.TextBoxMain.TextChanged += new System.EventHandler(this.TextBoxMain_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(41, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GroupBoxMain";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Location = new System.Drawing.Point(41, 323);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(35, 13);
            this.LabelMain.TabIndex = 3;
            this.LabelMain.Text = "label1";
            // 
            // ButtonMain
            // 
            this.ButtonMain.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images;
            this.ButtonMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ButtonMain.Location = new System.Drawing.Point(41, 34);
            this.ButtonMain.Name = "ButtonMain";
            this.ButtonMain.Size = new System.Drawing.Size(200, 23);
            this.ButtonMain.TabIndex = 0;
            this.ButtonMain.Text = "Push";
            this.ButtonMain.UseVisualStyleBackColor = true;
            this.ButtonMain.Click += new System.EventHandler(this.MainForm_Click);
            // 
            // PictureBoxMain
            // 
            this.PictureBoxMain.Image = global::WindowsFormsApp1.Properties.Resources.traffic;
            this.PictureBoxMain.Location = new System.Drawing.Point(44, 362);
            this.PictureBoxMain.Name = "PictureBoxMain";
            this.PictureBoxMain.Size = new System.Drawing.Size(197, 50);
            this.PictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxMain.TabIndex = 4;
            this.PictureBoxMain.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 452);
            this.Controls.Add(this.PictureBoxMain);
            this.Controls.Add(this.LabelMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBoxMain);
            this.Controls.Add(this.ButtonMain);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMain;
        private System.Windows.Forms.TextBox TextBoxMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.PictureBox PictureBoxMain;
    }
}

