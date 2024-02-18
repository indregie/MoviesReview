using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using Infrastructure.Repositories;

namespace Application.Services;

public class CommentService
{
    private readonly ICommentClient _client;
    public CommentService(ICommentClient client)
    {
        _client = client;
    }

    public async Task<IEnumerable<CommentEntity>> GetComments()
    {
        IEnumerable<CommentEntity> comments = await _client.Get();
        return comments;
    }

    //public async Task<GetAllMoviesResponse> GetMovies()
    //{
    //    IEnumerable<MovieEntity> result = await _movieRepository.GetMovies();

    //    GetAllMoviesResponse response = new GetAllMoviesResponse()
    //    {
    //        Movies = result.Select(m => new InsertMovieResponse { Id = m.Id, Name = m.Name })
    //        .ToList()
    //    };
    //    return response;
    //}

}
