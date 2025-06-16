using MovieLibraryCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryDL
{
    public class TextFileData : IMovieLibraryData
    {
        string AccountfilePath = "account.txt";
        string MovieListfilePath = "movielist.txt";

        static List<Account> accounts = new List<Account>();
        static List<Movie> movieList = new List<Movie>();

        public TextFileData()
        {
            GetDataFromFileAccount();
            GetDataFromFileMovieList();
        }

        private void GetDataFromFileAccount()
        {
            var lines = File.ReadAllLines(AccountfilePath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                accounts.Add(new Account
                {
                    Name = parts[0],
                    Username = parts[1],
                    Password = parts[2],

                });
            }
        }

        private void GetDataFromFileMovieList()
        {
            movieList.Clear();
            var lines = File.ReadAllLines(MovieListfilePath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                movieList.Add(new Movie
                {
                    Title = parts[0],
                    Country = parts[1],
                    Genre = parts[2],
                    ReleaseYear = parts[3],
                    Watched = parts[4],
                });
            }
        }

        private void WriteDataToFileAccount()
        {
            var lines = new string[accounts.Count];

            for (int i = 0; i < accounts.Count; i++)
            {
                lines[i] = accounts[i].Name + "|" + accounts[i].Username + "|" + accounts[i].Password;
            }

            File.WriteAllLines(AccountfilePath, lines);
        }

        private void WriteDataToFileMovieList()
        {
            var lines = new string[movieList.Count];

            for (int i = 0; i < movieList.Count; i++)
            {
                lines[i] = movieList[i].Title + "|" +
                           movieList[i].Country + "|" +
                           movieList[i].Genre + "|" +
                           movieList[i].ReleaseYear + "|" +
                           movieList[i].Watched;
            }

            File.WriteAllLines(MovieListfilePath, lines);
        }

        public int FindIndexMovieList(Movie movies)
        {
            for (int i = 0; i < movieList.Count; i++)
            {
                if (movieList[i].Title == movies.Title)
                {
                    return i;
                }
            }

            return -1;
        }

        public void AddMovie(string movieTitle, string country, string genre, string releaseYear, string watched)
        {
            var newMovie = new Movie
            {
                Title = movieTitle,
                Country = country,
                Genre = genre,
                ReleaseYear = releaseYear,
                Watched = watched
            };

            movieList.Add(newMovie);
            WriteDataToFileMovieList();
        }

        public bool DeleteMovie(string deleteMovie)
        {
            GetDataFromFileMovieList();
            deleteMovie = deleteMovie.Trim();
            int index = -1;

            for (int i = 0; i < movieList.Count; i++)
            {
                if (movieList[i].Title.Trim().Equals(deleteMovie, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                movieList.RemoveAt(index);
                WriteDataToFileMovieList();

                return true;
            }
            return false;
        }

        public List<Movie> GetMovieList()
        {
            GetDataFromFileMovieList();
            return movieList;
        }

        public Movie GetMovieTitle(string title)
        {

            movieList.Clear();
            GetDataFromFileMovieList();

            foreach (var movie in movieList)
            {
                if (movie.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return movie;
                }
            }

            return null;
        }

        public Movie SearchMovie(string searchMovie)
        {
            GetDataFromFileMovieList();
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
            Movie tempMovie = new Movie { Title = title };
            int index = FindIndexMovieList(tempMovie);

            if (index != -1)
            {
                movieList[index].Country = newCountry;
                movieList[index].Genre = newGenre;
                movieList[index].ReleaseYear = newReleaseYear;
                movieList[index].Watched = watched;

                WriteDataToFileMovieList();
                return movieList[index];
            }

            return null;
        }

        public List<Account> GetAllAccounts()
        {
            return accounts;
        }

        public void CreateAccount(string name, string userName, string password)
        {
            {
                if (accounts.Any(a => a.Username.Equals(userName, StringComparison.OrdinalIgnoreCase)))
                {
                    return;
                }

                Account newAccount = new Account
                {
                    Name = name,
                    Username = userName,
                    Password = password
                };

                accounts.Add(newAccount);
                WriteDataToFileAccount(); 
            }
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
                    WriteDataToFileAccount(); 
                    return true;
                }
                return false;
            }
        }
    }

}

