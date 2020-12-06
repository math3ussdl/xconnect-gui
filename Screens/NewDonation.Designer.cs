
namespace XConnectGUI.Screens
{
	partial class NewDonation
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
			this.CancelBtn = new System.Windows.Forms.Button();
			this.ClearBtn = new System.Windows.Forms.Button();
			this.CadBtn = new System.Windows.Forms.Button();
			this.label47 = new System.Windows.Forms.Label();
			this.label57 = new System.Windows.Forms.Label();
			this.TitleBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.DescriptionBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ProductDescBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ProductQuantityBox = new System.Windows.Forms.ComboBox();
			this.ProductGridView = new System.Windows.Forms.DataGridView();
			this.QuantityBox = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.AddProductBtn = new System.Windows.Forms.Button();
			this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// CancelBtn
			// 
			this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelBtn.Location = new System.Drawing.Point(689, 522);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(99, 44);
			this.CancelBtn.TabIndex = 0;
			this.CancelBtn.Text = "Cancelar";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// ClearBtn
			// 
			this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearBtn.Location = new System.Drawing.Point(575, 522);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(99, 44);
			this.ClearBtn.TabIndex = 1;
			this.ClearBtn.Text = "Limpar";
			this.ClearBtn.UseVisualStyleBackColor = true;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// CadBtn
			// 
			this.CadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CadBtn.Location = new System.Drawing.Point(460, 522);
			this.CadBtn.Name = "CadBtn";
			this.CadBtn.Size = new System.Drawing.Size(99, 44);
			this.CadBtn.TabIndex = 2;
			this.CadBtn.Text = "Cadastrar";
			this.CadBtn.UseVisualStyleBackColor = true;
			this.CadBtn.Click += new System.EventHandler(this.CadBtn_Click);
			// 
			// label47
			// 
			this.label47.AutoSize = true;
			this.label47.BackColor = System.Drawing.Color.Transparent;
			this.label47.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label47.ForeColor = System.Drawing.Color.Red;
			this.label47.Location = new System.Drawing.Point(72, 5);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(22, 28);
			this.label47.TabIndex = 37;
			this.label47.Text = "*";
			// 
			// label57
			// 
			this.label57.AutoSize = true;
			this.label57.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label57.Location = new System.Drawing.Point(12, 9);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(62, 28);
			this.label57.TabIndex = 35;
			this.label57.Text = "Título";
			// 
			// TitleBox
			// 
			this.TitleBox.Location = new System.Drawing.Point(17, 42);
			this.TitleBox.Name = "TitleBox";
			this.TitleBox.Size = new System.Drawing.Size(355, 26);
			this.TitleBox.TabIndex = 36;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(519, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 28);
			this.label1.TabIndex = 40;
			this.label1.Text = "*";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(425, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 28);
			this.label2.TabIndex = 38;
			this.label2.Text = "Descrição";
			// 
			// DescriptionBox
			// 
			this.DescriptionBox.Location = new System.Drawing.Point(430, 42);
			this.DescriptionBox.Multiline = true;
			this.DescriptionBox.Name = "DescriptionBox";
			this.DescriptionBox.Size = new System.Drawing.Size(355, 111);
			this.DescriptionBox.TabIndex = 39;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(107, 220);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 28);
			this.label3.TabIndex = 43;
			this.label3.Text = "*";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 224);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 28);
			this.label4.TabIndex = 41;
			this.label4.Text = "Descrição";
			// 
			// ProductDescBox
			// 
			this.ProductDescBox.Location = new System.Drawing.Point(17, 258);
			this.ProductDescBox.Name = "ProductDescBox";
			this.ProductDescBox.Size = new System.Drawing.Size(355, 26);
			this.ProductDescBox.TabIndex = 42;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(539, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(22, 28);
			this.label5.TabIndex = 46;
			this.label5.Text = "*";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(425, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 28);
			this.label6.TabIndex = 44;
			this.label6.Text = "Quantidade";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 182);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(136, 38);
			this.label7.TabIndex = 47;
			this.label7.Text = "Produtos";
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
			this.ProductQuantityBox.Location = new System.Drawing.Point(430, 256);
			this.ProductQuantityBox.Name = "ProductQuantityBox";
			this.ProductQuantityBox.Size = new System.Drawing.Size(355, 28);
			this.ProductQuantityBox.TabIndex = 48;
			// 
			// ProductGridView
			// 
			this.ProductGridView.AllowUserToAddRows = false;
			this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.quantity});
			this.ProductGridView.Location = new System.Drawing.Point(19, 299);
			this.ProductGridView.Name = "ProductGridView";
			this.ProductGridView.RowHeadersWidth = 62;
			this.ProductGridView.RowTemplate.Height = 28;
			this.ProductGridView.Size = new System.Drawing.Size(769, 217);
			this.ProductGridView.TabIndex = 49;
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
			this.QuantityBox.Location = new System.Drawing.Point(19, 112);
			this.QuantityBox.Name = "QuantityBox";
			this.QuantityBox.Size = new System.Drawing.Size(355, 28);
			this.QuantityBox.TabIndex = 52;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(128, 76);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(22, 28);
			this.label8.TabIndex = 51;
			this.label8.Text = "*";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(14, 80);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(115, 28);
			this.label9.TabIndex = 50;
			this.label9.Text = "Quantidade";
			// 
			// AddProductBtn
			// 
			this.AddProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddProductBtn.Location = new System.Drawing.Point(19, 522);
			this.AddProductBtn.Name = "AddProductBtn";
			this.AddProductBtn.Size = new System.Drawing.Size(163, 44);
			this.AddProductBtn.TabIndex = 53;
			this.AddProductBtn.Text = "Adicionar Produto";
			this.AddProductBtn.UseVisualStyleBackColor = true;
			this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
			// 
			// description
			// 
			this.description.DividerWidth = 1;
			this.description.HeaderText = "Descrição";
			this.description.MinimumWidth = 8;
			this.description.Name = "description";
			this.description.Width = 250;
			// 
			// quantity
			// 
			this.quantity.HeaderText = "Quantidade";
			this.quantity.MinimumWidth = 8;
			this.quantity.Name = "quantity";
			this.quantity.Width = 150;
			// 
			// NewDonation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 578);
			this.Controls.Add(this.AddProductBtn);
			this.Controls.Add(this.QuantityBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.ProductGridView);
			this.Controls.Add(this.ProductQuantityBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ProductDescBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DescriptionBox);
			this.Controls.Add(this.label47);
			this.Controls.Add(this.label57);
			this.Controls.Add(this.TitleBox);
			this.Controls.Add(this.CadBtn);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.CancelBtn);
			this.Name = "NewDonation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nova Doação";
			((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.Button ClearBtn;
		private System.Windows.Forms.Button CadBtn;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.TextBox TitleBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox DescriptionBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ProductDescBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox ProductQuantityBox;
		private System.Windows.Forms.DataGridView ProductGridView;
		private System.Windows.Forms.ComboBox QuantityBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button AddProductBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn description;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
	}
}