using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media
{
    public class Tweet
    {
        // Class to hold the tweet data that will be analysed in this project
        public string Text { get; set; }
        public int Likes { get; set; }
        public int HashtagCount { get; set; }
        public string DateTweeted { get; set; }

        public Tweet(string text, int likes, int hashtagCount, string dateTweeted)
        {
            // Class constructor, set passed in properties
            Text = text;
            Likes = likes;
            HashtagCount = hashtagCount;
            DateTweeted = dateTweeted;
        }

        public static Tweet FromTwitterResponse(TwitterGetStatusesResponse response)
        {
            // Method to extract the data to be stored in Tweet, from a full json-representing TwitterGetStatusesResponse object.
                return new Tweet(
                response.text,
                response.favorite_count,
                response.entities.hashtags.Count(),
                response.created_at
                );
           }
    }

    

}
