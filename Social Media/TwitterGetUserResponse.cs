namespace Social_Media
{

   
    public class TwitterGetUserResponse
    {
        // This class matches the parts of the JSON response sent by twitter that this program uses. Used to Deserialise json into usable object of this class
            public int followers_count { get; set; }
            public string created_at { get; set; }
            public int favourites_count { get; set; }
            public int statuses_count { get; set; }
            public Status status { get; set; }
            public string profile_image_url { get; set; }
        public class Status
        {
            public string text { get; set; }
        }
    }




}
