using System;
using System.Configuration;
using System.Windows.Forms;
using XConnectGUI.Services;
using XConnectGUI.Screens;
using System.Collections.Generic;
using XConnectGUI.DTOs;
using System.Data;

namespace XConnectGUI
{
	public partial class MDIForm : Form
	{
		private readonly ProfileService service = new ProfileService();
		private readonly DonationService donationService = new DonationService();

		private bool isONG = false;
		private string USER_TYPE;

		public MDIForm()
		{
			InitializeComponent();
		}

		[Obsolete]
		private void MDIForm_Load(object sender, EventArgs e)
		{
			service.HandleLogOut();

			UpdateListBtn.Visible = false;
			menu.Visible = false;

			bool isAuth = Convert.ToBoolean(ConfigurationSettings.AppSettings["LOGGED"]);

			var frmLogin = new Login();

			while (!isAuth)
			{
				frmLogin.ShowDialog();
			}

			USER_TYPE = ConfigurationSettings.AppSettings["USER_TYPE"];

			if (USER_TYPE.Contains("ONG"))
			{
				donationLbl.Text = "Doações Disponíveis";
				isONG = true;
			}

			menu.Visible = true;
			donationLbl.Visible = true;
			NewDonationBtn.Visible = true;
			DataGridView.Visible = true;
			UpdateListBtn.Visible = true;

			LoadDonations();
		}

		private void FeatureNotImplementedWarn()
		{
			MessageBox.Show("Esta Funcionalidade será desenvolvida em breve!", "Oops..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void NewDonationBtn_Click(object sender, EventArgs e)
		{
			new NewDonation().ShowDialog();
		}

		private async void LoadDonations()
		{
			List<Donation> donations;

			if (USER_TYPE.Contains("ONG"))
			{
				if (DataGridView.Columns.Contains(approved))
				{
					DataGridView.Columns.Remove(approved);
				}

				donations = await donationService.GetDonations();
			}

			else
			{
				donations = await donationService.GetMyDonations();
			}

			DataGridView.Rows.Clear();

			foreach (Donation donation in donations)
			{
				DataTable ss = new DataTable();
				ss.Columns.Add("Id");


				if (!USER_TYPE.Contains("ONG"))
				{
					ss.Columns.Add("Aprovado");
				}


				ss.Columns.Add("Título");
				ss.Columns.Add("Descrição");
				ss.Columns.Add("Quantidade");

				DataRow row = ss.NewRow();
				row["Id"] = donation.Number;

				if (!USER_TYPE.Contains("ONG"))
				{
					row["Aprovado"] = donation.Approved;
				}
				
				row["Título"] = donation.Title;
				row["Descrição"] = donation.Description;
				row["Quantidade"] = donation.Quantity;

				ss.Rows.Add(row);

				foreach (DataRow Drow in ss.Rows)
				{
					int num = DataGridView.Rows.Add();

					DataGridView.Rows[num].Cells[0].Value = Drow["Id"].ToString();

					if (!USER_TYPE.Contains("ONG"))
					{
						DataGridView.Rows[num].Cells[1].Value = Drow["Aprovado"].ToString();
						DataGridView.Rows[num].Cells[2].Value = Drow["Título"].ToString();
						DataGridView.Rows[num].Cells[3].Value = Drow["Descrição"].ToString();
						DataGridView.Rows[num].Cells[4].Value = Drow["Quantidade"].ToString();
					}

					else
					{
						DataGridView.Rows[num].Cells[1].Value = Drow["Título"].ToString();
						DataGridView.Rows[num].Cells[2].Value = Drow["Descrição"].ToString();
						DataGridView.Rows[num].Cells[3].Value = Drow["Quantidade"].ToString();
					}
				}
			}
		}

		private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var targetId = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

			new DonationDetails(targetId, isONG).Show();
		}

		private void UpdateListBtn_Click(object sender, EventArgs e)
		{
			LoadDonations();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ExitAccountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			menu.Visible = false;
			donationLbl.Visible = false;
			NewDonationBtn.Visible = false;
			DataGridView.Visible = false;
			UpdateListBtn.Visible = false;

			service.HandleLogOut();
		}

		private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FeatureNotImplementedWarn();
		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("     XConnect     \n     Versão 1.0.0.0     \n       VulkanSoft™     ", "Sobre o XConnect", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ApprovedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FeatureNotImplementedWarn();

			// Get Donations Approved List (create a function)
		}
	}
}
