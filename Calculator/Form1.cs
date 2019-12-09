using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double value = 0;
        string operation = "";
        bool operation_pressed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
            {
                result.Clear();
            }

            operation_pressed = false;

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;


        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString("F4");
                    break;

                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString("F4");
                    break;

                case "x":
                    result.Text = (value * double.Parse(result.Text)).ToString("F4");
                    break;

                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString("F4");
                    break;

                case "1/x":
                    result.Text = (1 / value).ToString("F4");
                    break;

                case "x²\r\n":
                    result.Text = (value * value).ToString("F4");
                    break;

                case "x³\r\n":
                    result.Text = (value * value * value).ToString("F4");
                    break;

                case "√":
                    result.Text = Math.Sqrt(value).ToString("F4");
                    break;



                default:
                    break;

            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value * (1 + double.Parse(result.Text) / 100)).ToString("F4");
                    break;

                case "-":
                    result.Text = (value * (1 - double.Parse(result.Text) / 100)).ToString("F4");
                    break;

                case "x":
                    result.Text = (value * (1 * double.Parse(result.Text) / 100)).ToString("F4");
                    break;

                case "/":
                    result.Text = (value/(value * (double.Parse(result.Text) / 100))).ToString("F4");
                    break;

                default:
                    break;

            }
        }
    }
}
