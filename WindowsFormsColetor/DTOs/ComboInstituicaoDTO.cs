using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsColetor.DTOs
{
    class ComboInstituicaoDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ComboInstituicaoDTO(string id, string name)
        {

            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
