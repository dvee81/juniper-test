using Lib.SalesTaxApi.Models;
using Lib.SalesTaxApi.Interfaces;
using Microsoft.Extensions.Configuration;  

namespace Svc.SalesTaxApi
{
    public class TaxJarService : ITaxService
    {
        private readonly ITaxCalculator _calculator;
        
        public TaxJarService(ITaxCalculator calculator)
        {
            _calculator = calculator;
            
        }

        public Task<Location?> GetRatesForLocation()
        {
            return _calculator.CalculateRatesForLocation(new RateRequest());
        }
    }
}

