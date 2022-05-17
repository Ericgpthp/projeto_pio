using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_pio
{
    public partial class Cadastrar : Form
    {

        FEValidacao objValidar = new FEValidacao();
        public Cadastrar()
        {
            InitializeComponent();
        }

        //BOTAO DE INSERIR 
        private void btn_inserir_Click(object sender, EventArgs e)
        {
            BFFUsuario objBFFUsuario = new BFFUsuario();
            objBFFUsuario.objEntidadeUsuario.Nome = txt_nome.Text;
            objBFFUsuario.objEntidadeUsuario.Email = txt_email.Text;
            objBFFUsuario.objEntidadeUsuario.Endereco = txt_endereco.Text;
            objBFFUsuario.objEntidadeUsuario.NumeroEndereco = txt_numero.Text;
            objBFFUsuario.objEntidadeUsuario.Celular = txt_celular.Text;
            objBFFUsuario.objEntidadeUsuario.CPF = txt_cpf.Text;
            objBFFUsuario.objEntidadeUsuario.Senha = txt_senha.Text;
            
            if (proc_val(objBFFUsuario.objEntidadeUsuario.Nome,
                objBFFUsuario.objEntidadeUsuario.Email,
                objBFFUsuario.objEntidadeUsuario.Endereco,
                objBFFUsuario.objEntidadeUsuario.NumeroEndereco,
                objBFFUsuario.objEntidadeUsuario.Celular,
                objBFFUsuario.objEntidadeUsuario.CPF,
                objBFFUsuario.objEntidadeUsuario.Senha

                ))
            {


                if(objBFFUsuario.inserir())
                {
                    logado objLogado = new logado();
                    objLogado.mostrarDados();
                    objLogado.Show();
                }else
                {
                    MessageBox.Show("Erros ao inserir");
                }

            } 
        }


        //FUNÇÃO PARA VALIDAR OS DADOS
        public bool proc_val(string nome, string email, string endereco, string numeroEndereco, string celular, string cpf, string senha)
        {
            FEValidacao objFEValidacao = new FEValidacao();
            bool validar = true;

            //VALIDACAO DE NOME
            if (string.IsNullOrEmpty(nome))
            {
                txt_nome.Focus();
                errorProvider1.SetError(txt_nome, "INSIRA SEU NOME");
                validar = false;
            }

            //VALIDACAO DE EMAIL
            if (string.IsNullOrEmpty(email))
            {
                txt_email.Focus();
                errorProvider1.SetError(txt_email, "INSIRA SEU EMAIL");
                validar = false;
            }
            else
            {
                if (objFEValidacao.validarEmail(email.ToString()))
                {

                }
                else
                {
                    txt_email.Focus();
                    errorProvider1.SetError(txt_email, "EMAIL INVALIDO");
                    validar = false;
                }
            }

            //VALIDACAO DE ENDERECO
            if (string.IsNullOrEmpty(endereco))
            {
                txt_endereco.Focus();
                errorProvider1.SetError(txt_endereco, "INSIRA SEU ENDEREÇO");
                validar = false;
            }

            //VALIDACAO NUMERO DE ENDERECO
            if (string.IsNullOrEmpty(numeroEndereco))
            {
                txt_numero.Focus();
                errorProvider1.SetError(txt_numero, "INSIRA O NUMERO DO SEU ENDEREÇO");
                validar = false;
            }

            //VALIDACAO NUM CELULAR
            if (string.IsNullOrEmpty(celular))
            {
                txt_celular.Focus();
                errorProvider1.SetError(txt_celular, "INSIRA SEU NUMERO DE TELEFONE");
                validar = false;
            }
            else if (objFEValidacao.validarCelular(celular) == false)
            {
                txt_celular.Focus();
                errorProvider1.SetError(txt_celular, "NUMERO INVALIDO");
                validar = false;
            }

            //VALIDACAO CPF
            if (string.IsNullOrEmpty(cpf))
            {
                txt_cpf.Focus();
                errorProvider1.SetError(txt_cpf, "INSIRA SEU CPF");
                validar = false;
            }
            else if (objFEValidacao.ValidaCPF(cpf) == false)
            {
                txt_cpf.Focus();
                errorProvider1.SetError(txt_cpf, "CPF INVALIDO");
                validar = false;
            }

            return validar;

        }

        //FUNCAO PARA ATRIBUIR OS VALORES DOS CAMPOS NAS VARIAVEIS

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void mask_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }






}

