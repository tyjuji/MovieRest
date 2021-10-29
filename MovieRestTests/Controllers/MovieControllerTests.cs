using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieRest.Controllers.Tests
{
    [TestClass()]
    public class MovieControllerTests
    {
        // This is better
        //https://gkama.medium.com/dependency-injection-di-in-net-core-and-net-5-c-unit-tests-935651a99a2d

        private IMovieRepository irepo = new MovieRepository();

        private readonly IMovieRepository _irepo;

        public MovieControllerTests(IMovieRepository irepo)
        {
            _irepo = irepo;
        }

        public MovieControllerTests(){}

        [TestMethod()]
        public void GetAllTest()
        {
            var ctrl = new MovieController(_irepo);

            var result = ctrl.GetAll().ToList();
            var expected = new List<Movie>{
                new Movie { Title = "Rambo", BioRoom = 1, Duration = 120,
                    DateTimes = new List<DateTime>{DateTime.Parse("29-10-2021 13:14") } },
                new Movie { Title = "Rocky", BioRoom = 2, Duration = 130,
                    DateTimes = new List<DateTime>{DateTime.Parse("30-10-2021 14:13") } }
            };

            Assert.AreEqual(expected.Count, result.Count);
        }

        [TestMethod()]
        public void GetAllForDayTest()
        {
            //var ctrl = new MovieController();

            Assert.Fail();
        }

        [TestMethod()]
        public void GetDateTimeForMovieTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PutTest()
        {
            Assert.Fail();
        }
    }
}