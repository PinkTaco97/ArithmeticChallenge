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
        /// The DataTable for the array of questions.
        /// </summary>
        public DataTable arrayTable;

        /// <summary>
        /// The Array of questions asked to the student.
        /// </summary>
        List<Question> questions = new List<Question>();

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

            //Create the Array Table
            arrayTable = new DataTable();

            //Add the columns to the table
            arrayTable.Columns.Add("A");
            arrayTable.Columns.Add("Operator");
            arrayTable.Columns.Add("B");
            arrayTable.Columns.Add("=");
            arrayTable.Columns.Add("X");
            arrayTable.Columns.Add("Answer");

            //Set the Student Datas Data Source.
            ArrayDataTable.DataSource = arrayTable;

            //Hide the boders on the cells.
            ArrayDataTable.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            ArrayDataTable.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            //ArrayDataTable.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            //ArrayDataTable.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

            //Setup the columns.
            foreach (DataGridViewColumn column in ArrayDataTable.Columns)
            {
                //Set the column sort mode.
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                //Set the column header allignment. 
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //Set the column to autosize.
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        /// <summary>
        /// Called when the value is changed in the Input_A field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_A_ValueChanged(object sender, EventArgs e)
        {
            Output_Answer.Text = "" + Calculate(Input_A.Value, Input_Operator.SelectedIndex, Input_B.Value);
        }

        /// <summary>
        /// Called when the selected index is changed in the Input_Operator field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_Operator_SelectedIndexChanged(object sender, EventArgs e)
        {
            Output_Answer.Text = "" + Calculate(Input_A.Value, Input_Operator.SelectedIndex, Input_B.Value);
        }

        /// <summary>
        /// Called when the value is changed in the Input_B field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_B_ValueChanged(object sender, EventArgs e)
        {
            Output_Answer.Text = "" + Calculate(Input_A.Value, Input_Operator.SelectedIndex, Input_B.Value);
        }

        /// <summary>
        /// Calculate the outcome of the question.
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="op">The operator</param>
        /// <param name="b">The second number</param>
        /// <returns>The Answer</returns>
        private decimal Calculate(decimal a, int op, decimal b)
        {
            //The output
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

                        //Round x to 2 decimal places.
                        x = Math.Round(x, 2);
                        break;
                }
            }

            //return the output
            return x;
        }

        /// <summary>
        /// Called when the send button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Send_Click(object sender, EventArgs e)
        {
            //Add the question to the array.
            questions.Add(new Question(Input_A.Value, Input_Operator.SelectedIndex, Input_B.Value));

            //Update the array table.
            UpdateArrayTable();
        }

        /// <summary>
        /// Refresh the Array Table.
        /// </summary>
        private void UpdateArrayTable()
        {
            //Clear the Data Table.
            arrayTable.Clear();

            //Create the new row.
            DataRow row;

            //List of all unanswered questions.
            List<int> unansweredQuestions = new List<int>();

            //Foreach question in the array.
            foreach (Question question in questions)
            {
                //Create a new row.
                row = arrayTable.NewRow();

                //Add the data to the row.
                row[0] = question.a;
                row[1] = question.operatorSymbol;
                row[2] = question.b;
                row[3] = "=";
                row[4] = question.x;
                row[5] = "";

                //Add the row to the table.
                arrayTable.Rows.Add(row);

                if (!question.answered)
                {
                    unansweredQuestions.Add(ArrayDataTable.RowCount - 1);
                }
            }

            foreach (int i in unansweredQuestions)
            {
                ArrayDataTable.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            }

            //Clear the current selection.
            ArrayDataTable.ClearSelection();
        }

        /// <summary>
        /// Called when the selection is changed on the Array Table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArrayTable_SelectionChanged(object sender, EventArgs e)
        {
            ArrayDataTable.ClearSelection();
        }

        /// <summary>
        /// Called when the Random button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Random_Click(object sender, EventArgs e)
        {
            //Create a new Random number.
            Random rand = new Random();

            //Randomise the question.
            int a = rand.Next(0, 1000);
            int op = rand.Next(0, 3);
            int b = rand.Next(0, 1000);

            //Set the question fields to the random numbers.
            Input_A.Value = a;
            Input_Operator.SelectedIndex = op;
            Input_B.Value = b;

        }
    }
}
