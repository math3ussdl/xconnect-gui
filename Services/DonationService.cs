using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XConnectGUI.DTOs;

namespace XConnectGUI.Services
{
	public class DonationService
	{
		private readonly APIService aPIService = new APIService();
		private readonly ProfileService profileService = new ProfileService();
		private Session session;

		public async Task<List<Donation>> GetMyDonations()
		{
			session = profileService.GetSession();

			HttpResponseMessage response = await aPIService.HandleRequest("/donation/me", HttpMethod.Get, token: session.Token);

			if (response.IsSuccessStatusCode)
			{
				var respBody = await response.Content.ReadAsStringAsync();

				var json = JsonConvert.DeserializeObject<List<Donation>>(respBody);

				return json;
			}

			else
			{
				return new List<Donation>();
			}
		}

		public async Task<List<Donation>> GetDonations()
		{
			session = profileService.GetSession();

			HttpResponseMessage response = await aPIService.HandleRequest("/donation/all", HttpMethod.Get, token: session.Token);

			if (response.IsSuccessStatusCode)
			{
				var respBody = await response.Content.ReadAsStringAsync();

				var json = JsonConvert.DeserializeObject<List<Donation>>(respBody);

				return json;
			}

			else
			{
				return new List<Donation>();
			}
		}

		public async Task<Donation> GetDonation(string number)
		{
			session = profileService.GetSession();

			HttpResponseMessage response = await aPIService.HandleRequest($"/donation/{number}", HttpMethod.Get, token: session.Token);

			if (response.IsSuccessStatusCode)
			{
				var respBody = await response.Content.ReadAsStringAsync();

				Donation donation = JsonConvert.DeserializeObject<Donation>(respBody);

				return donation;
			}

			else
			{
				return new Donation()
				{
					Title = "Doação não Disponível"
				};
			}
		}

		public async void HandleRegister(string input, Form form)
		{
			session = profileService.GetSession();

			HttpResponseMessage response = await aPIService.HandleRequest("/donation/new", HttpMethod.Post, strInput: input, token: session.Token);

			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("Cadastro efetuado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

				form.Close();
			}
		}

		public async void HandleDelete(string targetId, Form form)
		{
			session = profileService.GetSession();

			HttpResponseMessage response = await aPIService.HandleRequest($"/donation/{targetId}", HttpMethod.Delete, token: session.Token);

			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("Doação removida com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

				form.Close();
			}
		}

		public async void HandleAccept(string targetId, Form form)
		{
			session = profileService.GetSession();

			HttpResponseMessage response = await aPIService.HandleRequest($"/donation/{targetId}/accept", HttpMethod.Put, token: session.Token);

			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("Doação aceita com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

				form.Close();
			}
		}
	}
}
