// See https://aka.ms/new-console-template for more information
using CSharp12Demo;

public class MovieRepository : IMovieRepository
{
    Task<IEnumerable<Movie>> IMovieRepository.GetAll()
    {
        throw new NotImplementedException();
    }
}