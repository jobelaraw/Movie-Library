using MovieLibraryCommon;
using System;

namespace MovieLibraryData
{
    public class AccountHandle
    {
        public static List<Account> accounts = new List<Account>();
        public static List<Movie> movieList = new List<Movie>();
        public static List<Genre> genremovieRecomendation = new List<Genre>
         {
         new Genre { Name = "Action", Movies = new List<string>{ "The K2", "My Name", "Healer", "Vincenzo", "Mr.Sunshine" } },
         new Genre { Name = "Comedy", Movies = new List<string>{ "Midnight Runners", "Extreme Job", "The Thieves", "The Dude In Me", "Luck-Key" } },
         new Genre { Name = "Drama", Movies = new List<string>{ "Laura", "The Handmaiden", "The Man From Nowhere", "Forgotten", "20th Century Girl" } },
         new Genre { Name = "Horror", Movies = new List<string>{ "The Conjuring", "It", "Hereditary", "A Quiet Place", "The Exorcist" } },
         new Genre { Name = "Sci-Fi", Movies = new List<string>{ "Call", "SeoBok", "Night Of The Undead", "Steel Rain", "Badland Hunters" } },
         new Genre { Name = "Romance", Movies = new List<string>{ "True In For Love", "On Your Wedding Day", "Titanic", "Pride & Prejudice", "Hello Stranger"} },
         };


        public AccountHandle()
        {
            CreateAccount();
        }

        private static void CreateAccount()
        {
            Account account1 = new Account();
            account1.Username = "macfroze";
            account1.Password = "macfrozen";
            accounts.Add(account1);

            Account account2 = new Account();
            account2.Username = "brodtire";
            account2.Password = "brodtires";
            accounts.Add(account2);
        }


        public static void AddMovie(string movieTitle, string country, string genre, string releaseDate, string watched)
        {
            movieList.Add(new Movie(movieTitle, country, genre, releaseDate, watched));
        }

        public static bool DeleteMovie(string deleteMovie)
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

        public static bool SearchMovie(string searchMovie)
        {
            foreach (var movie in movieList)
            {
                if (movie.Title.Equals(searchMovie, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateAccount(string userName, string password)
        {
            foreach (var account in accounts)
            {
                if (account.Username == userName && account.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
