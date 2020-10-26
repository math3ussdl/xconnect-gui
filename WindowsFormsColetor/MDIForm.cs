using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            //chama o formulário de login
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
    }
}
