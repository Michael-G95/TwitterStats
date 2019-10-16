using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Media
{
    public partial class TweetStats : Form
    {
        // Form to show data and stats on recent tweets.
        BindingSource tweetSource; // Data source for table 
        new DisplayForm ParentForm { get; set; }
        List<Tweet> Tweets { get; set; } // The tweet data
        public TweetStats(DisplayForm parent,List<Tweet> tweets)
        {
            // Constructor for tweetstats
            InitializeComponent(); 
            this.ParentForm = parent;
            Tweets = tweets;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the form, restore parent
            ParentForm.Show();
            this.Close();
            this.Dispose();
        }

        private void TweetStats_Load(object sender, EventArgs e)
        {
                // On form load, draw the table

            tweetSource = new BindingSource();
            // Add the tweets to the table's data source
            foreach (Tweet t in Tweets)
            {
                tweetSource.Add(t);
            }
            tweetGridView.AutoGenerateColumns = false;
            tweetGridView.AutoSize = true;
            tweetGridView.DataSource = tweetSource;

            // Add 4 columns, binding to the properties of Tweet
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DefaultCellStyle.BackColor = Color.FromArgb(192, 222, 237);
            column.Width = 200;
            column.DataPropertyName = "Text";
            column.Name = "Tweet Text";
            tweetGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DefaultCellStyle.BackColor = Color.FromArgb(192, 222, 237);
            column.DataPropertyName = "Likes";
            column.Name = "Likes";
            tweetGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DefaultCellStyle.BackColor = Color.FromArgb(192, 222, 237);
            column.DataPropertyName = "HashtagCount";
            column.Name = "No. Hashtags";
            tweetGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DefaultCellStyle.BackColor = Color.FromArgb(192, 222, 237);
            column.DataPropertyName = "DateTweeted";
            column.Name = "Date of Tweet";
            tweetGridView.Columns.Add(column);

            // Calculating the avg likes - pick out all the likes from Tweets, then average them
            double avgLikes = (from t in Tweets select t.Likes).Average();
            lblAvgLikes.Text = avgLikes.ToString("F2");
            // Calculating the avg hashtags - same as above
            double avgHashtags = (from t in Tweets select t.HashtagCount).Average();
            lblAvgHashtags.Text = avgHashtags.ToString("F2");
        }

        private void btnLikesGraph_Click(object sender, EventArgs e)
        {
            // create the new graph form, select all the likes out of the tweet data
            // This will display a dialog form with a graph of the likes for each tweet
            GraphForm g = new GraphForm(
                (from t in Tweets select t.Likes).ToList(),
                "Likes"
                );
            g.ShowDialog(this);
            g.Dispose();
        }

        private void btnHashtagsGraph_Click(object sender, EventArgs e)
        {
            // create the new graph form, select all the hashtag counts out of the tweet data
            // This will display a dialog form with a graph of the hashtag count for each tweet
            GraphForm g = new GraphForm(
                (from t in Tweets select t.HashtagCount).ToList(),
                "Hashtags"
                );
            g.ShowDialog(this);
            g.Dispose();
        }

        private void TweetStats_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Bring up the parent form
            ParentForm.Show();
        }
    }
}
