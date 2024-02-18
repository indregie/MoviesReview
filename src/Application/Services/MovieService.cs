using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using Infrastructure.Repositories;

namespace Application.Services;

public class MovieService
{
    private readonly IMovieRepository _movieRepository;
    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<GetAllMoviesResponse> GetMovies()
    {
        IEnumerable<MovieEntity> result = await _movieRepository.GetMovies();

        GetAllMoviesResponse response = new GetAllMoviesResponse()
        {
            Movies = result.Select(m => new InsertMovieResponse { Id = m.Id, Name = m.Name })
            .ToList()
        };
        return response;
    }

    //possible to optimize oneliners as in refreshes service
    public async Task<InsertMovieResponse> Insert(InsertMovieRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
        {
            throw new InvalidNameException();
        }

        MovieEntity movie = new MovieEntity()
        {
            Name = request.Name
        };

        MovieEntity result = await _movieRepository.Insert(movie);

        InsertMovieResponse response = new InsertMovieResponse()
        {
            Id = result.Id,
            Name = result.Name
        };

        return response;
    }

    public async Task<GetMovieByIdResponse> Get(int id)
    {
        MovieEntity? movieResult = await _movieRepository.Get(id)
           ?? throw new MovieNotFoundException();




        return null;
    }
}
