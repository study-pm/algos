namespace WF_10
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
            this.button_submit = new System.Windows.Forms.Button();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider_n = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_out = new System.Windows.Forms.GroupBox();
            this.textBox_out = new System.Windows.Forms.TextBox();
            this.label_out = new System.Windows.Forms.Label();
            this.groupBox_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_n)).BeginInit();
            this.groupBox_out.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_in
            // 
            this.groupBox_in.Controls.Add(this.button_submit);
            this.groupBox_in.Controls.Add(this.textBox_n);
            this.groupBox_in.Controls.Add(this.label1);
            this.groupBox_in.Location = new System.Drawing.Point(13, 13);
            this.groupBox_in.Name = "groupBox_in";
            this.groupBox_in.Size = new System.Drawing.Size(218, 100);
            this.groupBox_in.TabIndex = 0;
            this.groupBox_in.TabStop = false;
            this.groupBox_in.Text = "Input";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(7, 71);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(205, 23);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(160, 17);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(35, 20);
            this.textBox_n.TabIndex = 1;
            this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
            this.textBox_n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_n_KeyPress);
            this.textBox_n.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_n_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an even natural number";
            // 
            // errorProvider_n
            // 
            this.errorProvider_n.ContainerControl = this;
            // 
            // groupBox_out
            // 
            this.groupBox_out.Controls.Add(this.textBox_out);
            this.groupBox_out.Controls.Add(this.label_out);
            this.groupBox_out.Location = new System.Drawing.Point(238, 13);
            this.groupBox_out.Name = "groupBox_out";
            this.groupBox_out.Size = new System.Drawing.Size(200, 100);
            this.groupBox_out.TabIndex = 1;
            this.groupBox_out.TabStop = false;
            this.groupBox_out.Text = "Output";
            // 
            // textBox_out
            // 
            this.textBox_out.Location = new System.Drawing.Point(37, 16);
            this.textBox_out.Name = "textBox_out";
            this.textBox_out.ReadOnly = true;
            this.textBox_out.Size = new System.Drawing.Size(157, 20);
            this.textBox_out.TabIndex = 1;
            // 
            // label_out
            // 
            this.label_out.AutoSize = true;
            this.label_out.Location = new System.Drawing.Point(7, 19);
            this.label_out.Name = "label_out";
            this.label_out.Size = new System.Drawing.Size(24, 13);
            this.label_out.TabIndex = 0;
            this.label_out.Text = "y = ";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_out);
            this.Controls.Add(this.groupBox_in);
            this.Name = "Form_Main";
            this.Text = "10";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox_in.ResumeLayout(false);
            this.groupBox_in.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_n)).EndInit();
            this.groupBox_out.ResumeLayout(false);
            this.groupBox_out.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_in;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider_n;
        private System.Windows.Forms.GroupBox groupBox_out;
        private System.Windows.Forms.TextBox textBox_out;
        private System.Windows.Forms.Label label_out;
    }
}

