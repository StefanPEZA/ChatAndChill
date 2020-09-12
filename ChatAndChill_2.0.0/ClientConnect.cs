using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChatAndChill_2._0._0
{
    public partial class ClientConnect : Form
    {
        public static Main mainApp;
        public ClientConnect()
        {
            InitializeComponent();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (text_IP.Text == "" || text_NickName.Text == "" || text_PORT.Text == "")
            {
                MessageBox.Show("Fill in all text fields.", "Info required!", MessageBoxButtons.OK);
            }
            else
            {
                string ip = text_IP.Text;
                ushort port = ushort.Parse(text_PORT.Text);
                string name = text_NickName.Text;

                try
                {
                    if (Main.clientHandle.Connect(ip, port, name))
                    {
                        Main.CurrentName = name;
                        mainApp.toolStripMenuItem2.Enabled = true;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Server connection timed out, try again!", "Connection error!", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
                }
            }
        }

        private void ClientConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.connectForm = null;
        }

        private void text_PORT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void text_IP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9') 
                && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
            {
                e.Handled = true;
            }
        }

        private void text_NickName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9')
                && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
            {
                e.Handled = true;
            }
        }
    }
}
