using Lib.SalesTaxApi.Interfaces;
using Lib.SalesTaxApi.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace Api.SalesTax.Controllers;

[ApiController]
[Route("[controller]")]
public class TaxController : ControllerBase
{
    private readonly ILogger<TaxController> _logger;
    private readonly ITaxService _taxService;
 
    public TaxController(ILogger<TaxController> logger, ITaxService service)
    {
        _logger = logger;
        _taxService = service;

    }

    [HttpGet]
    [Route("rates")]
    public Task<Location?> Get()
    {
        return _taxService.GetRatesForLocation();
    }
}

