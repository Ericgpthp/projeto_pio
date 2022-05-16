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
            bool val = true;

            if (nome_login.Text == "")
            {
                val = false;
             
            }
            else if(senha_login.Text == "")
            {
                val = false;
            }
            else
            {
                val = true;
            }


            if (val == false)
            {
                MessageBox.Show("Email e senha incorretos!!");
            }
            else
            {
                logado obj_logado = new logado();
                obj_logado.ShowDialog();
            }




            
        }


        
    }
}
