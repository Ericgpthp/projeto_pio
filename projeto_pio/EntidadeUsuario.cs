using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_pio
{
    namespace PrototipoAula19_04_2022
    {
        internal class EntidadeUsuario
        {
            private string nome;
            private string email;
            private string senha;


            public string Email { get => email; set => email = value; }
            public string Nome { get => nome; set => nome = value; }
            public string Senha { get => senha; set => senha = value; }
        }
    }
}

