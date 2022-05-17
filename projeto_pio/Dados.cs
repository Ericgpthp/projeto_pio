using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace projeto_pio
{
    internal class Dados
    {
        BFFUsuario objBFFUsuario = new BFFUsuario();
        SqlConnection con;
        SqlCommand cmd;
        public bool inserirUsuario(string nome, string email, string endereco, string numeroEndereco, string celular, string cpf, string senha)
        {

            bool returnFunction = false;
            try
            {
                conectar();
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



        public bool updateUsuario(string nome, string email, string endereco, string numeroEndereco, string celular, string cpf, string senha)
        {

            bool returnUpdate = false;
            try
            {
                conectar();
                cmd = new SqlCommand("UPDATE tbUsuario SET nome = '" + nome + "', email = '" + email + "'," +
                "endereco = '" + endereco + "', numeroEndereco = '" + numeroEndereco + "', celular = '" + celular + "', senha = '" + senha + "'  WHERE cpf = '" + cpf + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                returnUpdate = true;
            }
            catch
            {
                throw;
            }
            return returnUpdate;
        }


        public bool buscarUsuario(string cpf)
        {
            bool returnSelect = false;

            try
            {
                conectar();
                con.Open();
                string sql = "SELECT * FROM CLIENTE WHERE cpf = '" + cpf + "'";
                SqlCommand adoCmd = new SqlCommand(sql, con);
                SqlDataReader adoDR = adoCmd.ExecuteReader();
                if (adoDR.HasRows)
                {
                    if (adoDR.Read())
                    {
                        objBFFUsuario.objEntidadeUsuario.Nome = (adoDR["nome"].ToString());
                        //senha = adoDR["senha"].ToString();
                        returnSelect = true;
                    }
                    else
                    {
                        returnSelect = false;
                    }
                }
                else
                {
                    returnSelect = false;
                }
                return returnSelect;

            }
            catch
            {
                throw;
            }

        }

        public bool deleteUsuario(string cpf)
        {
            bool retorno = false;
            try
            {
                conectar();
                cmd = new SqlCommand("DELETE FROM CLIENTE WHERE cpf = '" + cpf + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                retorno = true;
            }
            catch
            {
                retorno = false;
                throw;
            }
            return retorno;
        }

        public bool logarUsuario (string cpf, string senha)
        {
            bool returnSelect = false;

            try
            {
                conectar();
                con.Open();
                string sql = "SELECT * FROM CLIENTE WHERE cpf = '" + cpf + "'";
                SqlCommand adoCmd = new SqlCommand(sql, con);
                SqlDataReader adoDR = adoCmd.ExecuteReader();
                if (adoDR.HasRows)
                {
                    if (adoDR.Read())
                    {
                        
                        //senha = adoDR["senha"].ToString();
                        returnSelect = true;
                    }
                    else
                    {
                        returnSelect = false;
                    }
                }
                else
                {
                    returnSelect = false;
                }
                return returnSelect;

            }
            catch
            {
                throw;
            }
        }
 

        public void conectar()
        {
            con = new SqlConnection("Data Source=LAPTOP-QUN4NSI6;Initial Catalog = DADOS_USUARIO; Integrated Security = True");
        }


    }



}

