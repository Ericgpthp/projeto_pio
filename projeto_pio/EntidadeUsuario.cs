using System;
using System.Collections.Generic;
using System.Text;



    namespace projeto_pio
    {
    internal class EntidadeUsuario
    {
        private string nome;
        private string email;
        private string endereco;
        private string numeroEndereco;
        private string celular;
        private string cpf;
        private string senha;




        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Endereco { get => endereco; set => endereco = value; } 
        public string Celular { get => celular; set => celular = value; }
        public string NumeroEndereco { get => numeroEndereco; set => numeroEndereco = value; }
        public string CPF { get => cpf; set => cpf = value; }
    }
}


