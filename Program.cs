using System.Runtime.CompilerServices;
using MovieLibraryBusinessDataLogic;

namespace MovieLibrary
{
    internal class Program
    {

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
                        AddMovie();
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
            }
            Console.WriteLine("End. Thanks!!!!");

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


        //Process
        static void AddMovie()
        {
            string addMoreMovie;
            do
            {
                Console.Write("\nAdd movie title: ");
                string addMovie = Console.ReadLine();
                Console.WriteLine(addMovie + " Added Successfully!!!");
                MovieLibraryProcess.AddMovie(addMovie);
                Console.Write("\nDo you want to add another movie?(Yes/No):  ");
                addMoreMovie = Console.ReadLine().ToLower();
            }
            while (addMoreMovie == "yes");

        }


        //Process
        static void DeleteMovie()
        {
            string deleteAgain;
            do
            {
                Console.Write("\nEnter movie title to delete: ");
                string deleteMovie = Console.ReadLine();

                if (MovieLibraryProcess.DeleteMovie(deleteMovie))
                {
                    Console.WriteLine(deleteMovie + " Deleted Successfully!!!");
                }

                else if (!MovieLibraryProcess.DeleteMovie(deleteMovie))
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

            if (MovieLibraryProcess.movieList.Count == 0)
                
            {
                Console.WriteLine("\nNo movies available.");
            }
            else
            {
                foreach (var movie in MovieLibraryProcess.movieList)
                {
                    Console.WriteLine(movie);
                }
            }
        }
    }
}
//Jobel Araw
//BSIT 2-1