﻿namespace WF_04
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
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label_n = new System.Windows.Forms.Label();
            this.groupBox_out = new System.Windows.Forms.GroupBox();
            this.textBox_out = new System.Windows.Forms.TextBox();
            this.errorProvider_n = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_in.SuspendLayout();
            this.groupBox_out.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_n)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_in
            // 
            this.groupBox_in.Controls.Add(this.textBox_n);
            this.groupBox_in.Controls.Add(this.label_n);
            this.groupBox_in.Location = new System.Drawing.Point(13, 13);
            this.groupBox_in.Name = "groupBox_in";
            this.groupBox_in.Size = new System.Drawing.Size(250, 100);
            this.groupBox_in.TabIndex = 0;
            this.groupBox_in.TabStop = false;
            this.groupBox_in.Text = "Input";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(127, 17);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(97, 20);
            this.textBox_n.TabIndex = 1;
            this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
            this.textBox_n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_n_KeyPress);
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
            this.groupBox_out.Controls.Add(this.textBox_out);
            this.groupBox_out.Location = new System.Drawing.Point(269, 13);
            this.groupBox_out.Name = "groupBox_out";
            this.groupBox_out.Size = new System.Drawing.Size(250, 100);
            this.groupBox_out.TabIndex = 1;
            this.groupBox_out.TabStop = false;
            this.groupBox_out.Text = "Output";
            // 
            // textBox_out
            // 
            this.textBox_out.Location = new System.Drawing.Point(7, 17);
            this.textBox_out.Name = "textBox_out";
            this.textBox_out.Size = new System.Drawing.Size(187, 20);
            this.textBox_out.TabIndex = 0;
            // 
            // errorProvider_n
            // 
            this.errorProvider_n.ContainerControl = this;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_out);
            this.Controls.Add(this.groupBox_in);
            this.Name = "Form_Main";
            this.Text = "04";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox_in.ResumeLayout(false);
            this.groupBox_in.PerformLayout();
            this.groupBox_out.ResumeLayout(false);
            this.groupBox_out.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_n)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_in;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.GroupBox groupBox_out;
        private System.Windows.Forms.TextBox textBox_out;
        private System.Windows.Forms.ErrorProvider errorProvider_n;
    }
}

