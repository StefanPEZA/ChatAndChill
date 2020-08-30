namespace ChatAndChill
{
    partial class ConnectClient
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
            this.IPlabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.Connect_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPlabel
            // 
            this.IPlabel.AutoSize = true;
            this.IPlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.IPlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPlabel.ForeColor = System.Drawing.Color.White;
            this.IPlabel.Location = new System.Drawing.Point(12, 26);
            this.IPlabel.Name = "IPlabel";
            this.IPlabel.Size = new System.Drawing.Size(24, 20);
            this.IPlabel.TabIndex = 2;
            this.IPlabel.Text = "IP";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PortLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.ForeColor = System.Drawing.Color.White;
            this.PortLabel.Location = new System.Drawing.Point(12, 74);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(38, 20);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port";
            // 
            // textIP
            // 
            this.textIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.textIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIP.Location = new System.Drawing.Point(70, 24);
            this.textIP.MaxLength = 16;
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(211, 27);
            this.textIP.TabIndex = 4;
            // 
            // textPort
            // 
            this.textPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.textPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPort.Location = new System.Drawing.Point(70, 72);
            this.textPort.MaxLength = 16;
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(211, 27);
            this.textPort.TabIndex = 5;
            // 
            // Connect_button
            // 
            this.Connect_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Connect_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connect_button.FlatAppearance.BorderSize = 0;
            this.Connect_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect_button.ForeColor = System.Drawing.Color.White;
            this.Connect_button.Location = new System.Drawing.Point(179, 107);
            this.Connect_button.Margin = new System.Windows.Forms.Padding(5);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(102, 30);
            this.Connect_button.TabIndex = 6;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = false;
            this.Connect_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // ConnectClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(308, 171);
            this.Controls.Add(this.Connect_button);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.IPlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConnectClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectClient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPlabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Button Connect_button;
    }
}