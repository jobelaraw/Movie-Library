using MovieLibraryData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MovieLibraryBDL
{
    public class MovieLibraryProcess
    {
        public static List<Movie> movieList = new List<Movie>();
        public static List<Genre> genremovieRecomendation = new List<Genre>
        {
        new Genre { Name = "Action", Movies = new List<string>{ "The K2", "My Name", "Healer", "Vincenzo", "Mr.Sunshine" } },
        new Genre { Name = "Comedy", Movies = new List<string>{ "Midnight Runners", "Extreme Job", "The Thieves", "The Dude In Me", "Luck-Key" } },
        new Genre { Name = "Drama", Movies = new List<string>{ "Laura", "The Handmaiden", "The Man From Nowhere", "Forgotten", "20th Century Girl" } },
        new Genre { Name = "Horror", Movies = new List<string>{ "The Conjuring", "It", "Hereditary", "A Quiet Place", "The Exorcist" } },
        new Genre { Name = "Sci-Fi", Movies = new List<string>{ "Call", "SeoBok", "Night Of The Undead", "Steel Rain", "Badland Hunters" } },
        new Genre { Name = "Romance", Movies = new List<string>{ "True In For Love", "On Your Wedding Day", "Titanic", "Pride & Prejudice", "Hello Stranger"} },
        };

        public static void AddMovie(string movieTitle, string country, string genre, string releaseDate, string watched)
        {
            movieList.Add(new Movie(movieTitle, country, genre, releaseDate, watched));
        }

        public static bool DeleteMovie(string deleteMovie)
        {
            for (int i = 0; i < movieList.Count; i++)
            {
                if (movieList[i].Title.ToLower() == deleteMovie.ToLower())
                {
                    movieList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public static bool SearchMovie(string searchMovie)
        {
            foreach (var movie in movieList)
            {
                if (movie.Title.Equals(searchMovie, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public static List<Movie> GetMovieList()
        {
            return movieList;
        }

        public static Movie GetMovieTitle(string title)
        {
            foreach (var movie in movieList)
            {
                if (movie.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return movie;
                }
            }
            return null;
        }

        public static Movie UpdateMovieDetails(string title, string newCountry, string newGenre, string newReleaseDate, string watched)
        {
            foreach (var movie in movieList)
            {
                if (movie.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (!string.IsNullOrWhiteSpace(newCountry))
                        movie.Country = newCountry;

                    if (!string.IsNullOrWhiteSpace(newGenre))
                        movie.Genre = newGenre;

                    if (!string.IsNullOrWhiteSpace(newReleaseDate))
                        movie.ReleaseDate = newReleaseDate;

                    if (!string.IsNullOrWhiteSpace(watched))
                        movie.Watched = watched;

                    return movie;
                }
            }
            return null;
        }

        public static bool ValidateAccount(string userName, string password)
        {
            AccountHandle accounthandle = new AccountHandle();
            return accounthandle.ValidateAccount(userName, password);
        }

        public class Movie
        {
            public string Title;
            public string Country;
            public string Genre;
            public string ReleaseDate;
            public string Watched;

            public Movie(string title, string country, string genre, string releaseDate, string watched)
            {
                Title = title;
                Country = country;
                Genre = genre;
                ReleaseDate = releaseDate;
                Watched = watched;
            }
        }

        public class Genre
        {
            public string Name { get; set; }
            public List<string> Movies { get; set; }
        }
    }
}




