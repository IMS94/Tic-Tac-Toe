namespace Tik_tak_toe_pro
{
    partial class IPAddressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPAddressForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxLevels = new System.Windows.Forms.GroupBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hostButton = new System.Windows.Forms.Button();
            this.clientButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ipListBox = new System.Windows.Forms.ListBox();
            this.connectIpBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.waitLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBoxLevels.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.groupBoxLevels);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 421);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxLevels
            // 
            this.groupBoxLevels.Controls.Add(this.waitLabel);
            this.groupBoxLevels.Controls.Add(this.label7);
            this.groupBoxLevels.Controls.Add(this.connectIpBox);
            this.groupBoxLevels.Controls.Add(this.ipListBox);
            this.groupBoxLevels.Controls.Add(this.nameBox);
            this.groupBoxLevels.Controls.Add(this.label6);
            this.groupBoxLevels.Controls.Add(this.label5);
            this.groupBoxLevels.Controls.Add(this.label4);
            this.groupBoxLevels.Controls.Add(this.label3);
            this.groupBoxLevels.Controls.Add(this.hostButton);
            this.groupBoxLevels.Controls.Add(this.clientButton);
            this.groupBoxLevels.Controls.Add(this.label2);
            this.groupBoxLevels.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLevels.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxLevels.Location = new System.Drawing.Point(17, 37);
            this.groupBoxLevels.Name = "groupBoxLevels";
            this.groupBoxLevels.Size = new System.Drawing.Size(318, 369);
            this.groupBoxLevels.TabIndex = 5;
            this.groupBoxLevels.TabStop = false;
            this.groupBoxLevels.Text = "Enter IP Adress";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.SystemColors.Window;
            this.nameBox.Location = new System.Drawing.Point(125, 110);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(156, 29);
            this.nameBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Your Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Available IPs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "* \'Host\' to start and host a game.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "* \'Connect\' to connect to another computer.";
            // 
            // hostButton
            // 
            this.hostButton.BackColor = System.Drawing.Color.Black;
            this.hostButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hostButton.Location = new System.Drawing.Point(197, 179);
            this.hostButton.Name = "hostButton";
            this.hostButton.Size = new System.Drawing.Size(75, 34);
            this.hostButton.TabIndex = 8;
            this.hostButton.Text = "Host Game";
            this.hostButton.UseVisualStyleBackColor = false;
            this.hostButton.Click += new System.EventHandler(this.hostButton_Click);
            // 
            // clientButton
            // 
            this.clientButton.BackColor = System.Drawing.Color.Black;
            this.clientButton.FlatAppearance.BorderSize = 2;
            this.clientButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientButton.Location = new System.Drawing.Point(197, 303);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(75, 34);
            this.clientButton.TabIndex = 7;
            this.clientButton.Text = "Connect";
            this.clientButton.UseVisualStyleBackColor = false;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(5, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "<< Back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // ipListBox
            // 
            this.ipListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.ipListBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ipListBox.FormattingEnabled = true;
            this.ipListBox.ItemHeight = 21;
            this.ipListBox.Location = new System.Drawing.Point(39, 179);
            this.ipListBox.Name = "ipListBox";
            this.ipListBox.Size = new System.Drawing.Size(126, 88);
            this.ipListBox.TabIndex = 14;
            // 
            // connectIpBox
            // 
            this.connectIpBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.connectIpBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectIpBox.ForeColor = System.Drawing.SystemColors.Window;
            this.connectIpBox.Location = new System.Drawing.Point(39, 303);
            this.connectIpBox.Name = "connectIpBox";
            this.connectIpBox.Size = new System.Drawing.Size(126, 29);
            this.connectIpBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "or Connect to";
            // 
            // waitLabel
            // 
            this.waitLabel.AutoSize = true;
            this.waitLabel.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitLabel.Location = new System.Drawing.Point(105, 347);
            this.waitLabel.Name = "waitLabel";
            this.waitLabel.Size = new System.Drawing.Size(207, 19);
            this.waitLabel.TabIndex = 18;
            this.waitLabel.Text = "Please Wait for the other player ...";
            // 
            // IPAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(375, 457);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(275, 100);
            this.Name = "IPAddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxLevels.ResumeLayout(false);
            this.groupBoxLevels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxLevels;
        private System.Windows.Forms.Button hostButton;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ipListBox;
        private System.Windows.Forms.TextBox connectIpBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label waitLabel;
    }
}

