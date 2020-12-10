namespace WindowsFormsColetor
{
    partial class MDIForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.Operacao = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuDoar = new System.Windows.Forms.ToolStripMenuItem();
            this.Relatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arquivo,
            this.Cadastro,
            this.Operacao,
            this.Relatorio});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Arquivo";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // Arquivo
            // 
            this.Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sair});
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.Size = new System.Drawing.Size(61, 20);
            this.Arquivo.Text = "Arquivo";
            // 
            // Sair
            // 
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(93, 22);
            this.Sair.Text = "Sair";
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Cadastro
            // 
            this.Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuUsuarios,
            this.subMenuProdutos});
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(71, 20);
            this.Cadastro.Text = "Cadastros";
            // 
            // subMenuUsuarios
            // 
            this.subMenuUsuarios.Name = "subMenuUsuarios";
            this.subMenuUsuarios.Size = new System.Drawing.Size(122, 22);
            this.subMenuUsuarios.Text = "Usuários";
            this.subMenuUsuarios.Click += new System.EventHandler(this.subMenuUsuarios_Click);
            // 
            // subMenuProdutos
            // 
            this.subMenuProdutos.Name = "subMenuProdutos";
            this.subMenuProdutos.Size = new System.Drawing.Size(122, 22);
            this.subMenuProdutos.Text = "Produtos";
            this.subMenuProdutos.Click += new System.EventHandler(this.subMenuProdutos_Click);
            // 
            // Operacao
            // 
            this.Operacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuDoar});
            this.Operacao.Name = "Operacao";
            this.Operacao.Size = new System.Drawing.Size(75, 20);
            this.Operacao.Text = "Operações";
            // 
            // subMenuDoar
            // 
            this.subMenuDoar.Name = "subMenuDoar";
            this.subMenuDoar.Size = new System.Drawing.Size(99, 22);
            this.subMenuDoar.Text = "Doar";
            this.subMenuDoar.Click += new System.EventHandler(this.subMenuDoar_Click);
            // 
            // Relatorio
            // 
            this.Relatorio.Name = "Relatorio";
            this.Relatorio.Size = new System.Drawing.Size(71, 20);
            this.Relatorio.Text = "Relatórios";
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 348);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIForm";
            this.Text = "Sistema de Coleta de Eletrônicos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Arquivo;
        private System.Windows.Forms.ToolStripMenuItem Sair;
        private System.Windows.Forms.ToolStripMenuItem Cadastro;
        private System.Windows.Forms.ToolStripMenuItem Operacao;
        private System.Windows.Forms.ToolStripMenuItem Relatorio;
        private System.Windows.Forms.ToolStripMenuItem subMenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem subMenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem subMenuDoar;
    }
}

