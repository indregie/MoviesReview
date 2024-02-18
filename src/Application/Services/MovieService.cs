using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Repositories;

namespace Application.Services;

public class MovieService
{
    private readonly ICommentClient _client;
    private readonly IMovieRepository _movieRepository;
    public MovieService(ICommentClient client, IMovieRepository movieRepository)
    {
        _client = client;
        _movieRepository = movieRepository;
    }

    public async Task<IEnumerable<CommentEntity>> GetComments()
    {
        IEnumerable<CommentEntity> comments = await _client.Get();
        return comments;
    }
    public async Task<InsertMovieResponse> Insert(InsertMovieRequest request)
    {
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
}
