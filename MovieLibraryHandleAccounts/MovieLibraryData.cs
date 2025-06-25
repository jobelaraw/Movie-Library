using MovieLibraryCommon;
using System;

namespace MovieLibraryDL
{
    public class MovieLibraryData
    {

        IMovieLibraryData movielibrarydata;

        public MovieLibraryData()
        {
            //movielibrarydata = new InMemoryData();
            //movielibrarydata = new TextFileData();
            //movielibrarydata = new JsonFileData();
            movielibrarydata = new DBMovieLibraryData();

        }

        public List<Account> GetAllAccounts()
        {
            return movielibrarydata.GetAllAccounts();
        }
      
        public void AddMovie(string userName, string movieTitle, string country, string genre, string releaseYear, string watched)
        {
            movielibrarydata.AddMovie(userName, movieTitle, country, genre, releaseYear, watched);
        }

        public bool DeleteMovie(string userName, string deleteMovie)
        {
            return movielibrarydata.DeleteMovie(userName, deleteMovie);
        }

        public Movie SearchMovie(string userName, string searchMovie)
        {
            return movielibrarydata.SearchMovie(userName, searchMovie);
        }

        public Movie UpdateMovieDetails(string userName, string title, string newCountry, string newGenre, string newReleaseYear, string watched)
        {
            return movielibrarydata.UpdateMovieDetails(userName, title, newCountry, newGenre, newReleaseYear, watched);
        }

        public Movie GetMovieTitle(string title)
        {
            return movielibrarydata.GetMovieTitle(title);
        }

        public List<Movie> GetMovieList(string userName)
        {
            return movielibrarydata.GetMovieList(userName);
        }

        public void CreateAccount(string name, string userName, string password)
        {
            movielibrarydata.CreateAccount(name, userName, password);
        }

        public bool DeleteAccount(string userName, string password)
        {
            return movielibrarydata.DeleteAccount(userName, password);
        }
    }
}