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

namespace Instructor
{
    public partial class Connecting : Form
    {
        /// <summary>
        /// The Constructor.
        /// </summary>
        public Connecting()
        {
            //Initialize all the form components.
            InitializeComponent();
        }

        /// <summary>
        /// Called when the window has loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connecting_Load(object sender, EventArgs e)
        {
            //Try to connect to the student application.
            Connect();
        }

        /// <summary>
        /// Try to connect to the student application.
        /// </summary>
        public void Connect()
        {
            try
            {
                IPAddress ipAd = IPAddress.Parse("192.168.1.14");
                // use local m/c IP address, and 
                // use the same in the client

                /* Initializes the Listener */
                TcpListener listener = new TcpListener(ipAd, 8001);

                /* Start Listeneting at the specified port */
                listener.Start();

                Output.Text = "Connecting...";
                ProgressBar.Value = 25;

                Console.WriteLine(listener.Pending());

                //while (!listener.Pending())
                //{
                    Socket s = listener.AcceptSocket();
                    Output.Text = "Connection accepted from " + s.RemoteEndPoint;
                    ProgressBar.Value = 50;

                    byte[] b = new byte[100];
                    int k = s.Receive(b);
                    Output.Text = "Recieved...";
                    ProgressBar.Value = 75;
                    for (int i = 0; i < k; i++)
                        Console.Write(Convert.ToChar(b[i]));

                    ASCIIEncoding asen = new ASCIIEncoding();
                    s.Send(asen.GetBytes("The string was recieved by the server."));
                    Console.WriteLine("\nSent Acknowledgement");
                    /* clean up */
                    s.Close();
                //}
                
                listener.Stop();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }
        }
    }
}
