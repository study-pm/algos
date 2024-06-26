namespace WF_09
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
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.label_m = new System.Windows.Forms.Label();
            this.errorProvider_m = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView_out = new System.Windows.Forms.DataGridView();
            this.groupBox_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_out)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_in
            // 
            this.groupBox_in.Controls.Add(this.button_submit);
            this.groupBox_in.Controls.Add(this.textBox_m);
            this.groupBox_in.Controls.Add(this.label_m);
            this.groupBox_in.Location = new System.Drawing.Point(13, 13);
            this.groupBox_in.Name = "groupBox_in";
            this.groupBox_in.Size = new System.Drawing.Size(200, 100);
            this.groupBox_in.TabIndex = 0;
            this.groupBox_in.TabStop = false;
            this.groupBox_in.Text = "Input";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(7, 71);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(187, 23);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // textBox_m
            // 
            this.textBox_m.Location = new System.Drawing.Point(133, 17);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(44, 20);
            this.textBox_m.TabIndex = 1;
            this.textBox_m.TextChanged += new System.EventHandler(this.textBox_m_TextChanged);
            this.textBox_m.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_m_KeyPress);
            this.textBox_m.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_m_Validating);
            // 
            // label_m
            // 
            this.label_m.AutoSize = true;
            this.label_m.Location = new System.Drawing.Point(7, 20);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(120, 13);
            this.label_m.TabIndex = 0;
            this.label_m.Text = "Enter an integer number";
            // 
            // errorProvider_m
            // 
            this.errorProvider_m.ContainerControl = this;
            // 
            // dataGridView_out
            // 
            this.dataGridView_out.AllowUserToAddRows = false;
            this.dataGridView_out.AllowUserToDeleteRows = false;
            this.dataGridView_out.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_out.Location = new System.Drawing.Point(12, 119);
            this.dataGridView_out.Name = "dataGridView_out";
            this.dataGridView_out.ReadOnly = true;
            this.dataGridView_out.Size = new System.Drawing.Size(776, 150);
            this.dataGridView_out.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_out);
            this.Controls.Add(this.groupBox_in);
            this.Name = "Form_Main";
            this.Text = "09";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox_in.ResumeLayout(false);
            this.groupBox_in.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_out)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_in;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.Label label_m;
        private System.Windows.Forms.ErrorProvider errorProvider_m;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.DataGridView dataGridView_out;
    }
}

