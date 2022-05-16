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

        private void btn_inserir_Click(object sender, EventArgs e)

        {
            if (proc_val())
            {
                MessageBox.Show("Dados salvos!!");
                logado obj_logado = new logado();
                obj_logado.ShowDialog();
            } 
        }

        private bool proc_val()
        {
            FEValidacao objFEValidacao = new FEValidacao();
            bool validar = true;

            if (string.IsNullOrEmpty(txt_nome.Text))
            {
                txt_nome.Focus();
                errorProvider1.SetError(txt_nome, "Please Enter User Name");
                validar = false;
            }


            if (string.IsNullOrEmpty(txt_email.Text))
            {
                txt_email.Focus();
                errorProvider1.SetError(txt_email, "Please enter email");
                validar = false;
            }

            if (string.IsNullOrEmpty(txt_endereço.Text))
            {
                txt_endereço.Focus();
                errorProvider1.SetError(txt_endereço, "Please Enter User Name");
                validar = false;
            }

            if (string.IsNullOrEmpty(txt_numero.Text))
            {
                txt_numero.Focus();
                errorProvider1.SetError(txt_numero, "Please Enter User Name");
                validar = false;
            }

            //VALIDA CELULAR
            if (string.IsNullOrEmpty(text_celular.Text))
            {
                text_celular.Focus();
                errorProvider1.SetError(text_celular, "Please Enter User Name");
                validar = false;
            } else if (objFEValidacao.validarCelular(text_celular.Text) == false)
            {
                text_cpf.Focus();
                errorProvider1.SetError(text_cpf, "CPF INVALIDO");
                validar = false;
            }

            //VALIDA CPF
            if (string.IsNullOrEmpty(text_cpf.Text))
            {
                text_cpf.Focus();
                errorProvider1.SetError(text_cpf, "Please Enter User Name");
                validar = false;
            } else if (objFEValidacao.ValidaCPF(text_cpf.ToString()) == false)
            {
                text_cpf.Focus();
                errorProvider1.SetError(text_cpf, "CPF INVALIDO");
                validar = false;
            }

            return validar;

        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void mask_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }






}

