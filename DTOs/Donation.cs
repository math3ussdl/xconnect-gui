using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XConnectGUI.DTOs
{
	public class Donation
	{
		public string Number { get; set; } = "";
		public bool Approved { get; set; }
		public string Title { get; set; } = "";
		public string Description { get; set; } = "";
		public int Quantity { get; set; } = 0;
		public Donor Donor { get; set; }
		public ONG ONG { get; set; }
		public List<Product> Product { get; set; }

		[JsonProperty("created_at")]
		public string Created_At { get; set; }
	}
}
