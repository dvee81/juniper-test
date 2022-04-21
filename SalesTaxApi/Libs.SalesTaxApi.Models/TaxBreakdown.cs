using System;
namespace Lib.SalesTaxApi.Models
{
	public class TaxBreakdown
	{
		public double TaxableAmount { get; set; }
		public double TaxCollectable { get; set; }
		public double CombinedTaxRate { get; set; }
		public double StateTaxableAmount { get; set; }
		public double StateTaxRate { get; set; }
		public double CountyTaxCollectable { get; set; }
		public double CityTaxableAmount { get; set; }
		public double CityTaxRate { get; set; }
		public double CityTaxCollectable { get; set; }
		public double SpecialDistrictTaxableAmount { get; set; }
		public double SpecialTaxRate { get; set; }
		public double SpecialDsitrictTaxCollectable { get; set; }
	}
}

