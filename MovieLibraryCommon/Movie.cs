using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryCommon
{

        public class Movie
        {
            public string Title;
            public string Country;
            public string Genre;
            public string ReleaseDate;
            public string Watched;

            public Movie(string title, string country, string genre, string releaseDate, string watched)
            {
                Title = title;
                Country = country;
                Genre = genre;
                ReleaseDate = releaseDate;
                Watched = watched;
            }
        }
    }

