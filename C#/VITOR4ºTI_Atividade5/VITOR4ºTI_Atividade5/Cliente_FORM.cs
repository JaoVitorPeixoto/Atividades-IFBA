using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VITOR4ºTI_Atividade5
{
    public partial class Cliente_FORM : Form
    {
        public Cliente_FORM()
        {
            InitializeComponent();
        }

        private void btnVOLTAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCADASTRAR_Click(object sender, EventArgs e)
        {
            StreamWriter cliente = new StreamWriter("C:\\Users\\joaot\\source\\repos\\VITOR4ºTI_Atividade5\\VITOR4ºTI_Atividade5\\Resources\\Dados\\IFBACliente\\ifbaCLIENTE.txt");
            cliente.WriteLine(txtNOME.Text + ";" + nmcIDADE.Value + ";" + mskTELEFONE.Text);
            cliente.Close();

            MessageBox.Show("Cliente cadastrado com sucesso!!");

            txtNOME.Clear();
            nmcIDADE.Value = 0;
            mskTELEFONE.Clear();
            txtNOME.Focus();

        }
    }
}
