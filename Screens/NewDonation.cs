using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using XConnectGUI.DTOs;
using XConnectGUI.Services;

namespace XConnectGUI.Screens
{
	public partial class NewDonation : Form
	{
		private readonly DonationService donationService = new DonationService();

		private readonly List<Dictionary<string, dynamic>> products = new List<Dictionary<string, dynamic>>();

		public NewDonation()
		{
			InitializeComponent();
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ClearBtn_Click(object sender, EventArgs e)
		{
			// Clear All Fields
			const string message =
				"Você tem certeza?";
			const string caption = "Lembre-se que esta ação é irreversível";
			var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,	MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				TitleBox.Text = "";
				DescriptionBox.Text = "";
				QuantityBox.Text = "";

				ProductDescBox.Text = "";
				ProductQuantityBox.Text = "";

				products.Clear();
				ProductGridView.Rows.Clear();
			}
		}

		private void AddProductBtn_Click(object sender, EventArgs e)
		{
			DataTable ss = new DataTable();
			ss.Columns.Add("Descrição");
			ss.Columns.Add("Quantidade");

			DataRow row = ss.NewRow();
			row["Descrição"] = ProductDescBox.Text;
			row["Quantidade"] = ProductQuantityBox.Text;

			ss.Rows.Add(row);

			var product = new Dictionary<string, dynamic>
			{
				{ "description", row["Descrição"].ToString() },
				{ "quantity", Convert.ToInt32(row["Quantidade"].ToString()) }
			};

			products.Add(product);

			foreach (DataRow Drow in ss.Rows)
			{
				int num = ProductGridView.Rows.Add();

				ProductGridView.Rows[num].Cells[0].Value = Drow["Descrição"].ToString();
				ProductGridView.Rows[num].Cells[1].Value = Drow["Quantidade"].ToString();
			}
		}

		private void CadBtn_Click(object sender, EventArgs e)
		{
			string title = TitleBox.Text;
			string description = DescriptionBox.Text;
			int quantity = Convert.ToInt32(QuantityBox.Text);

			if (title == null || description == null)
			{
				MessageBox.Show("Oops! Preencha os campos corretamente!");
			}

			else
			{
				var body = new Dictionary<string, object>
				{
					{ "title", title },
					{ "description", description },
					{ "quantity", quantity },
					{ "products", products }
				};

				var bodyjSON = JsonConvert.SerializeObject(body);

				donationService.HandleRegister(bodyjSON, this);
			}
		}
	}
}
