using MovieLibraryCommon;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
            account1.Name = "Jobel Araw";
            account1.Username = "jobel";
            account1.Password = "jobel123";
            accounts.Add(account1);

        }
       

        public void AddMovie(string userName, string movieTitle, string country, string genre, string releaseYear, string watched)
        {
            Movie newMovie = new Movie();
            newMovie.Username = userName;
            newMovie.Title = movieTitle;
            newMovie.Country = country;
            newMovie.Genre = genre;
            newMovie.ReleaseYear = releaseYear;
            newMovie.Watched = watched;

            movieList.Add(newMovie);
        }

        public bool DeleteMovie(string userName, string deleteMovie)
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

        public Movie SearchMovie(string userName, string searchMovie)
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

        public Movie UpdateMovieDetails(string userName, string title, string newCountry, string newGenre, string newReleaseYear, string watched)
        {
            var movie = movieList.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (movie != null)
            {
                if (!string.IsNullOrWhiteSpace(newCountry)) movie.Country = newCountry;
                if (!string.IsNullOrWhiteSpace(newGenre)) movie.Genre = newGenre;
                if (!string.IsNullOrWhiteSpace(newReleaseYear)) movie.ReleaseYear = newReleaseYear;
                if (!string.IsNullOrWhiteSpace(watched)) movie.Watched = watched;
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

        public List<Movie> GetMovieList(string userName)
        {
            return movieList;

        }

        public List<Account> GetAllAccounts()
        {
            return accounts;
        }

        public void CreateAccount(string name, string userName, string password)
        {
            if (accounts.Any(a => a.Username.Equals(userName, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }

            Account newAccount = new Account()
            {
                Name = name,
                Username = userName,
                Password = password
            };

            accounts.Add(newAccount);
        }        

        public bool DeleteAccount(string userName, string password)
        {
            {
                var account = accounts.FirstOrDefault(a =>
                    a.Username.Equals(userName, StringComparison.OrdinalIgnoreCase) &&
                    a.Password == password);

                if (account != null)
                {
                    accounts.Remove(account);
                    return true;
                }
                return false;
            }
        }
    }
}

