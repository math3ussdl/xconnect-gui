using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WindowsFormsColetor.Service;

namespace WindowsFormsColetor.Login
{
    public partial class FormLogin : Form
    {
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
                //trocar o componente por um combobox
                this.textLogin.Text = usuarios[0].Name;
            }
        }

        private void lblVersao_Click(object sender, EventArgs e)
        {

        }
    }
}
