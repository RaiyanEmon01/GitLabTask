namespace calculator
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "%";
            txtDisplay.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "/";
            txtDisplay.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void butt_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void button00_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "00";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "+";
            txtDisplay.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "-";
            txtDisplay.Text = "";
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "*";
            txtDisplay.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(txtDisplay.Text);
            double result = 0;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operation == "/")
            {
                result = firstNumber / secondNumber;
            }
            else if (operation == "%")
            {
                result = firstNumber % secondNumber;
            }

            txtDisplay.Text = result.ToString();
        }
    }
}
