using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieLibraryCommon;
using MovieLibraryBL;

namespace MovieLibraryAPI.Controllers
{
    [Route("Movie Library/[controller]")]
    [ApiController]

    public class MovieLibraryController : ControllerBase
    {
        private readonly MovieLibraryBL.MovieLibraryProcess _movielibraryprocess;

        public MovieLibraryController(MovieLibraryProcess movielibraryprocess)
        {
            _movielibraryprocess = movielibraryprocess;
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


        [HttpGet("GetMovieTitle")]
        public Movie GetMovieTitle(string title)
        {
            return _movielibraryprocess.GetMovieTitle(title);
        }

        [HttpPatch("UpdateMovieDetails")]
        public Movie UpdateMovieDetails(string userName, string title, string newCountry, string newGenre, string newReleaseYear, string watched)
        {
            return _movielibraryprocess.UpdateMovieDetails(userName, title, newCountry, newGenre, newReleaseYear, watched);
        }

        [HttpPost("AddMovie")]
        public void AddMovie(string userName, string movieTitle, string country, string genre, string releaseYear, string watched)
        {
            _movielibraryprocess.AddMovie(userName, movieTitle, country, genre, releaseYear, watched);
        }

        [HttpDelete("DeleteMovie")]
        public bool DeleteMovie(string userName, string deleteMovie)
        {
            return _movielibraryprocess.DeleteMovie(userName, deleteMovie);
        }

        [HttpGet("SearchMovie")]
        public Movie SearchMovie(string userName, string title)
        {
            return _movielibraryprocess.SearchMovie(userName, title);
        }

        [HttpGet("GetMovieList")]
        public List<Movie> GetMovieList(string userName)
        {
            return _movielibraryprocess.GetMovieList(userName);
        }

        [HttpGet("GetAllAccounts")]
        public List<Account> GetAllAccounts()
        {
            var accounts = _movielibraryprocess.GetAllAccounts();
            return accounts;
        }

        [HttpGet("ValidateAccount")]
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

        [HttpGet("GetMovieLibraryAccount")]
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

        [HttpPost("CreateAccount")]
        public void CreateAccount(string name, string userName, string password)
        {
            _movielibraryprocess.CreateAccount(name, userName, password);
        }

        [HttpDelete("DeleteAccount")]
        public bool DeleteAccount(string userName, string password)
        {
            return _movielibraryprocess.DeleteAccount(userName, password);
        }

        [HttpGet("GetGenreRecommendations")]
        public List<Genre> GetGenreRecommendations()
        {
            return genremovieRecomendation;
        }

    }
}
