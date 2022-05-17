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

        public bool Buscar(string cpf)
        {
            return objDados.buscarUsuario(cpf);
        }
    
        public bool Deletar(string cpf)
        {
            return objDados.deleteUsuario(cpf);
        }
    }


}
