// See https://aka.ms/new-console-template for more information
using CSharp12Demo;

public class MovieRepository : IMovieRepository
{
    Task<IEnumerable<Movie>> IMovieRepository.GetAll()
    {
        return Task.FromResult<IEnumerable<Movie>>(
            new List<Movie>
            {
                new Movie("Inception", new DateTime(2010, 7, 16), 9, "Christopher Nolan"),
                new Movie("The Matrix", new DateTime(1999, 3, 31), 8, "Lana Wachowski and Lilly Wachowski"),
                new Movie("Interstellar", new DateTime(2014, 11, 7), 9, "Christopher Nolan")
            });
    }
}