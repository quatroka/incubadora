using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forca
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == Tudo.login && txtSenha.Text == Tudo.senha)
            {
                this.Hide();
                FrmCadastroPalavras frm = new FrmCadastroPalavras();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Errado!");
            }
        }
    }
}