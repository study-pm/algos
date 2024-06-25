namespace WF_05
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_in = new System.Windows.Forms.GroupBox();
            this.label_m = new System.Windows.Forms.Label();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_out = new System.Windows.Forms.GroupBox();
            this.errorProvider_m = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_n = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.label_y = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.groupBox_in.SuspendLayout();
            this.groupBox_out.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_n)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_in
            // 
            this.groupBox_in.Controls.Add(this.button_submit);
            this.groupBox_in.Controls.Add(this.textBox_n);
            this.groupBox_in.Controls.Add(this.label1);
            this.groupBox_in.Controls.Add(this.textBox_m);
            this.groupBox_in.Controls.Add(this.label_m);
            this.groupBox_in.Location = new System.Drawing.Point(13, 13);
            this.groupBox_in.Name = "groupBox_in";
            this.groupBox_in.Size = new System.Drawing.Size(200, 100);
            this.groupBox_in.TabIndex = 0;
            this.groupBox_in.TabStop = false;
            this.groupBox_in.Text = "Input";
            // 
            // label_m
            // 
            this.label_m.AutoSize = true;
            this.label_m.Location = new System.Drawing.Point(7, 20);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(78, 13);
            this.label_m.TabIndex = 0;
            this.label_m.Text = "Enter integer m";
            // 
            // textBox_m
            // 
            this.textBox_m.Location = new System.Drawing.Point(91, 17);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(77, 20);
            this.textBox_m.TabIndex = 1;
            this.textBox_m.TextChanged += new System.EventHandler(this.textBox_m_TextChanged);
            this.textBox_m.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_m_KeyPress);
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(91, 43);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(77, 20);
            this.textBox_n.TabIndex = 3;
            this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
            this.textBox_n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_n_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter integer n";
            // 
            // groupBox_out
            // 
            this.groupBox_out.Controls.Add(this.textBox_y);
            this.groupBox_out.Controls.Add(this.label_y);
            this.groupBox_out.Location = new System.Drawing.Point(228, 13);
            this.groupBox_out.Name = "groupBox_out";
            this.groupBox_out.Size = new System.Drawing.Size(200, 100);
            this.groupBox_out.TabIndex = 1;
            this.groupBox_out.TabStop = false;
            this.groupBox_out.Text = "Output";
            // 
            // errorProvider_m
            // 
            this.errorProvider_m.ContainerControl = this;
            // 
            // errorProvider_n
            // 
            this.errorProvider_n.ContainerControl = this;
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(36, 17);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.ReadOnly = true;
            this.textBox_y.Size = new System.Drawing.Size(158, 20);
            this.textBox_y.TabIndex = 5;
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(6, 20);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(24, 13);
            this.label_y.TabIndex = 4;
            this.label_y.Text = "y = ";
            this.label_y.UseMnemonic = false;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(10, 71);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(184, 23);
            this.button_submit.TabIndex = 4;
            this.button_submit.Text = "Process";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_out);
            this.Controls.Add(this.groupBox_in);
            this.Name = "Form_Main";
            this.Text = "05";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox_in.ResumeLayout(false);
            this.groupBox_in.PerformLayout();
            this.groupBox_out.ResumeLayout(false);
            this.groupBox_out.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_n)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_in;
        private System.Windows.Forms.Label label_m;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.GroupBox groupBox_out;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.ErrorProvider errorProvider_m;
        private System.Windows.Forms.ErrorProvider errorProvider_n;
        private System.Windows.Forms.Button button_submit;
    }
}

