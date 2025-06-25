using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryCommon
{

    public class Movie
    {
        public string Username { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }
        public string ReleaseYear { get; set; }
        public string Watched { get; set; }

    }

    public class Genre
    {
        public string Name { get; set; }
        public List<string> Movies { get; set; }
    }
}

