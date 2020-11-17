using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsColetor.DTOs
{
    /**
     * Classe responsavel por armazenar as informacoes de usuario
     **/
    public class Sessao
    {
        public static Usuario usuario { get; set; }

        private static Sessao Instance;

        public static Sessao GetInstance
        {
            get
            {
                if (Instance == null) {
                    Instance = new Sessao();
                }
                return Instance;
            }
        }
    }
}
