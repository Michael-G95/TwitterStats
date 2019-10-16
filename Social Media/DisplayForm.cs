using System;
using System.IO;
using System.Windows.Forms;

namespace Social_Media
{
    public partial class DisplayForm : Form
    {
        // Form that will display the information for passed in username


        // Overriding the Parent property of form - as will be calling methods specific to MainForm when restoring it.
        new MainForm Parent;
        TwitterUser ChosenUser { get; set; } // Hold the user object once retrieved from file or from api
        bool LoadFromWeb { get; set; } // Will determine if loading from file or from api - passed in as choice from MainForm
        string UserHandle { get; set; } // User name to load data on

        public DisplayForm(MainForm parentForm, string ChosenHandle, bool bLoadFromWeb)
        {
            InitializeComponent();

            // Initialise class variables with passed in values
            this.Parent = parentForm;
            LoadFromWeb = bLoadFromWeb;
            UserHandle = ChosenHandle;
        }


 
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Restore the main form and reload files (a new profile may have been saved)
            Parent.Show();
            Parent.LoadExistingFiles();
            Close();
            
        }

        private void btnShowTweet_Click(object sender, EventArgs e)
        {
            // Event handler - show the last status of the user when clicked
            MessageBox.Show(ChosenUser.LastStatus);
        }


        private async void DisplayForm_Load(object sender, EventArgs e)
        {
            // On load event for this form

            if (LoadFromWeb)
            {// Load twitter stats from web
                try
                {
                    ChosenUser = new TwitterUser(UserHandle,
                        (string s) => { MessageBox.Show(s); } // Passing in an anonymous method - sending a messagebox to user. Can't pass in messagebox as it has a DialogResult return type
                        );

                    if (await ChosenUser.LoadFromAPI() == true) // Async method as uses HttpClient functions
                    { // Checking to see if the method has loaded from the API successfully - if not can't continue and need to close form

                        try
                        {
                            ChosenUser.WriteToFile("../../../Saved Profiles/" + UserHandle);
                        } // Don't need to check if the saving has failed - TwitterUser will communicate the error, the data can still be displayed
                        catch (Exception)
                        {
                            // Catch any exception not caught by TwitterUser
                            MessageBox.Show("Error in saving the files. Data can still be shown, but is not saved.");
                        }
                    }
                    else
                    {
                        Parent.Show();
                        Close();
                        return;
                    }
                }
                catch (Exception)
                {
                    // catch any exception not handled by TwitterUser
                    MessageBox.Show("Unable to load the user's data. Please try again!");
                    Parent.Show();
                    Close();
                    return;
                }
            }
            else
            {// Load twitter stats from file
                try
                {
                    ChosenUser = new TwitterUser(UserHandle, (string s) => { MessageBox.Show(s); });
                    if (!ChosenUser.ReadFromFile("../../../Saved Profiles/"))
                    {
                        // Error in reading in from file
                        Parent.LoadExistingFiles();
                        Parent.Show();
                        this.Dispose();
                        return;

                    }
                }
                catch (Exception)
                {
                    // Catching any error not caught by twitteruser
                    MessageBox.Show("Unable to access the saved profile. Please try again!");
                    Parent.LoadExistingFiles();
                    Parent.Show();
                    this.Close();
                    return;
                }
            }

            // Set the display labels to display the user's data
            lblHandleText.Text = ChosenUser.ScreenName;
            lblFollowerText.Text = ChosenUser.Followers.ToString("N0");
            lblLikesText.Text = ChosenUser.Likes.ToString("N0");
            lblTweetsText.Text = ChosenUser.TweetCount.ToString("N0");

            lblCreateDateText.Text = ChosenUser.DateCreated;

            pbxProfileIcon.ImageLocation = ChosenUser.PictureURL;
        }     

        private void bTweetsInfo_Click(object sender, EventArgs e)
        {
            // onclick to create and show a tweetstats window, displaying information about recent tweets
            TweetStats ts = new TweetStats(this,ChosenUser.Tweets);
            ts.Show();
            this.Hide();
        }

        private void DisplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Bring up the parent form
            Parent.Show();
        }
    }
}
