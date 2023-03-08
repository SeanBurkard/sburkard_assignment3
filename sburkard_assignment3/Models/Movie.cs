namespace sburkard_assignment3.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string IMDBLink { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public byte[]? Poster { get; set; }
    }
}
