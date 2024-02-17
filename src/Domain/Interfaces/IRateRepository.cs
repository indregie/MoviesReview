using Domain.Dtos.Response;

namespace Domain.Interfaces;

public interface IRateRepository
{
    Task Delete();
    Task Add(IEnumerable<RateResponse> rateResponses);
    Task<IEnumerable<RateResponse>> CheckExistence(DateTime date);
}