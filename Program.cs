using System.Runtime.CompilerServices;
using System.Collections.Generic;
using MovieLibraryBL;
using MovieLibraryDL;
using MovieLibraryCommon;

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
                "[7] Delete Account",
                "[8] Exit"
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

        static string[] AccountChoices =
        {
            "[1] Signin",
            "[2] Signup",
            "[3] Exit"
        };

        static MovieLibraryProcess movielibraryprocess = new MovieLibraryProcess();
        static bool loggedin = false;

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Movie Library!");

            SignUpOrSignin();

            while (loggedin == true)
            {
                int userChoice;

                do
                {
                    DisplayMenu();
                    userChoice = GetUserInput();

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
                            DeleteAccount();
                            loggedin = false; 
                            break;

                        case 8:
                            Console.WriteLine("Thank you.");
                            loggedin = false;  
                            break;

                        default:
                            Console.WriteLine("Invalid Input. Enter between 1-8.");
                            break;
                    }

                } while (userChoice != 8 && loggedin == true);

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

            static void DisplaySigninOrSignup()
            {
                Console.WriteLine("\n---------------------------");
                Console.WriteLine("\n=====Account Menu=====");
                foreach (var accaction in AccountChoices)
                {
                    Console.WriteLine(accaction);
                }
            }

            static int GetUserInput()
            {
                Console.Write("\nUser Choice: ");
                int userChoice = Convert.ToInt16(Console.ReadLine());
                return userChoice;
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

                    Console.Write("Release Year (yyyy): ");
                    string releaseYear = Console.ReadLine();

                    Console.Write("Have you watched this movie? (Yes or No): ");
                    string watched = Console.ReadLine();

                    movielibraryprocess.AddMovie(movieTitle, country, genre, releaseYear, watched);
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

                    if (movielibraryprocess.DeleteMovie(deleteMovie))
                    {
                        Console.WriteLine(deleteMovie + " Deleted Successfully!!!");
                    }

                    else if (!movielibraryprocess.DeleteMovie(deleteMovie))
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
                if (movielibraryprocess.GetMovieList().Count == 0)
                {
                    Console.WriteLine("\nNo movies available.");
                }
                else
                {
                    Console.WriteLine("\nMovie Titles:");
                    foreach (var movie in movielibraryprocess.GetMovieList())
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
                    Console.Write("\nSearch Movie Title: ");
                    string searchTitle = Console.ReadLine().Trim();

                    var movie = movielibraryprocess.SearchMovie(searchTitle);

                    if (movie != null)
                    {
                        Console.WriteLine("\nMovie Found:");
                        Console.WriteLine("Title: " + movie.Title);
                        Console.WriteLine("Country: " + movie.Country);
                        Console.WriteLine("Genre: " + movie.Genre);
                        Console.WriteLine("Release Year: " + movie.ReleaseYear);
                        Console.WriteLine("Watched: " + movie.Watched);
                    }
                    else
                    {
                        Console.WriteLine(searchTitle + "is not in the list.");
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
                    var movie = movielibraryprocess.GetMovieTitle(title);

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

                        Console.Write("Edit Release Year: ");
                        string newReleaseYear = Console.ReadLine();

                        Console.Write("Have you watched this movie? (Yes/No): ");
                        string watched = Console.ReadLine();

                        var updatedMovie = movielibraryprocess.UpdateMovieDetails(title, newCountry, newGenre, newReleaseYear, watched);

                        Console.WriteLine("\nMovie updated successfully!");
                        Console.WriteLine("====Updated details====");
                        Console.WriteLine("Title: " + updatedMovie.Title);
                        Console.WriteLine("Country: " + updatedMovie.Country);
                        Console.WriteLine("Genre: " + updatedMovie.Genre);
                        Console.WriteLine("ReleaseDate: " + updatedMovie.ReleaseYear);
                        Console.WriteLine("Watched: " + updatedMovie.Watched);
                    }
                    Console.Write("\nDo you want to update another movie? (Yes/No): ");
                    updateAgain = Console.ReadLine().ToLower();

                } while (updateAgain == "yes");
            }

            static void DisplayMovieDetails()
            {
                Console.WriteLine("\nMovies:");
                List<Movie> movie = movielibraryprocess.GetMovieList();
                for (int i = 0; i < movie.Count; i++)
                {
                    Console.WriteLine(
                        "Title: " + movie[i].Title + " | " +
                        " Country: " + movie[i].Country + " | " +
                        " Genre: " + movie[i].Genre + " | " +
                        " Release Year: " + movie[i].ReleaseYear + " | " +
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
                Genre match = null;

                foreach (var genre in MovieLibraryData.genremovieRecomendation)
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

            static void SignUpOrSignin()
            {
                do
                {
                    DisplaySigninOrSignup();
                    int userAccountChoice = GetUserInput();

                    switch (userAccountChoice)
                    {
                        case 1:
                            Signin();
                            break;
                        case 2:
                            Signup();
                            break;
                        case 3:
                            Console.WriteLine("Thank you!");
                            return; 
                        default:
                            Console.WriteLine("Invalid Input. Enter between 1-3.");
                            break;
                    }

                } while (!loggedin);
            }

            static void Signin()
            {
                {
                    Console.Write("\nUsername: ");
                    string userName = Console.ReadLine().Trim();

                    Console.Write("Password: ");
                    string password = Console.ReadLine().Trim();

                    if (movielibraryprocess.ValidateAccount(userName, password))
                    {
                        loggedin = true;
                        Console.WriteLine("Login successful! Welcome, " + userName);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect username or password. Please try again.");
                    }
                }
            }

            static void Signup()
            {
                string name;
                string userName;
                string password;

                do
                {
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine().Trim();

                    Console.Write("Enter Username: ");
                    userName = Console.ReadLine().Trim();

                    Console.Write("Enter Password: ");
                    password = Console.ReadLine().Trim();

                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                    {
                        Console.WriteLine("Please input your Name, Username, and Password.\n");
                        continue;
                    }

                    movielibraryprocess.CreateAccount(name, userName, password);
                    Console.WriteLine("Account created successfully! Please log in.\n");
                    return;

                } while (true);
            }

            static void DeleteAccount()
            {
                Console.WriteLine("\n===== Delete Account =====");

                Console.Write("Plead Enter your Username: ");
                string userName = Console.ReadLine().Trim();

                Console.Write("Please Enter your Password: ");
                string password = Console.ReadLine().Trim();

                Console.Write("Are you sure you want to delete your account? (Yes/No): ");
                string confirmation = Console.ReadLine().Trim().ToLower();

                if (confirmation == "yes")
                {
                    bool deleted = movielibraryprocess.DeleteAccount(userName, password);

                    if (deleted)
                    {
                        Console.WriteLine("\nAccount has been successfully deleted.");
                        loggedin = false;
                        SignUpOrSignin(); 
                    }
                    else
                    {
                        Console.WriteLine("\nProcess Failed.");
                    }
                }
                else
                {
                }
            }
        }
    }
}

//Jobel Araw
//BSIT 2-1