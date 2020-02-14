using System;
using System.Collections.Generic;
using System.Text;

namespace GodfatherCharacters.Data
{
    public class Movie
    {
        public string Title { get; set; }
        public int YearReleased { get; set; }
    }
    
    public static class Movies
    {
        public static IEnumerable<Movie> GetMovies() 
        {
            yield return new Movie
            {
                Title = "The Godfather",
                YearReleased = 1972
            };

            yield return new Movie
            {
                Title = "The Godfather, Part II",
                YearReleased = 1974
            };

            yield return new Movie
            {
                Title = "The Godfather, Part III",
                YearReleased = 1990
            };

        }
    }
}
