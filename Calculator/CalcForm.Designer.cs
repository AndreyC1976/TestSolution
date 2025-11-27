namespace Calculator
{
    partial class CalcForm
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
            this.Reset = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Button();
            this.OprMultiply = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.Number0 = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.NumberComma = new System.Windows.Forms.Button();
            this.OprEquals = new System.Windows.Forms.Button();
            this.OprDivide = new System.Windows.Forms.Button();
            this.OprSubstraction = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.OprAdd = new System.Windows.Forms.Button();
            this.OperationBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset.Location = new System.Drawing.Point(12, 62);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(50, 50);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "AC";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Number1
            // 
            this.Number1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number1.Location = new System.Drawing.Point(12, 230);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(50, 50);
            this.Number1.TabIndex = 6;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = false;
            this.Number1.Click += new System.EventHandler(this.Number1_Click);
            // 
            // OprMultiply
            // 
            this.OprMultiply.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OprMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OprMultiply.Location = new System.Drawing.Point(180, 230);
            this.OprMultiply.Name = "OprMultiply";
            this.OprMultiply.Size = new System.Drawing.Size(50, 50);
            this.OprMultiply.TabIndex = 9;
            this.OprMultiply.Text = "x";
            this.OprMultiply.UseVisualStyleBackColor = false;
            this.OprMultiply.Click += new System.EventHandler(this.OprMultiply_Click);
            // 
            // Number4
            // 
            this.Number4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number4.Location = new System.Drawing.Point(12, 174);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(50, 50);
            this.Number4.TabIndex = 10;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = false;
            this.Number4.Click += new System.EventHandler(this.Number4_Click);
            // 
            // Number0
            // 
            this.Number0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number0.Location = new System.Drawing.Point(68, 286);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(50, 50);
            this.Number0.TabIndex = 11;
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = false;
            this.Number0.Click += new System.EventHandler(this.Number0_Click);
            // 
            // Number3
            // 
            this.Number3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number3.Location = new System.Drawing.Point(124, 230);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(50, 50);
            this.Number3.TabIndex = 12;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = false;
            this.Number3.Click += new System.EventHandler(this.Number3_Click);
            // 
            // Number2
            // 
            this.Number2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number2.Location = new System.Drawing.Point(68, 230);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(50, 50);
            this.Number2.TabIndex = 13;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = false;
            this.Number2.Click += new System.EventHandler(this.Number2_Click);
            // 
            // Number9
            // 
            this.Number9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number9.Location = new System.Drawing.Point(124, 118);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(50, 50);
            this.Number9.TabIndex = 14;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = false;
            this.Number9.Click += new System.EventHandler(this.Number9_Click_1);
            // 
            // Number8
            // 
            this.Number8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number8.Location = new System.Drawing.Point(68, 118);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(50, 50);
            this.Number8.TabIndex = 15;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = false;
            this.Number8.Click += new System.EventHandler(this.Number8_Click);
            // 
            // Number7
            // 
            this.Number7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number7.Location = new System.Drawing.Point(12, 118);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(50, 50);
            this.Number7.TabIndex = 16;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = false;
            this.Number7.Click += new System.EventHandler(this.Number7_Click);
            // 
            // Number6
            // 
            this.Number6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number6.Location = new System.Drawing.Point(124, 174);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(50, 50);
            this.Number6.TabIndex = 17;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = false;
            this.Number6.Click += new System.EventHandler(this.Number6_Click);
            // 
            // Number5
            // 
            this.Number5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number5.Location = new System.Drawing.Point(68, 174);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(50, 50);
            this.Number5.TabIndex = 18;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = false;
            this.Number5.Click += new System.EventHandler(this.Number5_Click);
            // 
            // Backspace
            // 
            this.Backspace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Backspace.Location = new System.Drawing.Point(180, 62);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(50, 50);
            this.Backspace.TabIndex = 20;
            this.Backspace.Text = "<—";
            this.Backspace.UseVisualStyleBackColor = false;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // NumberComma
            // 
            this.NumberComma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumberComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberComma.Location = new System.Drawing.Point(12, 286);
            this.NumberComma.Name = "NumberComma";
            this.NumberComma.Size = new System.Drawing.Size(50, 50);
            this.NumberComma.TabIndex = 21;
            this.NumberComma.Text = ",";
            this.NumberComma.UseVisualStyleBackColor = false;
            this.NumberComma.Click += new System.EventHandler(this.NumberComma_Click);
            // 
            // OprEquals
            // 
            this.OprEquals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OprEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OprEquals.Location = new System.Drawing.Point(124, 286);
            this.OprEquals.Name = "OprEquals";
            this.OprEquals.Size = new System.Drawing.Size(50, 50);
            this.OprEquals.TabIndex = 22;
            this.OprEquals.Text = "=";
            this.OprEquals.UseVisualStyleBackColor = false;
            this.OprEquals.Click += new System.EventHandler(this.OprEquals_Click);
            // 
            // OprDivide
            // 
            this.OprDivide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OprDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OprDivide.Location = new System.Drawing.Point(180, 174);
            this.OprDivide.Name = "OprDivide";
            this.OprDivide.Size = new System.Drawing.Size(50, 50);
            this.OprDivide.TabIndex = 23;
            this.OprDivide.Text = "/";
            this.OprDivide.UseVisualStyleBackColor = false;
            this.OprDivide.Click += new System.EventHandler(this.OprDivide_Click);
            // 
            // OprSubstraction
            // 
            this.OprSubstraction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OprSubstraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OprSubstraction.Location = new System.Drawing.Point(180, 286);
            this.OprSubstraction.Name = "OprSubstraction";
            this.OprSubstraction.Size = new System.Drawing.Size(50, 50);
            this.OprSubstraction.TabIndex = 24;
            this.OprSubstraction.Text = "—";
            this.OprSubstraction.UseVisualStyleBackColor = false;
            this.OprSubstraction.Click += new System.EventHandler(this.OprSubstraction_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputBox.Location = new System.Drawing.Point(12, 12);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(218, 44);
            this.OutputBox.TabIndex = 26;
            this.OutputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OprAdd
            // 
            this.OprAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OprAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OprAdd.Location = new System.Drawing.Point(180, 118);
            this.OprAdd.Name = "OprAdd";
            this.OprAdd.Size = new System.Drawing.Size(50, 50);
            this.OprAdd.TabIndex = 27;
            this.OprAdd.Text = "+";
            this.OprAdd.UseVisualStyleBackColor = false;
            this.OprAdd.Click += new System.EventHandler(this.OprAdd_Click);
            // 
            // OperationBox
            // 
            this.OperationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationBox.Location = new System.Drawing.Point(68, 68);
            this.OperationBox.Name = "OperationBox";
            this.OperationBox.Size = new System.Drawing.Size(106, 44);
            this.OperationBox.TabIndex = 28;
            this.OperationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalcForm
            // 
            this.AcceptButton = this.OprEquals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(242, 349);
            this.Controls.Add(this.OperationBox);
            this.Controls.Add(this.OprAdd);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.OprSubstraction);
            this.Controls.Add(this.OprDivide);
            this.Controls.Add(this.OprEquals);
            this.Controls.Add(this.NumberComma);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number0);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.OprMultiply);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Reset);
            this.Name = "CalcForm";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button OprMultiply;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button NumberComma;
        private System.Windows.Forms.Button OprEquals;
        private System.Windows.Forms.Button OprDivide;
        private System.Windows.Forms.Button OprSubstraction;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button OprAdd;
        private System.Windows.Forms.TextBox OperationBox;
    }
}

