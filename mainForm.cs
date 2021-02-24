using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorWindowsFormsApplication
{
    public partial class mainForm : Form
    {
        Boolean operationSw;
        Double operand1;
        Double operand2;
        String operation;
        public mainForm()
        {
            InitializeComponent();
            textBox1.Text = "0";
            operationSw = false;
            operand1 = 0;
            operand2 = 0;
            operation = "";
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addChar(String a)
        {
            if (textBox1.Text.Length == 10)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = a;
            else
                textBox1.Text = textBox1.Text + a;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addChar("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addChar("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addChar("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addChar("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addChar("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addChar("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addChar("6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addChar("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addChar("8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addChar("9");
        }
        private void operate()
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        textBox1.Text = Convert.ToString(operand1 + operand2);
                        break;
                    case "-":
                        textBox1.Text = Convert.ToString(operand1 - operand2);
                        break;
                    case "*":
                        textBox1.Text = Convert.ToString(operand1 * operand2);
                        break;
                    case "/":
                        if (operand2 == 0)
                        {
                            MessageBox.Show("Ambigus");
                            operation = "";
                            operationSw = false;
                            operand1 = 0;
                            operand2 = 0;
                            textBox1.Text = "0";
                        }
                        else
                            textBox1.Text = Convert.ToString(operand1 / operand2);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Overflow");
                operation = "";
                operationSw = false;
                operand1 = 0;
                operand2 = 0;
                textBox1.Text = "0";
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (operationSw)
            {
                operand2 = Convert.ToInt32(textBox1.Text);
                operate();
            }
            operationSw = true;
            operation = "+";
            operand1 = Convert.ToDouble(textBox1.Text);
            operand2 = 0;
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (operationSw)
            {
                operand2 = Convert.ToInt32(textBox1.Text);
                operate();
            }
            operationSw = false;
            operation = "";
            operand1 = 0;
            operand2 = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (operationSw)
            {
                operand2 = Convert.ToInt32(textBox1.Text);
                operate();
            }
            operationSw = true;
            operation = "-";
            operand1 = Convert.ToDouble(textBox1.Text);
            operand2 = 0;
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (operationSw)
            {
                operand2 = Convert.ToInt32(textBox1.Text);
                operate();
            }
            operationSw = true;
            operation = "*";
            operand1 = Convert.ToDouble(textBox1.Text);
            operand2 = 0;
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (operationSw)
            {
                operand2 = Convert.ToInt32(textBox1.Text);
                operate();
            }
            operationSw = true;
            operation = "/";
            operand1 = Convert.ToDouble(textBox1.Text);
            operand2 = 0;
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            operationSw = false;
            operation = "";
            operand1 = 0;
            operand2 = 0;
            textBox1.Text = "0";

        }
    }
}
