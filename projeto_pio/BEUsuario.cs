using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_pio
{
    internal class BEUsuario
    {
        private Dados objDados = new Dados();
        public bool Inserir(string nome, string email, string endereco, string numeroEndereco, string celular, string cpf, string senha)
        {
            return objDados.inserirUsuario(nome, email, endereco, numeroEndereco, celular, cpf, senha);
        }
        
        public bool Update (string nome, string email, string endereco, string numeroEndereco, string celular, string cpf, string senha)
        {
            return objDados.updateUsuario(nome, email, endereco, numeroEndereco, celular, cpf, senha);
        }

        public bool Buscar(string cpf, ref string nome, ref string email, ref string endereco, ref string numeroEndereco, ref string celular, ref string senha)
        {
            return objDados.buscarUsuario( cpf, ref nome,  ref email, ref endereco, ref numeroEndereco, ref celular, ref senha);
        }

        public bool Logar(string cpf, ref string nome, ref string email, ref string endereco, ref string numeroEndereco, ref string celular, string senha)
        {
            return objDados.logarUsuario(cpf, ref nome, ref email, ref endereco, ref numeroEndereco, ref celular, senha);
        }

        public bool Deletar(string cpf)
        {
            return objDados.deleteUsuario(cpf);
        }
    }


}
