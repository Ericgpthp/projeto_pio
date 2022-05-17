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
            FEValidacao obj_FEValidacao = new FEValidacao();
            objBFFUsuario.objEntidadeUsuario.Nome = "";
            objBFFUsuario.objEntidadeUsuario.Email = "";
            objBFFUsuario.objEntidadeUsuario.Endereco = "";
            objBFFUsuario.objEntidadeUsuario.NumeroEndereco = "";
            objBFFUsuario.objEntidadeUsuario.Celular = "";
            objBFFUsuario.objEntidadeUsuario.CPF = cpf_login.Text;
            objBFFUsuario.objEntidadeUsuario.Senha = senha_login.Text;
            if (obj_FEValidacao.ValidaCPF(cpf_login.Text))
            {
                MessageBox.Show("Entrou na cosulta");
            } else
            {
                MessageBox.Show("Erro na consulta");
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
