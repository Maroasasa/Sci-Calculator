using System.Globalization;
using System.Data;
using System.Numerics;

namespace Sci_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double LastAnswer = 0;
        private double result;

        private double Evaluate(string expression)
        {
            double result = Convert.ToDouble(new DataTable().Compute(expression, null));
            return result;
        }
        private void ValueInput(string str)
        {
            if (resetbtn == true)
            {
                displayTxt.Clear();
            }
            var NewValue = "";

            if (displayTxt.Text != "" && Operator(str) && Operator(displayTxt.Text.Last().ToString()))
            {
                NewValue = displayTxt.Text.Substring(0, displayTxt.Text.Length - 1) + str;
            }
            else
            {
                NewValue = displayTxt.Text + str;
            }

            displayTxt.Text = NewValue;
            resetbtn = false;
        }

        private bool resetbtn;

        private Boolean Operator(string input)
        {
            return input == Plus.Text || input == Subtract.Text || input == Multiply.Text || input == Divide.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            displayTxt.Text = result.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (displayTxt.Text != "")
            {
                var Oldvalue = displayTxt.Text;
                displayTxt.Text = Oldvalue.Substring(0, Oldvalue.Length - 1);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            displayTxt.Clear();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ValueInput(btn7.Text);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            ValueInput(Plus.Text);
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            ValueInput(Multiply.Text);
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            ValueInput(Subtract.Text);
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            ValueInput(Divide.Text);
        }

        private void EqualTo_Click(object sender, EventArgs e)
        {
            var expression = displayTxt.Text;
            if (expression != "")
            {
                if (Operator(displayTxt.Text.Last().ToString()))
                {
                    expression = displayTxt.Text.Substring(0, displayTxt.Text.Length - 1);
                }

                var result = Evaluate(expression);
                displayTxt.Text = result.ToString();
                LastAnswer = result;
                resetbtn = true;
            }
        }

        private void DecimalPoint_Click(object sender, EventArgs e)
        {
            if (displayTxt.Text.Contains(".") && !Operator(displayTxt.Text.Last().ToString()))
            {

            }
            else
            {
                var Newvalue = "";
                if (displayTxt.Text == "")
                    Newvalue = "0.";

                else if (Operator(displayTxt.Text.Last().ToString()))
                {
                    Newvalue = displayTxt.Text + "0.";
                }
                else
                {
                    Newvalue = displayTxt.Text + ".";
                }


                displayTxt.Text = Newvalue;
                resetbtn = false;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ValueInput(btn0.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ValueInput(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ValueInput(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ValueInput(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ValueInput(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ValueInput(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ValueInput(btn6.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ValueInput(btn8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ValueInput(button9.Text);
        }

        private void displayTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled = !char.IsDigit(e.KeyChar)) // ( e.KeyChar.ToString() != "." || e.KeyChar.ToString() != "-" || e.KeyChar.ToString() != "+" || e.KeyChar.ToString() != "*"))
            {

            }
            
        }
    }
}