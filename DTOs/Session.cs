using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XConnectGUI.DTOs
{
	public class Session
	{
		public bool Auth { get; set; } = false;
		public object User { get; set; }
		public string Token { get; set; } = "";
	}
}
