namespace Task3
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
            txtFibonacciInput = new TextBox();
            btnCalculateFibonacci = new Button();
            lblFibonacciResult = new Label();
            txtBase = new TextBox();
            txtExponent = new TextBox();
            btnCalculatePower = new Button();
            lblPowerResult = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(36, 46);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(171, 27);
            txtFibonacciInput.TabIndex = 0;
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(36, 79);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(171, 50);
            btnCalculateFibonacci.TabIndex = 1;
            btnCalculateFibonacci.Text = "Calculate Fibonacci";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(36, 23);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(60, 20);
            lblFibonacciResult.TabIndex = 2;
            lblFibonacciResult.Text = "Answer:";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(321, 46);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(219, 27);
            txtBase.TabIndex = 3;
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(321, 79);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(219, 27);
            txtExponent.TabIndex = 4;
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Location = new Point(321, 112);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(219, 49);
            btnCalculatePower.TabIndex = 5;
            btnCalculatePower.Text = "Calculate Power";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(321, 23);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(60, 20);
            lblPowerResult.TabIndex = 6;
            lblPowerResult.Text = "Answer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 53);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 7;
            label1.Text = "Base:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 86);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 8;
            label2.Text = "Exponent:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 228);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPowerResult);
            Controls.Add(btnCalculatePower);
            Controls.Add(txtExponent);
            Controls.Add(txtBase);
            Controls.Add(lblFibonacciResult);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(txtFibonacciInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFibonacciInput;
        private Button btnCalculateFibonacci;
        private Label lblFibonacciResult;
        private TextBox txtBase;
        private TextBox txtExponent;
        private Button btnCalculatePower;
        private Label lblPowerResult;
        private Label label1;
        private Label label2;
    }
}
