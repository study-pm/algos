namespace WF_19
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
            this.dataGridView_in = new System.Windows.Forms.DataGridView();
            this.dataGridView_out = new System.Windows.Forms.DataGridView();
            this.button_submit = new System.Windows.Forms.Button();
            this.errorProvider_in = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_in)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_in
            // 
            this.dataGridView_in.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_in.Location = new System.Drawing.Point(13, 13);
            this.dataGridView_in.Name = "dataGridView_in";
            this.dataGridView_in.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView_in.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_in.TabIndex = 0;
            this.dataGridView_in.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_in_CellEndEdit);
            // 
            // dataGridView_out
            // 
            this.dataGridView_out.AllowUserToAddRows = false;
            this.dataGridView_out.AllowUserToDeleteRows = false;
            this.dataGridView_out.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_out.Location = new System.Drawing.Point(13, 169);
            this.dataGridView_out.Name = "dataGridView_out";
            this.dataGridView_out.ReadOnly = true;
            this.dataGridView_out.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView_out.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_out.TabIndex = 1;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(305, 13);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(131, 23);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // errorProvider_in
            // 
            this.errorProvider_in.ContainerControl = this;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.dataGridView_out);
            this.Controls.Add(this.dataGridView_in);
            this.Name = "Form_Main";
            this.Text = "19";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_in)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_in;
        private System.Windows.Forms.DataGridView dataGridView_out;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.ErrorProvider errorProvider_in;
    }
}

