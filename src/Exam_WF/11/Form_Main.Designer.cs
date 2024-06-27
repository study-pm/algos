namespace WF_11
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
            this.groupBox_out = new System.Windows.Forms.GroupBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.label_B = new System.Windows.Forms.Label();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.groupBox_in = new System.Windows.Forms.GroupBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label_n = new System.Windows.Forms.Label();
            this.errorProvider_n = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_save = new System.Windows.Forms.Button();
            this.dataGridView_A = new System.Windows.Forms.DataGridView();
            this.dataGridView_B = new System.Windows.Forms.DataGridView();
            this.groupBox_output = new System.Windows.Forms.GroupBox();
            this.groupBox_out.SuspendLayout();
            this.groupBox_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_B)).BeginInit();
            this.groupBox_output.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_out
            // 
            this.groupBox_out.Controls.Add(this.button_save);
            this.groupBox_out.Controls.Add(this.textBox_B);
            this.groupBox_out.Controls.Add(this.label_B);
            this.groupBox_out.Controls.Add(this.textBox_A);
            this.groupBox_out.Controls.Add(this.label_A);
            this.groupBox_out.Location = new System.Drawing.Point(219, 12);
            this.groupBox_out.Name = "groupBox_out";
            this.groupBox_out.Size = new System.Drawing.Size(200, 100);
            this.groupBox_out.TabIndex = 3;
            this.groupBox_out.TabStop = false;
            this.groupBox_out.Text = "Output";
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
            // groupBox_in
            // 
            this.groupBox_in.Controls.Add(this.button_submit);
            this.groupBox_in.Controls.Add(this.textBox_n);
            this.groupBox_in.Controls.Add(this.label_n);
            this.groupBox_in.Location = new System.Drawing.Point(12, 12);
            this.groupBox_in.Name = "groupBox_in";
            this.groupBox_in.Size = new System.Drawing.Size(200, 100);
            this.groupBox_in.TabIndex = 2;
            this.groupBox_in.TabStop = false;
            this.groupBox_in.Text = "Input";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(6, 68);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(188, 23);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
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
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(7, 20);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(90, 13);
            this.label_n.TabIndex = 0;
            this.label_n.Text = "Enter array length";
            // 
            // errorProvider_n
            // 
            this.errorProvider_n.ContainerControl = this;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(6, 68);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(188, 23);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dataGridView_A
            // 
            this.dataGridView_A.AllowUserToAddRows = false;
            this.dataGridView_A.AllowUserToDeleteRows = false;
            this.dataGridView_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_A.Location = new System.Drawing.Point(10, 19);
            this.dataGridView_A.Name = "dataGridView_A";
            this.dataGridView_A.ReadOnly = true;
            this.dataGridView_A.Size = new System.Drawing.Size(300, 150);
            this.dataGridView_A.TabIndex = 4;
            // 
            // dataGridView_B
            // 
            this.dataGridView_B.AllowUserToAddRows = false;
            this.dataGridView_B.AllowUserToDeleteRows = false;
            this.dataGridView_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_B.Location = new System.Drawing.Point(316, 19);
            this.dataGridView_B.Name = "dataGridView_B";
            this.dataGridView_B.ReadOnly = true;
            this.dataGridView_B.Size = new System.Drawing.Size(300, 150);
            this.dataGridView_B.TabIndex = 5;
            // 
            // groupBox_output
            // 
            this.groupBox_output.Controls.Add(this.dataGridView_A);
            this.groupBox_output.Controls.Add(this.dataGridView_B);
            this.groupBox_output.Location = new System.Drawing.Point(12, 119);
            this.groupBox_output.Name = "groupBox_output";
            this.groupBox_output.Size = new System.Drawing.Size(776, 180);
            this.groupBox_output.TabIndex = 6;
            this.groupBox_output.TabStop = false;
            this.groupBox_output.Text = "Output";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_output);
            this.Controls.Add(this.groupBox_out);
            this.Controls.Add(this.groupBox_in);
            this.Name = "Form_Main";
            this.Text = "11";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox_out.ResumeLayout(false);
            this.groupBox_out.PerformLayout();
            this.groupBox_in.ResumeLayout(false);
            this.groupBox_in.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_B)).EndInit();
            this.groupBox_output.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_out;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.GroupBox groupBox_in;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.ErrorProvider errorProvider_n;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataGridView dataGridView_A;
        private System.Windows.Forms.DataGridView dataGridView_B;
        private System.Windows.Forms.GroupBox groupBox_output;
    }
}

