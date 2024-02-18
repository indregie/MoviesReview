using Dapper;
using Domain.Dtos.Response;
using Domain.Entities;
using Domain.Interfaces;
using System.Data;

namespace Infrastructure.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly IDbConnection _connection;

    public MovieRepository(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<MovieEntity> Insert(MovieEntity movie)
    {
        string sql = @"INSERT INTO movies (name, average_rate) 
                        VALUES (@Name, @AverageRate) 
                        RETURNING id as Id, name as Name, average_rate as AverageRate";

        var queryObject = new
        {
            movie.Name,
            movie.AverageRate
        };

        return await _connection.QuerySingleAsync<MovieEntity>(sql, queryObject);
    }

}

