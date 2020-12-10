using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsColetor.DTOs;
using WindowsFormsColetor.Service;

namespace WindowsFormsColetor.Forms.Cadastro
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProdutoService pService = new ProdutoService();
            String id = textBox3.Text;

            Produto p  = pService.findById(id);

            textBox2.Text = p.Description;
            textBox3.Text = p.Id;
        }
    }
}
