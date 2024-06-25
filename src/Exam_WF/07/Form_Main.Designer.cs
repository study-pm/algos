namespace WF_07
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
            this.groupBox_in = new System.Windows.Forms.GroupBox();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label_x = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label_n = new System.Windows.Forms.Label();
            this.groupBox_out = new System.Windows.Forms.GroupBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.errorProvider_n = new System.Windows.Forms.ErrorProvider();
            this.errorProvider_x = new System.Windows.Forms.ErrorProvider();
            this.groupBox_in.SuspendLayout();
            this.groupBox_out.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_x)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_in
            // 
            this.groupBox_in.Controls.Add(this.button_submit);
            this.groupBox_in.Controls.Add(this.textBox_x);
            this.groupBox_in.Controls.Add(this.label_x);
            this.groupBox_in.Controls.Add(this.textBox_n);
            this.groupBox_in.Controls.Add(this.label_n);
            this.groupBox_in.Location = new System.Drawing.Point(13, 13);
            this.groupBox_in.Name = "groupBox_in";
            this.groupBox_in.Size = new System.Drawing.Size(200, 100);
            this.groupBox_in.TabIndex = 0;
            this.groupBox_in.TabStop = false;
            this.groupBox_in.Text = "Input";
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(119, 40);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(55, 20);
            this.textBox_x.TabIndex = 4;
            this.textBox_x.TextChanged += new System.EventHandler(this.textBox_x_TextChanged);
            this.textBox_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_x_KeyPress);
            this.textBox_x.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_x_Validating);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(7, 43);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(99, 13);
            this.label_x.TabIndex = 3;
            this.label_x.Text = "Enter a real number";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(119, 17);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(55, 20);
            this.textBox_n.TabIndex = 1;
            this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
            this.textBox_n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_n_KeyPress);
            this.textBox_n.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_n_Validating);
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(7, 20);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(114, 13);
            this.label_n.TabIndex = 0;
            this.label_n.Text = "Enter a natural number";
            // 
            // groupBox_out
            // 
            this.groupBox_out.Controls.Add(this.textBox_result);
            this.groupBox_out.Controls.Add(this.label_result);
            this.groupBox_out.Location = new System.Drawing.Point(220, 13);
            this.groupBox_out.Name = "groupBox_out";
            this.groupBox_out.Size = new System.Drawing.Size(200, 100);
            this.groupBox_out.TabIndex = 1;
            this.groupBox_out.TabStop = false;
            this.groupBox_out.Text = "Output";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(49, 17);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(143, 20);
            this.textBox_result.TabIndex = 4;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(6, 20);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(37, 13);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "Result";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(10, 71);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(184, 23);
            this.button_submit.TabIndex = 5;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // errorProvider_n
            // 
            this.errorProvider_n.ContainerControl = this;
            // 
            // errorProvider_x
            // 
            this.errorProvider_x.ContainerControl = this;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_out);
            this.Controls.Add(this.groupBox_in);
            this.Name = "Form_Main";
            this.Text = "07";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox_in.ResumeLayout(false);
            this.groupBox_in.PerformLayout();
            this.groupBox_out.ResumeLayout(false);
            this.groupBox_out.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_x)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_in;
        private System.Windows.Forms.GroupBox groupBox_out;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.ErrorProvider errorProvider_n;
        private System.Windows.Forms.ErrorProvider errorProvider_x;
    }
}

