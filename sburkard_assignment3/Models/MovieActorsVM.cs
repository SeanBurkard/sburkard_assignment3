using Tweetinvi.Client;
using Tweetinvi.Client.V2;
using Tweetinvi.Models.V2;

namespace sburkard_assignment3.Models
{
    public class MovieActorsVM
    {
        public Movie Movie { get; set; }
        public List<MovieActor> Actors { get; set; }
        public List<Tweet> Tweets { get; set; }
        public double OverallSentiment { get; set; }
    }
}
