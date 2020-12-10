using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsColetor.DTOs;

namespace WindowsFormsColetor.Service
{
    class InstituicaoService
    {

        public List<Instituicao> Listar()
        {
            var lista = new List<Instituicao>();

            Instituicao inst = new Instituicao();
            inst.Id = "1";
            inst.Name = "CRC Recife";

            lista.Add(inst);

            return lista;

        }
    }

}
