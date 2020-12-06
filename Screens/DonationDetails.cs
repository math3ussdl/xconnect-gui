using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using XConnectGUI.DTOs;
using XConnectGUI.Services;

namespace XConnectGUI.Screens
{
	public partial class DonationDetails : Form
	{
		private readonly string targetId;
		private readonly bool isONG;

		private readonly DonationService service = new DonationService();

		public DonationDetails(string targetId, bool isONG = false)
		{
			InitializeComponent();
			this.targetId = targetId;
			this.isONG = isONG;

			this.Text = "Detalhes | " + targetId;
		}

		private async void DonationDetails_Load(object sender, EventArgs e)
		{
			Donation donation = await service.GetDonation(targetId);

			TitleBox.Text = donation.Title;
			DescriptionBox.Text = donation.Description;
			QuantityBox.Text = Convert.ToString(donation.Quantity);

			if (isONG)
			{
				UpProductBtn.Visible = false;
				UpdateBtn.Text = "Aceitar Doação";
				DelBtn.Visible = false;
				UpdateBtn.Location = DelBtn.Location;
				UpdateBtn.AutoSize = true;
			}

			foreach (Product product in donation.Product)
			{
				DataTable ss = new DataTable();
				ss.Columns.Add("Descrição");
				ss.Columns.Add("Quantidade");

				DataRow row = ss.NewRow();
				row["Descrição"] = product.Description;
				row["Quantidade"] = product.Quantity;

				ss.Rows.Add(row);

				foreach (DataRow Drow in ss.Rows)
				{
					int num = ProductGridView.Rows.Add();

					ProductGridView.Rows[num].Cells[0].Value = Drow["Descrição"].ToString();
					ProductGridView.Rows[num].Cells[1].Value = Drow["Quantidade"].ToString();
				}
			}
		}

		private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ProductDescBox.Text = ProductGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
			ProductQuantityBox.Text = ProductGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
		}

		private void DelBtn_Click(object sender, EventArgs e)
		{
			const string message =
				"Lembre-se que esta ação é irreversível";
			const string caption = "Você tem certeza?";
			var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				service.HandleDelete(targetId, this);
			}
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void UpdateBtn_Click(object sender, EventArgs e)
		{
			if (isONG)
			{
				const string message =
				"Lembre-se que esta ação é irreversível";
				const string caption = "Você tem certeza?";
				var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					service.HandleAccept(targetId, this);
				}
			}
		}
	}
}
