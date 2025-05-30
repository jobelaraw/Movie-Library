using MovieLibraryCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryDL
{
    public class InMemoryData : IMovieLibraryData
    {
        List<Movie> movieList = new List<Movie>();
        List<Account> accounts = new List<Account>();


        public InMemoryData()
        {
            CreateList();
            CreateAcc();
        }

        private void CreateList()
        {
            Movie list1 = new Movie();
            list1.Title = "Laura";
            list1.Country = "Indonesia";
            list1.Genre = "Drama";
            list1.ReleaseYear = "2025";
            list1.Watched = "Yes";
            movieList.Add(list1);

        }

        private void CreateAcc()
        {
            Account account1 = new Account();
            account1.Username = "jobel";
            account1.Password = "jobel123";
            accounts.Add(account1);

        }

        public void CreateAccount(Account account, string userName, string password)
        {
            {
                accounts.Add(new Account
                {
                    Username = userName,
                    Password = password,
                });
            }
        }

        public void DeleteAccount(Account account, string userName)
        {
            var accountToRemove = accounts.FirstOrDefault(a => a.Username == userName);
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Username == userName)
                {
                    accounts.RemoveAt(i);
                    break;
                }
            }
        }

        public void AddMovie(string movieTitle, string country, string genre, string releaseYear, string watched)
        {
            movieList.Add(new Movie(movieTitle, country, genre, releaseYear, watched));
        }

        public bool DeleteMovie(string deleteMovie)
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

        public Movie SearchMovie(string searchMovie)
        {
            foreach (var movie in movieList)
            {
                if (movie.Title.Equals(searchMovie, StringComparison.OrdinalIgnoreCase))
                {
                    return movie; 
                }
            }
            return null; 
        }


        public Movie UpdateMovieDetails(string title, string newCountry, string newGenre, string newReleaseYear, string watched)
        {

            var movie = movieList.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (movie != null)
            {
                movie.UpdateDetails(newCountry, newGenre, newReleaseYear, watched);
            }
            return movie;
        }

        public Movie GetMovieTitle(string title)
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

        public List<Movie> GetMovieList()
        {
            return movieList;

        }

        public List<Account> GetAllAccounts()
        {
            return accounts;
        }
    }
}

