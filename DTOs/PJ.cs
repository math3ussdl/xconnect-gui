using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XConnectGUI.DTOs
{
	public class PJ
	{
		public string Cnpj { get; set; } = "";
		public string Name { get; set; } = "";
		public Donor Donor { get; set; } = new Donor();
	}
}
