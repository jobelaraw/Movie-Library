﻿using MovieLibraryCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieLibraryDL
{
    public class JsonFileData : IMovieLibraryData
    {
        List<Account> accounts = new List<Account>();
        List<Movie> movieList = new List<Movie>();
        string AccountjsonFilePath = "accounts.json";
        string MovieListjsonFilePath = "movielists.json";

        public JsonFileData()
        {
            ReadJsonDataFromFileAccount();
            ReadJsonDataFromFileMovieList();
        }
        private void ReadJsonDataFromFileAccount()
        {
            string jsonText = File.ReadAllText(AccountjsonFilePath);

            accounts = JsonSerializer.Deserialize<List<Account>>(jsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        private void WriteJsonDataToFileAccount()
        {
            string jsonString = JsonSerializer.Serialize(accounts, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(AccountjsonFilePath, jsonString);
        }

        private void ReadJsonDataFromFileMovieList()
        {
            string jsonText = File.ReadAllText(MovieListjsonFilePath);

            movieList = JsonSerializer.Deserialize<List<Movie>>(jsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        private void WriteJsonDataToFileMovieList()
        {
            string jsonString = JsonSerializer.Serialize(movieList, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(MovieListjsonFilePath, jsonString);
        }

        private int FindAccountIndex(Account account, string userName)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Username == account.Username)
                {
                    return i;
                }
            }

            return -1;
        }

        private int FindMovieListIndex(string title)
        {
            for (int i = 0; i < movieList.Count; i++)
            {
                if (movieList[i].Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

        public List<Account> GetAllAccounts()
        {
            return accounts;
        }

        public void CreateAccount(Account account, string userName, string password)
        {
            accounts.Add(account);
            WriteJsonDataToFileAccount();
        }

        public void DeleteAccount(Account account, string userName)
        {
            var index = FindAccountIndex(account, account.Username);

            accounts.RemoveAt(index);
            WriteJsonDataToFileAccount();
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
            WriteJsonDataToFileMovieList();
        }

        public bool DeleteMovie(string deleteMovie)
        {
            ReadJsonDataFromFileMovieList();
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
                WriteJsonDataToFileMovieList();

                return true;
            }
            return false;
        }

        public bool SearchMovie(string searchMovie)
        {
            {
                foreach (var movie in movieList)
                {
                    if (movie.Title.Contains(searchMovie, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public Movie UpdateMovieDetails(string title, string newCountry, string newGenre, string newReleaseYear, string watched)
        {
            {
                ReadJsonDataFromFileMovieList();
                int index = FindMovieListIndex(title);
                if (index != -1)
                {
                    movieList[index].Country = newCountry;
                    movieList[index].Genre = newGenre;
                    movieList[index].ReleaseYear = newReleaseYear;
                    movieList[index].Watched = watched;

                    WriteJsonDataToFileMovieList();
                    return movieList[index];
                }
                return null;
            }
        }

        public Movie GetMovieTitle(string title)
        {
            ReadJsonDataFromFileMovieList();
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
            ReadJsonDataFromFileMovieList();
            return movieList;
        }
    }
}
