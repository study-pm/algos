namespace WF_08
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
            this.label_n = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.errorProvider_n = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_out = new System.Windows.Forms.GroupBox();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.label_B = new System.Windows.Forms.Label();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.label_C = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.groupBox_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_n)).BeginInit();
            this.groupBox_out.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_in
            // 
            this.groupBox_in.Controls.Add(this.button_submit);
            this.groupBox_in.Controls.Add(this.textBox_n);
            this.groupBox_in.Controls.Add(this.label_n);
            this.groupBox_in.Location = new System.Drawing.Point(13, 13);
            this.groupBox_in.Name = "groupBox_in";
            this.groupBox_in.Size = new System.Drawing.Size(200, 100);
            this.groupBox_in.TabIndex = 0;
            this.groupBox_in.TabStop = false;
            this.groupBox_in.Text = "Input";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(7, 20);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(90, 13);
            this.label_n.TabIndex = 0;
            this.label_n.Text = "Enter array length";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(103, 17);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(69, 20);
            this.textBox_n.TabIndex = 1;
            this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
            this.textBox_n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_n_KeyPress);
            this.textBox_n.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_n_Validating);
            // 
            // errorProvider_n
            // 
            this.errorProvider_n.ContainerControl = this;
            // 
            // groupBox_out
            // 
            this.groupBox_out.Controls.Add(this.textBox_C);
            this.groupBox_out.Controls.Add(this.label_C);
            this.groupBox_out.Controls.Add(this.textBox_B);
            this.groupBox_out.Controls.Add(this.label_B);
            this.groupBox_out.Controls.Add(this.textBox_A);
            this.groupBox_out.Controls.Add(this.label_A);
            this.groupBox_out.Location = new System.Drawing.Point(220, 13);
            this.groupBox_out.Name = "groupBox_out";
            this.groupBox_out.Size = new System.Drawing.Size(200, 100);
            this.groupBox_out.TabIndex = 1;
            this.groupBox_out.TabStop = false;
            this.groupBox_out.Text = "Output";
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(29, 17);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.ReadOnly = true;
            this.textBox_A.Size = new System.Drawing.Size(165, 20);
            this.textBox_A.TabIndex = 3;
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(6, 20);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(17, 13);
            this.label_A.TabIndex = 2;
            this.label_A.Text = "A:";
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(29, 41);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.ReadOnly = true;
            this.textBox_B.Size = new System.Drawing.Size(165, 20);
            this.textBox_B.TabIndex = 5;
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(6, 44);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(17, 13);
            this.label_B.TabIndex = 4;
            this.label_B.Text = "B:";
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(29, 66);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.ReadOnly = true;
            this.textBox_C.Size = new System.Drawing.Size(165, 20);
            this.textBox_C.TabIndex = 7;
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Location = new System.Drawing.Point(6, 69);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(17, 13);
            this.label_C.TabIndex = 6;
            this.label_C.Text = "C:";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(10, 62);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(184, 23);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Submit";
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
            this.Text = "08";
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
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.ErrorProvider errorProvider_n;
        private System.Windows.Forms.GroupBox groupBox_out;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Button button_submit;
    }
}

