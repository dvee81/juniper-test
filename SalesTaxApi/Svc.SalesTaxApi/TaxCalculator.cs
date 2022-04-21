using System;
using RestSharp;
using Lib.SalesTaxApi.Interfaces;
using Lib.SalesTaxApi.Models;

namespace Svc.SalesTaxApi
{
    public class TaxJarCalculator : ITaxCalculator
    {
        private readonly RestClient _client;
        
        public TaxJarCalculator(RestClient client)
        {
            _client = client;      
        }

        public  Task<Location?> CalculateRatesForLocation(RateRequest criteria)
        {
            var request = new RestRequest("rates/{zip}");
            request.AddHeader("Authorization", "Token token=\"5da2f821eee4035db4771edab942a4cc\"");
            request.AddUrlSegment("zip","90404");
            request.AddParameter("country", "US");
            request.AddParameter("city", "Santa Monica");

            var task = _client.GetAsync<Location>(request);
            return task;
            
        }
    }
}

