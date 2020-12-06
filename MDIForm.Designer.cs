
namespace XConnectGUI
{
	partial class MDIForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menu = new System.Windows.Forms.MenuStrip();
			this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.donationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DataGridView = new System.Windows.Forms.DataGridView();
			this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.approved = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.donationLbl = new System.Windows.Forms.Label();
			this.NewDonationBtn = new System.Windows.Forms.Button();
			this.UpdateListBtn = new System.Windows.Forms.Button();
			this.approvedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menu
			// 
			this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.CadMenuItem,
            this.contaToolStripMenuItem});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(1279, 24);
			this.menu.TabIndex = 0;
			this.menu.Text = "menuStrip1";
			// 
			// FileMenuItem
			// 
			this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.ExitToolStripMenuItem});
			this.FileMenuItem.Name = "FileMenuItem";
			this.FileMenuItem.Size = new System.Drawing.Size(61, 20);
			this.FileMenuItem.Text = "Arquivo";
			// 
			// AboutToolStripMenuItem
			// 
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.AboutToolStripMenuItem.Text = "Sobre...";
			this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.ExitToolStripMenuItem.Text = "Sair..";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// CadMenuItem
			// 
			this.CadMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donationsToolStripMenuItem});
			this.CadMenuItem.Name = "CadMenuItem";
			this.CadMenuItem.Size = new System.Drawing.Size(71, 20);
			this.CadMenuItem.Text = "Cadastros";
			// 
			// donationsToolStripMenuItem
			// 
			this.donationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.approvedToolStripMenuItem});
			this.donationsToolStripMenuItem.Name = "donationsToolStripMenuItem";
			this.donationsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.donationsToolStripMenuItem.Text = "Doações";
			// 
			// AddToolStripMenuItem
			// 
			this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
			this.AddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.AddToolStripMenuItem.Text = "Adicionar...";
			// 
			// contaToolStripMenuItem
			// 
			this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DetailsToolStripMenuItem,
            this.ExitAccountToolStripMenuItem});
			this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
			this.contaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.contaToolStripMenuItem.Text = "Conta";
			// 
			// DetailsToolStripMenuItem
			// 
			this.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem";
			this.DetailsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.DetailsToolStripMenuItem.Text = "Detalhes...";
			this.DetailsToolStripMenuItem.Click += new System.EventHandler(this.DetailsToolStripMenuItem_Click);
			// 
			// ExitAccountToolStripMenuItem
			// 
			this.ExitAccountToolStripMenuItem.Name = "ExitAccountToolStripMenuItem";
			this.ExitAccountToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.ExitAccountToolStripMenuItem.Text = "Sair da Conta";
			this.ExitAccountToolStripMenuItem.Click += new System.EventHandler(this.ExitAccountToolStripMenuItem_Click);
			// 
			// DataGridView
			// 
			this.DataGridView.AllowUserToAddRows = false;
			this.DataGridView.AllowUserToDeleteRows = false;
			this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.approved,
            this.title,
            this.description,
            this.quantity});
			this.DataGridView.Location = new System.Drawing.Point(12, 98);
			this.DataGridView.Name = "DataGridView";
			this.DataGridView.ReadOnly = true;
			this.DataGridView.RowHeadersWidth = 62;
			this.DataGridView.RowTemplate.Height = 28;
			this.DataGridView.Size = new System.Drawing.Size(1255, 484);
			this.DataGridView.TabIndex = 1;
			this.DataGridView.Visible = false;
			this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
			// 
			// number
			// 
			this.number.HeaderText = "Id";
			this.number.MinimumWidth = 8;
			this.number.Name = "number";
			this.number.ReadOnly = true;
			this.number.Width = 320;
			// 
			// approved
			// 
			this.approved.HeaderText = "Aprovado";
			this.approved.MinimumWidth = 8;
			this.approved.Name = "approved";
			this.approved.ReadOnly = true;
			this.approved.Width = 150;
			// 
			// title
			// 
			this.title.HeaderText = "Título";
			this.title.MinimumWidth = 8;
			this.title.Name = "title";
			this.title.ReadOnly = true;
			this.title.Width = 150;
			// 
			// description
			// 
			this.description.HeaderText = "Descrição";
			this.description.MinimumWidth = 8;
			this.description.Name = "description";
			this.description.ReadOnly = true;
			this.description.Width = 320;
			// 
			// quantity
			// 
			this.quantity.HeaderText = "Quantidade";
			this.quantity.MinimumWidth = 8;
			this.quantity.Name = "quantity";
			this.quantity.ReadOnly = true;
			this.quantity.Width = 150;
			// 
			// donationLbl
			// 
			this.donationLbl.AutoSize = true;
			this.donationLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.donationLbl.Location = new System.Drawing.Point(12, 44);
			this.donationLbl.Name = "donationLbl";
			this.donationLbl.Size = new System.Drawing.Size(156, 25);
			this.donationLbl.TabIndex = 2;
			this.donationLbl.Text = "Minhas Doações";
			this.donationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.donationLbl.Visible = false;
			// 
			// NewDonationBtn
			// 
			this.NewDonationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NewDonationBtn.Location = new System.Drawing.Point(1101, 44);
			this.NewDonationBtn.Name = "NewDonationBtn";
			this.NewDonationBtn.Size = new System.Drawing.Size(166, 39);
			this.NewDonationBtn.TabIndex = 3;
			this.NewDonationBtn.Text = "Nova Doação...";
			this.NewDonationBtn.UseVisualStyleBackColor = true;
			this.NewDonationBtn.Visible = false;
			this.NewDonationBtn.Click += new System.EventHandler(this.NewDonationBtn_Click);
			// 
			// UpdateListBtn
			// 
			this.UpdateListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.UpdateListBtn.Location = new System.Drawing.Point(1154, 595);
			this.UpdateListBtn.Name = "UpdateListBtn";
			this.UpdateListBtn.Size = new System.Drawing.Size(113, 39);
			this.UpdateListBtn.TabIndex = 4;
			this.UpdateListBtn.Text = "Atualizar...";
			this.UpdateListBtn.UseVisualStyleBackColor = true;
			this.UpdateListBtn.Click += new System.EventHandler(this.UpdateListBtn_Click);
			// 
			// approvedToolStripMenuItem
			// 
			this.approvedToolStripMenuItem.Name = "approvedToolStripMenuItem";
			this.approvedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.approvedToolStripMenuItem.Text = "Aprovadas";
			this.approvedToolStripMenuItem.Click += new System.EventHandler(this.ApprovedToolStripMenuItem_Click);
			// 
			// MDIForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1279, 646);
			this.Controls.Add(this.UpdateListBtn);
			this.Controls.Add(this.NewDonationBtn);
			this.Controls.Add(this.donationLbl);
			this.Controls.Add(this.DataGridView);
			this.Controls.Add(this.menu);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menu;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MDIForm";
			this.Text = "Sistema de Coleta de Eletrônicos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MDIForm_Load);
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CadMenuItem;
		private System.Windows.Forms.DataGridView DataGridView;
		private System.Windows.Forms.Label donationLbl;
		private System.Windows.Forms.Button NewDonationBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn number;
		private System.Windows.Forms.DataGridViewTextBoxColumn approved;
		private System.Windows.Forms.DataGridViewTextBoxColumn title;
		private System.Windows.Forms.DataGridViewTextBoxColumn description;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
		private System.Windows.Forms.Button UpdateListBtn;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitAccountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem donationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem approvedToolStripMenuItem;
	}
}