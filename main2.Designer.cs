namespace MultiFaceRec
{
    partial class main2
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
            this.btnstart = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnstop = new Guna.UI2.WinForms.Guna2Button();
            this.cboWebcams = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblObjectCount = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnstart.ForeColor = System.Drawing.Color.White;
            this.btnstart.Location = new System.Drawing.Point(51, 105);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(180, 45);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "START";
            this.btnstart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(51, 185);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "START COUNTING";
            // 
            // btnstop
            // 
            this.btnstop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnstop.ForeColor = System.Drawing.Color.White;
            this.btnstop.Location = new System.Drawing.Point(51, 266);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(180, 45);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "STOP";
            this.btnstop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cboWebcams
            // 
            this.cboWebcams.BackColor = System.Drawing.Color.Transparent;
            this.cboWebcams.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboWebcams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWebcams.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboWebcams.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboWebcams.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboWebcams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboWebcams.ItemHeight = 30;
            this.cboWebcams.Location = new System.Drawing.Point(51, 48);
            this.cboWebcams.Name = "cboWebcams";
            this.cboWebcams.Size = new System.Drawing.Size(180, 36);
            this.cboWebcams.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(237, 48);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(349, 263);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(592, 48);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(349, 263);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 5;
            this.guna2PictureBox2.TabStop = false;
            // 
            // lblObjectCount
            // 
            this.lblObjectCount.AutoSize = true;
            this.lblObjectCount.Location = new System.Drawing.Point(48, 334);
            this.lblObjectCount.Name = "lblObjectCount";
            this.lblObjectCount.Size = new System.Drawing.Size(29, 13);
            this.lblObjectCount.TabIndex = 6;
            this.lblObjectCount.Text = "OVC";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(48, 358);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(39, 13);
            this.lblCPU.TabIndex = 7;
            this.lblCPU.Text = "lblCPU";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(48, 382);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(39, 13);
            this.lblRAM.TabIndex = 8;
            this.lblRAM.Text = "lblCPU";
            // 
            // main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 518);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblObjectCount);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cboWebcams);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btnstart);
            this.Name = "main2";
            this.Text = "main2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnstart;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnstop;
        private Guna.UI2.WinForms.Guna2ComboBox cboWebcams;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label lblObjectCount;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
    }
}