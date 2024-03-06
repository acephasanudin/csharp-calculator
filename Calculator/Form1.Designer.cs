namespace Calculator
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
            textTotal = new TextBox();
            btnClear = new Button();
            btnSquareRoot = new Button();
            btnPercentage = new Button();
            buttonDivision = new Button();
            btnSubstraction = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnAddition = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnResult = new Button();
            btnPeriod = new Button();
            btn0 = new Button();
            btnMultiplication = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            SuspendLayout();
            // 
            // textTotal
            // 
            textTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTotal.CausesValidation = false;
            textTotal.Enabled = false;
            textTotal.Font = new Font("Segoe UI", 28F);
            textTotal.ForeColor = Color.Black;
            textTotal.Location = new Point(12, 12);
            textTotal.Name = "textTotal";
            textTotal.PlaceholderText = "0";
            textTotal.ReadOnly = true;
            textTotal.RightToLeft = RightToLeft.Yes;
            textTotal.Size = new Size(258, 57);
            textTotal.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Font = new Font("Segoe UI", 18F);
            btnClear.Location = new Point(12, 75);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 62);
            btnClear.TabIndex = 1;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSquareRoot.Font = new Font("Segoe UI", 18F);
            btnSquareRoot.Location = new Point(78, 75);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new Size(60, 62);
            btnSquareRoot.TabIndex = 2;
            btnSquareRoot.Text = "√x";
            btnSquareRoot.UseVisualStyleBackColor = true;
            btnSquareRoot.Click += BtnSquareRoot_Click;
            // 
            // btnPercentage
            // 
            btnPercentage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPercentage.Font = new Font("Segoe UI", 18F);
            btnPercentage.Location = new Point(144, 75);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(60, 62);
            btnPercentage.TabIndex = 3;
            btnPercentage.Text = "%";
            btnPercentage.UseVisualStyleBackColor = true;
            btnPercentage.Click += BtnPercentage_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDivision.Font = new Font("Segoe UI", 18F);
            buttonDivision.Location = new Point(210, 75);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(60, 62);
            buttonDivision.TabIndex = 4;
            buttonDivision.Text = "÷";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += BtnDivision_Click;
            // 
            // btnSubstraction
            // 
            btnSubstraction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSubstraction.Font = new Font("Segoe UI", 18F);
            btnSubstraction.Location = new Point(210, 211);
            btnSubstraction.Name = "btnSubstraction";
            btnSubstraction.Size = new Size(60, 62);
            btnSubstraction.TabIndex = 8;
            btnSubstraction.Text = "−";
            btnSubstraction.UseVisualStyleBackColor = true;
            btnSubstraction.Click += BtnSubstraction_Click;
            // 
            // btn6
            // 
            btn6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn6.Font = new Font("Segoe UI", 18F);
            btn6.Location = new Point(144, 211);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 62);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Btn6_Click;
            // 
            // btn5
            // 
            btn5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn5.Font = new Font("Segoe UI", 18F);
            btn5.Location = new Point(78, 211);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 62);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Btn5_Click;
            // 
            // btn4
            // 
            btn4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn4.Font = new Font("Segoe UI", 18F);
            btn4.Location = new Point(12, 211);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 62);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Btn4_Click;
            // 
            // btnAddition
            // 
            btnAddition.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddition.Font = new Font("Segoe UI", 18F);
            btnAddition.Location = new Point(210, 279);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(60, 62);
            btnAddition.TabIndex = 12;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += BtnAddition_Click;
            // 
            // btn9
            // 
            btn9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn9.Font = new Font("Segoe UI", 18F);
            btn9.Location = new Point(144, 279);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 62);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Btn9_Click;
            // 
            // btn8
            // 
            btn8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn8.Font = new Font("Segoe UI", 18F);
            btn8.Location = new Point(78, 279);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 62);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Btn8_Click;
            // 
            // btn7
            // 
            btn7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn7.Font = new Font("Segoe UI", 18F);
            btn7.Location = new Point(12, 279);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 62);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Btn7_Click;
            // 
            // btnResult
            // 
            btnResult.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnResult.Font = new Font("Segoe UI", 18F);
            btnResult.Location = new Point(144, 347);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(126, 62);
            btnResult.TabIndex = 16;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += BtnResult_Click;
            // 
            // btnPeriod
            // 
            btnPeriod.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPeriod.Font = new Font("Segoe UI", 18F);
            btnPeriod.Location = new Point(78, 347);
            btnPeriod.Name = "btnPeriod";
            btnPeriod.Size = new Size(60, 62);
            btnPeriod.TabIndex = 14;
            btnPeriod.Text = ",";
            btnPeriod.UseVisualStyleBackColor = true;
            btnPeriod.Click += BtnPeriod_Click;
            // 
            // btn0
            // 
            btn0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn0.Font = new Font("Segoe UI", 18F);
            btn0.Location = new Point(12, 347);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 62);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Btn0_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMultiplication.Font = new Font("Segoe UI", 18F);
            btnMultiplication.Location = new Point(210, 143);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(60, 62);
            btnMultiplication.TabIndex = 21;
            btnMultiplication.Text = "×";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += BtnMultiplication_Click;
            // 
            // btn3
            // 
            btn3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn3.Font = new Font("Segoe UI", 18F);
            btn3.Location = new Point(144, 143);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 62);
            btn3.TabIndex = 20;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Btn3_Click;
            // 
            // btn2
            // 
            btn2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn2.Font = new Font("Segoe UI", 18F);
            btn2.Location = new Point(78, 143);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 62);
            btn2.TabIndex = 19;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Btn2_Click;
            // 
            // btn1
            // 
            btn1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn1.Font = new Font("Segoe UI", 18F);
            btn1.Location = new Point(12, 143);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 62);
            btn1.TabIndex = 18;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 424);
            Controls.Add(btnMultiplication);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnResult);
            Controls.Add(btnPeriod);
            Controls.Add(btn0);
            Controls.Add(btnAddition);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnSubstraction);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(buttonDivision);
            Controls.Add(btnPercentage);
            Controls.Add(btnSquareRoot);
            Controls.Add(btnClear);
            Controls.Add(textTotal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTotal;
        private Button btnClear;
        private Button btnSquareRoot;
        private Button btnPercentage;
        private Button buttonDivision;
        private Button btnSubstraction;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnAddition;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnResult;
        private Button btnPeriod;
        private Button btn0;
        private Button btnMultiplication;
        private Button btn3;
        private Button btn2;
        private Button btn1;
    }
}
