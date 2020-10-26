using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

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
        }

        private void lblVersao_Click(object sender, EventArgs e)
        {

        }
    }
}
