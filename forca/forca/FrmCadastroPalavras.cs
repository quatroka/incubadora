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
    public partial class FrmCadastroPalavras : Form
    {
        public FrmCadastroPalavras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text == "" || txtDica1.Text == "" || txtDica2.Text == "" || txtDica3.Text == "")
            {
                MessageBox.Show("Digita direito cara!");
            }
            else
            {
                Tudo.palavra = txtPalavra.Text.ToLower();
                Tudo.dica1 = txtDica1.Text.ToUpper();
                Tudo.dica2 = txtDica2.Text.ToUpper();
                Tudo.dica3 = txtDica3.Text.ToUpper();
                FrmJogar frm = new FrmJogar();
                this.Hide();
                frm.Show();

                
            }


        }

        private void FrmCadastroPalavras_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
