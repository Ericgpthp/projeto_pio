using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_pio
{
    public partial class Alterar : Form
    {
        
        public Cadastrar objCadastrar = new Cadastrar();
        public string cpf_buscado = "";
        public Alterar()
        {
            InitializeComponent();


        }

        public void LerDados()
        
        {
            BFFUsuario objBFFUsuario = new BFFUsuario();
            FEValidacao objFEValidacao = new FEValidacao();
            if (objFEValidacao.ValidaCPF(cpf_buscado))
            {
                string nome = "";
                string email = "";
                string endereco = "";
                string numeroEndereco = "";
                string celular = "";
                string senha = "";
                if (objBFFUsuario.buscar(cpf_buscado, ref nome, ref email, ref endereco, ref numeroEndereco, ref celular, ref senha))
                {
                    txt_nome.Text = nome;
                    txt_email.Text = email;
                    txt_endereco.Text = endereco;
                    txt_numero.Text = numeroEndereco;
                    txt_celular.Text = celular;
                    txt_senha.Text = senha;
                }
                else
                {
                    MessageBox.Show("Cpf inexistente");
                }
            }
            else
            {
                MessageBox.Show("Cpf incorreto");
            }
        }
        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BFFUsuario objBFFUsuario = new BFFUsuario();
            objBFFUsuario.objEntidadeUsuario.Nome = txt_nome.Text;
            objBFFUsuario.objEntidadeUsuario.Email = txt_email.Text;
            objBFFUsuario.objEntidadeUsuario.Endereco = txt_endereco.Text;
            objBFFUsuario.objEntidadeUsuario.NumeroEndereco = txt_numero.Text;
            objBFFUsuario.objEntidadeUsuario.Celular = txt_celular.Text;
            objBFFUsuario.objEntidadeUsuario.CPF = cpf_buscado;
            objBFFUsuario.objEntidadeUsuario.Senha = txt_senha.Text;
            
            
            if (objCadastrar.proc_val(objBFFUsuario.objEntidadeUsuario.Nome,
                objBFFUsuario.objEntidadeUsuario.Email,
                objBFFUsuario.objEntidadeUsuario.Endereco,
                objBFFUsuario.objEntidadeUsuario.NumeroEndereco,
                objBFFUsuario.objEntidadeUsuario.Celular,
                objBFFUsuario.objEntidadeUsuario.CPF,
                objBFFUsuario.objEntidadeUsuario.Senha
                ))
            {
                if(objBFFUsuario.update())
                {
                    MessageBox.Show("Usuario alterado com sucesso");
                } else
                {
                    MessageBox.Show("Usuario não alterado");
                }
            }
        }
    }
}
