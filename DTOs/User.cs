using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XConnectGUI.DTOs
{
	public class User
	{
		public string Cnpj { get; set; } = "";
		public string Cpf { get; set; } = "";
		public bool IsActive { get; set; } = false;
		public string Picture { get; set; } = "";
		public string HashDelete { get; set; } = "";
		public string Address { get; set; } = "";
		public string Name { get; set; } = "";
		public string Surname { get; set; } = "";
		public string Email { get; set; } = "";
		public string Password { get; set; } = "";
		public string Number { get; set; } = "";
		public string Complement { get; set; } = "";
		public string Neighborhood { get; set; } = "";
		public string City { get; set; } = "";
		public string State { get; set; } = "";
		public string Zip { get; set; } = "";
		public string Phone { get; set; } = "";
	}
}
