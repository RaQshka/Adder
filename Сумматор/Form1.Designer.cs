namespace Сумматор
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FirstUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            SecondUpDown = new NumericUpDown();
            SecondBinaryLabel = new Label();
            FirstBinaryLabel = new Label();
            ResultLabel = new Label();
            ResultDescription = new Label();
            label4 = new Label();
            ResultDecimal = new Label();
            ((System.ComponentModel.ISupportInitialize)FirstUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecondUpDown).BeginInit();
            SuspendLayout();
            // 
            // FirstUpDown
            // 
            FirstUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstUpDown.Location = new Point(164, 13);
            FirstUpDown.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            FirstUpDown.Minimum = new decimal(new int[] { 32768, 0, 0, int.MinValue });
            FirstUpDown.Name = "FirstUpDown";
            FirstUpDown.Size = new Size(120, 29);
            FirstUpDown.TabIndex = 0;
            FirstUpDown.ValueChanged += FirstUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 1;
            label1.Text = "Первое число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 3;
            label2.Text = "Второе число";
            // 
            // SecondUpDown
            // 
            SecondUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SecondUpDown.Location = new Point(164, 50);
            SecondUpDown.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            SecondUpDown.Minimum = new decimal(new int[] { 32768, 0, 0, int.MinValue });
            SecondUpDown.Name = "SecondUpDown";
            SecondUpDown.Size = new Size(120, 29);
            SecondUpDown.TabIndex = 2;
            SecondUpDown.ValueChanged += SecondUpDown_ValueChanged;
            // 
            // SecondBinaryLabel
            // 
            SecondBinaryLabel.AutoSize = true;
            SecondBinaryLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SecondBinaryLabel.Location = new Point(294, 54);
            SecondBinaryLabel.Name = "SecondBinaryLabel";
            SecondBinaryLabel.Size = new Size(0, 25);
            SecondBinaryLabel.TabIndex = 5;
            // 
            // FirstBinaryLabel
            // 
            FirstBinaryLabel.AutoSize = true;
            FirstBinaryLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FirstBinaryLabel.Location = new Point(294, 17);
            FirstBinaryLabel.Name = "FirstBinaryLabel";
            FirstBinaryLabel.Size = new Size(0, 25);
            FirstBinaryLabel.TabIndex = 4;
            // 
            // ResultLabel
            // 
            ResultLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ResultLabel.Location = new Point(12, 134);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(500, 40);
            ResultLabel.TabIndex = 6;
            ResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResultDescription
            // 
            ResultDescription.Location = new Point(12, 195);
            ResultDescription.Name = "ResultDescription";
            ResultDescription.Size = new Size(500, 23);
            ResultDescription.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 98);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 8;
            label4.Text = "Результат: ";
            // 
            // ResultDecimal
            // 
            ResultDecimal.AutoSize = true;
            ResultDecimal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ResultDecimal.Location = new Point(123, 98);
            ResultDecimal.Name = "ResultDecimal";
            ResultDecimal.Size = new Size(0, 25);
            ResultDecimal.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 238);
            Controls.Add(ResultDecimal);
            Controls.Add(label4);
            Controls.Add(ResultDescription);
            Controls.Add(ResultLabel);
            Controls.Add(SecondBinaryLabel);
            Controls.Add(FirstBinaryLabel);
            Controls.Add(label2);
            Controls.Add(SecondUpDown);
            Controls.Add(label1);
            Controls.Add(FirstUpDown);
            MaximizeBox = false;
            MaximumSize = new Size(540, 489);
            MinimumSize = new Size(540, 277);
            Name = "Form1";
            Text = "Сумматор";
            ((System.ComponentModel.ISupportInitialize)FirstUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecondUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown FirstUpDown;
        private Label label1;
        private Label label2;
        private NumericUpDown SecondUpDown;
        private Label SecondBinaryLabel;
        private Label FirstBinaryLabel;
        private Label ResultLabel;
        private Label ResultDescription;
        private Label label4;
        private Label ResultDecimal;
    }
}
