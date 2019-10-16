using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Web;
using System.Configuration;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Social_Media
{
    class TwitterUser
    {
        // Class to allow interaction between program and twitter in simple way
        public string ScreenName { get; set; } // Screen name of twitter user
        // Properties of the twitter user
        public int Followers { get; set; }
        public int Likes { get; set; }
        public int TweetCount { get; set; } 

        public string DateCreated { get; set; }
        public float LikesPerPost { get; set; }
        public string LastStatus { get; set; }
        public string PictureURL { get; set; }

        public List<Tweet> Tweets { get; set; } // List of tweet data

        // This delegate used to hold a function to pass error messages to user 
        // Could use console.writeline or MessageBox.show however incase UI/interface type is changed this means the program still
        // Be able to communicate with user, eg. if this was used in a server-side web app this would break the communication
        public delegate void CommunicateToUser(string Message);
        private CommunicateToUser SendErrorMessage { get; set; }


        public TwitterUser(string screenName,CommunicateToUser com)
        {
            // Constructor - only screenName known, will then either read from file or use api to fill other properties
            ScreenName = screenName;
            SendErrorMessage = com;
        }


        public bool ReadFromFile(string path)
        {
            // Function to read a saved TwitterUser from a file, into the current object  
            try
            {
                // Read the file into an arraw
                string[] sFileData = File.ReadAllLines(path + ScreenName + ".txt");
                // Initialise list used to hold the tweets
                Tweets = new List<Tweet>();

                // Read in properties of TwitterUser
                this.ScreenName = sFileData[0];
                this.Followers = Convert.ToInt32(sFileData[1]);
                this.Likes = Convert.ToInt32(sFileData[2]);
                this.TweetCount = Convert.ToInt32(sFileData[3]);
                this.DateCreated = sFileData[4];
                this.PictureURL = sFileData[5];
                this.LastStatus = sFileData[6].Replace((char)37, '\n');

                // Read in all tweets stored in the file
                int i = 6;
                while (++i < sFileData.Length)
                {
                    // Create a tweet object using each line in the file
                    Tweets.Add(new Tweet(
                        sFileData[i].Replace((char)37, '\n'),
                        Convert.ToInt32(sFileData[++i]),
                        Convert.ToInt32(sFileData[++i]),
                        sFileData[++i].Replace((char)37, '\n')
                        ));
                }
                return true; // Execution completed successfully
            }
            catch (FileNotFoundException)
            {
                // File can't be found
                SendErrorMessage("Profile's File not found - please try again!");
                return false;
            }
            catch (IOException)
            {
                // Error during reading - file lock, changed during read, etc
                SendErrorMessage("Error in reading file - please try again!");
                return false;
            }
            catch (FormatException)
            {
                // File has been changed from expected format - old version of program, user error, or data corruption
                SendErrorMessage("Error in reading file data - file may be from old version, or corrupt. Please try again!");
                return false;
            }
            catch (OverflowException)
            {
                // File has been changed from expected format - old version of program, user error, or data corruption
                SendErrorMessage("Error in reading file data - file may be corrupt. Please try again!");
                return false;
            }
            catch (IndexOutOfRangeException)
            {
                // File has been changed from expected format - old version of program, user error, or data corruption
                SendErrorMessage("Error in reading file data - file may be from old version, or corrupt. Please try again!");
                return false;
            }
        }
        public async Task<bool> LoadFromAPI()
        {
            // Create the twitter service object and authenticate with api
            // Convert the delegate type into the one used by twitterservice - they are identical.
            TwitterService ts = new TwitterService(new TwitterService.CommunicateToUser(SendErrorMessage));
            try
            {
                if((!await ts.GetBearerToken())){
                    return false;
                    // error in authenticating
                }
            }catch(Exception )
            {
                // Catch any errors not caught by twitterService
                MessageBox.Show("Error in authenticating to twitter - please check connection and try again!");
                return false;
            }

            //Pull user details from api
            TwitterGetUserResponse user;
            try
            {
                user = await ts.GetUser(ScreenName);
                
                if (user == null)
                {
                    // Error in pulling data from twitter
                    MessageBox.Show("Unable to pull the user's data from twitter. Please try again later!");
                    return false;
                }
            }
            catch (Exception)
            {
                // Catch any exception not handled by twitter service
                MessageBox.Show("Unable to pull the user's data from twitter. Please try again later!");
                return false;
            }
            // Assign user properties to the obtained values
            Followers = user.followers_count;
            Likes = user.favourites_count;
            TweetCount = user.statuses_count;
            DateCreated = user.created_at.Substring(0, user.created_at.IndexOf(':') - 3) + ", " + user.created_at.Substring(user.created_at.IndexOf(':') + 12);
            PictureURL = user.profile_image_url.Replace("normal", "400x400"); // Twitter gives a link to a small image, this will provide a higher res image
            LastStatus = user.status.text;
            this.LikesPerPost = ((float)Followers / TweetCount); // Need to cast to float to avoid integer division

            // Get the last 50 tweets for this user, however as retweets dont have their own
            // data eg. likes we are excluding these, so pulling 50 so we should have enough to work with
            List<TwitterGetStatusesResponse> responseTweets;
            try
            {
                responseTweets = await ts.GetStatuses(ScreenName, 50);
                if (responseTweets == null)
                {
                    // Error in getting tweets
                    MessageBox.Show("Unable to pull the user's tweets from twitter. Please check the user has enough tweets and try again!");
                    return false;
                }
            }catch(Exception)
            {   // Catch any exception not handled by twitter service
                MessageBox.Show("Unable to pull the user's tweets from twitter. Please check the user has enough tweets and try again!");
                return false;
            }
            // Select all tweets that aren't retweets i.e. the retweeted tweet is null, and that have a creation date (if user has under 50 tweets, some of the 50 we pull will be null)
            var originalTweets = (from r in responseTweets where (r.retweeted_status == null && r.created_at!=null) select r);
            if(originalTweets.Count() == 0)
            {
                // User has no tweets in last 50 that aren't retweets - Nothing to analyse
                throw new Exception("User has no original tweets in last 50 tweets, no data to analyse - try another user!");
            }else
            {
                Tweets = new List<Tweet>();
                // User has some original tweets
                foreach (TwitterGetStatusesResponse response in originalTweets)
                {
                    // Move this data into a list of Tweet objects which will be used by the program
                    Tweets.Add(Tweet.FromTwitterResponse(response));
                }
            }
            return true; // Execution completed successfully
        }
        
        public bool WriteToFile(string path)
        {
            // Takes in path (folder) then writes the user to file
            StreamWriter sw=null;
            try
            {
                // Open the file, append set to false so will overwrite.
                sw = new StreamWriter(path + ".txt", false);
                // Write out the properties of user
                sw.WriteLine(ScreenName);
                sw.WriteLine(Followers);
                sw.WriteLine(Likes);
                sw.WriteLine(TweetCount);
                sw.WriteLine(DateCreated);
                sw.WriteLine(PictureURL);
                sw.WriteLine(LastStatus.Replace('\n', (char)37)); // Line breaks replaced with ascii unit seperator (37) to allow file reading to function

                // Write out the tweet info
                foreach (Tweet t in Tweets)
                {

                    sw.WriteLine(t.Text.Replace('\n', (char)37));
                    sw.WriteLine(t.Likes);
                    sw.WriteLine(t.HashtagCount);
                    sw.WriteLine(t.DateTweeted.Replace('\n', (char)37));
                }
                return true; // Execution completed successfully
            }
            catch (IOException)
            {
                SendErrorMessage("Unable to access the file to save the user. Data may still be displayed, but isn't saved");
                return false;
            }
            finally
            {
                if(sw!=null)
                    sw.Close();
            }
            
        }

    }
}
