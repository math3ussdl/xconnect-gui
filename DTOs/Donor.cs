using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XConnectGUI.DTOs
{
	public class Donor
	{
		public string Id { get; set; } = "";
		public bool Active { get; set; } = false;
		public string Picture { get; set; } = "";
		public string HashDelete { get; set; } = "";
		public string Email { get; set; } = "";
		public string Password { get; set; } = "";
		public string Phone { get; set; } = "";
		public string City { get; set; } = "";
		public string State { get; set; } = "";
		public List<Donation> Donation { get; set; } = new List<Donation>();
		public List<PF> PF { get; set; } = new List<PF>();
		public List<PJ> PJ { get; set; } = new List<PJ>();
	}
}
