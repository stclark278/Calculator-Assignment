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
 
    public partial class frmCalculator : Form
    {
        string inputString;
        double operand1 = 0;
        double operand2 = 0;
        double answer = 0;
        char operation = 'z';
        bool negative = false;
        

        public frmCalculator()
        {
            InitializeComponent();
            txtCurrentInput.Text = "0";
            btnEqual.Select();
        }

        #region Number Buttons
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                txtCurrentInput.Text = "0";
            }
            else
            {
                txtCurrentInput.Text += "0";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                txtCurrentInput.Text = "1";
            }
            else
            {
                txtCurrentInput.Text += "1";
            }
        }

            private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                txtCurrentInput.Text = "2";
            }
            else
            {
                txtCurrentInput.Text += "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                txtCurrentInput.Text = "3";
            }
            else
            {
                txtCurrentInput.Text += "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                txtCurrentInput.Text = "4";
            }
            else
            {
                txtCurrentInput.Text += "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                txtCurrentInput.Text = "5";
            }
            else
            {
                txtCurrentInput.Text += "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                txtCurrentInput.Text = "6";
            }
            else
            {
                txtCurrentInput.Text += "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                txtCurrentInput.Text = "7";
            }
            else
            {
                txtCurrentInput.Text += "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                txtCurrentInput.Text = "8";
            }
            else
            {
                txtCurrentInput.Text += "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                txtCurrentInput.Text = "9";
            }
            else
            {
                txtCurrentInput.Text += "9";
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            inputString = txtCurrentInput.Text;
            if (inputString.Contains("."))
            {
            }
            else
            {
                inputString = inputString + '.';
                txtCurrentInput.Text = inputString;
            }
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            if (negative == true)
            {
                negative = false;
            }
            else if (negative == false)
            {
                negative = true;
            }

        }
        #endregion

        #region Arithmatic Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                operation = '+';
                txtInputHistory.Text = operand1.ToString() + ' ' + operation;
            }
            else
            {
                operand1 = Double.Parse(txtCurrentInput.Text);
                if (negative == true)
                {
                    operand1 = operand1 * -1;
                }
                operation = '+';
                txtInputHistory.Text = operand1.ToString() + ' ' + operation;
                txtCurrentInput.Text = "0";
                negative = false;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                operation = '-';
                txtInputHistory.Text = operand1.ToString() + ' ' + operation;
            }
            else
            {
                operand1 = Double.Parse(txtCurrentInput.Text);
                if (negative == true)
                {
                    operand1 = operand1 * -1;
                }
                operation = '-';
                txtInputHistory.Text = operand1.ToString() + ' ' + operation;
                txtCurrentInput.Text = "0";
                negative = false;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                operation = '*';
                txtInputHistory.Text = operand1.ToString() + ' ' + operation;
            }
            else
            {
                operand1 = Double.Parse(txtCurrentInput.Text);
                if (negative == true)
                {
                    operand1 = operand1 * -1;
                }
                operation = '*';
                txtInputHistory.Text = operand1.ToString() + ' ' + operation;
                txtCurrentInput.Text = "0";
                negative = false;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                operation = '/';
                txtInputHistory.Text = operand1.ToString() + ' ' + operation;
            }
            else
            {
                operand1 = Double.Parse(txtCurrentInput.Text);
                if (negative == true)
                {
                    operand1 = operand1 * -1;
                }
                operation = '/';
                txtInputHistory.Text = operand1.ToString() + ' ' + operation;
                txtCurrentInput.Text = "0";
                negative = false;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (operation == '+')
            {
                operand2 = Double.Parse(txtCurrentInput.Text);
                if (negative == true)
                {
                    operand2 = operand2 * -1;
                }
                answer = operand1 + operand2;
                txtInputHistory.Text += ' ' + operand2.ToString() + ' ' + '=';
                txtCurrentInput.Text = answer.ToString();
                negative = false;
            }

            if (operation == '-')
            {
                operand2 = Double.Parse(txtCurrentInput.Text);
                if (negative == true)
                {
                    operand2 = operand2 * -1;
                }
                answer = operand1 - operand2;
                txtInputHistory.Text += ' ' + operand2.ToString() + ' ' + '=';
                txtCurrentInput.Text = answer.ToString();
                negative = false;
            }

            if (operation == '*')
            {
                operand2 = Double.Parse(txtCurrentInput.Text);
                if (negative == true)
                {
                    operand2 = operand2 * -1;
                }
                answer = operand1 * operand2;
                txtInputHistory.Text += ' ' + operand2.ToString() + ' ' + '=';
                txtCurrentInput.Text = answer.ToString();
                negative = false;
            }

            if (operation == '/')
            {
                operand2 = Double.Parse(txtCurrentInput.Text);
                if (negative == true)
                {
                    operand2 = operand2 * -1;
                }
                answer = operand1 / operand2;
                if (operand2 == 0)
                {
                    txtInputHistory.Text = "Unable to Divided by Zero";
                    txtCurrentInput.Text = "0";
                }
                else
                {
                    txtInputHistory.Text += ' ' + operand2.ToString() + ' ' + '=';
                    txtCurrentInput.Text = answer.ToString();
                }
                negative = false;
            }

            if (operation == '^')
            {
                operand2 = Double.Parse(txtCurrentInput.Text);
                if (negative == true)
                {
                    operand2 = operand2 * -1;
                }
                answer = Math.Pow(operand1, operand2);
                txtInputHistory.Text += operand2.ToString() + ' ' + '=';
                txtCurrentInput.Text = answer.ToString();
                negative = false;
            }
        }


        #endregion

        #region Clear Buttons
        private void btnDelete_Click(object sender, EventArgs e)
        {
            inputString = txtCurrentInput.Text;
            inputString = inputString.Remove(inputString.Length - 1);
            if (inputString.Length <= 0)
            {
                inputString = "0";
            }
            txtCurrentInput.Text = inputString;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtCurrentInput.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            operand1 = 0;
            operand2 = 0;
            operation = 'z';
            negative = false;
            txtCurrentInput.Text = "0";
            txtInputHistory.Text = "";
        }
        #endregion

        #region Function Buttons

        private void btnSquare_Click(object sender, EventArgs e)
        {
                operand1 = Double.Parse(txtCurrentInput.Text);
                if (negative == true)
                {
                    operand1 = operand1 * -1;
                }
                answer = operand1 * operand1;
                txtInputHistory.Text = operand1.ToString() + '^' + '2';
                txtCurrentInput.Text = answer.ToString();
                negative = false;
            }

        private void btnPowerFunction_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                operation = '^';
                txtInputHistory.Text = operand1.ToString() + operation;
            }
            else
            {
                operand1 = Double.Parse(txtCurrentInput.Text);
                if (negative == true)
                {
                    operand1 = operand1 * -1;
                }
                operation = '^';
                txtInputHistory.Text = operand1.ToString() + operation;
                txtCurrentInput.Text = "0";
                negative = false;
            }
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (txtCurrentInput.Text == "0")
            {
                txtInputHistory.Text = "Unable to divide by zero";
            }
            else
            {
                operand1 = Double.Parse(txtCurrentInput.Text);
                if (negative == true)
                {
                    operand1 = operand1 * -1;
                }
                answer = 1 / operand1;
                txtInputHistory.Text = "1 / " + operand1.ToString();
                txtCurrentInput.Text = answer.ToString();
                negative = false;
            }
        }
        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
                operand1 = Double.Parse(txtCurrentInput.Text);
            if (negative == true)
            {
                txtInputHistory.Text = "Unable to find square root of a negative number";
                txtCurrentInput.Text = "0";
                negative = false;
            }
            else
            {
                operation = '√';
                txtInputHistory.Text = operation + operand1.ToString();
                answer = Math.Sqrt(operand1);
                txtCurrentInput.Text = answer.ToString();
                negative = false;
            }
        }
        #endregion

        #region Keyboard Commands
        private void Calculator_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            KeyPress += Calculator_KeyPress;
        }

        void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case 8:
                    btnDelete_Click(btnDelete, new EventArgs());
                    break;

                case 42:
                    btnMultiply_Click(btnMultiply, new EventArgs());
                    break;

                case 43:
                    btnAdd_Click(btnAdd, new EventArgs());
                    break;

                case 45:
                    btnSubtract_Click(btnSubtract, new EventArgs());
                    break;

                case 46:
                    btnDecimal_Click(btnDecimal, new EventArgs());
                    break;

                case 47:
                    btnDivide_Click(btnDivide, new EventArgs());
                    break;

                case 48:
                    btnZero_Click(btnZero, new EventArgs());
                    break;

                case 49:
                    btnOne_Click(btnOne, new EventArgs());
                    break;

                case 50:
                    btnTwo_Click(btnTwo, new EventArgs());
                    break;

                case 51:
                    btnThree_Click(btnThree, new EventArgs());
                    break;

                case 52:
                    btnFour_Click(btnFour, new EventArgs());
                    break;

                case 53:
                    btnFive_Click(btnFive, new EventArgs());
                    break;

                case 54:
                    btnSix_Click(btnSix, new EventArgs());
                    break;

                case 55:
                    btnSeven_Click(btnSeven, new EventArgs());
                    break;

                case 56:
                    btnEight_Click(btnEight, new EventArgs());
                    break;

                case 57:
                    btnNine_Click(btnNine, new EventArgs());
                    break;

                default:
                    e.Handled = true;
                    break;
            }
        }
        #endregion

    }
}
