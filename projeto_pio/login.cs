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
            cadastrar obj_cadastrar = new cadastrar();
            obj_cadastrar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logado obj_logado = new logado();
            obj_logado.ShowDialog();
        }
    }
}
