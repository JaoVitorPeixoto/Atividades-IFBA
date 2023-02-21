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
    public partial class Forms_QUESTAO1 : Form
    {
        public Forms_QUESTAO1()
        {
            InitializeComponent();
            txtNUM.Focus();
        }

        private void btnFATORIAL_Click(object sender, EventArgs e)
        {


            if (txtNUM.Text.Trim().Equals("") || !int.TryParse(txtNUM.Text, out _))
            {
                MessageBox.Show("Informe um número corretamente!!");

            }
            else
            {
                int resultado = int.Parse(txtNUM.Text);
                int n = int.Parse(txtNUM.Text);

                while (n != 1)
                {
                    n -= 1;
                    resultado *= n;
                }

                MessageBox.Show("O fatorial de " + txtNUM.Text + " é " + resultado);
            }

        }
    }
}
