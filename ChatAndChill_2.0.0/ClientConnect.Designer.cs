namespace ChatAndChill_2._0._0
{
    partial class ClientConnect
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
            this.button_Connect = new System.Windows.Forms.Button();
            this.text_IP = new System.Windows.Forms.TextBox();
            this.text_PORT = new System.Windows.Forms.TextBox();
            this.text_NickName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Connect
            // 
            this.button_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.button_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.button_Connect.FlatAppearance.BorderSize = 0;
            this.button_Connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.button_Connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Connect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Connect.ForeColor = System.Drawing.Color.White;
            this.button_Connect.Location = new System.Drawing.Point(319, 139);
            this.button_Connect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(91, 33);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = false;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // text_IP
            // 
            this.text_IP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.text_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_IP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_IP.ForeColor = System.Drawing.Color.White;
            this.text_IP.Location = new System.Drawing.Point(82, 64);
            this.text_IP.MaxLength = 20;
            this.text_IP.Name = "text_IP";
            this.text_IP.PlaceholderText = "Type the server IP here...";
            this.text_IP.Size = new System.Drawing.Size(328, 26);
            this.text_IP.TabIndex = 0;
            this.text_IP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_IP_KeyPress);
            // 
            // text_PORT
            // 
            this.text_PORT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.text_PORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_PORT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_PORT.ForeColor = System.Drawing.Color.White;
            this.text_PORT.Location = new System.Drawing.Point(82, 105);
            this.text_PORT.MaxLength = 20;
            this.text_PORT.Name = "text_PORT";
            this.text_PORT.PlaceholderText = "Type the server PORT here...";
            this.text_PORT.Size = new System.Drawing.Size(328, 26);
            this.text_PORT.TabIndex = 0;
            this.text_PORT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_PORT_KeyPress);
            // 
            // text_NickName
            // 
            this.text_NickName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.text_NickName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_NickName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_NickName.ForeColor = System.Drawing.Color.White;
            this.text_NickName.Location = new System.Drawing.Point(82, 23);
            this.text_NickName.MaxLength = 20;
            this.text_NickName.Name = "text_NickName";
            this.text_NickName.PlaceholderText = "Type you nickname here...";
            this.text_NickName.Size = new System.Drawing.Size(328, 26);
            this.text_NickName.TabIndex = 0;
            this.text_NickName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_NickName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "PORT:";
            // 
            // ClientConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(435, 196);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_NickName);
            this.Controls.Add(this.text_PORT);
            this.Controls.Add(this.text_IP);
            this.Controls.Add(this.button_Connect);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ClientConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientConnect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientConnect_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.TextBox text_IP;
        private System.Windows.Forms.TextBox text_PORT;
        private System.Windows.Forms.TextBox text_NickName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}