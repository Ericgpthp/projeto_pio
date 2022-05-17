using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace projeto_pio
{
    internal class Dados
    {
        SqlConnection con;
        SqlCommand cmd;
        public bool inserirUsuario(string nome, string email, string endereco, string numeroEndereco, string celular, string cpf, string senha)
        {

            bool returnFunction = false;
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-QUN4NSI6; Initial Catalog = DADOS_USUARIO; Integrated Security = True");
                cmd = new SqlCommand("INSERT INTO CLIENTE(nome, email, endereco, numeroEndereco, celular, cpf, senha )" +
                    "VALUES(@nome, @email, @endereco, @numeroEndereco, @celular, @cpf, @senha)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@numeroEndereco", numeroEndereco);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
                con.Close();
                returnFunction = true;
            }
            catch
            {
                throw;
            }
            return returnFunction;


        }
    
        
        
        public bool consultarUsuario(string cpf, string senha)
        {
            bool returnFunction = false;
            try
            {
                //con = new SqlConnection("Data Source=CPX-8F030SWZ5XN\\SQLEXPRESS2;Initial Catalog = crud; Integrated Security = True");
                //cmd = new SqlCommand("INSERT INTO tbUsuario(email,senha,nome)VALUES(@email, @senha, @nome)", con);
                //con.Open();
                //cmd.Parameters.AddWithValue("@email", email);
                //cmd.Parameters.AddWithValue("@senha", senha);
                //cmd.Parameters.AddWithValue("@nome", nome);
                //cmd.ExecuteNonQuery();
                //con.Close();
                returnFunction = true;
            }
            catch
            {
                throw;
            }
            return returnFunction;
        }
    

        public void buscarUsuario (string cpf, string senha)
        {
            EntidadeUsuario objEntidadeUsuario = new EntidadeUsuario(); 
            if (consultarUsuario(cpf, senha))                
            {
                objEntidadeUsuario.Endereco = "";
                objEntidadeUsuario.NumeroEndereco = "";
                objEntidadeUsuario.Celular = "";
                objEntidadeUsuario.CPF = "";
                objEntidadeUsuario.Senha = "";
            } else
            {

            }
        }
    
    }



}
