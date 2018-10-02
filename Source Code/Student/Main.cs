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
            //Start to listen for a question.
            ListenForQuestion();
        }

        /// <summary>
        /// Called when we are waiting for a question.
        /// </summary>
        public void ListenForQuestion()
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
            Question question = JsonConvert.DeserializeObject<Question>(output);

            //Alert the user.
            MessageBox.Show(question.a + " " + question.operatorSymbol + " " + question.b + " = " + question.x);

            //Close the Client connection.
            client.Close();

            //Stop listening for an answer.
            listener.Stop();
        }

        /// <summary>
        /// Connect and send the question back to the instructor application.
        /// </summary>
        /// <param name="question"></param>
        public void SendQuestion(Question question)
        {
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
    }
}
