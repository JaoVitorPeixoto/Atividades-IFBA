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
    public partial class Forms2_QUESTAO4 : Form
    {
        public Forms2_QUESTAO4(int c1, int c2, int c3, int c4, int nulo, int branco, int totalVotos)
        {
            InitializeComponent();

            double porcNulo = nulo * 100 / totalVotos;
            double porcBranco = branco * 100 / totalVotos;

            lblPORCENTAGEMNULO.Text = porcNulo.ToString("F") + "%";
            lblPORCENTAGEMBRANCO.Text = porcBranco.ToString("F") + "%";
            pgbNULO.Value = (int) porcNulo;
            pgbBRANCO.Value = (int) porcBranco;

            lblC1.Text = Convert.ToString(c1);
            lblC2.Text = Convert.ToString(c2);
            lblC3.Text = Convert.ToString(c3);
            lblC4.Text = Convert.ToString(c4);

            lblVOTOSNULO.Text = Convert.ToString(nulo);
            lblVOTOSBRANCO.Text = Convert.ToString(branco);
            lblTOTALVOTOS.Text = lblTOTALVOTOS.Text + totalVotos;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Forms2_QUESTAO4_Load(object sender, EventArgs e)
        {

        }
    }
}
