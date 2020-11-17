using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsColetor.DTOs
{
    /**
     * Classe responsável por exibir os dados do usuario no combobox
     **/
    public class ComboLoginDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ComboLoginDTO(string id, string name) {

            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
