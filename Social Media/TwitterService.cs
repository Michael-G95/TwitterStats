    using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Social_Media
{
    class TwitterService
    {
        // Class to authenticate with, and read from the twitter api

        private readonly string KEY; // Used to authenticate with twitter
        private readonly string SECRET;// Used to authenticate with twitter
        private HttpClient httpClient; // the object used to send GET and POST actions
        private string Bearer_Token { get; set; } // Hplds authentication token for twitter once obtained
        public delegate void CommunicateToUser(string message); 
        public CommunicateToUser SendErrorMessage { get; set; }// Holds a method to send error messages to user

        public TwitterService(CommunicateToUser com)
        {
            // Keys for the application to access twitter api

            /**
             * ************************ DEVELOPER NOTICE **************************************
             * 
             * This section has been edited to remove the application key and secret for security reasons when uploading to github, 
             * so that it can't be used by any public person that sees the project.
             * Insert your own KEY and SECRET below to use the API functions - or the program will still function reading a saved file provided.
             * 
             * *********************************************************************************
             */
            KEY = "REMOVED_FOR_SECURITY";
            SECRET = "REMOVED_FOR_SECURITY";

            //Sending an error message as the API cant be accessed unless a key is provided above
            com("The application key and secret must be provided. See TwitterService.cs for more details.");
            SendErrorMessage = com;
        }

        public async Task<bool> GetBearerToken()
        {
            // Method to get an access token to use twitter api
            // Uses HTTP Post to get a response, then extract the useful data to a class.

            httpClient = new HttpClient();

            // Converting the key and secret into a base64 encoded token - this is how twitter needs to recieve the authentication to accept it
            string keyEncoded = WebUtility.UrlEncode(KEY);
            string secretEncoded = WebUtility.UrlEncode(SECRET);
            string authEncoded = Convert.ToBase64String(
                Encoding.UTF8.GetBytes(KEY + ":" + secretEncoded)
                );

            // Settings for getting the bearer (auth) token
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Basic " + authEncoded);
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded;charset=UTF-8");

            var values = new Dictionary<string, string> { { "grant_type", "client_credentials" } };
            var body = new FormUrlEncodedContent(values);

            // Get the response from twitter api
            try
            {
                HttpResponseMessage response = await httpClient.PostAsync("https://api.twitter.com/oauth2/token", body);
                string payload = await response.Content.ReadAsStringAsync();

                // Try to convert the response into useful object 
                JavaScriptSerializer ser = new JavaScriptSerializer();
                TwitterAuthResponse twitterAuthResponse = ser.Deserialize<TwitterAuthResponse>(payload);
                Bearer_Token = twitterAuthResponse.access_token;
                return true; // Execution completed successfully

           
            }
            catch (ArgumentException)
            {
                // GET failed if can't pull this from JSON - api change or error in transmission?
                Bearer_Token = null;
                SendErrorMessage("Error authenticating to twitter! Please check connection and try again");
                return false;
            }
            catch (HttpRequestException )
            {
                // Invalid request - tokens invalid, connection issue... 
                Bearer_Token = null;
                SendErrorMessage("Error authenticating to twitter! Please check connection and try again");
                return false;
            }
        }


        public async Task<TwitterGetUserResponse> GetUser(string screen_name)
        {
            // Method to get user data from Twitter API for the screen name
            if (Bearer_Token == null)
            {
                return null;
            }
            httpClient = new HttpClient();
            try
            {
                // Creating the httpclient used to do the GET request
                httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + Bearer_Token);

                // Send the GET request, then execute it and get JSON response as string
                HttpResponseMessage response = await httpClient.GetAsync("https://api.twitter.com/1.1/users/show.json?screen_name=" + screen_name);
                string responseBody = await response.Content.ReadAsStringAsync();

                // Using this class to read the JSON into a matching class
                JavaScriptSerializer jss = new JavaScriptSerializer();                
                return jss.Deserialize<TwitterGetUserResponse>(responseBody);
            }
            catch (HttpRequestException)
            {
                // Error in http request
                SendErrorMessage("Unable to load profile - please check screen name!");
                return null;
            }
            catch (ArgumentException)
            {
                // error in reading json
                SendErrorMessage("Unable to load profile - please try again!");
                return null;
            }
            
        }

        public async Task<List<TwitterGetStatusesResponse>> GetStatuses(string screen_name,int count)
        {
            // Function to get count number of most recent tweets for screen_name
            try
            {
                // Create HttpClient used for the request to twitter api
                httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + Bearer_Token);

                // Send the GET request, and get response as JSON string
                HttpResponseMessage response = await httpClient.GetAsync("https://api.twitter.com/1.1/statuses/user_timeline.json?screen_name=" + screen_name+ "&count="+count+"&include_rts=false");
                string responseBody = await response.Content.ReadAsStringAsync();

                // Using this class to read the JSON into a matching class
                JavaScriptSerializer jss = new JavaScriptSerializer();
                return jss.Deserialize<List<TwitterGetStatusesResponse>>(responseBody);
            }
            catch (Exception )
            {
                // If there is an exception, pass this message back to user
                throw new Exception("Unable to download user profile - please check name!");
            }
        }

        
       
    }
}
