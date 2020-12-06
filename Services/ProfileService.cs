using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using XConnectGUI.DTOs;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace XConnectGUI.Services
{
	public class ProfileService
	{
		private readonly APIService service = new APIService();

		private readonly string sessionPath =
			$"{Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))}/.data/prfl.json";

		public Session GetSession()
		{
			return JObject.Parse(File.ReadAllText(sessionPath)).ToObject<Session>();
		}

		public async void HandleRegister(Dictionary<string, string> input, string userType, Form form)
		{
			HttpResponseMessage response = await this.service.HandleRequest("/sessions/", HttpMethod.Post, userType, input);

			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("Cadastro efetuado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

				new Login().ShowDialog();
				form.Dispose();
			}
		}

		public async void HandleLogin(Dictionary<string, string> input, string userType, Form form)
		{
			HttpResponseMessage response = await this.service.HandleRequest("/sessions/auth/", HttpMethod.Post, userType, input);

			if (response.IsSuccessStatusCode)
			{
				var data = await response.Content.ReadAsStringAsync();

				var json = JsonConvert.DeserializeObject(data);

				var finalFile = JsonConvert.SerializeObject(json, Formatting.Indented);

				string pathJSON = $"{Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))}/.data/prfl.json";

				System.IO.File.WriteAllText(pathJSON, finalFile);

				MessageBox.Show("Login efetuado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				form.Close();
			}

			else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
			{
				MessageBox.Show("Sua conta não está ativada! Consulte o seu email e ative a sua conta.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void HandleLogOut()
		{
			File.Delete(sessionPath);

			new Login().ShowDialog();
		}
	}
}
