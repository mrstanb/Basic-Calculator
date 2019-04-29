using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        decimal value = 0;
        bool operatorIsClicked = false;
        string operationPerformed = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if((txtResult.Text == "0") || (operatorIsClicked == true))
            {
                txtResult.Clear();
            }

            operatorIsClicked = false;
            if(b.Text == ".")
            {
                if(!txtResult.Text.Contains("."))
                {
                    txtResult.Text = txtResult.Text + b.Text;
                }
            }
            else
            {
                txtResult.Text = txtResult.Text + b.Text;
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblMemory.Text = "";

        }

        private void operator_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            if (value != 0m)
            {
                btnEquals.PerformClick();
                operatorIsClicked = true;
                operationPerformed = b.Text;
                lblMemory.Text = txtResult.Text + " " + b.Text;
            }
            else
            {
                operationPerformed = b.Text;
                value = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                operatorIsClicked = true;
                lblMemory.Text = txtResult.Text + " " + b.Text;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtResult.Text = Operations.Add(value, decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "-":
                    txtResult.Text = Operations.Subtract(value, decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "*":
                    txtResult.Text = Operations.Multiply(value, decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "/":
                    txtResult.Text = Operations.Divide(value, decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;

                default:
                    break;
            }

            lblMemory.Text = "";
            value = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            operationPerformed = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            value = 0;
            txtResult.Text = "0";
            lblMemory.Text = "";
            operatorIsClicked = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.C:
                    btnClear.PerformClick();
                    break;
                case Keys.Delete:
                    btnClearEntry.PerformClick();
                    break;
                case Keys.D0:
                    btnZero.PerformClick();
                    break;
                case Keys.D1:
                    btnOne.PerformClick();
                    break;
                case Keys.D2:
                    btnTwo.PerformClick();
                    break;
                case Keys.D3:
                    btnThree.PerformClick();
                    break;
                case Keys.D4:
                    btnFour.PerformClick();
                    break;
                case Keys.D5:
                    btnFive.PerformClick();
                    break;
                case Keys.D6:
                    btnSix.PerformClick();
                    break;
                case Keys.D7:
                    btnSeven.PerformClick();
                    break;
                case Keys.D8:
                    btnEight.PerformClick();
                    break;
                case Keys.D9:
                    btnNine.PerformClick();
                    break;
                case Keys.NumPad0:
                    goto case Keys.D0;
                case Keys.NumPad1:
                    goto case Keys.D1;
                case Keys.NumPad2:
                    goto case Keys.D2;
                case Keys.NumPad3:
                    goto case Keys.D3;
                case Keys.NumPad4:
                    goto case Keys.D4;
                case Keys.NumPad5:
                    goto case Keys.D5;
                case Keys.NumPad6:
                    goto case Keys.D6;
                case Keys.NumPad7:
                    goto case Keys.D7;
                case Keys.NumPad8:
                    goto case Keys.D8;
                case Keys.NumPad9:
                    goto case Keys.D9;
                case Keys.Decimal:
                    btnDecPoint.PerformClick();
                    break;
                case Keys.OemPeriod:
                    goto case Keys.Decimal;
                case Keys.Oemplus:
                    btnPlus.PerformClick();
                    break;
                case Keys.OemMinus:
                    btnMinus.PerformClick();
                    break;
                case Keys.Add:
                    goto case Keys.Oemplus;
                case Keys.Subtract:
                    goto case Keys.OemMinus;
                case Keys.Multiply:
                    btnTimes.PerformClick();
                    break;
                case Keys.Divide:
                    btnDivide.PerformClick();
                    break;
                case Keys.Enter:
                    btnEquals.PerformClick();
                    break;
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = Math.PI.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            txtResult.Text = Math.Tan(double.Parse(txtResult.Text)).ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            txtResult.Text = Math.Cos(double.Parse(txtResult.Text)).ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            txtResult.Text = Math.Sin(double.Parse(txtResult.Text)).ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtResult.Text = Math.Sqrt(double.Parse(txtResult.Text)).ToString();
        }

        private void btnSecondPower_Click(object sender, EventArgs e)
        {
            txtResult.Text = Math.Pow(double.Parse(txtResult.Text), 2d).ToString();
        }

        private void btnNaturalLog_Click(object sender, EventArgs e)
        {
            operatorIsClicked = true;
            if ((txtResult.Text == "") && (operatorIsClicked))
            {
                
            }
            else
            {
                txtResult.Text = Math.Log(double.Parse(txtResult.Text)).ToString();
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtResult.Text = Math.E.ToString();
        }

        private void btnOneDivideByNumber_Click(object sender, EventArgs e)
        {
            txtResult.Text = Operations.Divide(1m, decimal.Parse(txtResult.Text)).ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            decimal factorialResult = 0m;
            factorialResult = Operations.Factorial(decimal.Parse(txtResult.Text));
            txtResult.Text = factorialResult.ToString();
        }
    }
}
