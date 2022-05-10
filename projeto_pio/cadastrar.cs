using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_pio
{
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)

        {
            if (proc_val() == false) { 
                MessageBox.Show("[ERRO] preencha todos os campos!!");
                }
               
            
           
              
          
        }
        private bool proc_val()
        {

            bool validar;

            if (txt_nome.Text == "")
            {
                validar = false;
            }
            else if (txt_email.Text == "")
            {
                validar = false;
            }
            else if (txt_endereço.Text == "")
            {
                validar = false;
            }
            else if (txt_numero.Text == "")
            {
                validar = false;
            }
            else if (mask_celular.Text == "")
            {
                validar = false;
            }
            else if (mask_cpf.Text == "")
            {
                validar = false;
            }
            else
            {
                validar = true;
                MessageBox.Show("Dados salvos!!");
                logado obj_logado = new logado();
                obj_logado.ShowDialog();
            }
                return validar;
            
        }
    }
}
