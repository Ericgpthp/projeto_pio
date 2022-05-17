using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_pio
{
    internal class BFFUsuario
    {
        public EntidadeUsuario objEntidadeUsuario = new EntidadeUsuario();
        private BEUsuario objBEUsuario = new BEUsuario();
        public bool inserir()
        {
            return objBEUsuario.Inserir(objEntidadeUsuario.Nome, 
                objEntidadeUsuario.Email, 
                objEntidadeUsuario.Endereco, 
                objEntidadeUsuario.NumeroEndereco, 
                objEntidadeUsuario.Celular,
                objEntidadeUsuario.CPF,
                objEntidadeUsuario.Senha);
        }
    
        public bool update()
        {
            return objBEUsuario.Update(objEntidadeUsuario.Nome,
                objEntidadeUsuario.Email,
                objEntidadeUsuario.Endereco,
                objEntidadeUsuario.NumeroEndereco,
                objEntidadeUsuario.Celular,
                objEntidadeUsuario.CPF,
                objEntidadeUsuario.Senha);
        }
 
        public bool buscar(string cpf)
        {
            return objBEUsuario.Buscar(cpf);
        }

        public bool deletar(string cpf)
        {
            return objBEUsuario.Deletar(cpf);
        }





    }
}
