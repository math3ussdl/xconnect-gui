using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsColetor.DTOs;
using WindowsFormsColetor.Service;

namespace WindowsFormsColetor.Forms.Operacao
{
    public partial class FormDoacao : Form
    {
        public FormDoacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDoacao_Load(object sender, EventArgs e)
        {
            this.CarregarUsuarios();
            this.CarregarInstituicoes();
        }

        private void CarregarInstituicoes()
        {
            var instituicoes = new InstituicaoService().Listar();

            if (instituicoes.Count > 0) {

                foreach (var instituicao in instituicoes)
                {
                    //adiciona as instituicoes ao combobox
                    this.comboBox2.Items.Add(new ComboInstituicaoDTO(instituicao.Id, instituicao.Name));
                }
            }
           
        }

        private void CarregarUsuarios()
        {

            var usuarios = new UsuarioService().ListarUsuarios();
            if (usuarios.Count > 0)
            {
                foreach (var usuario in usuarios)
                {
                    //adiciona os usuarios ao combobox
                    this.comboBox1.Items.Add(new ComboLoginDTO(usuario.Id, usuario.Name));
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProdutoService pService = new ProdutoService();
            String id = textBox1.Text;

            Produto p = pService.findById(id);

            textBox2.Text = p.Description;
            textBox1.Text = p.Id;
            textBox3.Text = "1";
        }
    }
}
