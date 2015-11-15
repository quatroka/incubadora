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
    public partial class FrmJogar : Form
    {
        public FrmJogar()
        {
            InitializeComponent();
        }

        private void FrmJogar_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmForca frm = new FrmForca();
            frm.Show();
        }

        private void FrmJogar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
