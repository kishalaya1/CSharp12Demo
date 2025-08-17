namespace CSharp12Demo
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAll();
    }
}