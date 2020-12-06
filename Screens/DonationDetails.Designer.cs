
namespace XConnectGUI.Screens
{
	partial class DonationDetails
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
			this.UpProductBtn = new System.Windows.Forms.Button();
			this.QuantityBox = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ProductGridView = new System.Windows.Forms.DataGridView();
			this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductQuantityBox = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ProductDescBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.DescriptionBox = new System.Windows.Forms.TextBox();
			this.label57 = new System.Windows.Forms.Label();
			this.TitleBox = new System.Windows.Forms.TextBox();
			this.UpdateBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.DelBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// UpProductBtn
			// 
			this.UpProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.UpProductBtn.Location = new System.Drawing.Point(13, 342);
			this.UpProductBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.UpProductBtn.Name = "UpProductBtn";
			this.UpProductBtn.Size = new System.Drawing.Size(109, 29);
			this.UpProductBtn.TabIndex = 74;
			this.UpProductBtn.Text = "Atualizar Produto";
			this.UpProductBtn.UseVisualStyleBackColor = true;
			// 
			// QuantityBox
			// 
			this.QuantityBox.FormattingEnabled = true;
			this.QuantityBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
			this.QuantityBox.Location = new System.Drawing.Point(13, 75);
			this.QuantityBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.QuantityBox.Name = "QuantityBox";
			this.QuantityBox.Size = new System.Drawing.Size(238, 21);
			this.QuantityBox.TabIndex = 73;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(9, 55);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 19);
			this.label9.TabIndex = 71;
			this.label9.Text = "Quantidade";
			// 
			// ProductGridView
			// 
			this.ProductGridView.AllowUserToAddRows = false;
			this.ProductGridView.AllowUserToDeleteRows = false;
			this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.quantity});
			this.ProductGridView.Location = new System.Drawing.Point(13, 197);
			this.ProductGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ProductGridView.Name = "ProductGridView";
			this.ProductGridView.ReadOnly = true;
			this.ProductGridView.RowHeadersWidth = 62;
			this.ProductGridView.RowTemplate.Height = 28;
			this.ProductGridView.Size = new System.Drawing.Size(513, 141);
			this.ProductGridView.TabIndex = 70;
			this.ProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellContentClick);
			// 
			// description
			// 
			this.description.DividerWidth = 1;
			this.description.HeaderText = "Descrição";
			this.description.MinimumWidth = 8;
			this.description.Name = "description";
			this.description.ReadOnly = true;
			this.description.Width = 250;
			// 
			// quantity
			// 
			this.quantity.HeaderText = "Quantidade";
			this.quantity.MinimumWidth = 8;
			this.quantity.Name = "quantity";
			this.quantity.ReadOnly = true;
			this.quantity.Width = 150;
			// 
			// ProductQuantityBox
			// 
			this.ProductQuantityBox.FormattingEnabled = true;
			this.ProductQuantityBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
			this.ProductQuantityBox.Location = new System.Drawing.Point(287, 169);
			this.ProductQuantityBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ProductQuantityBox.Name = "ProductQuantityBox";
			this.ProductQuantityBox.Size = new System.Drawing.Size(238, 21);
			this.ProductQuantityBox.TabIndex = 69;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 121);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 25);
			this.label7.TabIndex = 68;
			this.label7.Text = "Produtos";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(283, 148);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 19);
			this.label6.TabIndex = 66;
			this.label6.Text = "Quantidade";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 148);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 19);
			this.label4.TabIndex = 63;
			this.label4.Text = "Descrição";
			// 
			// ProductDescBox
			// 
			this.ProductDescBox.Location = new System.Drawing.Point(11, 170);
			this.ProductDescBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ProductDescBox.Name = "ProductDescBox";
			this.ProductDescBox.Size = new System.Drawing.Size(238, 20);
			this.ProductDescBox.TabIndex = 64;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(283, 8);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 19);
			this.label2.TabIndex = 60;
			this.label2.Text = "Descrição";
			// 
			// DescriptionBox
			// 
			this.DescriptionBox.Location = new System.Drawing.Point(287, 30);
			this.DescriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.DescriptionBox.Multiline = true;
			this.DescriptionBox.Name = "DescriptionBox";
			this.DescriptionBox.Size = new System.Drawing.Size(238, 74);
			this.DescriptionBox.TabIndex = 61;
			// 
			// label57
			// 
			this.label57.AutoSize = true;
			this.label57.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label57.Location = new System.Drawing.Point(8, 8);
			this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(43, 19);
			this.label57.TabIndex = 57;
			this.label57.Text = "Título";
			// 
			// TitleBox
			// 
			this.TitleBox.Location = new System.Drawing.Point(11, 30);
			this.TitleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.TitleBox.Name = "TitleBox";
			this.TitleBox.Size = new System.Drawing.Size(238, 20);
			this.TitleBox.TabIndex = 58;
			// 
			// UpdateBtn
			// 
			this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.UpdateBtn.Location = new System.Drawing.Point(288, 342);
			this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.UpdateBtn.Name = "UpdateBtn";
			this.UpdateBtn.Size = new System.Drawing.Size(66, 29);
			this.UpdateBtn.TabIndex = 56;
			this.UpdateBtn.Text = "Atualizar";
			this.UpdateBtn.UseVisualStyleBackColor = true;
			this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelBtn.Location = new System.Drawing.Point(459, 342);
			this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(66, 29);
			this.CancelBtn.TabIndex = 54;
			this.CancelBtn.Text = "Cancelar";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// DelBtn
			// 
			this.DelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DelBtn.Location = new System.Drawing.Point(358, 342);
			this.DelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.DelBtn.Name = "DelBtn";
			this.DelBtn.Size = new System.Drawing.Size(97, 29);
			this.DelBtn.TabIndex = 75;
			this.DelBtn.Text = "Deletar Doação";
			this.DelBtn.UseVisualStyleBackColor = true;
			this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
			// 
			// DonationDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 376);
			this.Controls.Add(this.DelBtn);
			this.Controls.Add(this.UpProductBtn);
			this.Controls.Add(this.QuantityBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.ProductGridView);
			this.Controls.Add(this.ProductQuantityBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ProductDescBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DescriptionBox);
			this.Controls.Add(this.label57);
			this.Controls.Add(this.TitleBox);
			this.Controls.Add(this.UpdateBtn);
			this.Controls.Add(this.CancelBtn);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "DonationDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DonationDetails";
			this.Load += new System.EventHandler(this.DonationDetails_Load);
			((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button UpProductBtn;
		private System.Windows.Forms.ComboBox QuantityBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView ProductGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn description;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
		private System.Windows.Forms.ComboBox ProductQuantityBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ProductDescBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox DescriptionBox;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.TextBox TitleBox;
		private System.Windows.Forms.Button UpdateBtn;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.Button DelBtn;
	}
}