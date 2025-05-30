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
        public void CreateAccount(Account account, string userName, string password);
        public void DeleteAccount(Account account, string userName);
        public void AddMovie(string movieTitle, string country, string genre, string releaseYear, string watched);
        public bool DeleteMovie(string deleteMovie);
        public Movie SearchMovie(string searchMovie);
        public Movie UpdateMovieDetails(string title, string newCountry, string newGenre, string newReleaseYear, string watched);
        public Movie GetMovieTitle(string title);
        public List<Movie> GetMovieList();
    }
}
