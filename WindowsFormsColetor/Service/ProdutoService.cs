using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsColetor.DTOs;

namespace WindowsFormsColetor.Service
{
    class ProdutoService
    {

        public List<Produto> lista = null;

        public ProdutoService() {

            popularLista();
        }

        private void popularLista() {

            this.lista = new List<Produto>();

            Produto produto = new Produto();
            produto.Id = "1";
            produto.Description = "Celular";
            this.lista.Add(produto);

            produto = new Produto();
            produto.Id = "2";
            produto.Description = "Computador";
            this.lista.Add(produto);

            produto = new Produto();
            produto.Id = "3";
            produto.Description = "Monitor";
            this.lista.Add(produto);

            produto = new Produto();
            produto.Id = "4";
            produto.Description = "Laptop";
            this.lista.Add(produto);
        }

        public List<Produto> listar() {

            return this.lista;
        }

        public Produto findById(String id) {

            foreach (Produto p in this.lista)
            {
                if (p.Id.Equals(id)) {

                    return p;
                }
            }

            return null;
        }


    }
}
