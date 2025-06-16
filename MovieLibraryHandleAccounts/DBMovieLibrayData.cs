using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using MovieLibraryCommon;
using System.Reflection.PortableExecutable;

namespace MovieLibraryDL
{
    public class DBMovieLibraryData : IMovieLibraryData
    {
        static string connectionString = "Data Source = DESKTOP-DSD04FC\\SQLEXPRESS01; Initial Catalog = MovieLibrary; Integrated Security = True; TrustServerCertificate = True;";
        static SqlConnection sqlConnection;
        public DBMovieLibraryData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }


        public void AddMovie(string movieTitle, string country, string genre, string releaseYear, string watched)
        {
            var insertStatement = "INSERT INTO MovieInfo VALUES (@MovieTitle, @MovieCountry, @MovieGenre, @MovieReleaseYear, @MovieWatched)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

                insertCommand.Parameters.AddWithValue("@MovieTitle", movieTitle);
                insertCommand.Parameters.AddWithValue("@MovieCountry", country);
                insertCommand.Parameters.AddWithValue("@MovieGenre", genre);
                insertCommand.Parameters.AddWithValue("@MovieReleaseYear", releaseYear);
                insertCommand.Parameters.AddWithValue("@MovieWatched", watched);

                sqlConnection.Open();
                insertCommand.ExecuteNonQuery();
                sqlConnection.Close();

        }

        public void CreateAccount(string name, string userName, string password)
        {
            var insertStatement = "INSERT INTO AccountInfo (Name, Username, Password) VALUES (@Name, @Username, @Password)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@Name", name);
            insertCommand.Parameters.AddWithValue("@Username", userName);
            insertCommand.Parameters.AddWithValue("@Password", password);

            sqlConnection.Open();
            insertCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public bool DeleteAccount(string userName, string password)
        {
            var deleteStatement = "DELETE FROM AccountInfo WHERE Username = @Username AND Password = @Password";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);

            deleteCommand.Parameters.AddWithValue("@Username", userName);
            deleteCommand.Parameters.AddWithValue("@Password", password);

            sqlConnection.Open();
            int rowsAffected = deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return rowsAffected > 0;
        }

        public bool DeleteMovie(string deleteMovie)
        {
            var deleteStatement = "DELETE FROM MovieInfo WHERE MovieTitle = @MovieTitle";
            sqlConnection.Open();
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            
                deleteCommand.Parameters.AddWithValue("@MovieTitle", deleteMovie);

                int rowsAffected = deleteCommand.ExecuteNonQuery();
                sqlConnection.Close();

                return rowsAffected > 0;
            
        }

        public List<Account> GetAllAccounts()
        {
            string selectStatement = "SELECT Name, Username, Password FROM AccountInfo";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();

            SqlDataReader reader = selectCommand.ExecuteReader();

            var accounts = new List<Account>();

            while (reader.Read())
            {
                Account account = new Account();
                account.Username = reader["Name"].ToString();
                account.Username = reader["Username"].ToString();
                account.Password = reader["Password"].ToString();

                accounts.Add(account);
            }

            sqlConnection.Close();
            return accounts;

        }

        public List<Movie> GetMovieList()
        {
            string selectStatement = "SELECT * FROM MovieInfo";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var movielist = new List<Movie>();
            while (reader.Read())
            {
                movielist.Add(new Movie()
                {
                    Title = reader["MovieTitle"].ToString(),
                    Country = reader["MovieCountry"].ToString(),
                    Genre = reader["MovieGenre"].ToString(),
                    ReleaseYear = reader["MovieReleaseYear"].ToString(),
                    Watched = reader["MovieWatched"].ToString()
                });

            }
            sqlConnection.Close();
            return movielist;
        }


        public Movie GetMovieTitle(string title)
        {
            string selectStatement = "SELECT * FROM MovieInfo WHERE MovieTitle = @MovieTitle";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            {
                selectCommand.Parameters.AddWithValue("@MovieTitle", title);
                sqlConnection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                Movie foundMovie = null;

                if (reader.Read())
                {
                    foundMovie = new Movie
                    {
                        Title = reader["MovieTitle"].ToString(),
                        Country = reader["MovieCountry"].ToString(),
                        Genre = reader["MovieGenre"].ToString(),
                        ReleaseYear = reader["MovieReleaseYear"].ToString(),
                        Watched = reader["MovieWatched"].ToString()
                    };
                }
                reader.Close();
                sqlConnection.Close();
                return foundMovie;
            }
        }

        public Movie SearchMovie(string title)
        {
            string query = "SELECT * FROM MovieInfo WHERE MovieTitle = @MovieTitle";
            SqlCommand selectCommand = new SqlCommand(query, sqlConnection);
            selectCommand.Parameters.AddWithValue("@MovieTitle", title);

            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            Movie movie = null;

            if (reader.Read())
            {
                movie = new Movie
                {
                    Title = reader["MovieTitle"].ToString(),
                    Country = reader["MovieCountry"].ToString(),
                    Genre = reader["MovieGenre"].ToString(),
                    ReleaseYear = reader["MovieReleaseYear"].ToString(),
                    Watched = reader["MovieWatched"].ToString()
                };
            }

            reader.Close();
            sqlConnection.Close();
            return movie;
        }


        public Movie UpdateMovieDetails(string title, string newCountry, string newGenre, string newReleaseYear, string watched)
        {
            sqlConnection.Open();
            var updateStatement = "UPDATE MovieInfo SET MovieCountry = @MovieCountry, MovieGenre = @MovieGenre, MovieReleaseYear = @MovieReleaseYear, MovieWatched = @MovieWatched WHERE MovieTitle = @MovieTitle";

            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@MovieTitle", title);
            updateCommand.Parameters.AddWithValue("@MovieCountry", newCountry);
            updateCommand.Parameters.AddWithValue("@MovieGenre", newGenre);
            updateCommand.Parameters.AddWithValue("@MovieReleaseYear", newReleaseYear);
            updateCommand.Parameters.AddWithValue("@MovieWatched", watched);

            updateCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return new Movie
            {
                Title = title,
                Country = newCountry,
                Genre = newGenre,
                ReleaseYear = newReleaseYear,
                Watched = watched
            };
        }
    }
}