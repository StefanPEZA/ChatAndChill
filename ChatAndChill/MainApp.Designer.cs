namespace ChatAndChill
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Connected Users", System.Windows.Forms.HorizontalAlignment.Left);
            this.MaxCharUses_label = new System.Windows.Forms.Label();
            this.MessageArea = new System.Windows.Forms.Panel();
            this.UserInfo_label = new System.Windows.Forms.Label();
            this.Message_textBox = new System.Windows.Forms.TextBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NameChanger_textBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_ConnectedUsers = new System.Windows.Forms.ListView();
            this.MessagesHolder_textBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostAServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MessageArea.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaxCharUses_label
            // 
            this.MaxCharUses_label.AutoSize = true;
            this.MaxCharUses_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.MaxCharUses_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxCharUses_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxCharUses_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxCharUses_label.ForeColor = System.Drawing.Color.White;
            this.MaxCharUses_label.Location = new System.Drawing.Point(10, 5);
            this.MaxCharUses_label.Name = "MaxCharUses_label";
            this.MaxCharUses_label.Size = new System.Drawing.Size(58, 20);
            this.MaxCharUses_label.TabIndex = 1;
            this.MaxCharUses_label.Text = "0/1000";
            this.MaxCharUses_label.TextChanged += new System.EventHandler(this.MaxCharUses_label_TextChanged);
            // 
            // MessageArea
            // 
            this.MessageArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.MessageArea.Controls.Add(this.UserInfo_label);
            this.MessageArea.Controls.Add(this.Message_textBox);
            this.MessageArea.Controls.Add(this.Send_button);
            this.MessageArea.Controls.Add(this.MaxCharUses_label);
            this.MessageArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessageArea.Location = new System.Drawing.Point(0, 472);
            this.MessageArea.Name = "MessageArea";
            this.MessageArea.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MessageArea.Size = new System.Drawing.Size(832, 67);
            this.MessageArea.TabIndex = 2;
            // 
            // UserInfo_label
            // 
            this.UserInfo_label.AutoSize = true;
            this.UserInfo_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.UserInfo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInfo_label.ForeColor = System.Drawing.Color.White;
            this.UserInfo_label.Location = new System.Drawing.Point(74, 5);
            this.UserInfo_label.Name = "UserInfo_label";
            this.UserInfo_label.Size = new System.Drawing.Size(155, 20);
            this.UserInfo_label.TabIndex = 4;
            this.UserInfo_label.Text = "Chating as: Guest01";
            // 
            // Message_textBox
            // 
            this.Message_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.Message_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Message_textBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Message_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_textBox.Location = new System.Drawing.Point(10, 30);
            this.Message_textBox.MaxLength = 150;
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.Size = new System.Drawing.Size(812, 27);
            this.Message_textBox.TabIndex = 3;
            this.Message_textBox.WordWrap = false;
            this.Message_textBox.TextChanged += new System.EventHandler(this.Message_textBox_TextChanged);
            this.Message_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Message_textBox_KeyPress);
            // 
            // Send_button
            // 
            this.Send_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Send_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send_button.FlatAppearance.BorderSize = 0;
            this.Send_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_button.ForeColor = System.Drawing.Color.White;
            this.Send_button.Location = new System.Drawing.Point(747, 0);
            this.Send_button.Margin = new System.Windows.Forms.Padding(5);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(75, 30);
            this.Send_button.TabIndex = 2;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = false;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.MessagesHolder_textBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(832, 448);
            this.panel1.TabIndex = 3;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(597, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(225, 428);
            this.panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.NameChanger_textBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(5, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(220, 96);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(4, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save name";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameChanger_textBox
            // 
            this.NameChanger_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.NameChanger_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameChanger_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameChanger_textBox.Location = new System.Drawing.Point(4, 24);
            this.NameChanger_textBox.MaxLength = 16;
            this.NameChanger_textBox.Name = "NameChanger_textBox";
            this.NameChanger_textBox.Size = new System.Drawing.Size(211, 27);
            this.NameChanger_textBox.TabIndex = 0;
            this.NameChanger_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameChanger_textBox_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.groupBox3.Controls.Add(this.list_ConnectedUsers);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(5, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 326);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connected users:";
            // 
            // list_ConnectedUsers
            // 
            this.list_ConnectedUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.list_ConnectedUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_ConnectedUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_ConnectedUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_ConnectedUsers.ForeColor = System.Drawing.Color.White;
            listViewGroup1.Header = "Connected Users";
            listViewGroup1.Name = "ConnectedUsers";
            this.list_ConnectedUsers.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.list_ConnectedUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_ConnectedUsers.HideSelection = false;
            this.list_ConnectedUsers.LabelWrap = false;
            this.list_ConnectedUsers.Location = new System.Drawing.Point(3, 22);
            this.list_ConnectedUsers.MultiSelect = false;
            this.list_ConnectedUsers.Name = "list_ConnectedUsers";
            this.list_ConnectedUsers.Size = new System.Drawing.Size(214, 301);
            this.list_ConnectedUsers.TabIndex = 1;
            this.list_ConnectedUsers.UseCompatibleStateImageBehavior = false;
            this.list_ConnectedUsers.View = System.Windows.Forms.View.List;
            // 
            // MessagesHolder_textBox
            // 
            this.MessagesHolder_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MessagesHolder_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessagesHolder_textBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MessagesHolder_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessagesHolder_textBox.ForeColor = System.Drawing.Color.White;
            this.MessagesHolder_textBox.Location = new System.Drawing.Point(10, 10);
            this.MessagesHolder_textBox.Name = "MessagesHolder_textBox";
            this.MessagesHolder_textBox.ReadOnly = true;
            this.MessagesHolder_textBox.Size = new System.Drawing.Size(581, 428);
            this.MessagesHolder_textBox.TabIndex = 3;
            this.MessagesHolder_textBox.Text = "";
            this.MessagesHolder_textBox.TextChanged += new System.EventHandler(this.MessagesHolder_textBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToServerToolStripMenuItem,
            this.hostAServerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // connectToServerToolStripMenuItem
            // 
            this.connectToServerToolStripMenuItem.Name = "connectToServerToolStripMenuItem";
            this.connectToServerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.connectToServerToolStripMenuItem.Text = "Connect to server";
            this.connectToServerToolStripMenuItem.Click += new System.EventHandler(this.connectToServerToolStripMenuItem_Click);
            // 
            // hostAServerToolStripMenuItem
            // 
            this.hostAServerToolStripMenuItem.Name = "hostAServerToolStripMenuItem";
            this.hostAServerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.hostAServerToolStripMenuItem.Text = "Host a Server";
            this.hostAServerToolStripMenuItem.Click += new System.EventHandler(this.hostAServerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MessageArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatAndChill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainApp_FormClosing);
            this.MessageArea.ResumeLayout(false);
            this.MessageArea.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MaxCharUses_label;
        private System.Windows.Forms.Panel MessageArea;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostAServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NameChanger_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UserInfo_label;
        private System.Windows.Forms.ListView list_ConnectedUsers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RichTextBox MessagesHolder_textBox;
        public System.Windows.Forms.TextBox Message_textBox;
        public System.Windows.Forms.Timer timer1;
    }
}

