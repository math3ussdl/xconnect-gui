using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WindowsFormsColetor.DTOs;
using WindowsFormsColetor.Service;

namespace WindowsFormsColetor.Login
{
    public partial class FormLogin : Form
    {
        public bool bFlagLogin;

        public FormLogin()
        {
            InitializeComponent();
        }

       
        private void FormLogin_Load(object sender, EventArgs e)
        {
            //captura as informações sobre a versão
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersao.Text = string.Format(lblVersao.Text, version.Major, version.Minor, version.Build, version.Revision);
            this.CarregarUsuarios();
        }

        private void CarregarUsuarios() {

            var usuarios = new UsuarioService().ListarUsuarios();
            if(usuarios.Count > 0)
            {
                foreach (var usuario in usuarios)
                {
                    //adiciona os usuarios ao combobox
                    this.comboBoxLogin.Items.Add(new ComboLoginDTO(usuario.Id, usuario.Name));
                }
               
            }
        }

        private void lblVersao_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //ação para sair do sistema
            Dispose();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //verifica se foi selecionado algum usuario
            if (this.comboBoxLogin.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Você deve selecionar um login","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //verifica se a senha foi informada
            if (this.textSenha.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar a sua senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //obtem o item selecionado no combobox
            var item = (ComboLoginDTO)this.comboBoxLogin.SelectedItem;

            //implementar logica de validacao de login
            if (true) {
                bFlagLogin = true;
            }

            //armazena as informacoes do usuario na sessao
            Usuario u = new Usuario();
            u.Name = item.Name;
            Sessao.usuario = u;

            this.Close();

         
        }
    }
}
