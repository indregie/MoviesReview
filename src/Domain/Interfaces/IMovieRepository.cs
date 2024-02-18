using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IMovieRepository
    {
        Task<MovieEntity> Insert(MovieEntity movie);
    }
}