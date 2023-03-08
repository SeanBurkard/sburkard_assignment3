namespace sburkard_assignment3.Models
{
    public class ActorMoviesVM
    {
        public Actor Actor { get; set; }
        public List<MovieActor> Movies { get; set; }
        public List<Tweet> Tweets { get; set; }
        public double OverallSentiment { get; set; }
    }
}
