using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instructor
{
    /// <summary>
    /// The Main Form Class.
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// The Constructor.
        /// </summary>
        public Main()
        {
            //Initialize the forms components.
            InitializeComponent();

            //Setup any other components.
            SetupComponents();
        }

        /// <summary>
        /// Setup any other components.
        /// </summary>
        public void SetupComponents()
        {
            //Set the divide symbol.
            char symbol = '\u00F7';
            string divide = "" + symbol;

            //Add the menu items to the operator context menu.
            Input_Operator.Items.Add("+");
            Input_Operator.Items.Add("-");
            Input_Operator.Items.Add("x");
            Input_Operator.Items.Add(divide);

            //Set the selected index of the combo box.
            Input_Operator.SelectedIndex = 0;
        }

        /// <summary>
        /// Called when the value is changed in the Input_A field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_A_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        /// <summary>
        /// Called when the selected index is changed in the Input_Operator field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_Operator_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        /// <summary>
        /// Called when the value is changed in the Input_B field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_B_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private decimal Calculate()
        {
            //Get the values from the form.
            //int a = Convert.ToInt32(Input_A.Value);
            decimal a = Input_A.Value;
            int op = Input_Operator.SelectedIndex;
            //int b = Convert.ToInt32(Input_B.Value);
            decimal b = Input_B.Value;
            decimal x = 0;

            //If the numbers are more than 0.
            if(a > 0 && b > 0)
            {
                //perform the correct calculation.
                switch (op)
                {
                    case 0:
                        //Add the 2 numbers.
                        x = a + b;
                        break;

                    case 1:
                        //Subtract the 2 numbers.
                        x = a - b;
                        break;

                    case 2:
                        //Multiply the 2 numbers.
                        x = a * b;
                        break;

                    case 3:
                        //Divide the 2 numbers.
                        x = a / b;
                        break;
                }

                //Set the outputs value.
                Output_Answer.Text = "" + x;
                return x;
            }

            return x;
        }
    }
}
