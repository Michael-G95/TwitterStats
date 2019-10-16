namespace Social_Media
{
    partial class TweetStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TweetStats));
            this.btnExit = new System.Windows.Forms.Button();
            this.tweetGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvlAvgLikesTitle = new System.Windows.Forms.Label();
            this.lblAvgLikes = new System.Windows.Forms.Label();
            this.lblAvgHashtags = new System.Windows.Forms.Label();
            this.lblAvgHashtagsTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLikesGraph = new System.Windows.Forms.Button();
            this.btnHashtagsGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tweetGridView)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(532, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tweetGridView
            // 
            this.tweetGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.tweetGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tweetGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tweetGridView.Location = new System.Drawing.Point(0, 0);
            this.tweetGridView.Name = "tweetGridView";
            this.tweetGridView.RowHeadersVisible = false;
            this.tweetGridView.Size = new System.Drawing.Size(620, 231);
            this.tweetGridView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tweetGridView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 231);
            this.panel1.TabIndex = 4;
            // 
            // lvlAvgLikesTitle
            // 
            this.lvlAvgLikesTitle.AutoSize = true;
            this.lvlAvgLikesTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAvgLikesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lvlAvgLikesTitle.Location = new System.Drawing.Point(81, 281);
            this.lvlAvgLikesTitle.Name = "lvlAvgLikesTitle";
            this.lvlAvgLikesTitle.Size = new System.Drawing.Size(152, 23);
            this.lvlAvgLikesTitle.TabIndex = 5;
            this.lvlAvgLikesTitle.Text = "Average Likes:";
            // 
            // lblAvgLikes
            // 
            this.lblAvgLikes.AutoSize = true;
            this.lblAvgLikes.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgLikes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblAvgLikes.Location = new System.Drawing.Point(239, 281);
            this.lblAvgLikes.Name = "lblAvgLikes";
            this.lblAvgLikes.Size = new System.Drawing.Size(100, 23);
            this.lblAvgLikes.TabIndex = 6;
            this.lblAvgLikes.Text = "Loading..";
            // 
            // lblAvgHashtags
            // 
            this.lblAvgHashtags.AutoSize = true;
            this.lblAvgHashtags.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgHashtags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblAvgHashtags.Location = new System.Drawing.Point(277, 313);
            this.lblAvgHashtags.Name = "lblAvgHashtags";
            this.lblAvgHashtags.Size = new System.Drawing.Size(100, 23);
            this.lblAvgHashtags.TabIndex = 8;
            this.lblAvgHashtags.Text = "Loading..";
            // 
            // lblAvgHashtagsTitle
            // 
            this.lblAvgHashtagsTitle.AutoSize = true;
            this.lblAvgHashtagsTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgHashtagsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblAvgHashtagsTitle.Location = new System.Drawing.Point(81, 313);
            this.lblAvgHashtagsTitle.Name = "lblAvgHashtagsTitle";
            this.lblAvgHashtagsTitle.Size = new System.Drawing.Size(190, 23);
            this.lblAvgHashtagsTitle.TabIndex = 7;
            this.lblAvgHashtagsTitle.Text = "Average Hashtags:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(154, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Averages from these recent tweets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLikesGraph
            // 
            this.btnLikesGraph.BackColor = System.Drawing.Color.Transparent;
            this.btnLikesGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLikesGraph.FlatAppearance.BorderSize = 0;
            this.btnLikesGraph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLikesGraph.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLikesGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.btnLikesGraph.Location = new System.Drawing.Point(386, 281);
            this.btnLikesGraph.Name = "btnLikesGraph";
            this.btnLikesGraph.Size = new System.Drawing.Size(78, 30);
            this.btnLikesGraph.TabIndex = 19;
            this.btnLikesGraph.Text = "Graph";
            this.btnLikesGraph.UseVisualStyleBackColor = false;
            this.btnLikesGraph.Click += new System.EventHandler(this.btnLikesGraph_Click);
            // 
            // btnHashtagsGraph
            // 
            this.btnHashtagsGraph.BackColor = System.Drawing.Color.Transparent;
            this.btnHashtagsGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHashtagsGraph.FlatAppearance.BorderSize = 0;
            this.btnHashtagsGraph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHashtagsGraph.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashtagsGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.btnHashtagsGraph.Location = new System.Drawing.Point(386, 312);
            this.btnHashtagsGraph.Name = "btnHashtagsGraph";
            this.btnHashtagsGraph.Size = new System.Drawing.Size(78, 30);
            this.btnHashtagsGraph.TabIndex = 20;
            this.btnHashtagsGraph.Text = "Graph";
            this.btnHashtagsGraph.UseVisualStyleBackColor = false;
            this.btnHashtagsGraph.Click += new System.EventHandler(this.btnHashtagsGraph_Click);
            // 
            // TweetStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(644, 361);
            this.Controls.Add(this.btnHashtagsGraph);
            this.Controls.Add(this.btnLikesGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAvgHashtags);
            this.Controls.Add(this.lblAvgHashtagsTitle);
            this.Controls.Add(this.lblAvgLikes);
            this.Controls.Add(this.lvlAvgLikesTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TweetStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social Media";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TweetStats_FormClosing);
            this.Load += new System.EventHandler(this.TweetStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tweetGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView tweetGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lvlAvgLikesTitle;
        private System.Windows.Forms.Label lblAvgLikes;
        private System.Windows.Forms.Label lblAvgHashtags;
        private System.Windows.Forms.Label lblAvgHashtagsTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLikesGraph;
        private System.Windows.Forms.Button btnHashtagsGraph;
    }
}