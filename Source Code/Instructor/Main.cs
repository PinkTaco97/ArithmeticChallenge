using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;

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
        /// The Binary Tree.
        /// </summary>
        BinaryTree binaryTree = new BinaryTree();

        /// <summary>
        /// The Binary Tree View.
        /// </summary>
        TreeView binaryTreeView = new TreeView();

        /// <summary>
        /// The Array of questions asked to the student.
        /// </summary>
        List<Question> questions = new List<Question>();

        /// <summary>
        /// Colors.
        /// </summary>
        Color green = Color.FromArgb(255, 0, 204, 102);
        Color red = Color.FromArgb(255, 204, 0, 0);

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
            Question question = new Question(Input_A.Value, Input_Operator.SelectedIndex, Input_B.Value);
            
            //Connect to the Student and send the question
            SendQuestion(question);
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

            //The row index.
            int count = 0;

            //Foreach question in the array.
            foreach (Question question in questions)
            {
                //Create a new row.
                row = arrayTable.NewRow();

                //Add the data to the row.
                row[0] = question.a.ToString("0.##");
                row[1] = question.operatorSymbol;
                row[2] = question.b.ToString("0.##");
                row[3] = "=";
                row[4] = question.answer.ToString("0.##");

                //Add the row to the table.
                arrayTable.Rows.Add(row);

                //If the question was answered correctly.
                if (question.correct)
                {
                    //Set the background color of the row in the DataTable.
                    ArrayDataTable.Rows[count].DefaultCellStyle.BackColor = green;
                }
                else
                {
                    //Set the background color of the row in the DataTable.
                    ArrayDataTable.Rows[count].DefaultCellStyle.BackColor = red;
                }

                //Add 1 to the count.
                count++;
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

        /// <summary>
        /// Connect and send a question to the student application.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="question"></param>
        public void SendQuestion(Question question)
        {
            //The IP Address of the student.
            string ip = "127.0.0.1";

            //The open port.
            int port = 5000;

            //Convert the Question Object to a JSON string.
            string json = JsonConvert.SerializeObject(question);

            //Try to create a TCP connection to the student application.
            try
            {
                TcpClient client = new TcpClient(ip, port);

                //Reference to the network stream.
                NetworkStream stream = client.GetStream();

                //Convert the JSON to an array of bytes.
                byte[] data = ASCIIEncoding.ASCII.GetBytes(json);

                //Send the question.
                stream.Write(data, 0, data.Length);

                //Listen for an answer.
                ListenForAnswer();

                //Close the connection.
                client.Close();
            }
            catch (Exception ex)
            {
                //Print the exception to the console.
                Console.WriteLine(ex.Message);

                //Alert the user that the question wasnt sent.
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Listens for an answer for a question.
        /// </summary>
        public void ListenForAnswer()
        {
            //Hide the Question Panel.
            Panel_Question.Visible = false;

            //Show the Waiting Panel.
            Panel_Waiting.Visible = true;

            //Start the background worker
            backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Called when the application needs to wait for an answer.
        /// Completes this task on another thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListenForAnswer(object sender, DoWorkEventArgs e)
        {
            //The IP Address.
            string ip = "127.0.0.1";

            //The open port.
            int port = 5001;

            //Convert the string to an IPAddress.
            IPAddress IP = IPAddress.Parse(ip);

            //Create a TCP Listener.
            TcpListener listener = new TcpListener(IP, port);

            //Start listening.
            listener.Start();

            //Reference to the Connected Client.
            TcpClient client = listener.AcceptTcpClient();

            //Get the incoming data through a network stream.
            NetworkStream stream = client.GetStream();

            //Create a buffer to hold the incoming data.
            byte[] buffer = new byte[client.ReceiveBufferSize];

            //Read the incoming stream.
            int bytes = stream.Read(buffer, 0, client.ReceiveBufferSize);

            //Convert the data received into a string.
            string data = Encoding.ASCII.GetString(buffer, 0, bytes);

            //Convert the string to a Question object.
            Question question = JsonConvert.DeserializeObject<Question>(data);

            //Refresh the Symbol.
            question.RefreshSymbol();

            //Add the question to the array.
            questions.Add(question);

            //Add the question to the Binary Tree.
            binaryTree.AddQuestion(question);

            //Close the Client connection.
            client.Close();

            //Stop listening for an answer.
            listener.Stop();
        }

        /// <summary>
        /// Called when the application recieves an answer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FoundAnswer(object sender, RunWorkerCompletedEventArgs e)
        {
            //Hide the Waiting Panel.
            Panel_Waiting.Visible = false;

            //Show the Question Panel.
            Panel_Question.Visible = true;

            //Update the array table.
            UpdateArrayTable();
        }

        /// <summary>
        /// Called when the Seleted Index for the TabControl Changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControl_SelectedIndex_Changed(object sender, EventArgs e)
        {
            //Console.WriteLine(TabControl.SelectedIndex);
            //If we are on the Binary Tree Tab.
            if (TabControl.SelectedIndex == 2)
            {
                binaryTree.Traverse();
                binaryTree.Print();
                Console.WriteLine("Test");
            }
        }

        //Displays a binary tree in a tree view
        private void DisplayTree(BinaryTree binaryTree)
        {
            //If the Binary Tree has a root node.
            if(binaryTree.root != null)
            {

            }
        }
    }
}
