using System;

namespace Lib.SalesTaxApi.Models
{
	public class Tax
	{
		public double OrderTotalAmount { get; set; }
		public double Shipping { get; set; }
		public double TaxableAmount { get; set; }
		public double AmountToCollect { get; set; }
		public double Rate { get; set; }
		public bool HasNexus { get; set; }
		public bool FreightTaxable {get;set;}
		public string? TaxSource { get; set; }
	}
}

