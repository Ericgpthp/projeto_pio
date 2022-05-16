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
            if (true)
            {
                BFFUsuario objBFFUsuario = new BFFUsuario();
                logado obj_logado = new logado();
                obj_logado.ShowDialog();
                atribuirDados();
                if(objBFFUsuario.inserir())
                {
                    MessageBox.Show("Gabriel Inserido no Sistema");
                }else
                {
                    MessageBox.Show("Erros ao inserir");
                }

            } 
        }


        //FUNÇÃO PARA VALIDAR OS DADOS
        private bool proc_val()
        {
            FEValidacao objFEValidacao = new FEValidacao();
            bool validar = true;

            //VALIDACAO DE NOME
            if (string.IsNullOrEmpty(txt_nome.Text))
            {
                txt_nome.Focus();
                errorProvider1.SetError(txt_nome, "INSIRA SEU NOME");
                validar = false;
            }

            //VALIDACAO DE EMAIL
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                txt_email.Focus();
                errorProvider1.SetError(txt_email, "INSIRA SEU EMAIL");
                validar = false;
            }
            else
            {
                if (objFEValidacao.validarEmail(txt_email.ToString()))
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
            if (string.IsNullOrEmpty(txt_endereco.Text))
            {
                txt_endereco.Focus();
                errorProvider1.SetError(txt_endereco, "INSIRA SEU ENDEREÇO");
                validar = false;
            }

            //VALIDACAO NUMERO DE ENDERECO
            if (string.IsNullOrEmpty(txt_numero.Text))
            {
                txt_numero.Focus();
                errorProvider1.SetError(txt_numero, "INSIRA O NUMERO DO SEU ENDEREÇO");
                validar = false;
            }

            //VALIDACAO NUM CELULAR
            if (string.IsNullOrEmpty(txt_celular.Text))
            {
                txt_celular.Focus();
                errorProvider1.SetError(txt_celular, "INSIRA SEU NUMERO DE TELEFONE");
                validar = false;
            }
            else if (objFEValidacao.validarCelular(txt_celular.Text) == false)
            {
                txt_celular.Focus();
                errorProvider1.SetError(txt_celular, "NUMERO INVALIDO");
                validar = false;
            }

            //VALIDACAO CPF
            if (string.IsNullOrEmpty(txt_cpf.Text))
            {
                txt_cpf.Focus();
                errorProvider1.SetError(txt_cpf, "INSIRA SEU CPF");
                validar = false;
            }
            else if (objFEValidacao.ValidaCPF(txt_cpf.Text) == false)
            {
                txt_cpf.Focus();
                errorProvider1.SetError(txt_cpf, "CPF INVALIDO");
                validar = false;
            }

            return validar;

        }

        //FUNCAO PARA ATRIBUIR OS VALORES DOS CAMPOS NAS VARIAVEIS
        private void atribuirDados()
        {
            EntidadeUsuario objEntidadeUsuario = new EntidadeUsuario();
            objEntidadeUsuario.Nome = txt_nome.Text;
            objEntidadeUsuario.Email = txt_email.Text;
            objEntidadeUsuario.Endereco = txt_endereco.Text;
            objEntidadeUsuario.NumeroEndereco = txt_numero.Text;
            objEntidadeUsuario.Celular = txt_celular.Text;
            objEntidadeUsuario.CPF = txt_cpf.Text;
            objEntidadeUsuario.Senha = txt_senha.Text;
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void mask_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }






}

