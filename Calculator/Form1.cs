using System.Diagnostics;
using System.Numerics;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float num1;
        float num2;
        string? option;
        float result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn0.Text;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn1.Text;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn2.Text;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn3.Text;
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn4.Text;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn5.Text;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn6.Text;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn7.Text;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn8.Text;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn9.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textTotal.Clear();
        }

        private void BtnPeriod_Click(object sender, EventArgs e)
        {
            if (!textTotal.Text.Contains(','))
            {
                if (textTotal.Text == "") textTotal.Text = "0";
                textTotal.Text += ',';
            }
        }

        private void BtnAddition_Click(object sender, EventArgs e)
        {
            if (textTotal.Text == "") return;
            option = "+";
            num1 = float.Parse(textTotal.Text);

            textTotal.Clear();
        }

        private void BtnSubstraction_Click(object sender, EventArgs e)
        {
            if (textTotal.Text == "") return;
            option = "-";
            num1 = float.Parse(textTotal.Text);

            textTotal.Clear();
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            if (textTotal.Text == "") return;
            option = "×";
            num1 = float.Parse(textTotal.Text);

            textTotal.Clear();
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            if (textTotal.Text == "") return;
            option = "÷";
            num1 = float.Parse(textTotal.Text);

            textTotal.Clear();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (textTotal.Text == "") return;
            num2 = float.Parse(textTotal.Text);

            result = GetResult();
            textTotal.Text = result.ToString();
        }

        private float GetResult()
        {
            return option switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "×" => num1 * num2,
                "÷" => num1 / num2,
                _ => 0,
            };
        }

        private void BtnSquareRoot_Click(object sender, EventArgs e)
        {
            if (textTotal.Text == "") return;
            result = (float)Math.Sqrt(float.Parse(textTotal.Text));
            textTotal.Text = result.ToString();
        }

        private void BtnPercentage_Click(object sender, EventArgs e)
        {
            if (textTotal.Text == "") return;
            textTotal.Text = ((float.Parse(textTotal.Text) / 100) * num1).ToString();
        }
    }
}
