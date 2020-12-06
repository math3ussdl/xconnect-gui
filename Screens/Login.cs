using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using XConnectGUI.Services;
using XConnectGUI.Screens;

namespace XConnectGUI
{
	public partial class Login : Form
	{
		public bool bFlagLogin;
		private readonly ProfileService service = new ProfileService();
		public string UserType;

		public Login()
		{
			InitializeComponent();

			var version = Assembly.GetExecutingAssembly().GetName().Version;
			versionlbl.Text = version.Major.ToString()
				+ "."
				+ version.Minor.ToString()
				+ "." + version.Build.ToString()
				+ "." + version.Revision.ToString();
		}

		private void ExitBtn_Click(object sender, EventArgs e)
		{
			Close();
			//Application.Exit();
		}

		[Obsolete]
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			string login = LoginBox.Text;
			string password = PasswordBox.Text;
			string userType = UserTypeBox.Text;

			if (login == "" || password == "")
			{
				MessageBox.Show("Preencha todos os campos acima.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				LoginBox.Focus();
			}

			else if (userType.Trim().Equals(string.Empty))
			{
				MessageBox.Show("Você deve selecionar um tipo de usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			else if (password.Length < 6)
			{
				MessageBox.Show("A senha precisa ter, pelo menos, 6 caracteres.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				PasswordBox.Focus();
			}

			else
			{
				Dictionary<string, string> input;

				if (userType.Contains("Física"))
				{
					input = new Dictionary<string, string>
					{
						{ "cpf", login },
						{ "password", password }
					};
				}

				else
				{
					input = new Dictionary<string, string>
					{
						{ "cnpj", login },
						{ "password", password }
					};
				}

				System.Configuration.ConfigurationSettings.AppSettings["USER_TYPE"] = userType;
				System.Configuration.ConfigurationSettings.AppSettings["LOGGED"] = "true";
				this.service.HandleLogin(input, userType, this);
			}
		}

		private void RegistrationLbl_Click(object sender, EventArgs e)
		{
			new Register().ShowDialog();
			this.Hide();
		}
	}
}
