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
    public partial class Cadastrar_Produto_FORM : Form
    {
        public Cadastrar_Produto_FORM()
        {
            InitializeComponent();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCADASTRAR_Click(object sender, EventArgs e)
        {
            StreamWriter produto = new StreamWriter("C:\\Users\\joaot\\source\\repos\\VITOR4ºTI_Atividade5\\VITOR4ºTI_Atividade5\\Resources\\Dados\\IFBAProduto\\ifbaPRODUTO.txt");
            produto.WriteLine(mskPRECO.Text.Replace(" ", "0") + ";" + nmcESTOQUE.Value + ";" + dtpVALIDADE.Text + ";" + txtDESCRICAO.Text);
            produto.Close();

            MessageBox.Show("Produto cadastrado com sucesso!!");

            mskPRECO.Clear();
            nmcESTOQUE.Value = 0;
            dtpVALIDADE.Value = DateTime.Now;
            txtDESCRICAO.Clear();
            mskPRECO.Focus();


        }
    }
}
