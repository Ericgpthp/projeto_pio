using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_pio
{
    public partial class login : Form
    {
        public logado objLogado = new logado();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar obj_cadastrar = new Cadastrar();
            obj_cadastrar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BFFUsuario objBFFUsuario = new BFFUsuario();
            FEValidacao objFEValidacao = new FEValidacao();
            if (objFEValidacao.ValidaCPF(cpf_login.Text))
            {
                string nome = "";
                string email = "";
                string endereco = "";
                string numeroEndereco = "";
                string celular = "";                
                if (objBFFUsuario.Logar(cpf_login.Text, ref nome, ref email, ref endereco, ref numeroEndereco, ref celular, senha_login.Text))
                {
                    MessageBox.Show("Logou");
                    this.Hide();
                    objLogado.ShowDialog();

                }
                else
                {
                    MessageBox.Show("CPF ou senha incorretos");
                    cpf_login.Text = "";
                    senha_login.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Cpf incorreto");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
