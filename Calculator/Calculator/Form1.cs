using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * PORTFOLIO ACTIVITY 1.6
 * Supanat Kakanaporn
 * ID: 445682
 * Using the previous activities create a three (3) new math libraries with the following methods
    Arithmetic
         Addition
         Subtraction
         Division
         Multiplication
    Trigonometric
         Tan
         Sine
         Cosine
    Algebraic
         Square Root
         Cube Root
         Inverse
 * Criteria
    Each of these methods will require some research to ensure the correct values are displayed. 
    For example the Tan(90o) is undefined and your calculator should display an “invalid” message. 
    Check the MSDN web site for information and sample code for each trigonometric function to ensure correct functionality.
    Testing
    Create a test table for each method with a range of valid and invalid data. 
    Record your results in a table with screen shots in a formal report.
 */


namespace Calculator
{
    public partial class Calculator : Form
    {
        //Gobal variables
        //variable to hold operands
        public double Var1 = 0.0;// first input
        public double Var2 = 0.0;// second input or display value
        //variable to hold Operater
        public bool Plus = false;
        public bool Minus = false;
        public bool Divide = false;
        public bool Multiply = false;
        

        public Calculator()
        {
            InitializeComponent();
        }
        #region Button values
        // Set the values to the value of the button
        private void btnOne_Click(object sender, EventArgs e)//Button number 1
        {
            tbDisplay.Text = tbDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)//Button number 2
        {
            tbDisplay.Text = tbDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)//Button number 3
        {
            tbDisplay.Text = tbDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)//Button number 4
        {
            tbDisplay.Text = tbDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)//Button number 5
        {
            tbDisplay.Text = tbDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)//Button number 6
        {
            tbDisplay.Text = tbDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)//Button number 7
        {
            tbDisplay.Text = tbDisplay.Text + btnSeven.Text;
        }

        private void btnEigth_Click(object sender, EventArgs e)//Button number 8
        {
            tbDisplay.Text = tbDisplay.Text + btnEigth.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)//Button number 9
        {
            tbDisplay.Text = tbDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)//Button number 0
        {
            tbDisplay.Text = tbDisplay.Text + btnZero.Text;
        }

        //Button for decimal point
        private void btnDot_Click(object sender, EventArgs e)
        {
           
            if (tbDisplay.Text == "")//check if text box dis play is empty will shown '0.'
            {
                tbDisplay.Text = "0.";
            }
            else if (!tbDisplay.Text.Contains("."))//check dot already present or not
            {
                tbDisplay.Text = tbDisplay.Text + btnDot.Text;
            }

        }
        //Button Plus or Minus
        private void btnPoM_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Contains("-"))//check the '-' sign is exits or not
            {
                tbDisplay.Text = tbDisplay.Text.Remove(0, 1);
            }
            else
            {
                tbDisplay.Text = "-" + tbDisplay.Text;
            }
        }

        #endregion

        #region Button Operations
        //Button clear text box
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
        }
        // Button Addition
        private void btnPlus_Click(object sender, EventArgs e)
        {
            try//This exception handler for protected empty value input when press the buttons
            {
                Var1 += double.Parse(tbDisplay.Text);
                tbDisplay.Clear();

                Plus = true; //Check operator are used
                Minus = false;
                Divide = false;
                Multiply = false;
            }
            catch (Exception ex)
            {

            }

        }
        //Button Subtraction
        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                Var1 += double.Parse(tbDisplay.Text);
                tbDisplay.Clear();

                Plus = false;
                Minus = true;
                Divide = false;
                Multiply = false;
            }
            catch (Exception ex)
            {

            }
            
        }
        //Button Division
        private void btnDiv_Click(object sender, EventArgs e)
        {
            try 
            {
                Var1 += double.Parse(tbDisplay.Text);
                tbDisplay.Clear();

                Plus = false;
                Minus = false;
                Divide = true;
                Multiply = false;
            }
            catch (Exception ex)
            {
                
            }
            
        }
        //Button Multiplication
        private void btnMult_Click(object sender, EventArgs e)
        {
            try
            {
                Var1 += double.Parse(tbDisplay.Text);
                tbDisplay.Clear();

                Plus = false;
                Minus = false;
                Divide = false;
                Multiply = true;
            }
            catch (Exception ex)
            {

            }
        }
        //Button function squareRoot
        private void btnSQRT_Click(object sender, EventArgs e)
        {
            try
            {
                Var2 = double.Parse(tbDisplay.Text);
                //Display 'Invalid' and show message box when recieve zero;
                if (Var2 >= 0)
                {
                    tbDisplay.Text = Algebraic.Algebraic.sqrt(Var2).ToString();
                }
                else
                {
                    tbDisplay.Text = "Invalid";
                    MessageBox.Show("Number must be positive", "Error Message");
                }
            }
            catch (Exception ex)
            {

            }
        }
        //Button functon Cube root
        private void btnCubeRT_Click(object sender, EventArgs e)
        {
            double negNum = 0.0;// to holding the negative number
            try
            {
                Var2 = double.Parse(tbDisplay.Text);
                if (Var2 <= 0)// if value less than zero
                {
                    Var2 = 0 - Var2; //convert to the positive value
                    negNum = -Algebraic.Algebraic.cubeRT(Var2);//do the cube root and convert to the negative value
                    tbDisplay.Text = negNum.ToString();// display
                }
                else
                {
                    tbDisplay.Text = Algebraic.Algebraic.cubeRT(Var2).ToString();
                }    
            }
            catch (Exception ex)
            {

            }
        }
        // Buttton function Inverse
        private void btnInv_Click(object sender, EventArgs e)
        {

            try
            {
                Var2 = double.Parse(tbDisplay.Text);
                //Display 'Invalid' and show message box when recieve zero;
                if (Var2 != 0)
                {
                    tbDisplay.Text = Algebraic.Algebraic.inv(Var2).ToString();
                }
                else
                {
                    tbDisplay.Text = "Invalid";
                    MessageBox.Show("Can not dividing by zero");
                }
            }
            catch (Exception ex)
            {

            }
        }
        // BUtton Tan function
        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                Var2 = double.Parse(tbDisplay.Text);
                //Display 'Invalid' and show message box when Trigonometric Tan at 90 Degrees; 
                if (Var2 != 90)
                {
                    tbDisplay.Text = Trigonometric.Trigonometric.tan(Var2).ToString();
                }
                else
                {
                    tbDisplay.Text = "Invalid";
                    MessageBox.Show("Tan at 90 degree is Undefine");
                }
            }
            catch (Exception ex)
            {

            }
            
            
        }
        // BUtton Sin function
        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                Var2 = double.Parse(tbDisplay.Text);
                tbDisplay.Text = Trigonometric.Trigonometric.sin(Var2).ToString();
            }
            catch (Exception ex)
            {

            }
        }
        // BUtton Cos function
        private void btnCos_Click(object sender, EventArgs e)
        {

            try
            {
                Var2 = double.Parse(tbDisplay.Text);
                tbDisplay.Text = Trigonometric.Trigonometric.cos(Var2).ToString();
            }
            catch (Exception ex)
            {

            }
        }

        // Button Equal by using if statement and boolean verification
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if (Plus == true)
                {
                    Var2 = Arithmetic.Arithmetic.Add( Var1, double.Parse(tbDisplay.Text));
                    tbDisplay.Text = Convert.ToString(Var2);
                }
                else if (Minus == true)
                {
                    Var2 = Arithmetic.Arithmetic.Sub( Var1, double.Parse(tbDisplay.Text));
                    tbDisplay.Text = Convert.ToString(Var2);
                }
                else if (Divide == true)
                {   //Display 'Invalid' and show message box when recieve zero;
                    if (double.Parse(tbDisplay.Text) != 0) 
                    {
                        Var2 = Arithmetic.Arithmetic.Div(Var1, double.Parse(tbDisplay.Text));
                        tbDisplay.Text = Convert.ToString(Var2);
                    }
                    else
                    {
                        tbDisplay.Text = "Invalid";
                        MessageBox.Show("Can not dividing by zero");
                    }  
                }
                else if (Multiply == true)
                {
                    Var2 = Arithmetic.Arithmetic.Mult(Var1, double.Parse(tbDisplay.Text));
                    tbDisplay.Text = Convert.ToString(Var2);
                }
                
                //Set value to default
                Var1 = 0;
                Plus = false;
                Minus = false;
                Divide = false;
                Multiply = false;
            }
            catch (Exception ex)
            {

            }  
        }
        #endregion

        //Method for menu (File -> quit)
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) ==
                DialogResult.OK)// will show message option box OK/Cancel  
            {
                Application.Exit();//Do exit program
            }
        }

        //Method for menu (File -> clear)
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();//Clear the textbox
        }
   
    }
}