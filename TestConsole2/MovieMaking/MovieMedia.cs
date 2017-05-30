using System;

namespace MovieMaking
{
    public class MovieMedia
    {
        public void OnMovieStauts(object source, Movie movie)
        {
            Console.WriteLine("Notification to Media about {0} is in status '{1}'", movie.Title, movie.Status);
        }
    }
}
