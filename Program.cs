using System.Runtime.CompilerServices;

namespace MovieLibrary
{
    internal class Program
    {

        static List<string> movieList = new List<string>();
        static string[] MenuChoices =
               {
                "[1] Add Movie",
                "[2] Delete Movie",
                "[3] View Movie Recommendations",
                "[4] Exit"
                };

        static void Main(string[] args)
        {

            //Movie Library System
            //add movie, delete movie, view movie reco, exit

            Console.WriteLine("Welcome To Movie Library!");


            DisplayMenu();
            int userChoice = GetUserInput();


            while (userChoice != 4)
            {
                switch (userChoice)
                {

                    case 1:
                        AddMovie(1);
                        break;

                    case 2:
                        DeleteMovie();
                        break;

                    case 3:
                        ViewMovieRecommendations();
                        break;

                    case 4:                        
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please enter between 1-4 to access.");
                        break;
                }      
                DisplayMenu();
                userChoice = GetUserInput();
                Console.WriteLine("End. Thanks!!!!");
            }
        }


            static void DisplayMenu()
            {
                Console.WriteLine("\n-------------");
                Console.WriteLine("\nMain Menu");
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


            static void AddMovie(int userChoice)
            {
                if (userChoice == 1)
                {
                    string addMoreMovie;
                    do
                    {
                        Console.Write("\nAdd movie title: ");
                        string addMovie = Console.ReadLine();
                        movieList.Add(addMovie);
                        Console.WriteLine(addMovie + " Added Successfully!!!");

                        Console.Write("\nDo you want to add another movie?(Yes/No):  ");
                        addMoreMovie = Console.ReadLine().ToLower();
                    }
                    while (addMoreMovie == "yes");
                }
            }


            static void DeleteMovie()
            {
                string deleteAgain;
                do
                {
                    Console.Write("\nEnter movie title to delete: ");
                    string deleteMovie = Console.ReadLine();

                    if (movieList.Contains(deleteMovie))
                    {
                        movieList.Remove(deleteMovie);
                        Console.WriteLine(deleteMovie + " Deleted Successfully!!!");
                    }
                    else
                    {
                        Console.WriteLine(deleteMovie + " is not on the list.");
                    }

                    Console.Write("\nDo you want to delete another movie?(Yes/No): ");
                    deleteAgain = Console.ReadLine().ToLower();
                }
                while (deleteAgain == "yes");
            }


            static void ViewMovieRecommendations()
            {
                Console.WriteLine("\nMovie Recommendations:");

                if (movieList.Count == 0)
                {
                    Console.WriteLine("\nNo movies available.");
                }
                else
                {
                    foreach (var movie in movieList)
                    {
                        Console.WriteLine(movie);
                    }
                }
            }
        }   
    }
    //Jobel Araw
    //BSIT 2-1