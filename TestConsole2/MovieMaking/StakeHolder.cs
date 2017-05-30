using System;

namespace MovieMaking
{
    public class StakeHolder
    {
        public void OnMovieStauts(object source, Movie movie)
        {
            Console.WriteLine("Notification to Stakeholders about {0} is in status '{1}'", movie.Title, movie.Status);
        }
    }
}
