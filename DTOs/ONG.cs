using Newtonsoft.Json;
using System.Collections.Generic;

namespace XConnectGUI.DTOs
{
	public class ONG
	{
		public string Cnpj { get; set; } = "";

		[JsonProperty("is_active")]
		public bool IsActive { get; set; } = false;

		public string Picture { get; set; } = "";
		public string HashDelete { get; set; } = "";
		public string Address { get; set; } = "";
		public string Name { get; set; } = "";
		public string Email { get; set; } = "";
		public string Password { get; set; } = "";
		public string Number { get; set; } = "";
		public string Complement { get; set; } = "";
		public string Neighborhood { get; set; } = "";
		public string City { get; set; } = "";
		public string State { get; set; } = "";
		public string Zip { get; set; } = "";
		public string Phone { get; set; } = "";
		public List<Donation> Donation { get; set; } = new List<Donation>();
	}
}
