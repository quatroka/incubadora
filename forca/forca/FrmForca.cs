using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace forca
{
    public partial class FrmForca : Form
    {
        public FrmForca()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void FrmForca_Load(object sender, EventArgs e)
        {
            dica1.Text = "Dica 1: " + Tudo.dica1;
            dica2.Text = "Dica 2: " + Tudo.dica2;
            dica3.Text = "Dica 3: " + Tudo.dica3;
            dica2.Visible = false;
            dica3.Visible = false;

            //recebe array do conjunto da palavra
            string[] palavraEmBloco = Tudo.conjuntoEmTracos();

            //transforma em uma coisa so
            string palavra = "";
            for (int i = 0; i < palavraEmBloco.Length; i++)
            {
                palavra = palavra + palavraEmBloco[i] + " ";
            }

            lblPalavra.Text = palavra.Remove(palavra.Length - 1).ToUpper();
        }

        private void FrmForca_KeyPress(object sender, KeyPressEventArgs e)
        {

            //ACERTOU MIZERAVI
            bool acertou = false;


            char letraPressionada = e.KeyChar;
            string conversao = letraPressionada.ToString();
            conversao.ToUpper();
            letraPressionada = Convert.ToChar(conversao);

            string palavraForca = lblPalavra.Text;
            string palavra = Tudo.palavra;






            bool letraJaDigitada = true;
            for (int i = 0; i < Tudo.letras.Length; i++)
            {
                if (Tudo.letras[i] == letraPressionada && letraJaDigitada == true)
                {
                    //verifica se a letra ja foi digitada
                    MessageBox.Show("Voce já digitou essa letra cara!");
                    letraJaDigitada = false;
                    acertou = true;
                    break;
                }
            }
            
            if (letraJaDigitada == true)
            {
                //guarda letra digitada
                Tudo.letras += letraPressionada;
                lblDigitadas.Text = Tudo.letras;
                letraJaDigitada = false;
                //substitui palavras
                for (int j = 0; j < lblPalavra.Text.Length; j++)
                {

                    if (palavra[j] == letraPressionada)
                    {
                        StringBuilder texto = new StringBuilder(lblPalavra.Text);
                        texto.Replace('-', letraPressionada, j, 1);
                        lblPalavra.Text = texto.ToString().ToUpper();
                        acertou = true;
                    }
                }
            }

            if(acertou ==  false)
            {
                Tudo.chances -= 1;
            }

            //QUADRADINHO MODERFUCKER
            if(Tudo.chances == 4)
            {
                vida1.Visible = false;
                dica2.Visible = true;
            }
            if (Tudo.chances == 3)
            {
                vida2.Visible = false;
            }
            if (Tudo.chances == 2)
            {
                vida3.Visible = false;
                dica3.Visible = true;
            }
            if (Tudo.chances == 1)
            {
                vida4.Visible = false;
            }
            if (Tudo.chances == 0)
            {
                vida5.Visible = false;
                MessageBox.Show("VOCE PERDEU");
                Application.Exit();
            }

            string palavraCompleta = lblPalavra.Text;
            int contadorTracos = 0;
            for(int i = 0; i < palavraCompleta.Length;i++)
            {
                if(palavraCompleta[i] == '-')
                {
                    contadorTracos = +1;
                }
            }
            if (contadorTracos == 0)
            {
                MessageBox.Show("VOCE GANHOU");
                Application.Exit();
            }
        }

        private void FrmForca_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}