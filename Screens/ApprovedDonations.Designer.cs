
namespace XConnectGUI.Screens
{
	partial class ApprovedDonations
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
			this.donationLbl = new System.Windows.Forms.Label();
			this.DataGridView = new System.Windows.Forms.DataGridView();
			this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UpBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// donationLbl
			// 
			this.donationLbl.AutoSize = true;
			this.donationLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.donationLbl.Location = new System.Drawing.Point(12, 9);
			this.donationLbl.Name = "donationLbl";
			this.donationLbl.Size = new System.Drawing.Size(187, 25);
			this.donationLbl.TabIndex = 3;
			this.donationLbl.Text = "Doações Aprovadas";
			this.donationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.title,
            this.description,
            this.quantity});
			this.DataGridView.Location = new System.Drawing.Point(12, 37);
			this.DataGridView.Name = "DataGridView";
			this.DataGridView.ReadOnly = true;
			this.DataGridView.RowHeadersWidth = 62;
			this.DataGridView.RowTemplate.Height = 28;
			this.DataGridView.Size = new System.Drawing.Size(620, 348);
			this.DataGridView.TabIndex = 4;
			this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
			// 
			// number
			// 
			this.number.HeaderText = "Id";
			this.number.MinimumWidth = 8;
			this.number.Name = "number";
			this.number.ReadOnly = true;
			this.number.Width = 120;
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
			this.description.Width = 150;
			// 
			// quantity
			// 
			this.quantity.HeaderText = "Quantidade";
			this.quantity.MinimumWidth = 8;
			this.quantity.Name = "quantity";
			this.quantity.ReadOnly = true;
			this.quantity.Width = 120;
			// 
			// UpBtn
			// 
			this.UpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.UpBtn.Location = new System.Drawing.Point(557, 394);
			this.UpBtn.Name = "UpBtn";
			this.UpBtn.Size = new System.Drawing.Size(75, 23);
			this.UpBtn.TabIndex = 5;
			this.UpBtn.Text = "Atualizar...";
			this.UpBtn.UseVisualStyleBackColor = true;
			this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
			// 
			// ApprovedDonations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 429);
			this.Controls.Add(this.UpBtn);
			this.Controls.Add(this.DataGridView);
			this.Controls.Add(this.donationLbl);
			this.Name = "ApprovedDonations";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ApprovedDonations";
			this.Load += new System.EventHandler(this.ApprovedDonations_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label donationLbl;
		private System.Windows.Forms.DataGridView DataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn number;
		private System.Windows.Forms.DataGridViewTextBoxColumn title;
		private System.Windows.Forms.DataGridViewTextBoxColumn description;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
		private System.Windows.Forms.Button UpBtn;
	}
}