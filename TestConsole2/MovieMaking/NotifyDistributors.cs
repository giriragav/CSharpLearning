using System;

namespace MovieMaking
{
    public class NotifyDistributors
    {
        public void OnMovieStauts(object source,Movie movie)
        {
            Console.WriteLine("Notification to Distributors about {0} is in status '{1}'", movie.Title, movie.Status);
        }
    }
}
