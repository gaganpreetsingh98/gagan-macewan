using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MovieManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataContext())
            {
                AddGenres(db);
                AddMovies(db);
                Query1(db);
                Query2(db);

            }
        }

        private static void Query1(DataContext db)
        {
            var result = db.Movies.Include(x => x.Genre).Select(x => new
            {
                GenreTypeName = x.Genre.GenreType,
                GenreDescription = x.Genre.GenreDescription,
            });
            Console.WriteLine($"Results: {result.Count()} Movies");
            foreach (var genre in result)
            {
                Console.WriteLine($"{genre.GenreDescription}, {genre.GenreTypeName}");
            }
            Console.WriteLine("");
        }
        private static void Query2(DataContext db)
        {
            var result = db.Movies.Include(x => x.Genre).Include(p => p.Genre).Select(x => new
            {
                GenreTypeName = x.Genre.GenreDescription,
                TotalMovies = x.MovieDescription.Count()
            });
            Console.WriteLine($"Results: {result.Count()} Movies with total posts");
            foreach (var movie in result)
            {
                Console.WriteLine($"{movie.GenreTypeName}, {movie.TotalMovies}, {movie.GenreTypeName} Movies");
            }
            Console.WriteLine("");
        }

        private static void AddGenres(DataContext db)
        {
            if (db.Genres.Count() == 0)
            {
                              
                    Console.WriteLine("Adding Genres...");
                    AddGenre(db, "horror", "nvfkaj");
                    AddGenre(db, "comedy", "fgmnwekqjklef");
                    AddGenre(db, "love", "wafesdag");

                     db.SaveChanges();
                
            }
            else
            {
                Console.WriteLine("Genres already exist...");
            }
        }
        private static void AddGenre(DataContext db, string genretype, string genredescription)
        {
            db.Genres.Add(new Genre()
            {

                GenreType = genretype,
                GenreDescription = genredescription,

            });
        }
        private static void AddMovies(DataContext db)
        {
            
            if (db.Movies.Count() == 0)
            {
                var genre = db.Genres.FirstOrDefault(x => x.GenreType == "horror");
                if (genre != null)
                {
                    Console.WriteLine("Adding  Movies...");
                    AddMovie(db, "Interstellar", "Sci-fi/adventure", "Christopher Nolan", genre);

                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Genre is null");
                }
                
            }
            else
            {
                Console.WriteLine("Movies already exist...");
            }
        }
        private static void AddMovie(DataContext db, string title, string moviedescription, string director , Genre genre)
        {
            db.Movies.Add(new Movies()
            {
                
                Title = title,
                MovieDescription = moviedescription,
                Director = director,
                Genre = genre

            });


        }
        
    }
}
