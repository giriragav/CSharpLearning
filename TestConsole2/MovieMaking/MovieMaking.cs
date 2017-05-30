using System;
using System.Threading;

namespace MovieMaking
{
    public class MovieMaking
    {
        //public delegate void MovieStatusChangeEventHandler(object source, EventArgs arg, Movie movie);
        //public event MovieStatusChangeEventHandler MovieStatusChange;

        public EventHandler<Movie> MovieStatusChange;

        public void Start(Movie movie)
        {
            PreProduction(movie);
        }
        public void PreProduction(Movie movie)
        {
            movie.Status = "Pre Production";
            OnMovieStatusChange(movie);
            Thread.Sleep(5000);
            Shooting(movie);
        }

        public void Shooting(Movie movie)
        {
            movie.Status = "Shooting";
            OnMovieStatusChange(movie);
            Thread.Sleep(5000);
            PostProdcution(movie);
        }

        public void PostProdcution(Movie movie)
        {
            movie.Status = "PostProduction";
            OnMovieStatusChange(movie);
            Thread.Sleep(5000);
            Release(movie);
        }
        public void Release(Movie movie)
        {
            movie.Status = "Release";
            OnMovieStatusChange(movie);
        }

        public virtual void OnMovieStatusChange(Movie movie)
        {
            MovieStatusChange(this, movie);
        }

    }
}
