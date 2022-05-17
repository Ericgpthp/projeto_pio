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
 
        public bool buscar(string cpf, ref string nome, ref string email, ref string endereco, ref string numeroEndereco, ref string celular, ref string senha)
        {
            return objBEUsuario.Buscar(cpf, ref nome, ref email, ref endereco, ref numeroEndereco, ref celular, ref senha);
        }

        public bool Logar(string cpf, ref string nome, ref string email, ref string endereco, ref string numeroEndereco, ref string celular, string senha)
        {
            return objBEUsuario.Logar(cpf, ref nome, ref email, ref endereco, ref numeroEndereco, ref celular, senha);
        }
        public bool deletar(string cpf)
        {
            return objBEUsuario.Deletar(cpf);
        }





    }
}
