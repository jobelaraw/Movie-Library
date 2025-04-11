using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MovieLibraryData;

namespace MovieLibraryBDL
{
    public class MovieLibraryProcess
    {

        AccountHandle accounthandle = new AccountHandle();
        
        public static MovieLibraryCommon.Movie GetMovieTitle(string title)
        {
            foreach (var movie in AccountHandle.movieList)
            {
                if (movie.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return movie;
                }
            }
            return null;
        }

        public static MovieLibraryCommon.Movie UpdateMovieDetails(string title, string newCountry, string newGenre, string newReleaseDate, string watched)
        {
            foreach (var movie in AccountHandle.movieList)
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

        public static void AddMovie(string movieTitle, string country, string genre, string releaseDate, string watched)
        {
            AccountHandle.AddMovie(movieTitle, country, genre, releaseDate, watched);
        }

        public static bool DeleteMovie(string deleteMovie)
        {
          return AccountHandle.DeleteMovie(deleteMovie);         
        }
        
        public static bool SearchMovie(string searchMovie)
        {
            return AccountHandle.SearchMovie(searchMovie);
        }

        public static List<MovieLibraryCommon.Movie> GetMovieList()
        {
            return AccountHandle.movieList;
        }

        public bool ValidateAccount(string userName, string password)
        {
            return accounthandle.ValidateAccount(userName, password);
        }

    }
}




