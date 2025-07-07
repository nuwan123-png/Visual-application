using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator_design
{
    public partial class devition : Form
    {
        private double result = 0;
        private string operation = "";
        private bool operationPressed = false;
        public devition()
        {
            InitializeComponent();
        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void minos_Click(object sender, EventArgs e)
        {
            btnoperation("-");
        }

        private void dev_Click(object sender, EventArgs e)
        {
            btnoperation("/");
        }

        private void num_click(string number)
        {
            if (operationPressed)
            {
                operationPressed = false;
            }
            text.Text += number;
            text.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num_click("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num_click("8");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num_click("9");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num_click("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num_click("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num_click("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num_click("1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num_click("2");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num_click("3");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num_click("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num_click(".");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            btnoperation("+");
        }

        private void btnoperation(string op)
        {
            result = double.Parse(text.Text);
            operation = op;
            operationPressed = true;

            text.Text = text.Text + op; // Append the operator to the textbox
            text.Refresh();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = text.Text.Split(new char[] { '+', '-', '*', '/' });
                if (parts.Length != 2)
                {
                    text.Text = "error";
                    return;
                }

                double num2 = double.Parse(parts[1]);

                switch (operation)
                {
                    case "+":
                        result += num2;
                        break;
                    case "-":
                        result -= num2;
                        break;
                    case "*":
                        result *= num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result /= num2;
                        else
                        {
                            text.Text = "error";
                            return;
                        }
                        break;
                }

                text.Text += "=" + result.ToString();
                text.Refresh();
            }
            catch
            {
                text.Text = "error";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            text.Text = " ";
            result = 0;
            operation = "";
            operationPressed = false;

            text.Refresh();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            btnoperation("*");
        }

        private void CE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text.Text) && text.Text != "0" && text.Text != "error")
            {
                text.Text = text.Text.Substring(0, text.Text.Length - 1);

                if (string.IsNullOrEmpty(text.Text))
                {
                    text.Text = "0";
                }
                text.Refresh();
            }
        }
    }
}