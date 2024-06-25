namespace WF_06
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
            this.label_a = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label_x = new System.Windows.Forms.Label();
            this.errorProvider_a = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_x = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_submit = new System.Windows.Forms.Button();
            this.groupBox_out = new System.Windows.Forms.GroupBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.label_y = new System.Windows.Forms.Label();
            this.groupBox_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_x)).BeginInit();
            this.groupBox_out.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_in
            // 
            this.groupBox_in.Controls.Add(this.button_submit);
            this.groupBox_in.Controls.Add(this.textBox_x);
            this.groupBox_in.Controls.Add(this.label_x);
            this.groupBox_in.Controls.Add(this.textBox_a);
            this.groupBox_in.Controls.Add(this.label_a);
            this.groupBox_in.Location = new System.Drawing.Point(13, 13);
            this.groupBox_in.Name = "groupBox_in";
            this.groupBox_in.Size = new System.Drawing.Size(200, 112);
            this.groupBox_in.TabIndex = 0;
            this.groupBox_in.TabStop = false;
            this.groupBox_in.Text = "Input";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(7, 20);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(79, 13);
            this.label_a.TabIndex = 0;
            this.label_a.Text = "Enter number a";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(124, 17);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(48, 20);
            this.textBox_a.TabIndex = 1;
            this.textBox_a.TextChanged += new System.EventHandler(this.textBox_a_TextChanged);
            this.textBox_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_a_KeyPress);
            this.textBox_a.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_a_Validating);
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(124, 40);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(48, 20);
            this.textBox_x.TabIndex = 3;
            this.textBox_x.TextChanged += new System.EventHandler(this.textBox_x_TextChanged);
            this.textBox_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_x_KeyPress);
            this.textBox_x.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_x_Validating);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(6, 43);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(101, 26);
            this.label_x.TabIndex = 2;
            this.label_x.Text = "Enter number x\r\n(must not be 0 or -1)";
            // 
            // errorProvider_a
            // 
            this.errorProvider_a.ContainerControl = this;
            // 
            // errorProvider_x
            // 
            this.errorProvider_x.ContainerControl = this;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(9, 83);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(185, 23);
            this.button_submit.TabIndex = 4;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // groupBox_out
            // 
            this.groupBox_out.Controls.Add(this.textBox_y);
            this.groupBox_out.Controls.Add(this.label_y);
            this.groupBox_out.Location = new System.Drawing.Point(220, 13);
            this.groupBox_out.Name = "groupBox_out";
            this.groupBox_out.Size = new System.Drawing.Size(200, 112);
            this.groupBox_out.TabIndex = 1;
            this.groupBox_out.TabStop = false;
            this.groupBox_out.Text = "Output";
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(36, 14);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.ReadOnly = true;
            this.textBox_y.Size = new System.Drawing.Size(158, 20);
            this.textBox_y.TabIndex = 6;
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(6, 17);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(24, 13);
            this.label_y.TabIndex = 5;
            this.label_y.Text = "y = ";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_out);
            this.Controls.Add(this.groupBox_in);
            this.Name = "Form_Main";
            this.Text = "06";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox_in.ResumeLayout(false);
            this.groupBox_in.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_x)).EndInit();
            this.groupBox_out.ResumeLayout(false);
            this.groupBox_out.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_in;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.ErrorProvider errorProvider_a;
        private System.Windows.Forms.ErrorProvider errorProvider_x;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.GroupBox groupBox_out;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label label_y;
    }
}

