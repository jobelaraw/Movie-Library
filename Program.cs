namespace MovieLibrary
{
    internal class Program
    {
      
            static void Main(string[] args)
            {

                //Movie Library System
                //add movie, delete movie, view movie reco, exit


                Console.WriteLine("Welcome To Movie Library!");

                List<string> movieList = new List<string>();
                string[] MenuChoices =
                {
                "[1] Add Movie",
                "[2] Delete Movie",
                "[3] View Movie Recommendations",
                "[4] Exit"
                };

                string choices;
                do
                {
                    Console.WriteLine("\nMain Menu");
                    foreach (var choice in MenuChoices)
                    {
                        Console.WriteLine(choice);
                    }

                    Console.Write("\nKindly Choose an Option: ");
                    choices = Console.ReadLine();


                
                if (choices == "1")
                    {
                        string addMoreMovie;
                        do
                        {
                            Console.Write("Add movie title: ");
                            string addMovie = Console.ReadLine();
                            movieList.Add(addMovie);
                            Console.WriteLine(addMovie + " Added Successfully!!!");

                            Console.Write("Do you want to add another movie? ");
                            addMoreMovie = Console.ReadLine().ToLower();
                        }
                        while (addMoreMovie == "yes");
                    }

                    
                else if (choices == "2")
                    {
                        string deleteAgain;
                        do
                        {
                            Console.Write("Enter movie title to delete: ");
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

                            Console.Write("Do you want to delete another movie? ");
                            deleteAgain = Console.ReadLine().ToLower();
                        }
                        while (deleteAgain == "yes");
                    }


                    
                else if (choices == "3")
                    {
                        Console.WriteLine("\nMovie Recommendations:");

                        if (movieList.Count == 0)
                        {
                            Console.WriteLine("No movies available.");
                        }
                        else
                        {
                            foreach (var movie in movieList)
                            {
                                Console.WriteLine(movie);
                            }
                        }
                    }
                    
                
                else if (choices == "4")
                    {
                        Console.WriteLine("Bye!!!!!");
                    }
                } while (choices != "4");
            }
        }
    }
    //Jobel Araw
    //BSIT 2-1