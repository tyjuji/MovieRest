using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRest.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private static List<Movie> _movies = new List<Movie>{
            new Movie { Title = "Rambo", BioRoom = 1, Duration = 120,
                DateTimes = new List<DateTime>{DateTime.Parse("29-10-2021 13:14") } },
            new Movie { Title = "Rocky", BioRoom = 2, Duration = 130,
                DateTimes = new List<DateTime>{DateTime.Parse("30-10-2021 14:13") } }
        };

        public List<Movie> GetAll()
        {
            var returnList = _movies.ToList();
            return returnList;
        }

        public List<DateTime> GetDateByMovie(string title)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetMoviesByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void Post(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Put(string title, List<DateTime> dates)
        {
            throw new NotImplementedException();
        }

        public Movie Delete(string title)
        {
            throw new NotImplementedException();
        }
    }
}
