using System;
using Lib.SalesTaxApi.Models;

namespace Lib.SalesTaxApi.Interfaces
{
	public interface ITaxCalculator
	{
		Task<Location?> CalculateRatesForLocation(RateRequest request);
	}
}

