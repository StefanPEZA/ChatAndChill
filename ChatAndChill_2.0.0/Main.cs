using System;
using System.Collections.Generic;
using System.Windows.Forms;

using EasyTcp3.ClientUtils;

namespace ChatAndChill_2._0._0
{
    public partial class Main : Form
    {
        public static ClientConnect connectForm = new ClientConnect();
        public static Client clientHandle = new Client();
        public static List<string> clientsList = new List<string>();
        public static string CurrentName { get; set; } = "Guest";

        private int maxLength;
        public Main()
        {
            InitializeComponent();
            Client.mainApp = this;
            ClientConnect.mainApp = this;
            toolStripMenuItem2.Enabled = false;
            UpdateVisuals();
        }

        public void UpdateConnectedUsersList()
        {
            list_connectedUsers.Items.Clear();
            foreach(string name in clientsList)
            {
                list_connectedUsers.Items.Add(name);
            }
        }

        private void UpdateVisuals()
        {
            maxLength = text_MessageSender.MaxLength;
            label1.Text = $"{text_MessageSender.Text.Length}/{maxLength}";
            label2.Text = $"Chating as {CurrentName}";
        }

        public void Disconnect_toolStripMenuItem(object seder, EventArgs e)
        {
            if (Client.tcpClient != null)
            {
                if (Client.tcpClient.IsConnected())
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to disconnect from the server?" + Environment.NewLine + "All chat will be cleared!", "Are you sure?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        toolStripMenuItem2.Enabled = false;
                        clientHandle.Disconnect(CurrentName);
                        text_MessageHolder.Text = "";
                        WriteMessage("You left the chat server!");
                    }
                }
            }
                    
        }

        public void Connect_toolStripMenuItem(object seder, EventArgs e)
        {
            if (connectForm != null)
            {
                connectForm.Show();
            }
            else
            {
                connectForm = new ClientConnect();
                connectForm.Show();
            }
            UpdateVisuals();
        }

        public void Host_toolStripMenuItem(object seder, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("DedicatedServer.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public void Exit_toolStripMenuItem(object seder, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this application?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void WriteMessage(string message)
        {
            string messageToWrite = ">> " + message + Environment.NewLine;
            text_MessageHolder.Text += messageToWrite;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateVisuals();
        }

        private void text_MessageHolder_TextChanged(object sender, EventArgs e)
        {
            text_MessageHolder.SelectionStart = text_MessageHolder.Text.Length;
            text_MessageHolder.ScrollToCaret();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            clientHandle.SendMessage(CurrentName + "\u241E" + text_MessageSender.Text);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientHandle.Disconnect(CurrentName);
        }
    }
}
