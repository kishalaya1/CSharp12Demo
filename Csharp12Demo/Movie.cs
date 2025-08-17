using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp12Demo
{
    public class Movie(string name, DateTime releaseDate, int ratings, string director)
    {
        public string Name { get; } = name;
        public DateTime ReleaseDate { get; } = releaseDate;
        public int Ratings { get; } = ratings;
        public string Director { get; } = director;

        public string GetDescription()
        {
            return $"{Name} is directed by {Director} and was released on {ReleaseDate.ToShortDateString()}. It has a rating of {Ratings}.";
        }
    }
}
