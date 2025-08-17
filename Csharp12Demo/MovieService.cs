using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp12Demo
{
    public class MovieService(IMovieRepository movieRepository)
    {
        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await movieRepository.GetAll();
        }
    }
}
