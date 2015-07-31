namespace Tik_tak_toe_pro
{
    partial class MultiplayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiplayerForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxLevels = new System.Windows.Forms.GroupBox();
            this.levelMedium = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.levelEasy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel2.Size = new System.Drawing.Size(304, 251);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxLevels
            // 
            this.groupBoxLevels.Controls.Add(this.levelMedium);
            this.groupBoxLevels.Controls.Add(this.label2);
            this.groupBoxLevels.Controls.Add(this.levelEasy);
            this.groupBoxLevels.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLevels.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxLevels.Location = new System.Drawing.Point(27, 50);
            this.groupBoxLevels.Name = "groupBoxLevels";
            this.groupBoxLevels.Size = new System.Drawing.Size(263, 174);
            this.groupBoxLevels.TabIndex = 5;
            this.groupBoxLevels.TabStop = false;
            this.groupBoxLevels.Text = "Mode";
            // 
            // levelMedium
            // 
            this.levelMedium.AutoSize = true;
            this.levelMedium.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelMedium.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.levelMedium.Location = new System.Drawing.Point(42, 78);
            this.levelMedium.Name = "levelMedium";
            this.levelMedium.Size = new System.Drawing.Size(141, 29);
            this.levelMedium.TabIndex = 2;
            this.levelMedium.TabStop = true;
            this.levelMedium.Text = "Over Network";
            this.levelMedium.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(181, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "<< Back";
            // 
            // levelEasy
            // 
            this.levelEasy.AutoSize = true;
            this.levelEasy.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelEasy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.levelEasy.Location = new System.Drawing.Point(42, 38);
            this.levelEasy.Name = "levelEasy";
            this.levelEasy.Size = new System.Drawing.Size(88, 29);
            this.levelEasy.TabIndex = 1;
            this.levelEasy.TabStop = true;
            this.levelEasy.Text = "This PC";
            this.levelEasy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplayer Mode";
            // 
            // MultiplayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(328, 268);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(275, 100);
            this.Name = "MultiplayerForm";
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
        private System.Windows.Forms.RadioButton levelMedium;
        private System.Windows.Forms.RadioButton levelEasy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxLevels;
    }
}

