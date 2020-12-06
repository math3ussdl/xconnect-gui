using Newtonsoft.Json;

namespace XConnectGUI.DTOs
{
	public class Product
	{
		public string Id { get; set; } = null;

		[JsonProperty("description")]
		public string Description { get; set; } = "";

		[JsonProperty("quantity")]
		public int Quantity { get; set; } = 1;

		public Donation Donation { get; set; }
	}
}
