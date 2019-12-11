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
 Trevor Carver
 3/13/19
 CITPT 206 Midterm 1
 The goal of this assignment is to create a windows calculator.
 To do this we need to:
 1.) Design the form similar to a windows calculator.(Numbers 0-9, +,-,*,/, =, . , and Clear)
 2.) Create a click event for each number button that puts the equivalent value in the input textbox.(when you click 1 it displays 1, 2 displays 2 etc....)
 3.) Create a click event for each operator button which clears the textbox, displays the user input in a label above the text + the operator chosen, and stores the value in the result variable.
 4.) Add if statements to find the correct result depending on what the user entered.
 EX: if user enters 1, hits + and enters 1 again it should display 2 + in the label and clear the textbox(same with -, *, /)
 It should continue until the user hits clear. The user should be able to perform any operation.
 5.) Create a click event for the equals button which gets the result, clears the label, and outputs the result to the textbox.
 6.) Add try-catch statements to prevent the app from crashing.
 // FormatException(when the user enters something other than a valid decimal/integer number.
 // DivideByZeroException(when the user tries to divide by 0)
 7.) Test your application to make sure your catch blocks and if statements work properly.
 8.) If everything works properly save and submit.

 */
namespace WindowsCalculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        // Declares 4 "global" variables that we use to store each part of the equation
        // The first and second numbers, the Operator, the result, and the result rounded to 12 decimal places.
        decimal result = 0;
        decimal roundedResult = 0;       
        
        //Sets the value of the textbox to 1 when button is clicked 
        private void btn_1_Click(object sender, EventArgs e)
        {
            txtInput.Text += "1";
        }

        //Sets the value of the textbox to 0 when button is clicked 
        private void btn_0_Click(object sender, EventArgs e)
        {
            txtInput.Text += "0";
        }

        // Performs the calculation when the button is clicked.
        private void btn_Equals_Click(object sender, EventArgs e)
        {
            try
            {
                // Throws up a message box if the user failed to enter a value or entered just a decimal.
                if (txtInput.Text == "" || txtInput.Text == ".")
                {
                    MessageBox.Show("Please enter a valid input.", "Entry Error");
                }
                // Runs if the user is trying to add to a negative number when the equal button is clicked.
                // Calculates the result, rounds it to 12 decimal places, clears the label, and places the roundedResult in the textbox.
                else if (lblOperation.Text.Contains("-") && lblOperation.Text.Contains("+"))
                {
                    result = result + Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    txtInput.Text = roundedResult.ToString();
                    result = 0;
                    lblOperation.Text = "";
                }
                // Runs if the user is trying to multiply with a negative number when the equal button is clicked.
                // Calculates the result, rounds it to 12 decimal places, clears the label, and places the roundedResult in the textbox.
                else if (lblOperation.Text.Contains("-") && lblOperation.Text.Contains("*"))
                {
                    result = result * Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    txtInput.Text = roundedResult.ToString();
                    result = 0;
                    lblOperation.Text = "";
                }
                // Runs if the user is trying to divie with a negative number when the equal button is clicked.
                // Calculates the result, rounds it to 12 decimal places, clears the label, and places the roundedResult in the textbox.
                else if (lblOperation.Text.Contains("-") && lblOperation.Text.Contains("/"))
                {
                    result = result / Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    txtInput.Text = roundedResult.ToString();
                    result = 0;
                    lblOperation.Text = "";
                }
                
                // Runs if the user is trying to add when the equal button is clicked.
                // Calculates the result, rounds it to 12 decimal places, clears the label, and places the roundedResult in the textbox.
                else if (lblOperation.Text.Contains("+"))
                {
                    result = result + Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    txtInput.Text = roundedResult.ToString();
                    result = 0;
                    lblOperation.Text = "";
                }
                // Runs if the user is trying to subtract when the equal button is clicked.
                // Calculates the result, rounds it to 12 decimal places, clears the label, and places the roundedResult in the textbox.
                else if (lblOperation.Text.Contains("-"))
                {
                    result = result - Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    txtInput.Text = roundedResult.ToString();
                    result = 0;
                    lblOperation.Text = "";
                }
                // Runs if the user is trying to mutliply when the equal button is clicked.
                // Calculates the result, rounds it to 12 decimal places, clears the label, and places the roundedResult in the textbox.
                else if (lblOperation.Text.Contains("*"))
                {
                    result = result * Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    txtInput.Text = roundedResult.ToString();
                    result = 0;
                    lblOperation.Text = "";
                }
                // Runs if the user is trying to divide when the equal button is clicked.
                // Calculates the result, rounds it to 12 decimal places, clears the label, and places the roundedResult in the textbox.
                else if (lblOperation.Text.Contains("/"))
                {
                    result = result / Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    txtInput.Text = roundedResult.ToString();
                    result = 0;
                    lblOperation.Text = "";
                }                                        
            }
            
            // Occurs when the user tries to hit equals without first making sure he puts in two values and an operator
            catch (FormatException)
            {
                lblOperation.Text = "";
                MessageBox.Show("Please Enter a valid input.", "Entry Error");
            }
            // Prevents the application from breaking when the user divides by 0
            catch (DivideByZeroException)
            {
                lblOperation.Text = "";
                MessageBox.Show("You cannot divide by 0!", "Entry Error");
            }
            catch (OverflowException)
            {
                lblOperation.Text = "";
                MessageBox.Show("Number is too large to compute!");
            }
            
        }
        //Sets the value of the textbox to 2 when button is clicked 
        private void btn_2_Click(object sender, EventArgs e)
        {
            txtInput.Text += "2";
      
        }
        //Sets the value of the textbox to 3 when button is clicked 
        private void btn_3_Click(object sender, EventArgs e)
        {           
            txtInput.Text += "3";
           
        }
        //Sets the value of the textbox to 4 when button is clicked 
        private void btn_4_Click(object sender, EventArgs e)
        {            
            txtInput.Text += "4";           
        }
        //Sets the value of the textbox to 5 when button is clicked 
        private void btn_5_Click(object sender, EventArgs e)
        {
            txtInput.Text += "5";
        }
        //Sets the value of the textbox to 6 when button is clicked 
        private void btn_6_Click(object sender, EventArgs e)
        {
            txtInput.Text += "6";
        }
        //Sets the value of the textbox to 7 when button is clicked 
        private void btn_7_Click(object sender, EventArgs e)
        {
            txtInput.Text += "7";
        }
        //Sets the value of the textbox to 8 when button is clicked 
        private void btn_8_Click(object sender, EventArgs e)
        {
            txtInput.Text += "8";
        }
        //Sets the value of the textbox to 9 when button is clicked 
        private void btn_9_Click(object sender, EventArgs e)
        {
            txtInput.Text += "9";
        }
        // Clears the values of the textbox and the label when clicked
        private void btnClear_Click(object sender, EventArgs e)
        {   
            txtInput.Text = "";
            lblOperation.Text = "";
            result = 0;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {   //Runs if the user fails to enter anything or enters just a decimal
                if (txtInput.Text == "" || txtInput.Text == ".")
                {
                    MessageBox.Show("Please enter a valid input.", "Entry Error");
                }
                // Runs if the user tries to divide when they were already trying to add
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the division symbol
                else if (lblOperation.Text.Contains("+"))
                {
                    result = result + Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "/";
                    txtInput.Clear();
                }
                // Runs if the user clicks divide while already performing a division operation
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the division symbol
                else if (lblOperation.Text.Contains("/"))
                {
                    result = result / Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "/";
                    txtInput.Clear();
                }
                // Runs if the user clicks Multiply while already performing a division operation
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the division symbol
                else if (lblOperation.Text.Contains("*"))
                {
                    result = result * Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "/";
                    txtInput.Clear();
                }
                // Runs if the user clicks subtract while already performing a division operation
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the division symbol
                else if (lblOperation.Text.Contains("-"))
                {
                    result = result - Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "/";
                    txtInput.Clear();
                }
                // Runs if nothing else runs
                // Essentially runs the 1st time you hit divide(assuming you haven't hit anything else)
                //Sets the result to the number you entered, rounds the result to 12 decimal places, Sets the label to the roundedResult + the operator, and clears the textbox.
                else
                {                               
                    result = Decimal.Parse(txtInput.Text); 
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "/";
                    txtInput.Clear();
                }
            }
            //Runs if the user enters anything than a number inside the textbox 
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid input.", "Entry Error");
            }
            //Runs if the user tries to divide by 0
            catch (DivideByZeroException)
            {
                MessageBox.Show("You cannot divide by 0!", "Error");
            }
            catch (OverflowException)
            {
                lblOperation.Text = "";
                MessageBox.Show("Number is too large to compute!");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                //Runs if the user fails to enter anything or enters just a decimal
                if (txtInput.Text == "" || txtInput.Text == ".")
                {
                    MessageBox.Show("Please enter a valid input.", "Entry Error");
                }
                // Runs if the user clicks Add(+) while already performing a multiplication operation 
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the multiplication symbol
                else if (lblOperation.Text.Contains("+"))
                {
                    result = result + Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "*";
                    txtInput.Clear();
                }
                // Runs if the user clicks Divide(/) while already performing a multiplication operation 
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the multiplication symbol
                else if (lblOperation.Text.Contains("/"))
                {
                    result = result / Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "*";
                    txtInput.Clear();
                }
                // Runs if the user clicks Multiply(*) while already performing a multiplication operation 
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the multiplication symbol
                else if (lblOperation.Text.Contains("*"))
                {
                    result = result * Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "*";
                    txtInput.Clear();
                }
                // Runs if the user clicks Subtract(-) while already performing a multiplication operation 
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the multiplication symbol
                else if (lblOperation.Text.Contains("-"))
                {
                    result = result - Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "*";
                    txtInput.Clear();
                }
                //Runs on the first instance of you pressing the multiply button(assuming you haven't hit any other operator)
                //Sets the result to the user input, rounds it to 12 decimal places, clears the textbox, and sets the label text to the roundedResult + the multiplication symbol.
                else
                {
                    result = Decimal.Parse(txtInput.Text);
                    txtInput.Clear();
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "*";

                }
            }
            //Runs if the user enters anything besides a number in the textbox
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid input.", "Entry Error");
            }
            //Runs if the user tries to divide by 0
            catch (DivideByZeroException)
            {
                MessageBox.Show("You cannot divide by 0!", "Error");
            }
            catch (OverflowException)
            {
                lblOperation.Text = "";
                MessageBox.Show("Number is too large to compute!");
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Runs if the user fails to enter anything or enters just a decimal
                if (txtInput.Text == "" || txtInput.Text == ".")
                {
                    MessageBox.Show("Please enter a valid input.", "Entry Error");
                }
                // Runs if the user clicks Add(+) while already performing a subtraction operation 
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the subtraction symbol
                else if (lblOperation.Text.Contains("+"))
                {
                    result = result + Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "-";
                    txtInput.Clear();
                }
                // Runs if the user clicks Divide(/) while already performing a subtraction operation 
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the subtraction symbol
                else if (lblOperation.Text.Contains("/"))
                {
                    result = result / Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "-";
                    txtInput.Clear();

                }
                // Runs if the user clicks Multiply(*) while already performing a subtraction operation 
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the subtraction symbol
                else if (lblOperation.Text.Contains("*"))
                {
                    result = result * Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    txtInput.Clear();
                    lblOperation.Text = roundedResult + " " + "-";
                }
                // Runs if the user clicks Subtract(-) while already performing a subtraction operation 
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the subtraction symbol
                else if (lblOperation.Text.Contains("-"))
                {
                    result = result - Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    txtInput.Clear();
                    lblOperation.Text = roundedResult + " " + "-";
                }
                //Runs on the first instance of you pressing the subtract button(assuming you haven't hit any other operator)
                //Sets the result to the user input, rounds it to 12 decimal places, clears the textbox, and sets the label text to the roundedResult + the subtraction symbol.
                else
                {                    
                    result = Decimal.Parse(txtInput.Text);
                    txtInput.Clear();
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "-";
                }
            }    
            //Runs if the user tries to enter anything besides a number in the textbox.
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid input.", "Entry Error");
            }
            //Runs if the user tries to divide by 0
            catch (DivideByZeroException)
            {
                MessageBox.Show("You cannot divide by 0!", "Error");
            }
            catch (OverflowException)
            {
                lblOperation.Text = "";
                MessageBox.Show("Number is too large to compute!");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //Runs if the user fails to enter anything or enters just a decimal
                if (txtInput.Text == "" || txtInput.Text == ".")
                {
                    MessageBox.Show("Please enter a valid input.", "Entry Error");
                }
                // Runs if the user is trying to add to a negative number when the Add button is clicked.
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the label text to the roundedResult + the addition symbol
                else if (lblOperation.Text.Contains("-") && lblOperation.Text.Contains("+"))
                {
                    result = result + Decimal.Parse(txtInput.Text);
                    txtInput.Clear();
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "+";
                }
                // Runs if the user clicks Subtract(-) while already performing an addition operation 
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the addition symbol
                else if (lblOperation.Text.Contains("-"))
                {
                    result = result - Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "+";
                    txtInput.Clear();
                }
                // Runs if the user clicks Multiply(*) while already performing an addition operation 
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the addition symbol
                else if (lblOperation.Text.Contains("*"))
                {
                    result = result * Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "+";
                    txtInput.Clear();
                }
                // Runs if the user clicks Divide(/) while already performing an addition operation 
                // Calculates the result, rounds it to 12 decimal places, clears the textbox, and sets the text of the label to the roundedResult + the addition symbol
                else if (lblOperation.Text.Contains("/"))
                {
                    result = result / Decimal.Parse(txtInput.Text);
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "+";
                    txtInput.Clear();
                }
                //Runs on the first instance of you pressing the Add button(assuming you haven't hit any other operator)
                //Sets the result to the user input, rounds it to 12 decimal places, clears the textbox, and sets the label text to the roundedResult + the addition symbol.
                else
                {                                  
                    result = result + Decimal.Parse(txtInput.Text);
                    txtInput.Clear();
                    roundedResult = Math.Round(result, 12);
                    lblOperation.Text = roundedResult + " " + "+";
                }          

            }
            //Runs if the user tries to enter anything besides a number into the textbox.
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid input.", "Entry Error");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("You cannot divide by 0!", "Error");
            }
            catch (OverflowException)
            {
                lblOperation.Text = "";
                MessageBox.Show("Number is too large to compute!");
            }
        }

        private void btn_Decimal_Click(object sender, EventArgs e)
        {
            // Creates a Button called Decimal which takes the value of . when clicked(it inherits from the button click event it is within)
            Button DECIMAL = (Button)sender;
            // Runs because the button inherits from the btn_Decimal the text of .
            if(DECIMAL.Text == ".")
            {
                // Only runs once.
                // This prevents the user from continuously clicking the button and adding decimal points.
                // On the first click the textbox does not contain a decimal so it will run, but everytime the button is clicked after that it will not run since 
                // it already contains a decimal point (.)
                if (!txtInput.Text.Contains("."))
                {
                    txtInput.Text += ".";
                }
            }          
        }
        // Prevents the user from entering more than 16 digits. Creates a messagebox if they try to.
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
           if(txtInput.Text.Length > 16)
           {
                MessageBox.Show("You cannot enter more than 16 digits");
           }
        }
    }
}
