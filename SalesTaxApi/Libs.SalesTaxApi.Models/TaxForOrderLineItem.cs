using System;
using System.Text.Json.Serialization;

namespace Lib.SalesTaxApi.Models
{
	public class TaxForOrderLineItem
	{
		public string? Id { get; set; }
		public int Quantity { get; set; }
		public string? ProductTaxCode { get; set; }
		[JsonPropertyName("unit_price")]
		public double UnitPrice { get; set; }
		public double Discount { get; set; }
	}
}

