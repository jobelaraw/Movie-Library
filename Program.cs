using System.Runtime.CompilerServices;
using System.Collections.Generic;
using MovieLibraryBDL;
using MovieLibraryData;
using static MovieLibraryBDL.MovieLibraryProcess;

namespace MovieLibrary
{
    internal class Program
    {

        static string[] MenuChoices =
               {
                "[1] Add Movie",
                "[2] Delete Movie",
                "[3] View Movie List",
                "[4] Search Movie",
                "[5] Update Movie",
                "[6] Movie Recommendation",
                "[7] Exit"
                };

        static string[] movieGenres =
                 {
                 "Action",
                 "Comedy",
                 "Drama",
                 "Horror",
                 "Sci-Fi",
                 "Romance"
                 };

        static MovieLibraryProcess movieLibrary = new MovieLibraryProcess();
        static string userName = string.Empty;


        static void Main(string[] args)
        {

            //Movie Library System

            Console.WriteLine("Welcome To Movie Library!");


            string password = string.Empty;

            do
            {

                Console.Write("\nUsername: ");
                userName = Console.ReadLine();

                Console.Write("\nPassword: ");
                password = Console.ReadLine();

                if (!movieLibrary.ValidateAccount(userName, password))
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

            } while (!movieLibrary.ValidateAccount(userName, password));


            DisplayMenu();
            int userChoice = GetUserInput();

            while (userChoice != 7)
            {
                switch (userChoice)
                {

                    case 1:
                        AddMovie();
                        break;

                    case 2:
                        DeleteMovie();
                        break;

                    case 3:
                        ViewMovieList();
                        break;

                    case 4:
                        SearchMovie();
                        break;

                    case 5:
                        UpdateMovieDetails();
                        break;

                    case 6:
                        MovieRecommendation();
                        break;

                    case 7:
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Enter between 1-7.");
                        break;
                }

                DisplayMenu();
                userChoice = GetUserInput();
            }
            Console.WriteLine("End. Thanks!!!!");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("\n=====Main Menu=====");
            foreach (var choice in MenuChoices)
            {
                Console.WriteLine(choice);
            }
        }

        static int GetUserInput()
        {
            Console.Write("\nUser Choice: ");
            int userInput = Convert.ToInt16(Console.ReadLine());
            return userInput;
        }

        static void AddMovie()
        {
            string addMoreMovie;
            do
            {
                Console.Write("\nAdd movie title: ");
                string movieTitle = Console.ReadLine();

                Console.Write("Country: ");
                string country = Console.ReadLine();

                Console.Write("Genre: ");
                string genre = Console.ReadLine();

                Console.Write("Release Date (mm-dd-yyyy): ");
                string date = Console.ReadLine();

                Console.Write("Have you watched this movie? (Yes or No): ");
                string watched = Console.ReadLine();

                MovieLibraryProcess.AddMovie(movieTitle, country, genre, date, watched);
                Console.WriteLine(movieTitle + " Added Successfully!!!");
                Console.Write("\nDo you want to add another movie?(Yes/No):  ");
                addMoreMovie = Console.ReadLine().ToLower();
            }
            while (addMoreMovie == "yes");

        }

        static void DeleteMovie()
        {
            string deleteAgain;
            do
            {
                DisplayMovieDetails();
                Console.Write("\nEnter movie title to delete: ");
                string deleteMovie = Console.ReadLine();

                if (MovieLibraryProcess.DeleteMovie(deleteMovie))
                {
                    Console.WriteLine(deleteMovie + " Deleted Successfully!!!");
                }

                else if (!MovieLibraryProcess.DeleteMovie(deleteMovie))
                {
                    Console.WriteLine(deleteMovie + " is unable to delete.");
                }

                Console.Write("\nDo you want to delete another movie?(Yes/No): ");
                deleteAgain = Console.ReadLine().ToLower();
            }
            while (deleteAgain == "yes");
        }

        static void ViewMovieList()
        {

            if (AccountHandle.movieList.Count == 0)
            {
                Console.WriteLine("\nNo movies available.");
            }
            else
            {
                Console.WriteLine("\nMovie Titles:");
                foreach (var movie in AccountHandle.movieList)
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }

        static void SearchMovie()
        {
            string searchAgain;
            do
            {
                Console.Write("\nSearch by Movie Title: ");
                string searchTitle = Console.ReadLine();

                if (MovieLibraryProcess.SearchMovie(searchTitle))
                {
                    foreach (var movie in AccountHandle.movieList)
                    {
                        if (movie.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("\nMovie Found:");
                            Console.WriteLine("Title: " + movie.Title);
                            Console.WriteLine("Country: " + movie.Country);
                            Console.WriteLine("Genre: " + movie.Genre);
                            Console.WriteLine("Release Date: " + movie.ReleaseDate);
                            Console.WriteLine("Watched: " + movie.Watched);

                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n" + searchTitle + " is not on the Movie List.");
                }

                Console.Write("\nDo you want to search another movie? (Yes/No): ");
                searchAgain = Console.ReadLine().ToLower();

            } while (searchAgain == "yes");
        }

        static void UpdateMovieDetails()
        {
            string updateAgain;
            do
            {
                DisplayMovieDetails();
                Console.Write("\nEnter movie title you want to update: ");
                string title = Console.ReadLine();
                var movie = MovieLibraryProcess.GetMovieTitle(title);

                if (movie == null)
                {
                    Console.WriteLine("\nMovie not found.");
                }
                else
                {
                    Console.Write("Edit Country: ");
                    string newCountry = Console.ReadLine();

                    Console.Write("Edit Genre: ");
                    string newGenre = Console.ReadLine();

                    Console.Write("Edit Release Date: ");
                    string newReleaseDate = Console.ReadLine();

                    Console.Write("Have you watched this movie? (Type done): ");
                    string watched = Console.ReadLine();

                    var updatedMovie = MovieLibraryProcess.UpdateMovieDetails(title, newCountry, newGenre, newReleaseDate, watched);

                    Console.WriteLine("\nMovie updated successfully!");
                    Console.WriteLine("====Updated details====");
                    Console.WriteLine("Title: " + updatedMovie.Title);
                    Console.WriteLine("Country: " + updatedMovie.Country);
                    Console.WriteLine("Genre: " + updatedMovie.Genre);
                    Console.WriteLine("Watched: " + updatedMovie.Watched);
                }
                Console.Write("\nDo you want to update another movie? (Yes/No): ");
                updateAgain = Console.ReadLine().ToLower();

            } while (updateAgain == "yes");
        }

        static void DisplayMovieDetails()
        {
            Console.WriteLine("\nMovies:");
            List<MovieLibraryCommon.Movie> movie = MovieLibraryProcess.GetMovieList();
            for (int i = 0; i < movie.Count; i++)
            {
                Console.WriteLine(
                    "Title: " + movie[i].Title + " | " +
                    " Country: " + movie[i].Country + " | " +
                    " Genre: " + movie[i].Genre + " | " +
                    " Release Date: " + movie[i].ReleaseDate + " | " +
                    " Watched: " + movie[i].Watched + "\n");
            }

        }

        static void MovieRecommendation()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("\n=====Genre List=====");
            foreach (var genre in movieGenres)
            {
                Console.WriteLine(genre);
            }

            Console.Write("\nEnter Genre: ");
            string genreChoice = Console.ReadLine();
            MovieLibraryCommon.Genre match = null;

            foreach (var genre in AccountHandle.genremovieRecomendation)
            {
                if (string.Equals(genre.Name, genreChoice, StringComparison.OrdinalIgnoreCase))
                {
                    match = genre;
                    break;
                }
            }

            if (match != null)
            {
                Console.WriteLine("\nMovies Available:");
                foreach (var movie in match.Movies)
                {
                    Console.WriteLine(movie);
                }
            }

        }
    }
}

//Jobel Araw
//BSIT 2-1