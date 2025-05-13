namespace TienLenDoAn
{
    partial class Playerinfo
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
            this.lblLoseNum = new System.Windows.Forms.Label();
            this.lblWinNum = new System.Windows.Forms.Label();
            this.lblLosetime = new System.Windows.Forms.Label();
            this.lblWintimes = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.tmrRight = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft = new System.Windows.Forms.Timer(this.components);
            this.tmrDesOpacity = new System.Windows.Forms.Timer(this.components);
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoseNum
            // 
            this.lblLoseNum.AutoSize = true;
            this.lblLoseNum.BackColor = System.Drawing.Color.Transparent;
            this.lblLoseNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoseNum.ForeColor = System.Drawing.Color.Navy;
            this.lblLoseNum.Location = new System.Drawing.Point(155, 181);
            this.lblLoseNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoseNum.Name = "lblLoseNum";
            this.lblLoseNum.Size = new System.Drawing.Size(19, 20);
            this.lblLoseNum.TabIndex = 11;
            this.lblLoseNum.Text = "0";
            // 
            // lblWinNum
            // 
            this.lblWinNum.AutoSize = true;
            this.lblWinNum.BackColor = System.Drawing.Color.Transparent;
            this.lblWinNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinNum.ForeColor = System.Drawing.Color.Crimson;
            this.lblWinNum.Location = new System.Drawing.Point(155, 160);
            this.lblWinNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinNum.Name = "lblWinNum";
            this.lblWinNum.Size = new System.Drawing.Size(19, 20);
            this.lblWinNum.TabIndex = 10;
            this.lblWinNum.Text = "0";
            // 
            // lblLosetime
            // 
            this.lblLosetime.AutoSize = true;
            this.lblLosetime.BackColor = System.Drawing.Color.Transparent;
            this.lblLosetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosetime.ForeColor = System.Drawing.Color.Navy;
            this.lblLosetime.Location = new System.Drawing.Point(95, 180);
            this.lblLosetime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLosetime.Name = "lblLosetime";
            this.lblLosetime.Size = new System.Drawing.Size(56, 20);
            this.lblLosetime.TabIndex = 9;
            this.lblLosetime.Text = "Lose:";
            // 
            // lblWintimes
            // 
            this.lblWintimes.AutoSize = true;
            this.lblWintimes.BackColor = System.Drawing.Color.Transparent;
            this.lblWintimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWintimes.ForeColor = System.Drawing.Color.Crimson;
            this.lblWintimes.Location = new System.Drawing.Point(106, 160);
            this.lblWintimes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWintimes.Name = "lblWintimes";
            this.lblWintimes.Size = new System.Drawing.Size(47, 20);
            this.lblWintimes.TabIndex = 8;
            this.lblWintimes.Text = "Win:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayerName.Location = new System.Drawing.Point(50, 130);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(173, 25);
            this.lblPlayerName.TabIndex = 7;
            this.lblPlayerName.Text = "Player Name";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerName.Click += new System.EventHandler(this.lblPlayerName_Click_2);
            // 
            // tmrRight
            // 
            this.tmrRight.Interval = 1;
            this.tmrRight.Tick += new System.EventHandler(this.tmrRight_Tick);
            // 
            // tmrLeft
            // 
            this.tmrLeft.Interval = 1;
            this.tmrLeft.Tick += new System.EventHandler(this.tmrLeft_Tick);
            // 
            // tmrDesOpacity
            // 
            this.tmrDesOpacity.Interval = 5;
            this.tmrDesOpacity.Tick += new System.EventHandler(this.tmrDesOpacity_Tick_2);
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAvatar.Location = new System.Drawing.Point(88, 29);
            this.pbxAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(93, 86);
            this.pbxAvatar.TabIndex = 6;
            this.pbxAvatar.TabStop = false;
       
            // 
            // Playerinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TienLenDoAn.Properties.Resources.bgrst;
            this.ClientSize = new System.Drawing.Size(272, 237);
            this.ControlBox = false;
            this.Controls.Add(this.lblLoseNum);
            this.Controls.Add(this.lblWinNum);
            this.Controls.Add(this.lblLosetime);
            this.Controls.Add(this.lblWintimes);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pbxAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Playerinfo";
            this.Text = "Playerinfo";
            this.Load += new System.EventHandler(this.Playerinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblLoseNum;
        public System.Windows.Forms.Label lblWinNum;
        private System.Windows.Forms.Label lblLosetime;
        private System.Windows.Forms.Label lblWintimes;
        public System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Timer tmrRight;
        private System.Windows.Forms.Timer tmrLeft;
        public System.Windows.Forms.Timer tmrDesOpacity;
        public System.Windows.Forms.PictureBox pbxAvatar;
    }
}