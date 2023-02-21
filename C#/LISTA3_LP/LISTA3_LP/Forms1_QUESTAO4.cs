using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA3_LP
{
    public partial class Forms1_QUESTAO4 : Form
    {

        private int c1;
        private int c2;
        private int c3;
        private int c4;
        private int nulo;
        private int branco;
        private int totalVotos;

        public Forms1_QUESTAO4()
        {
            InitializeComponent();
        }

        private void Votar(int voto)
        {
            switch (voto)
            {
                case 1:
                    c1++;
                    totalVotos++;
                    MessageBox.Show("Voto contabilizado!!");
                    break;

                case 2:
                    c2++;
                    totalVotos++;
                    MessageBox.Show("Voto contabilizado!!");
                    break;

                case 3:
                    c3++;
                    totalVotos++;
                    MessageBox.Show("Voto contabilizado!!");
                    break;

                case 4:
                    c4++;
                    totalVotos++;
                    MessageBox.Show("Voto contabilizado!!");
                    break;

                case 5:
                    nulo++;
                    totalVotos++;
                    MessageBox.Show("Voto contabilizado!!");
                    break;

                case 6:
                    branco++;
                    totalVotos++;
                    MessageBox.Show("Voto contabilizado!!");
                    break;

                default:
                    MessageBox.Show("ERRO!! Voto não contabilizado!");
                    break;
            }
        }

        private void bntC1_Click(object sender, EventArgs e)
        {
            Votar(1);
            lblVOTOS.Text = "VOTOS: " + totalVotos;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            Votar(2);
            lblVOTOS.Text = "VOTOS: " + totalVotos;
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            Votar(3);
            lblVOTOS.Text = "VOTOS: " + totalVotos;
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            Votar(4);
            lblVOTOS.Text = "VOTOS: " + totalVotos;
        }

        private void btnNULO_Click(object sender, EventArgs e)
        {
            Votar(5);
            lblVOTOS.Text = "VOTOS: " + totalVotos;
        }

        private void btnBRANCO_Click(object sender, EventArgs e)
        {
            Votar(6);
            lblVOTOS.Text = "VOTOS: " + totalVotos;
        }

        private void btnFINALIZAR_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms2_QUESTAO4 fmr2QUESTAO4 = new Forms2_QUESTAO4(c1, c2, c3, c4, nulo, branco, totalVotos);
            fmr2QUESTAO4.Show();
        }
    }
}
