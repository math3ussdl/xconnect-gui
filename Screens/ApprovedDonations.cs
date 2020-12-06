using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XConnectGUI.DTOs;
using XConnectGUI.Services;

namespace XConnectGUI.Screens
{
	public partial class ApprovedDonations : Form
	{
		private readonly DonationService service = new DonationService();

		public ApprovedDonations()
		{
			InitializeComponent();
		}

		private void ApprovedDonations_Load(object sender, EventArgs e)
		{
			LoadApprovedDonations();
		}

		private async void LoadApprovedDonations()
		{
			List<Donation> donations = await service.GetApprovedDonations();

			DataGridView.Rows.Clear();

			foreach (Donation donation in donations)
			{
				DataTable ss = new DataTable();
				ss.Columns.Add("Id");
				ss.Columns.Add("Título");
				ss.Columns.Add("Descrição");
				ss.Columns.Add("Quantidade");

				DataRow row = ss.NewRow();
				row["Id"] = donation.Number;
				row["Título"] = donation.Title;
				row["Descrição"] = donation.Description;
				row["Quantidade"] = donation.Quantity;

				ss.Rows.Add(row);

				foreach (DataRow Drow in ss.Rows)
				{
					int num = DataGridView.Rows.Add();

					DataGridView.Rows[num].Cells[0].Value = Drow["Id"].ToString();
					DataGridView.Rows[num].Cells[1].Value = Drow["Título"].ToString();
					DataGridView.Rows[num].Cells[2].Value = Drow["Descrição"].ToString();
					DataGridView.Rows[num].Cells[3].Value = Drow["Quantidade"].ToString();
				}
			}
		}

		private void UpBtn_Click(object sender, EventArgs e)
		{
			LoadApprovedDonations();
		}

		private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var targetId = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

			new DonationDetails(targetId, true).Show();
		}
	}
}
