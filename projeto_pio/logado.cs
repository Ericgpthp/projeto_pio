using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_pio
{
    public partial class logado : Form

        
    {   private Alterar objAlterar = new Alterar();
        private BFFUsuario objBFFUsuario = new BFFUsuario();
        private EntidadeUsuario objEntidadeUsuario = new EntidadeUsuario();
        
        public logado()
        {
            InitializeComponent();


        }

        

        public void mostrarDados ()
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public string gerarCPF()
        {
            return txt_cpf_buscar.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {   
            objAlterar.cpf_buscado = txt_cpf_buscar.Text;
            objAlterar.LerDados();
            objAlterar.ShowDialog();

        }   



        //BTN Buscar
        private void button3_Click(object sender, EventArgs e)
        {

            BFFUsuario objBFFUsuario = new BFFUsuario();
            FEValidacao objFEValidacao = new FEValidacao();
            if (objFEValidacao.ValidaCPF(txt_cpf_buscar.Text))
            {
                string nome = "";
                string email = "";
                string endereco = "";
                string numeroEndereco = "";
                string celular = "";
                string senha = "";
                if (objBFFUsuario.buscar(txt_cpf_buscar.Text, ref nome, ref email, ref endereco, ref numeroEndereco, ref celular, ref senha))
                {
                    this.painelDados.Rows.Add(nome, email, endereco, numeroEndereco, celular);
                } else
                {
                    MessageBox.Show("Cpf inexistente");
                }
            } else
            {
                MessageBox.Show("Cpf incorreto");
            }
        }

        
        //BTN DELETAR
        private void button2_Click(object sender, EventArgs e)
        {
            
            if(objBFFUsuario.deletar(txt_cpf_buscar.Text))
            {
                MessageBox.Show("Usuario removido");
            } else
            {
                MessageBox.Show("Falha ao remover");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void painelDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }

      

    
}
