using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsColetor.DTOs;

namespace WindowsFormsColetor.Service
{
    public class UsuarioService
    {
        /**
         * Metodo responsavel por listar os usuarios da API
         **/
        public List<Usuario> ListarUsuarios()
        {
            var lista = new List<Usuario>();

            Usuario usuario = new Usuario();
            usuario.Id = "1";
            usuario.Name = "Juliherms";
            usuario.LastName = "Vasconcelos";
            usuario.Password = "1234";
            usuario.Phone = "999999999";
            usuario.Role = "ADM";
            usuario.Zip = "50000000";
            usuario.Address = "rua teste n 55";
            usuario.Cpf = "111111111111";

            lista.Add(usuario);

            return lista;

        }

    }
}
