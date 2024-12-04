namespace MovieManager
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreType { get; set; }
        public string GenreDescription { get; set; }
        public List<Movies> Movies { get; set; }
    }
}
