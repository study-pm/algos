namespace WF_03
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
            this.label_n = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.errorProvider_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView_output = new System.Windows.Forms.DataGridView();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.label_sum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_output)).BeginInit();
            this.SuspendLayout();
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(12, 9);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(169, 13);
            this.label_n.TabIndex = 0;
            this.label_n.Text = "Enter n (must be a natural number)";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(187, 6);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(57, 20);
            this.textBox_n.TabIndex = 1;
            this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
            this.textBox_n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_n_KeyPress);
            this.textBox_n.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_n_Validating);
            // 
            // errorProvider_name
            // 
            this.errorProvider_name.ContainerControl = this;
            // 
            // dataGridView_output
            // 
            this.dataGridView_output.AllowUserToAddRows = false;
            this.dataGridView_output.AllowUserToDeleteRows = false;
            this.dataGridView_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_output.Location = new System.Drawing.Point(15, 69);
            this.dataGridView_output.Name = "dataGridView_output";
            this.dataGridView_output.ReadOnly = true;
            this.dataGridView_output.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_output.TabIndex = 2;
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(187, 38);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.ReadOnly = true;
            this.textBox_sum.Size = new System.Drawing.Size(57, 20);
            this.textBox_sum.TabIndex = 4;
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Location = new System.Drawing.Point(12, 41);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(86, 13);
            this.label_sum.TabIndex = 3;
            this.label_sum.Text = "Sum of n digits is";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.label_sum);
            this.Controls.Add(this.dataGridView_output);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.label_n);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.ErrorProvider errorProvider_name;
        private System.Windows.Forms.DataGridView dataGridView_output;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.Label label_sum;
    }
}

