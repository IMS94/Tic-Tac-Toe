namespace Tik_tak_toe_pro
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbVsExit = new System.Windows.Forms.PictureBox();
            this.pbVsSetting = new System.Windows.Forms.PictureBox();
            this.pbVsHuman = new System.Windows.Forms.PictureBox();
            this.pbVsComputer = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVsExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVsSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVsHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVsComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pbVsExit);
            this.panel2.Controls.Add(this.pbVsSetting);
            this.panel2.Controls.Add(this.pbVsHuman);
            this.panel2.Controls.Add(this.pbVsComputer);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 251);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Tik_tak_toe_pro.Properties.Resources.Tic_Tac_Toe_jpg;
            this.pictureBox1.Image = global::Tik_tak_toe_pro.Properties.Resources.Tic_Tac_Toe_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 34);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pbVsExit
            // 
            this.pbVsExit.Image = ((System.Drawing.Image)(resources.GetObject("pbVsExit.Image")));
            this.pbVsExit.Location = new System.Drawing.Point(161, 176);
            this.pbVsExit.Name = "pbVsExit";
            this.pbVsExit.Size = new System.Drawing.Size(142, 63);
            this.pbVsExit.TabIndex = 4;
            this.pbVsExit.TabStop = false;
            this.pbVsExit.Click += new System.EventHandler(this.pbVsExit_Click);
            this.pbVsExit.MouseEnter += new System.EventHandler(this.pbVsExit_MouseEnter);
            this.pbVsExit.MouseLeave += new System.EventHandler(this.pbVsExit_MouseLeave);
            // 
            // pbVsSetting
            // 
            this.pbVsSetting.Image = ((System.Drawing.Image)(resources.GetObject("pbVsSetting.Image")));
            this.pbVsSetting.Location = new System.Drawing.Point(8, 175);
            this.pbVsSetting.Name = "pbVsSetting";
            this.pbVsSetting.Size = new System.Drawing.Size(146, 63);
            this.pbVsSetting.TabIndex = 3;
            this.pbVsSetting.TabStop = false;
            this.pbVsSetting.Click += new System.EventHandler(this.pbVsSetting_Click);
            this.pbVsSetting.MouseEnter += new System.EventHandler(this.pbVsSetting_MouseEnter);
            this.pbVsSetting.MouseLeave += new System.EventHandler(this.pbVsSetting_MouseLeave);
            // 
            // pbVsHuman
            // 
            this.pbVsHuman.Image = ((System.Drawing.Image)(resources.GetObject("pbVsHuman.Image")));
            this.pbVsHuman.Location = new System.Drawing.Point(8, 109);
            this.pbVsHuman.Name = "pbVsHuman";
            this.pbVsHuman.Size = new System.Drawing.Size(294, 60);
            this.pbVsHuman.TabIndex = 2;
            this.pbVsHuman.TabStop = false;
            this.pbVsHuman.Click += new System.EventHandler(this.pbVsHuman_Click);
            this.pbVsHuman.MouseEnter += new System.EventHandler(this.pbVsHuman_MouseEnter);
            this.pbVsHuman.MouseLeave += new System.EventHandler(this.pbVsHuman_MouseLeave);
            // 
            // pbVsComputer
            // 
            this.pbVsComputer.BackColor = System.Drawing.Color.Transparent;
            this.pbVsComputer.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbVsComputer.ErrorImage")));
            this.pbVsComputer.Image = ((System.Drawing.Image)(resources.GetObject("pbVsComputer.Image")));
            this.pbVsComputer.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbVsComputer.InitialImage")));
            this.pbVsComputer.Location = new System.Drawing.Point(9, 43);
            this.pbVsComputer.Name = "pbVsComputer";
            this.pbVsComputer.Size = new System.Drawing.Size(294, 60);
            this.pbVsComputer.TabIndex = 1;
            this.pbVsComputer.TabStop = false;
            this.pbVsComputer.Click += new System.EventHandler(this.pbVsComputer_Click);
            this.pbVsComputer.MouseEnter += new System.EventHandler(this.pbVsComputer_MouseEnter);
            this.pbVsComputer.MouseLeave += new System.EventHandler(this.pbVsComputer_MouseLeave);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Tik_tak_toe_pro.Properties.Resources.backcheck2;
            this.ClientSize = new System.Drawing.Size(328, 268);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVsExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVsSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVsHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVsComputer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbVsExit;
        private System.Windows.Forms.PictureBox pbVsSetting;
        private System.Windows.Forms.PictureBox pbVsHuman;
        private System.Windows.Forms.PictureBox pbVsComputer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

