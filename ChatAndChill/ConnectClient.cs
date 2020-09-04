using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChatAndChill
{
    public partial class ConnectClient : Form
    {
        public MainApp mainApp;
        public ConnectClient(MainApp _mainApp)
        {
            InitializeComponent();
            mainApp = _mainApp;
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            if (textIP.Text != "" && textPort.Text != "")
            {
                Disconnect();
                ipAdress = textIP.Text;
                port = textPort.Text;
                mainApp.MessagesHolder_textBox.Text = "";
                ConnectButton_Click();
            }
            else
            {
                MessageBox.Show("Please give the IP and Port of the server!", "Complete all info!", MessageBoxButtons.OK);
            }
        }

        public TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;
        string clientNames = "";

        public string ipAdress { get; set; }
        public string port { get; set; }

        public void Disconnect()
        {
            try
            {
                if (serverStream != default)
                    serverStream.Close();
                readData = "Disconnecting from Chat Server ...";
                msg();

                if (clientSocket.Connected)
                    clientSocket.Close();
            }
            catch {
            }
            finally
            {
                clientSocket = new System.Net.Sockets.TcpClient();
                serverStream = default(NetworkStream);
            }
        }

        public void Send_Click()
        {
            if (serverStream != null)
            {
                try
                {
                    byte[] outStream = MessageProcessor.EncodeMessage(mainApp.Message_textBox.Text + "¶");
                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();
                }
                catch
                {
                    MessageBox.Show("You are not connected to any server!", "Not connected!", MessageBoxButtons.OK);
                }
            }
        }

        public void ConnectButton_Click()
        {
            try
            {
                clientSocket.Connect(ipAdress, Convert.ToInt32(port));
                serverStream = clientSocket.GetStream();

                readData = "Conected to Chat Server ...";
                msg();

                mainApp.timer1.Enabled = true;

                byte[] outStream = MessageProcessor.EncodeMessage(mainApp.CurrentUserName + "¶");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                Thread ctThread1 = new Thread(getMessage);
                ctThread1.Start();

                this.Hide();
            }
            catch (Exception ex)
            {
                readData = "Error conecting to Chat Server ...";
                msg();
                MessageBox.Show(ex.ToString());
            }
        }

        private void getMessage()
        {
            try
            {
                while (true)
                {

                    serverStream = clientSocket.GetStream();

                    byte[] inStream = new byte[10025];
                    serverStream.Read(inStream, 0, inStream.Length);

                    string tempdata = MessageProcessor.DecodeMessage(inStream);

                    string returndata = "";
                    if (tempdata.IndexOf("«") > 0)
                    {
                        returndata = tempdata.Substring(0, tempdata.IndexOf("«"));
                    }
                    else
                    {
                        returndata = tempdata;
                    }

                    readData = "" + returndata;

                    clientNames = "";
                    clientNames = tempdata.Substring(tempdata.IndexOf("«") + 1, tempdata.IndexOf("»") - tempdata.IndexOf("«") - 1);
                    mainApp.UsersConnected = clientNames.Split("_".ToCharArray()).ToList<string>();

                    msg();
                }
            }
            catch
            {
            }
            return;
        }


        private void msg()
        {
            try
            {
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(msg));
                else
                    mainApp.MessagesHolder_textBox.Text += Environment.NewLine + " >> " + readData;
            }
            catch
            {

            }
        }

        private void ConnectClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
            mainApp.client = null;
        }
    }
}
