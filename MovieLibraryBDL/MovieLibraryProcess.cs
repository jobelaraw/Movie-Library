using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryBDL
{
    public class MovieLibraryProcess
    {
        public static List<string> movieList = new List<string>();

        public static void AddMovie(string addMovie)
        {
            {
                movieList.Add(addMovie);
            }
        }

        public static bool DeleteMovie(string deleteMovie)
        {
            {
                if (movieList.Contains(deleteMovie))
                {
                    movieList.Remove(deleteMovie);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
