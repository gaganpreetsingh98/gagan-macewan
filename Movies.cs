using System.ComponentModel.DataAnnotations;

namespace MovieManager
{
    public class Movies
    {
        [Key]
        public int MoviesId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string MovieDescription { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }

    }
}
