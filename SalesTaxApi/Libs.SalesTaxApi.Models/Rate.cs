using System;
using System.Text.Json.Serialization;

namespace Lib.SalesTaxApi.Models
{
	public class Rate
	{
		public string? Zip { get; set; }
		public string? State { get; set; }
		[JsonPropertyName("state_rate")]
		public double StateRate { get; set; }
		public string? County { get; set; }
		[JsonPropertyName("county_rate")]
		public double CountyRate { get; set; }
		public string? Country { get; set; }
		[JsonPropertyName("country_rate")]
		public double CountryRate { get; set; }
		public string? City { get; set; }
		[JsonPropertyName("city_rate")]
		public double CityRate { get; set; }
		[JsonPropertyName("combined_district_rate")]
		public double CombinedDistrictRate { get; set; }
		[JsonPropertyName("combined_rate")]
		public double CombinedRate { get; set; }
		public bool FreightTaxable { get; set; }
	}
}