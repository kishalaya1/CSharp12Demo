using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp12Demo
{
    public class FavMovie
    {
        public string? Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Ratings { get; set; }
        public string? Director { get; set; }
    }
}
