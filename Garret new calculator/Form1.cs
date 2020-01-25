using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public string Operation { get; private set; }
        public double FirstNumber { get; private set; }

        public Form1()
        {
            double FirstNumber;
            string Operation;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }
        private void Five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }

        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void Add_Click(object sender, EventArgs e)
        {
             
            FirstNumber = Convert.ToDouble(textBox1.Text);         
            textBox1.Text = "0";
            Operation = "+";
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";

        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "*";
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "/";
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            {
                double SecondNumber;
                double Result;

                SecondNumber = Convert.ToDouble(textBox1.Text);

                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "*")
                {
                    Result = (FirstNumber * SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "/")
                {
                    if (SecondNumber == 0)
                    {
                        textBox1.Text = "Cannot divide by zero";

                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                }
            }


        }

        private void Button12_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = "0";
            }
        }
    }
}


