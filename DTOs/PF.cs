using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XConnectGUI.DTOs
{
	public class PF
	{
		public string Cpf { get; set; } = "";
		public string Name { get; set; } = "";
		public string Surname { get; set; } = "";
		public string Gender { get; set; } = "";
		public string Birthday { get; set; } = "";
		public Donor Donor { get; set; } = new Donor();
	}
}
