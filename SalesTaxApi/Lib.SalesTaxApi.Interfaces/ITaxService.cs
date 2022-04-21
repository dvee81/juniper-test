using System;
using Lib.SalesTaxApi.Models;

namespace Lib.SalesTaxApi.Interfaces
{
	public interface ITaxService
	{
		Task<Location?> GetRatesForLocation();
	}
}

