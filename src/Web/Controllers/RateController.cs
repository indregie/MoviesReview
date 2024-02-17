using Application.Services;
using Domain.Dtos.Response;
using Infrastructure.Errors;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

/// <summary>
/// Represents the API for managing rates.
/// </summary>
[ApiController]
public class RateController : Controller
{
    private RateService _rateService;
    /// <summary>
    /// Controller for managing rates.
    /// </summary>
    public RateController(RateService rateService)
    {
        _rateService = rateService;
    }

    /// <summary>
    /// Retrieve a list of currencies for a given day along with their differences in exchange rates compared to the previous day. The specified day should not be later than December 31, 2014.
    /// </summary>
    /// <returns>List of currencies with rates (based on Litas).</returns>
    /// 
    [HttpGet("rates")]
    [ProducesResponseType(typeof(IEnumerable<RateResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get([FromQuery] DateTime date)
    {
        return Ok();
    }
}
