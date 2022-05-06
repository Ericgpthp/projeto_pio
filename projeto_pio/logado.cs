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
        public logado()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login objsair = new login();
            objsair.ShowDialog();
        }
    }
}
