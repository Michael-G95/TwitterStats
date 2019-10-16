namespace Social_Media
{
    public class TwitterGetStatusesResponse
    {
        // This class matches the parts of the JSON response sent by twitter that this program uses. Used to Deserialise json into usable object of this class
        public string created_at { get; set; }       
        public string text { get; set; }        
        public Entities entities { get; set; }
        public int favorite_count { get; set; }
        public Retweeted_Status retweeted_status { get; set; }

        public class Entities
        {
            public Hashtag[] hashtags { get; set; }
        }
        public class Retweeted_Status
        {
            public string created_at { get; set; }
        }
        public class Hashtag
        {
            public string text { get; set; }
            public int[] indices { get; set; }
        }
    }
}
