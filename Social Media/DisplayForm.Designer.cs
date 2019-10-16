namespace Social_Media
{
    partial class DisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHandleText = new System.Windows.Forms.Label();
            this.lblTweetsText = new System.Windows.Forms.Label();
            this.lblTweets = new System.Windows.Forms.Label();
            this.lblFollowerText = new System.Windows.Forms.Label();
            this.lblFollowers = new System.Windows.Forms.Label();
            this.lblLikesText = new System.Windows.Forms.Label();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblLastStatus = new System.Windows.Forms.Label();
            this.lblCreateDateText = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.pbxProfileIcon = new System.Windows.Forms.PictureBox();
            this.btnShowTweet = new System.Windows.Forms.Button();
            this.bTweetsInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(504, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHandleText
            // 
            this.lblHandleText.AutoSize = true;
            this.lblHandleText.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblHandleText.Location = new System.Drawing.Point(44, 18);
            this.lblHandleText.Name = "lblHandleText";
            this.lblHandleText.Size = new System.Drawing.Size(389, 45);
            this.lblHandleText.TabIndex = 2;
            this.lblHandleText.Text = "Social Media Details";
            // 
            // lblTweetsText
            // 
            this.lblTweetsText.AutoSize = true;
            this.lblTweetsText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTweetsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblTweetsText.Location = new System.Drawing.Point(139, 83);
            this.lblTweetsText.Name = "lblTweetsText";
            this.lblTweetsText.Size = new System.Drawing.Size(111, 25);
            this.lblTweetsText.TabIndex = 6;
            this.lblTweetsText.Text = "Loading..";
            // 
            // lblTweets
            // 
            this.lblTweets.AutoSize = true;
            this.lblTweets.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTweets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblTweets.Location = new System.Drawing.Point(12, 83);
            this.lblTweets.Name = "lblTweets";
            this.lblTweets.Size = new System.Drawing.Size(77, 25);
            this.lblTweets.TabIndex = 5;
            this.lblTweets.Text = "Posts:";
            // 
            // lblFollowerText
            // 
            this.lblFollowerText.AutoSize = true;
            this.lblFollowerText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowerText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblFollowerText.Location = new System.Drawing.Point(139, 138);
            this.lblFollowerText.Name = "lblFollowerText";
            this.lblFollowerText.Size = new System.Drawing.Size(111, 25);
            this.lblFollowerText.TabIndex = 8;
            this.lblFollowerText.Text = "Loading..";
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblFollowers.Location = new System.Drawing.Point(12, 138);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(121, 25);
            this.lblFollowers.TabIndex = 7;
            this.lblFollowers.Text = "Followers:";
            // 
            // lblLikesText
            // 
            this.lblLikesText.AutoSize = true;
            this.lblLikesText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLikesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblLikesText.Location = new System.Drawing.Point(356, 83);
            this.lblLikesText.Name = "lblLikesText";
            this.lblLikesText.Size = new System.Drawing.Size(111, 25);
            this.lblLikesText.TabIndex = 10;
            this.lblLikesText.Text = "Loading..";
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLikes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblLikes.Location = new System.Drawing.Point(274, 83);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(76, 25);
            this.lblLikes.TabIndex = 9;
            this.lblLikes.Text = "Likes:";
            // 
            // lblLastStatus
            // 
            this.lblLastStatus.AutoSize = true;
            this.lblLastStatus.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblLastStatus.Location = new System.Drawing.Point(12, 203);
            this.lblLastStatus.Name = "lblLastStatus";
            this.lblLastStatus.Size = new System.Drawing.Size(135, 25);
            this.lblLastStatus.TabIndex = 15;
            this.lblLastStatus.Text = "Last Tweet:";
            // 
            // lblCreateDateText
            // 
            this.lblCreateDateText.AutoSize = true;
            this.lblCreateDateText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblCreateDateText.Location = new System.Drawing.Point(414, 138);
            this.lblCreateDateText.Name = "lblCreateDateText";
            this.lblCreateDateText.Size = new System.Drawing.Size(111, 25);
            this.lblCreateDateText.TabIndex = 12;
            this.lblCreateDateText.Text = "Loading..";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblCreateDate.Location = new System.Drawing.Point(274, 138);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(134, 25);
            this.lblCreateDate.TabIndex = 11;
            this.lblCreateDate.Text = "User Since:";
            // 
            // pbxProfileIcon
            // 
            this.pbxProfileIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxProfileIcon.ImageLocation = "";
            this.pbxProfileIcon.Location = new System.Drawing.Point(532, 12);
            this.pbxProfileIcon.Name = "pbxProfileIcon";
            this.pbxProfileIcon.Size = new System.Drawing.Size(100, 100);
            this.pbxProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProfileIcon.TabIndex = 17;
            this.pbxProfileIcon.TabStop = false;
            // 
            // btnShowTweet
            // 
            this.btnShowTweet.BackColor = System.Drawing.Color.Transparent;
            this.btnShowTweet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowTweet.BackgroundImage")));
            this.btnShowTweet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowTweet.FlatAppearance.BorderSize = 0;
            this.btnShowTweet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTweet.ForeColor = System.Drawing.Color.White;
            this.btnShowTweet.Location = new System.Drawing.Point(166, 203);
            this.btnShowTweet.Name = "btnShowTweet";
            this.btnShowTweet.Size = new System.Drawing.Size(30, 30);
            this.btnShowTweet.TabIndex = 18;
            this.btnShowTweet.UseVisualStyleBackColor = false;
            this.btnShowTweet.Click += new System.EventHandler(this.btnShowTweet_Click);
            // 
            // bTweetsInfo
            // 
            this.bTweetsInfo.BackColor = System.Drawing.Color.Transparent;
            this.bTweetsInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bTweetsInfo.BackgroundImage")));
            this.bTweetsInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTweetsInfo.FlatAppearance.BorderSize = 0;
            this.bTweetsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTweetsInfo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTweetsInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.bTweetsInfo.Location = new System.Drawing.Point(12, 249);
            this.bTweetsInfo.Name = "bTweetsInfo";
            this.bTweetsInfo.Size = new System.Drawing.Size(160, 100);
            this.bTweetsInfo.TabIndex = 19;
            this.bTweetsInfo.Text = "Recent\r\nTweets Stats";
            this.bTweetsInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bTweetsInfo.UseVisualStyleBackColor = false;
            this.bTweetsInfo.Click += new System.EventHandler(this.bTweetsInfo_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(644, 361);
            this.Controls.Add(this.bTweetsInfo);
            this.Controls.Add(this.btnShowTweet);
            this.Controls.Add(this.pbxProfileIcon);
            this.Controls.Add(this.lblLastStatus);
            this.Controls.Add(this.lblCreateDateText);
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.lblLikesText);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.lblFollowerText);
            this.Controls.Add(this.lblFollowers);
            this.Controls.Add(this.lblTweetsText);
            this.Controls.Add(this.lblTweets);
            this.Controls.Add(this.lblHandleText);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social Media";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayForm_FormClosing);
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfileIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHandleText;
        private System.Windows.Forms.Label lblTweetsText;
        private System.Windows.Forms.Label lblTweets;
        private System.Windows.Forms.Label lblFollowerText;
        private System.Windows.Forms.Label lblFollowers;
        private System.Windows.Forms.Label lblLikesText;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Label lblLastStatus;
        private System.Windows.Forms.Label lblCreateDateText;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.PictureBox pbxProfileIcon;
        private System.Windows.Forms.Button btnShowTweet;
        private System.Windows.Forms.Button bTweetsInfo;
    }
}