using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using XConnectGUI.Services;

namespace XConnectGUI.Screens
{
	public partial class Register : Form
	{
		private readonly ProfileService service = new ProfileService();
		private string userType = "pf";

		public Register()
		{
			InitializeComponent();
		}

		private void Register_Load(object sender, EventArgs e)
		{
			PFPanel.Visible = true;
			PJPanel.Visible = false;
			ONGPanel.Visible = false;

			PFCPFBox.MaxLength = 11;
			PJCNPJBox.MaxLength = 14;
			ONGCNPJBox.MaxLength = 14;
		}

		private void UserTypeBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (UserTypeBox.SelectedIndex == 0)
			{
				PJPanel.Visible = false;
				ONGPanel.Visible = false;

				PFPanel.Visible = true;
				PFPanel.Location = new Point(12, 73);

				userType = "pf";
			}

			else if (UserTypeBox.SelectedIndex == 1)
			{
				PFPanel.Visible = false;
				ONGPanel.Visible = false;

				PJPanel.Visible = true;
				PJPanel.Location = new Point(12, 73);

				userType = "pj";
			}

			else if (UserTypeBox.SelectedIndex == 2)
			{
				PFPanel.Visible = false;
				PJPanel.Visible = false;

				ONGPanel.Visible = true;
				ONGPanel.Location = new Point(8, 60);

				userType = "ong";
			}
		}

		private void NumberGenBtn_Click(object sender, EventArgs e)
		{
			Random random = new Random();

			int number = random.Next(100, 999);

			ONGNumberBox.Text = Convert.ToString(number);
		}

		private void CleanBtn_Click(object sender, EventArgs e)
		{
			PFNameBox.Text = "";
			PFSurnameBox.Text = "";
			PFCityBox.Text = "";
			PFCPFBox.Text = "";
			PFGenderBox.Text = "";
			PFMailBox.Text = "";
			PFPassBox.Text = "";
			PFPhoneBox.Text = "";
			PFStateBox.Text = "";
			
			PJCityBox.Text = "";
			PJCNPJBox.Text = "";
			PJMailBox.Text = "";
			PJNameBox.Text = "";
			PJPassBox.Text = "";
			PJPhoneBox.Text = "";
			PJStateBox.Text = "";

			ONGAddressBox.Text = "";
			ONGCityBox.Text = "";
			ONGCNPJBox.Text = "";
			ONGComplement.Text = "";
			ONGMailBox.Text = "";
			ONGNameBox.Text = "";
			ONGNeighborhood.Text = "";
			ONGNumberBox.Text = "";
			ONGPassBox.Text = "";
			ONGPhoneBox.Text = "";
			ONGStateBox.Text = "";
			ONGZipBox.Text = "";

			MessageBox.Show("Campos limpos com sucesso.", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CadBtn_Click(object sender, EventArgs e)
		{
			if (userType == "pf")
			{
				Dictionary<string, string> input = new Dictionary<string, string>
				{
					{ "name", PFNameBox.Text },
					{ "surname", PFSurnameBox.Text },
					{ "email", PFMailBox.Text },
					{ "password", PFPassBox.Text },
					{ "gender", PFGenderBox.Text },
					{ "birthday", PFBirthdayPicker.Value.ToString() },
					{ "cpf", PFCPFBox.Text },
					{ "phone", PFPhoneBox.Text },
					{ "city", PFCityBox.Text },
					{ "state", PFStateBox.Text }
				};

				service.HandleRegister(input, "Pessoa Física", this);
			}

			else if (userType == "pj")
			{
				Dictionary<string, string> input = new Dictionary<string, string>
				{
					{ "name", PJNameBox.Text },
					{ "cnpj", PJCNPJBox.Text },
					{ "email", PJMailBox.Text },
					{ "password", PJPassBox.Text },
					{ "phone", PJPhoneBox.Text },
					{ "city", PJCityBox.Text },
					{ "state", PJStateBox.Text }
				};

				service.HandleRegister(input, "Pessoa Jurídica", this);
			}

			else
			{
				Dictionary<string, string> input = new Dictionary<string, string>
				{
					{ "name", ONGNameBox.Text },
					{ "cnpj", ONGCNPJBox.Text },
					{ "email", ONGMailBox.Text },
					{ "password", ONGPassBox.Text },
					{ "phone", ONGPhoneBox.Text },
					{ "zip", ONGZipBox.Text },
					{ "address", ONGAddressBox.Text },
					{ "neighborhood", ONGNeighborhood.Text },
					{ "complement", ONGComplement.Text },
					{ "city", ONGCityBox.Text },
					{ "state", ONGStateBox.Text },
					{ "number", ONGNumberBox.Text }
				};

				service.HandleRegister(input, "ONG", this);
			}
		}
	}
}
