using Domain.Dtos.Response;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;

namespace Application.Services;

public class MovieService
{
    private readonly ICommentClient _client;
    private readonly IRateRepository _rateRepository;
    public MovieService(ICommentClient client, IRateRepository rateRepository)
    {
        _client = client;
        _rateRepository = rateRepository;
    }

    public async Task<IEnumerable<CommentEntity>> GetComments()
    {
        IEnumerable<CommentEntity> comments = await _client.Get();
        return comments;
    }

}
