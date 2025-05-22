using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryCommon
{

    public class Movie
    {
        public string Title { get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }
        public string ReleaseYear { get; set; }
        public string Watched { get; set; }

        public Movie()
        {
        }

        public void UpdateDetails(string country, string genre, string releaseYear, string watched)
        {
            if (!string.IsNullOrWhiteSpace(country)) Country = country;
            if (!string.IsNullOrWhiteSpace(genre)) Genre = genre;
            if (!string.IsNullOrWhiteSpace(releaseYear)) ReleaseYear = releaseYear;
            if (!string.IsNullOrWhiteSpace(watched)) Watched = watched;
        }
        public Movie(string title, string country, string genre, string releaseYear, string watched)
        {
            Title = title;
            Country = country;
            Genre = genre;
            ReleaseYear = releaseYear;
            Watched = watched;
        }
    }
}

