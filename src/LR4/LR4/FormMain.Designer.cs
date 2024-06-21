namespace LR4
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.button_generateArray = new System.Windows.Forms.Button();
            this.textBox_sizeInput = new System.Windows.Forms.TextBox();
            this.label_arraySize = new System.Windows.Forms.Label();
            this.label_header = new System.Windows.Forms.Label();
            this.label_results = new System.Windows.Forms.Label();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
            this.label_arrReverse = new System.Windows.Forms.Label();
            this.label_arrayReverse = new System.Windows.Forms.Label();
            this.label_arrSum = new System.Windows.Forms.Label();
            this.label_arraySum = new System.Windows.Forms.Label();
            this.textBox_arrSwap = new System.Windows.Forms.TextBox();
            this.label_arraySwap = new System.Windows.Forms.Label();
            this.button_repeat = new System.Windows.Forms.Button();
            this.textBox_arrGenerated = new System.Windows.Forms.TextBox();
            this.groupBox_data.SuspendLayout();
            this.groupBox_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_data
            // 
            this.groupBox_data.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox_data.Controls.Add(this.textBox_arrGenerated);
            this.groupBox_data.Controls.Add(this.button_generateArray);
            this.groupBox_data.Controls.Add(this.textBox_sizeInput);
            this.groupBox_data.Controls.Add(this.label_arraySize);
            this.groupBox_data.Location = new System.Drawing.Point(12, 36);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(776, 143);
            this.groupBox_data.TabIndex = 0;
            this.groupBox_data.TabStop = false;
            // 
            // button_generateArray
            // 
            this.button_generateArray.Location = new System.Drawing.Point(9, 76);
            this.button_generateArray.Name = "button_generateArray";
            this.button_generateArray.Size = new System.Drawing.Size(146, 50);
            this.button_generateArray.TabIndex = 2;
            this.button_generateArray.Text = "Сгенерировать\r\nмассив";
            this.button_generateArray.UseVisualStyleBackColor = true;
            this.button_generateArray.Click += new System.EventHandler(this.button_generateArray_Click);
            // 
            // textBox_sizeInput
            // 
            this.textBox_sizeInput.Location = new System.Drawing.Point(193, 28);
            this.textBox_sizeInput.Name = "textBox_sizeInput";
            this.textBox_sizeInput.Size = new System.Drawing.Size(52, 20);
            this.textBox_sizeInput.TabIndex = 1;
            // 
            // label_arraySize
            // 
            this.label_arraySize.AutoSize = true;
            this.label_arraySize.Location = new System.Drawing.Point(6, 31);
            this.label_arraySize.Name = "label_arraySize";
            this.label_arraySize.Size = new System.Drawing.Size(184, 13);
            this.label_arraySize.TabIndex = 0;
            this.label_arraySize.Text = "Введите размерность массива n =";
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_header.Location = new System.Drawing.Point(241, 9);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(353, 24);
            this.label_header.TabIndex = 1;
            this.label_header.Text = "Инициализация элеменов массива";
            this.label_header.UseMnemonic = false;
            // 
            // label_results
            // 
            this.label_results.AutoSize = true;
            this.label_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_results.Location = new System.Drawing.Point(341, 223);
            this.label_results.Name = "label_results";
            this.label_results.Size = new System.Drawing.Size(126, 24);
            this.label_results.TabIndex = 3;
            this.label_results.Text = "Результаты";
            this.label_results.UseMnemonic = false;
            // 
            // groupBox_result
            // 
            this.groupBox_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox_result.Controls.Add(this.label_arrReverse);
            this.groupBox_result.Controls.Add(this.label_arrayReverse);
            this.groupBox_result.Controls.Add(this.label_arrSum);
            this.groupBox_result.Controls.Add(this.label_arraySum);
            this.groupBox_result.Controls.Add(this.textBox_arrSwap);
            this.groupBox_result.Controls.Add(this.label_arraySwap);
            this.groupBox_result.Location = new System.Drawing.Point(12, 250);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(776, 139);
            this.groupBox_result.TabIndex = 2;
            this.groupBox_result.TabStop = false;
            // 
            // label_arrReverse
            // 
            this.label_arrReverse.AutoSize = true;
            this.label_arrReverse.Location = new System.Drawing.Point(161, 65);
            this.label_arrReverse.Name = "label_arrReverse";
            this.label_arrReverse.Size = new System.Drawing.Size(32, 13);
            this.label_arrReverse.TabIndex = 6;
            this.label_arrReverse.Text = "result";
            // 
            // label_arrayReverse
            // 
            this.label_arrayReverse.AutoSize = true;
            this.label_arrayReverse.Location = new System.Drawing.Point(9, 65);
            this.label_arrayReverse.Name = "label_arrayReverse";
            this.label_arrayReverse.Size = new System.Drawing.Size(125, 13);
            this.label_arrayReverse.TabIndex = 5;
            this.label_arrayReverse.Text = "Перевернутый массив:";
            // 
            // label_arrSum
            // 
            this.label_arrSum.AutoSize = true;
            this.label_arrSum.Location = new System.Drawing.Point(161, 30);
            this.label_arrSum.Name = "label_arrSum";
            this.label_arrSum.Size = new System.Drawing.Size(32, 13);
            this.label_arrSum.TabIndex = 4;
            this.label_arrSum.Text = "result";
            // 
            // label_arraySum
            // 
            this.label_arraySum.AutoSize = true;
            this.label_arraySum.Location = new System.Drawing.Point(9, 30);
            this.label_arraySum.Name = "label_arraySum";
            this.label_arraySum.Size = new System.Drawing.Size(149, 13);
            this.label_arraySum.TabIndex = 3;
            this.label_arraySum.Text = "Сумма элементов массива:";
            // 
            // textBox_arrSwap
            // 
            this.textBox_arrSwap.Location = new System.Drawing.Point(202, 104);
            this.textBox_arrSwap.Name = "textBox_arrSwap";
            this.textBox_arrSwap.Size = new System.Drawing.Size(428, 20);
            this.textBox_arrSwap.TabIndex = 1;
            // 
            // label_arraySwap
            // 
            this.label_arraySwap.AutoSize = true;
            this.label_arraySwap.Location = new System.Drawing.Point(9, 107);
            this.label_arraySwap.Name = "label_arraySwap";
            this.label_arraySwap.Size = new System.Drawing.Size(187, 13);
            this.label_arraySwap.TabIndex = 0;
            this.label_arraySwap.Text = "Поменять местами 2 и 3 элементы";
            // 
            // button_repeat
            // 
            this.button_repeat.Location = new System.Drawing.Point(282, 412);
            this.button_repeat.Name = "button_repeat";
            this.button_repeat.Size = new System.Drawing.Size(236, 26);
            this.button_repeat.TabIndex = 2;
            this.button_repeat.Text = "Повторить";
            this.button_repeat.UseVisualStyleBackColor = true;
            this.button_repeat.Click += new System.EventHandler(this.button_repeat_Click);
            // 
            // textBox_arrGenerated
            // 
            this.textBox_arrGenerated.Location = new System.Drawing.Point(193, 92);
            this.textBox_arrGenerated.Name = "textBox_arrGenerated";
            this.textBox_arrGenerated.Size = new System.Drawing.Size(437, 20);
            this.textBox_arrGenerated.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_results);
            this.Controls.Add(this.groupBox_result);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.button_repeat);
            this.Name = "FormMain";
            this.Text = "ЛР4 Волков В.В.";
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            this.groupBox_result.ResumeLayout(false);
            this.groupBox_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.Button button_generateArray;
        private System.Windows.Forms.TextBox textBox_sizeInput;
        private System.Windows.Forms.Label label_arraySize;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label_results;
        private System.Windows.Forms.GroupBox groupBox_result;
        private System.Windows.Forms.Label label_arrReverse;
        private System.Windows.Forms.Label label_arrayReverse;
        private System.Windows.Forms.Label label_arrSum;
        private System.Windows.Forms.Label label_arraySum;
        private System.Windows.Forms.TextBox textBox_arrSwap;
        private System.Windows.Forms.Label label_arraySwap;
        private System.Windows.Forms.Button button_repeat;
        private System.Windows.Forms.TextBox textBox_arrGenerated;
    }
}

