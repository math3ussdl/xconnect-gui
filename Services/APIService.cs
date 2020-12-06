using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XConnectGUI.Services
{
	public class APIService
	{
		public async Task<HttpResponseMessage> HandleRequest(
			string reqUrl,
			HttpMethod method,
			string userType = "",
			dynamic contentInput = null,
			string strInput = "",
			string token = ""
		)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("http://localhost:3000");

				dynamic content = null;

				if (token != "")
				{
					client.DefaultRequestHeaders.Add("x-access-token", $"{token}");
				}

				if (contentInput != null)
				{
					content = new FormUrlEncodedContent(contentInput);
				}

				else if (strInput != "")
				{
					content = new StringContent(strInput, Encoding.UTF8, "application/json");
				}

				else
				{
					content = null;
				}

				string url = "";

				if (userType == null)
				{
					url = "";
				}

				else if (userType.Contains("Física"))
				{
					url = "pf";
				}

				else if (userType.Contains("Jurídica"))
				{
					url = "pj";
				}

				else if (userType.Contains("ONG"))
				{
					url = "ong";
				}

				if (method == HttpMethod.Get)
				{
					return await client.GetAsync(reqUrl + url);
				}

				else if (method == HttpMethod.Post)
				{
					return await client.PostAsync(reqUrl + url, content);
				}

				else if (method == HttpMethod.Put)
				{
					return await client.PutAsync(reqUrl + url, content);
				}

				else
				{
					return await client.DeleteAsync(reqUrl + url);
				}
			}
		}
	}
}
