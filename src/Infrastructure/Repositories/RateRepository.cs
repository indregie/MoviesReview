using Dapper;
using Domain.Dtos.Response;
using Domain.Entities;
using Domain.Interfaces;
using System.Data;

namespace Infrastructure.Repositories;

public class RateRepository : IRateRepository
{
    private readonly IDbConnection _connection;

    public RateRepository(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task Delete()
    {
        await _connection.ExecuteAsync("DELETE * FROM currencies");
    }

    public async Task Add(IEnumerable<RateResponse> rateResponses)
    {
        string sql = @"INSERT INTO currencies (date, currency, rate, rate_difference) 
                        VALUES (@Date, @Currency, @Rate, @RateDiff)";
        foreach (var rate in rateResponses)
        {
            var queryObject = new
            {
                Date = rate.Date,
                Currency = rate.Currency,
                Rate = rate.Rate,
                RateDiff = rate.Difference
            };
            await _connection.ExecuteAsync(sql, queryObject);
        }
    }

    public async Task<IEnumerable<RateResponse>> CheckExistence(DateTime date)
    {
        string sql = "SELECT date AS Date, currency AS Currency, rate as Rate, rate_difference AS Difference FROM currencies WHERE date = @Date";

        var queryObject = new
        {
            Date = date
        };

        var result = await _connection.QueryAsync<RateResponse>(sql, queryObject);
        return result;
    }

}
