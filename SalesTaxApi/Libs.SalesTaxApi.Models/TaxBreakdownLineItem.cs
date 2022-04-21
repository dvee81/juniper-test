using System;
using System.Text.Json.Serialization;

namespace Lib.SalesTaxApi.Models
{
	public class TaxBreakdownLineItem
	{
		public string? Id { get; set; }
		public double TaxableAmount { get; set; }
		public double TaxCollectable { get; set; }
		public double CombinedTaxRate { get; set; }
		public double StateTaxableAmount { get; set; }
		public double StateSalesTax { get; set; }
		public double StateAmount { get; set; }
		public double CountyTaxableAmount { get; set; }
		public double CountyTaxRate { get; set; }
		public double CityAmount { get; set; }
		[JsonPropertyName("")]
		public double SpecialDistrictTaxableAmount { get; set; }
		[JsonPropertyName("special_tax_rate")]
		public double SpecialTaxRate { get; set; }
		[JsonPropertyName("special_district_amount")]
		public double SpecialDistrictAmount { get; set; }
	}
}

