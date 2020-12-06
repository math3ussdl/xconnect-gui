
namespace XConnectGUI
{
	partial class Login
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.LoginLbl = new System.Windows.Forms.Label();
			this.PasswordLbl = new System.Windows.Forms.Label();
			this.LoginBox = new System.Windows.Forms.TextBox();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.LoginBtn = new System.Windows.Forms.Button();
			this.TypeLbl = new System.Windows.Forms.Label();
			this.UserTypeBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.versionlbl = new System.Windows.Forms.Label();
			this.RegistrationLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LoginLbl
			// 
			this.LoginLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LoginLbl.AutoSize = true;
			this.LoginLbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginLbl.Location = new System.Drawing.Point(69, 90);
			this.LoginLbl.Name = "LoginLbl";
			this.LoginLbl.Size = new System.Drawing.Size(63, 24);
			this.LoginLbl.TabIndex = 0;
			this.LoginLbl.Text = "Login";
			// 
			// PasswordLbl
			// 
			this.PasswordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PasswordLbl.AutoSize = true;
			this.PasswordLbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasswordLbl.Location = new System.Drawing.Point(69, 149);
			this.PasswordLbl.Name = "PasswordLbl";
			this.PasswordLbl.Size = new System.Drawing.Size(69, 24);
			this.PasswordLbl.TabIndex = 1;
			this.PasswordLbl.Text = "Senha";
			// 
			// LoginBox
			// 
			this.LoginBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LoginBox.Location = new System.Drawing.Point(162, 90);
			this.LoginBox.Name = "LoginBox";
			this.LoginBox.Size = new System.Drawing.Size(314, 26);
			this.LoginBox.TabIndex = 2;
			// 
			// PasswordBox
			// 
			this.PasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasswordBox.Location = new System.Drawing.Point(162, 149);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.PasswordChar = '*';
			this.PasswordBox.Size = new System.Drawing.Size(314, 26);
			this.PasswordBox.TabIndex = 3;
			// 
			// ExitBtn
			// 
			this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ExitBtn.Location = new System.Drawing.Point(371, 272);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(105, 33);
			this.ExitBtn.TabIndex = 4;
			this.ExitBtn.Text = "Sair";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// LoginBtn
			// 
			this.LoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LoginBtn.Location = new System.Drawing.Point(73, 272);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new System.Drawing.Size(105, 33);
			this.LoginBtn.TabIndex = 5;
			this.LoginBtn.Text = "Entrar";
			this.LoginBtn.UseVisualStyleBackColor = true;
			this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
			// 
			// TypeLbl
			// 
			this.TypeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TypeLbl.AutoSize = true;
			this.TypeLbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TypeLbl.Location = new System.Drawing.Point(69, 207);
			this.TypeLbl.Name = "TypeLbl";
			this.TypeLbl.Size = new System.Drawing.Size(127, 24);
			this.TypeLbl.TabIndex = 6;
			this.TypeLbl.Text = "Entrar como";
			// 
			// UserTypeBox
			// 
			this.UserTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UserTypeBox.FormattingEnabled = true;
			this.UserTypeBox.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica",
            "ONG"});
			this.UserTypeBox.Location = new System.Drawing.Point(212, 206);
			this.UserTypeBox.Name = "UserTypeBox";
			this.UserTypeBox.Size = new System.Drawing.Size(264, 28);
			this.UserTypeBox.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(470, 413);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 18);
			this.label2.TabIndex = 9;
			this.label2.Text = "Versão";
			// 
			// versionlbl
			// 
			this.versionlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.versionlbl.AutoSize = true;
			this.versionlbl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.versionlbl.Location = new System.Drawing.Point(529, 413);
			this.versionlbl.Name = "versionlbl";
			this.versionlbl.Size = new System.Drawing.Size(37, 18);
			this.versionlbl.TabIndex = 10;
			this.versionlbl.Text = "<V>";
			// 
			// RegistrationLbl
			// 
			this.RegistrationLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RegistrationLbl.AutoSize = true;
			this.RegistrationLbl.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RegistrationLbl.Font = new System.Drawing.Font("Arial Black", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RegistrationLbl.ForeColor = System.Drawing.SystemColors.Highlight;
			this.RegistrationLbl.Location = new System.Drawing.Point(12, 410);
			this.RegistrationLbl.Name = "RegistrationLbl";
			this.RegistrationLbl.Size = new System.Drawing.Size(157, 23);
			this.RegistrationLbl.TabIndex = 11;
			this.RegistrationLbl.Text = "Não tenho conta";
			this.RegistrationLbl.Click += new System.EventHandler(this.RegistrationLbl_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(595, 453);
			this.Controls.Add(this.RegistrationLbl);
			this.Controls.Add(this.versionlbl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.UserTypeBox);
			this.Controls.Add(this.TypeLbl);
			this.Controls.Add(this.LoginBtn);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.PasswordBox);
			this.Controls.Add(this.LoginBox);
			this.Controls.Add(this.PasswordLbl);
			this.Controls.Add(this.LoginLbl);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "XConnect | Acesso";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LoginLbl;
		private System.Windows.Forms.Label PasswordLbl;
		private System.Windows.Forms.TextBox LoginBox;
		private System.Windows.Forms.TextBox PasswordBox;
		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.Button LoginBtn;
		private System.Windows.Forms.Label TypeLbl;
		private System.Windows.Forms.ComboBox UserTypeBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label versionlbl;
		private System.Windows.Forms.Label RegistrationLbl;
	}
}

