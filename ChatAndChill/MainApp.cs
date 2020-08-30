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

namespace ChatAndChill
{
    public partial class MainApp : Form
    {
        public string CurrentUserName { get; set; }
        public List<string> UsersConnected { get; set; }
        public short CharUses { get; set; }
        public string MessageToSend { get; set; }
        public byte[] EncodedMessage { get; set; }

        public ConnectClient client;

        public MainApp()
        {
            InitializeComponent();

            client = new ConnectClient(this);

            CurrentUserName = "Guest01";
            UsersConnected = new List<string>();

            CharUses = 0;
            MaxCharUses_label.Text = CharUses.ToString() + "/" + Message_textBox.MaxLength.ToString();

            UpdateVisuals();
            UpdateConnectedUsersList();
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            UpdateVisuals();
        }

        private void MaxCharUses_label_TextChanged(object sender, EventArgs e)
        {
            UpdateVisuals();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to close this app?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void UpdateVisuals()
        {
            MessagesHolder_textBox.Size = new Size(panel1.Size.Width - 250, MessagesHolder_textBox.Size.Height);
            UserInfo_label.Left = MaxCharUses_label.Right + 10;
            Send_button.Left = Message_textBox.Right - 75;
            groupBox3.Height = panel2.Height - groupBox2.Height - 5;
        }

        public void UpdateConnectedUsersList()
        {
            list_ConnectedUsers.Items.Clear();
            foreach (string user in UsersConnected) 
            { 
                if (user != "")
                {
                    ListViewItem item = new ListViewItem(user);
                    item.Group = list_ConnectedUsers.Groups[0];
                    list_ConnectedUsers.Items.Add(item);
                }
            }
        }

        private void Message_textBox_TextChanged(object sender, EventArgs e)
        {
            CharUses = (short)Message_textBox.Text.Length;
            MaxCharUses_label.Text = CharUses.ToString() + "/" + Message_textBox.MaxLength.ToString();
            MessageToSend = Message_textBox.Text;
        }

        private void MessagesHolder_textBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox textBox = (RichTextBox)sender;
            textBox.SelectionStart = textBox.Text.Length;
            textBox.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameChanger_textBox.TextLength >= 3)
            {
                CurrentUserName = NameChanger_textBox.Text;
                NameChanger_textBox.Text = "";
            }
            UserInfo_label.Text = "Chating as: " + CurrentUserName;
        }

        private void NameChanger_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '\b')
                || (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                return;
            }

            e.Handled = true;
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            if (Message_textBox.Text != "")
            {
                client.Send_Click();
                Message_textBox.Text = "";
            }
        }

        private void Message_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Send_button.PerformClick();
                e.Handled = true;
            }
        }

        private void hostAServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("DedicatedServer.exe");
            }
            catch
            {
                MessageBox.Show("Sorry, i can't find DedicatedServer.exe!", "Executable missing.", MessageBoxButtons.OK);
            }
            
        }

        private void connectToServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.Show();
            }
            else
            {
                client = new ConnectClient(this);
                client.Show();
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateConnectedUsersList();
        }
    }
}
