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


    {

        Cadastrar objCadastrar = new Cadastrar();
        BFFUsuario objBFFUsuario = new BFFUsuario();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            
            if (objCadastrar.proc_val(objBFFUsuario.objEntidadeUsuario.Nome,
                objBFFUsuario.objEntidadeUsuario.Email,
                objBFFUsuario.objEntidadeUsuario.Endereco,
                objBFFUsuario.objEntidadeUsuario.NumeroEndereco,
                objBFFUsuario.objEntidadeUsuario.Celular,
                objBFFUsuario.objEntidadeUsuario.CPF,
                objBFFUsuario.objEntidadeUsuario.Senha))
            {

                if(objBFFUsuario.update())
                {
                    MessageBox.Show("Usuario Alterado com sucesso");
                } else
                {
                    MessageBox.Show("Erro ao alterar os dados");

                }
            } 
            }

        private void button3_Click(object sender, EventArgs e)
        {
            FEValidacao objFEValidacao = new FEValidacao();
            if (objFEValidacao.ValidaCPF(txt_nome.Text))
            {
                if(objBFFUsuario.buscar(txt_nome.Text))
                {
                    MessageBox.Show(objBFFUsuario.objEntidadeUsuario.Nome);
                } else
                {
                    MessageBox.Show("Cpf inexistente");
                }
            } else
            {
                MessageBox.Show("Cpf incorreto");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            objBFFUsuario.deletar(txt_nome.Text);
        }
    }

      

    
}
