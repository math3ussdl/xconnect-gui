using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsColetor.Forms.Cadastro;
using WindowsFormsColetor.Login;

namespace WindowsFormsColetor
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        /**
         * Método chamado no evento load do formulário.
         * Quando o formulário é carregado.
         **/
        private void MDIForm_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls) {
                //varre a lista de controles e verificar se é um MDI
                if (control is MdiClient) {
                    //control.BackgroundImage = "Imagem";
                    //control.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                }
            }

            menuStrip1.Visible = false;

            //chama o formulário de login
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (!formLogin.bFlagLogin) {
                Application.Exit();
            }

            menuStrip1.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void subMenuUsuarios_Click(object sender, EventArgs e)
        {
            //Chama o cadastro de usuários
            var formUsuario = new FormCadastroUsuario();
            formUsuario.ShowDialog();

        }
    }
}
