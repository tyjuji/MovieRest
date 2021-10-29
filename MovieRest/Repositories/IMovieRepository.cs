using System;
using System.Collections.Generic;

namespace MovieRest.Repositories
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        List<Movie> GetMoviesByDate(DateTime date);
        List<DateTime> GetDateByMovie(string title);
        void Post(Movie movie);
        void Put(string title, List<DateTime> dates);
        Movie Delete(string title);        
    }
}