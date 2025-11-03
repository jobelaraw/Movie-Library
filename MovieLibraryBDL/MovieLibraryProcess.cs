using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Azure.Identity;
using MovieLibraryCommon;
using MovieLibraryDL;


namespace MovieLibraryBL
{
    public class MovieLibraryProcess
    {

        
        MovieLibraryData movielibrarydata = new MovieLibraryData();
        private readonly MovieLibraryEmail _movielibraryemail;

        public MovieLibraryProcess(MovieLibraryEmail movielibraryemail)
        {
            _movielibraryemail = movielibraryemail;
        }

        public static List<Genre> genremovieRecomendation = new List<Genre>
         {
         new Genre { Name = "Action", Movies = new List<string>{ "The K2", "My Name", "Healer", "Vincenzo", "Mr.Sunshine" } },
         new Genre { Name = "Comedy", Movies = new List<string>{ "Midnight Runners", "Extreme Job", "The Thieves", "The Dude In Me", "Luck-Key" } },
         new Genre { Name = "Drama", Movies = new List<string>{ "Laura", "The Handmaiden", "The Man From Nowhere", "Forgotten", "20th Century Girl" } },
         new Genre { Name = "Horror", Movies = new List<string>{ "The Conjuring", "It", "Hereditary", "A Quiet Place", "The Exorcist" } },
         new Genre { Name = "Sci-Fi", Movies = new List<string>{ "Call", "SeoBok", "Night Of The Undead", "Steel Rain", "Badland Hunters" } },
         new Genre { Name = "Romance", Movies = new List<string>{ "True In For Love", "On Your Wedding Day", "Titanic", "Pride & Prejudice", "Hello Stranger"} },
         };

        public Movie GetMovieTitle(string title)
        {
            return movielibrarydata.GetMovieTitle(title);
        }

        public Movie UpdateMovieDetails(string userName, string title, string newCountry, string newGenre, string newReleaseYear, string watched)
        {
            return movielibrarydata.UpdateMovieDetails(userName, title, newCountry, newGenre, newReleaseYear, watched);
        }

        public void AddMovie(string userName, string movieTitle, string country, string genre, string releaseYear, string watched)
        {
            movielibrarydata.AddMovie(userName, movieTitle, country, genre, releaseYear, watched);
        }

        public bool DeleteMovie(string userName, string deleteMovie)
        {
            return movielibrarydata.DeleteMovie(userName, deleteMovie);
        }

        public Movie SearchMovie(string userName, string title)
        {
            return movielibrarydata.SearchMovie(userName, title);
        }

        public List<Movie> GetMovieList(string userName)
        {
            return movielibrarydata.GetMovieList(userName);
        }

        public List<Account> GetAllAccounts()
        {
            var accounts = movielibrarydata.GetAllAccounts();
            return accounts;
        }

        public bool ValidateAccount(string userName, string password)
        {

            var acc = GetMovieLibraryAccount(userName, password);

            if (acc.Username != null)
            {
                return true;
            }

            return false;

        }

        public Account GetMovieLibraryAccount(string userName, string password)
        {
            var accounts = GetAllAccounts();
            var foundAccount = new Account();

            foreach (var account in accounts)
            {
                if (account.Username.Trim() == userName.Trim() && account.Password.Trim() == password.Trim())
                {
                    foundAccount = account;
                }
            }
            return foundAccount;
        }

        public void CreateAccount(string name, string userName, string password)
        {
            movielibrarydata.CreateAccount(name, userName, password);
            _movielibraryemail.SendEmail(name, userName, password);
        }

        public bool DeleteAccount(string userName, string password)
        {
            return movielibrarydata.DeleteAccount(userName, password);
        }

        public List<Genre> GetGenreRecommendations()
        {
            return genremovieRecomendation;
        }


    }
}