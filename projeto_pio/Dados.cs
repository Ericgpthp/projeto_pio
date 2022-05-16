using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_pio
{
    internal class Dados
    {
        public bool inserirUsuario(string nome, string email, string endereco, string numeroEndereco, string celular, string cpf, string senha)
        {
            if (nome.Equals("Gabriel"))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
