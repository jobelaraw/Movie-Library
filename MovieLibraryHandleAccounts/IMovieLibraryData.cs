using Azure.Core.Pipeline;
using MovieLibraryCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryDL
{
    interface IMovieLibraryData
    {
        public List<Account> GetAllAccounts();
        public void AddMovie(string movieTitle, string country, string genre, string releaseYear, string watched);
        public bool DeleteMovie(string deleteMovie);
        public Movie SearchMovie(string searchMovie);
        public Movie UpdateMovieDetails(string title, string newCountry, string newGenre, string newReleaseYear, string watched);
        public Movie GetMovieTitle(string title);
        public List<Movie> GetMovieList();
        public void CreateAccount(string name, string userName, string password);
        public bool DeleteAccount(string userName, string password);
    }
}
