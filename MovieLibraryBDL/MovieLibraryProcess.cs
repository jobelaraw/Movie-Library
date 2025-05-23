using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MovieLibraryCommon;
using MovieLibraryDL;

namespace MovieLibraryBL
{
    public class MovieLibraryProcess
    {


        MovieLibraryData movielibrarydata = new MovieLibraryData();

        public Movie GetMovieTitle(string title)
        {
            return movielibrarydata.GetMovieTitle(title);
        }

        public Movie UpdateMovieDetails(string title, string newCountry, string newGenre, string newReleaseYear, string watched)
        {
            return movielibrarydata.UpdateMovieDetails(title, newCountry, newGenre, newReleaseYear, watched);
        }

        public void AddMovie(string movieTitle, string country, string genre, string releaseYear, string watched)
        {
            movielibrarydata.AddMovie(movieTitle, country, genre, releaseYear, watched);
        }

        public bool DeleteMovie(string deleteMovie)
        {
            return movielibrarydata.DeleteMovie(deleteMovie);
        }

        public bool SearchMovie(string searchMovie)
        {
            return movielibrarydata.SearchMovie(searchMovie);
        }

        public List<Movie> GetMovieList()
        {
            return movielibrarydata.GetMovieList();
        }

        public bool ValidateAccount(string userName, string password)
        {
            {
                var acc = GetMovieLibraryAccount(userName, password);

                if (acc.Username != null)
                {
                    return true;
                }

                return false;
            }
        }

        private Account GetMovieLibraryAccount(string userName, string password)
        {
            var bankAccounts = movielibrarydata.GetAllAccounts();
            var foundAccount = new Account();

            foreach (var account in bankAccounts)
            {
                if (account.Username == userName && account.Password == password)
                {
                    foundAccount = account;
                }
            }
            return foundAccount;
        }

    }
}



