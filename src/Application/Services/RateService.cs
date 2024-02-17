using Domain.Dtos.Response;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;

namespace Application.Services;

public class RateService
{
    //private readonly IExchangeRatesClient _client;
    //private readonly IRateRepository _rateRepository;
    //public RateService(IExchangeRatesClient client, IRateRepository rateRepository)
    //{
    //    _client = client;
    //    _rateRepository = rateRepository;
    //}

    //public async Task<IEnumerable<RateResponse>> Get(DateTime date)
    //{
    //    if (date > new DateTime(2014, 12, 31))
    //    {
    //        throw new RatesNotFoundException();
    //    }

    //    IEnumerable<RateResponse> existsInDb = await CheckExistence(date);

    //    if (existsInDb.Count() == 0)
    //    {
    //        IEnumerable<RateEntity> rateEntities = await _client.Get(date);
    //        Dictionary<string, decimal> ratesDict = ConvertToDict(rateEntities);

    //        IEnumerable<RateEntity> rateEntitiesPrev = await _client.Get(date.AddDays(-1));
    //        Dictionary<string, decimal> ratesDictPrev = ConvertToDict(rateEntitiesPrev);

    //        Dictionary<string, decimal> differences = new Dictionary<string, decimal>();
    //        foreach (var keyValuePair in ratesDict)
    //        {
    //            string currency = keyValuePair.Key;
    //            decimal rate = keyValuePair.Value;
    //            decimal prevRate = ratesDictPrev[currency];

    //            decimal diff = rate - prevRate;
    //            differences[currency] = diff;
    //        }

    //        List<RateResponse> rateResponses = new List<RateResponse>();
    //        foreach (var keyValuePair in differences)
    //        {
    //            RateResponse rateResponse = new RateResponse
    //            {
    //                Date = date,
    //                Currency = keyValuePair.Key,
    //                Rate = ratesDict[keyValuePair.Key],
    //                Difference = keyValuePair.Value
    //            };

    //            rateResponses.Add(rateResponse);
    //        }
    //        await _rateRepository.Add(rateResponses);

    //        IEnumerable<RateResponse> sortedResponses = rateResponses.OrderByDescending(r => r.Difference);

    //        return sortedResponses;
    //    }

    //    return existsInDb.OrderByDescending(r => r.Difference);

    //}

    //public async Task<IEnumerable<RateResponse>> CheckExistence(DateTime date)
    //{
    //    return await _rateRepository.CheckExistence(date);
    //}

    //public Dictionary<string, decimal> ConvertToDict(IEnumerable<RateEntity> rateEntities)
    //{
    //    Dictionary<string, decimal> result = new Dictionary<string, decimal>();
    //    foreach (var rateEntity in rateEntities)
    //    {
    //        result.Add(rateEntity.Currency, rateEntity.Rate);
    //    }
    //    return result;
    //}

    //public async Task CleanUp()
    //{
    //    await _rateRepository.Delete();
    //}

}
