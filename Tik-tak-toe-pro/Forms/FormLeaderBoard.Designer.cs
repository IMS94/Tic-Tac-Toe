namespace Tik_tak_toe_pro
{
    partial class FormLeaderBoard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbnewname = new System.Windows.Forms.TextBox();
            this.pbhard = new System.Windows.Forms.PictureBox();
            this.pbmedium = new System.Windows.Forms.PictureBox();
            this.pbeasy = new System.Windows.Forms.PictureBox();
            this.lbHard = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblEasy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbscore = new System.Windows.Forms.ListBox();
            this.lbname = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblyourscore = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbhard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbeasy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tbnewname);
            this.panel2.Controls.Add(this.pbhard);
            this.panel2.Controls.Add(this.pbmedium);
            this.panel2.Controls.Add(this.pbeasy);
            this.panel2.Controls.Add(this.lbHard);
            this.panel2.Controls.Add(this.lblMedium);
            this.panel2.Controls.Add(this.lblEasy);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbscore);
            this.panel2.Controls.Add(this.lbname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 428);
            this.panel2.TabIndex = 1;
            // 
            // tbnewname
            // 
            this.tbnewname.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbnewname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnewname.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnewname.ForeColor = System.Drawing.Color.Gray;
            this.tbnewname.Location = new System.Drawing.Point(28, 402);
            this.tbnewname.Name = "tbnewname";
            this.tbnewname.Size = new System.Drawing.Size(156, 22);
            this.tbnewname.TabIndex = 15;
            this.tbnewname.Text = "Type Your Name Here";
            this.tbnewname.Click += new System.EventHandler(this.tbnewname_Click);
            // 
            // pbhard
            // 
            this.pbhard.Location = new System.Drawing.Point(173, 50);
            this.pbhard.Name = "pbhard";
            this.pbhard.Size = new System.Drawing.Size(57, 5);
            this.pbhard.TabIndex = 14;
            this.pbhard.TabStop = false;
            // 
            // pbmedium
            // 
            this.pbmedium.Location = new System.Drawing.Point(100, 50);
            this.pbmedium.Name = "pbmedium";
            this.pbmedium.Size = new System.Drawing.Size(57, 5);
            this.pbmedium.TabIndex = 13;
            this.pbmedium.TabStop = false;
            // 
            // pbeasy
            // 
            this.pbeasy.Location = new System.Drawing.Point(28, 50);
            this.pbeasy.Name = "pbeasy";
            this.pbeasy.Size = new System.Drawing.Size(57, 5);
            this.pbeasy.TabIndex = 12;
            this.pbeasy.TabStop = false;
            // 
            // lbHard
            // 
            this.lbHard.AutoSize = true;
            this.lbHard.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHard.ForeColor = System.Drawing.Color.White;
            this.lbHard.Location = new System.Drawing.Point(171, 30);
            this.lbHard.Name = "lbHard";
            this.lbHard.Size = new System.Drawing.Size(60, 34);
            this.lbHard.TabIndex = 11;
            this.lbHard.Text = "Hard    \r\n             \r\n";
            this.lbHard.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.ForeColor = System.Drawing.Color.White;
            this.lblMedium.Location = new System.Drawing.Point(97, 30);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(64, 34);
            this.lblMedium.TabIndex = 10;
            this.lblMedium.Text = "Medium\r\n              \r\n";
            this.lblMedium.Click += new System.EventHandler(this.lblMedium_Click);
            // 
            // lblEasy
            // 
            this.lblEasy.AutoSize = true;
            this.lblEasy.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEasy.ForeColor = System.Drawing.Color.White;
            this.lblEasy.Location = new System.Drawing.Point(25, 30);
            this.lblEasy.Name = "lblEasy";
            this.lblEasy.Size = new System.Drawing.Size(48, 34);
            this.lblEasy.TabIndex = 9;
            this.lblEasy.Text = "Easy  \r\n          \r\n";
            this.lblEasy.Click += new System.EventHandler(this.lblEasy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(172, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // lbscore
            // 
            this.lbscore.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbscore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbscore.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbscore.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbscore.FormattingEnabled = true;
            this.lbscore.ItemHeight = 21;
            this.lbscore.Location = new System.Drawing.Point(175, 93);
            this.lbscore.Name = "lbscore";
            this.lbscore.Size = new System.Drawing.Size(106, 294);
            this.lbscore.TabIndex = 6;
            // 
            // lbname
            // 
            this.lbname.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbname.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbname.FormattingEnabled = true;
            this.lbname.ItemHeight = 21;
            this.lbname.Location = new System.Drawing.Point(28, 93);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(106, 294);
            this.lbname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(287, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leader Board";
            // 
            // lblyourscore
            // 
            this.lblyourscore.AutoSize = true;
            this.lblyourscore.BackColor = System.Drawing.Color.Transparent;
            this.lblyourscore.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyourscore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblyourscore.Location = new System.Drawing.Point(38, 446);
            this.lblyourscore.Name = "lblyourscore";
            this.lblyourscore.Size = new System.Drawing.Size(65, 17);
            this.lblyourscore.TabIndex = 16;
            this.lblyourscore.Text = "Your Score";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.Transparent;
            this.lblscore.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblscore.Location = new System.Drawing.Point(118, 446);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(16, 17);
            this.lblscore.TabIndex = 17;
            this.lblscore.Text = "  ";
            // 
            // btadd
            // 
            this.btadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btadd.Location = new System.Drawing.Point(247, 444);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 2;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // FormLeaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Tik_tak_toe_pro.Properties.Resources.footbal_field;
            this.ClientSize = new System.Drawing.Size(334, 479);
            this.ControlBox = false;
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.lblyourscore);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(275, 100);
            this.Name = "FormLeaderBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbhard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbeasy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbscore;
        private System.Windows.Forms.ListBox lbname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbhard;
        private System.Windows.Forms.PictureBox pbmedium;
        private System.Windows.Forms.PictureBox pbeasy;
        private System.Windows.Forms.Label lbHard;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblEasy;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lblyourscore;
        private System.Windows.Forms.TextBox tbnewname;
        private System.Windows.Forms.Button btadd;
    }
}

