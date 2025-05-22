using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryCommon
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();

    }

    public class Genre
    {
        public string Name { get; set; }
        public List<string> Movies { get; set; }
    }

}

