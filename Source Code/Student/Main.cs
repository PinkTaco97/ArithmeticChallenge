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

namespace Student
{
    public partial class Main : Form
    {

        //The current Question.
        Question question;

        /// <summary>
        /// The constructor.
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the Main form is shown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Shown(object sender, EventArgs e)
        {
            //Start listening for a question.
            ListenForQuestion();
        }

        /// <summary>
        /// Start listening for a question.
        /// </summary>
        public void ListenForQuestion()
        {
            //Set the labels text
            Label.Text = "Waiting for Question...";

            // Start the asynchronous operation.
            backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Connect and send the question back to the instructor application.
        /// </summary>
        /// <param name="question"></param>
        public void SendQuestion()
        {
            //Hide the Loading panel.
            Panel_Answer.Visible = false;

            //Show the Answer panel.
            Panel_Loading.Visible = true;

            //Set the labels text
            Label.Text = "Sending Answer...";

            //The IP Address of the student.
            string ip = "127.0.0.1";

            //The open port.
            int port = 5001;

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
                ListenForQuestion();

                //Close the connection.
                client.Close();
            }
            catch (Exception ex)
            {
                //Print the exception to the console.
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Called when the application needs to wait for a question.
        /// Completes this task on another thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListenForQuestion(object sender, DoWorkEventArgs e)
        {
            //The IP Address.
            string ip = "127.0.0.1";

            //The open port.
            int port = 5000;

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
            int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);

            //Convert the data received into a string.
            string output = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            //Deserialize the Question object.
            question = JsonConvert.DeserializeObject<Question>(output);

            //Refresh the Symbol.
            question.RefreshSymbol();

            //Close the Client connection.
            client.Close();

            //Stop listening for an answer.
            listener.Stop();
        }

        /// <summary>
        /// Called when the application recieves a question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FoundQuestion(object sender, RunWorkerCompletedEventArgs e)
        {
            //Hide the Loading panel.
            Panel_Loading.Visible = false;

            //Show the Answer panel.
            Panel_Answer.Visible = true;

            //Set the question.
            Output.Text = question.a.ToString("0.##") + " " + question.operatorSymbol + " " + question.b.ToString("0.##") + " =";
        }

        /// <summary>
        /// Called when the Send button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Send_Click(object sender, EventArgs e)
        {
            //The answer.
            decimal answer;

            //If the user entered a number.
            if (decimal.TryParse(Input.Text, out answer))
            {
                //Set the questions answer.
                question.answer = answer;

                //Mark the question.
                question.Mark();

                //If the question was correct.
                if (question.correct)
                {
                    //Alert the user that the question was corret.
                    MessageBox.Show("Correct!");
                }
                else
                {
                    //Alert the user that the question was incorret.
                    MessageBox.Show("Incorrect!");
                }

                //Send the question.
                SendQuestion();
            }
            else
            {
                //Alert the user to enter a number.
                MessageBox.Show("Please enter a number.");  
            }

            //Empty what the user entered.
            Input.Text = "";
        }

        /// <summary>
        /// Called when a key is down on the Input Text Field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            //If the Key was the Enter Key.
            if (e.KeyCode == Keys.Enter)
            {
                Button_Send_Click(sender, e);
            }
        }

        /// <summary>
        /// Called when a key is pressed on the Input Text Field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow Numbers. Shift and Enter.
            /*if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Enter)) || (e.KeyChar == Convert.ToChar(45)))
            {
                e.Handled = true;
            }*/
        }
    }
}
