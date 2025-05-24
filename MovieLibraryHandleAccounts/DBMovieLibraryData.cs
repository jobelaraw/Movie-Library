using MovieLibraryCommon;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace MovieLibraryDL
{
    public class DBMovieLibraryData : IMovieLibraryData
    {
        static string connectionString = "Data Spurce = DESKTOP-C135LTF\\SQLEXPRESS; Initial Catalog = MovieLibraryAccount; Integrated Security = True; TrustServerCertification = True;"; 
        static SqlConnection sqlConnection;

        public DBMovieLibraryData()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        public void AddMovie(string movieTitle, string country, string genre, string releaseYear, string watched)
        {
            throw new NotImplementedException();
        }

        public void CreateAccount(Account account, string userName, string password)
        {

        }

        public void DeleteAccount(Account account, string userName)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMovie(string deleteMovie)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAllAccounts()
        {
            string selectStatement = "SELECT * FROM AccountInfo";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            
            var accounts = new List<Account>();
            while (reader.Read())
            {
                accounts.Add(new Account()
                {
                    Username = reader["UserName"].ToString(),
                    Password = reader["Password"].ToString()
                });

            }
            sqlConnection.Close();
            return accounts;
        }

        public List<Movie> GetMovieList()
        {
            throw new NotImplementedException();
        }

        public Movie GetMovieTitle(string title)
        {
            throw new NotImplementedException();
        }

        public bool SearchMovie(string searchMovie)
        {
            throw new NotImplementedException();
        }

        public Movie UpdateMovieDetails(string title, string newCountry, string newGenre, string newReleaseYear, string watched)
        {
            throw new NotImplementedException();
        }
    }
}
