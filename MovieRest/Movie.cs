using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRest
{
    public class Movie
    {
        public string Title { get; set; }

        public int BioRoom { get; set; }

        public int Duration { get; set; } // Minutes

        public List<DateTime> DateTimes { get; set; }
    }
}
