namespace CalculatorFractions
{
    partial class Form1
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
            this.tbFirstNumerator = new System.Windows.Forms.TextBox();
            this.tbSecondNumerator = new System.Windows.Forms.TextBox();
            this.tbFirstDenumerator = new System.Windows.Forms.TextBox();
            this.tbSecondDenumerator = new System.Windows.Forms.TextBox();
            this.cbSign = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirstNumerator
            // 
            this.tbFirstNumerator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstNumerator.Location = new System.Drawing.Point(63, 62);
            this.tbFirstNumerator.Multiline = true;
            this.tbFirstNumerator.Name = "tbFirstNumerator";
            this.tbFirstNumerator.Size = new System.Drawing.Size(54, 44);
            this.tbFirstNumerator.TabIndex = 0;
            this.tbFirstNumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSecondNumerator
            // 
            this.tbSecondNumerator.Location = new System.Drawing.Point(222, 62);
            this.tbSecondNumerator.Multiline = true;
            this.tbSecondNumerator.Name = "tbSecondNumerator";
            this.tbSecondNumerator.Size = new System.Drawing.Size(54, 44);
            this.tbSecondNumerator.TabIndex = 1;
            this.tbSecondNumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFirstDenumerator
            // 
            this.tbFirstDenumerator.Location = new System.Drawing.Point(63, 159);
            this.tbFirstDenumerator.Multiline = true;
            this.tbFirstDenumerator.Name = "tbFirstDenumerator";
            this.tbFirstDenumerator.Size = new System.Drawing.Size(54, 44);
            this.tbFirstDenumerator.TabIndex = 2;
            this.tbFirstDenumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSecondDenumerator
            // 
            this.tbSecondDenumerator.Location = new System.Drawing.Point(222, 159);
            this.tbSecondDenumerator.Multiline = true;
            this.tbSecondDenumerator.Name = "tbSecondDenumerator";
            this.tbSecondDenumerator.Size = new System.Drawing.Size(54, 44);
            this.tbSecondDenumerator.TabIndex = 3;
            this.tbSecondDenumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbSign
            // 
            this.cbSign.FormattingEnabled = true;
            this.cbSign.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbSign.Location = new System.Drawing.Point(147, 118);
            this.cbSign.Name = "cbSign";
            this.cbSign.Size = new System.Drawing.Size(45, 24);
            this.cbSign.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(28, 243);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 40);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Обчислити";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(130, 302);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(78, 44);
            this.tbResult.TabIndex = 6;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введіть значення дробів та оберіть операцію:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 362);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cbSign);
            this.Controls.Add(this.tbSecondDenumerator);
            this.Controls.Add(this.tbFirstDenumerator);
            this.Controls.Add(this.tbSecondNumerator);
            this.Controls.Add(this.tbFirstNumerator);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstNumerator;
        private System.Windows.Forms.TextBox tbSecondNumerator;
        private System.Windows.Forms.TextBox tbFirstDenumerator;
        private System.Windows.Forms.TextBox tbSecondDenumerator;
        private System.Windows.Forms.ComboBox cbSign;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
    }
}

