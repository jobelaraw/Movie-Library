using MovieLibraryCommon;
using System;

namespace MovieLibraryDL
{
    public class MovieLibraryData
    {

        IMovieLibraryData movielibrarydata;

        public MovieLibraryData()
        {
            movielibrarydata = new InMemoryData();
            //movielibrarydata = new TextFileData();
            //movielibrarydata = new JsonFileData();

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

        public List<Account> GetAllAccounts()
        {
            return movielibrarydata.GetAllAccounts();
        }
        public void CreateAccount(Account account, string userName, string password)
        {
            movielibrarydata.CreateAccount(account, userName, password);

        }

        public void DeleteAccount(Account account, string userName)
        {
            movielibrarydata.DeleteAccount(account, userName);
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

        public Movie UpdateMovieDetails(string title, string newCountry, string newGenre, string newReleaseYear, string watched)
        {
            return movielibrarydata.UpdateMovieDetails(title, newCountry, newGenre, newReleaseYear, watched);
        }

        public Movie GetMovieTitle(string title)
        {
            return movielibrarydata.GetMovieTitle(title);
        }

        public List<Movie> GetMovieList()
        {
            return movielibrarydata.GetMovieList();
        }
    }
}