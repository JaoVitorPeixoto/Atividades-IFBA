using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitor04º_Cartorio
{
    public partial class CadCliente_FORM : Form
    {
        public CadCliente_FORM()
        {
            InitializeComponent();
        }

        private void btnLIMPAR_Click(object sender, EventArgs e)
        {
            txtNOME.Clear();
            txtENDERECO.Clear();
            mskCPF.Clear();
            mskTELEFONE.Clear();

            txtNOME.Focus();
        }

        private void CadCliente_FORM_Load(object sender, EventArgs e)
        {
            txtNOME.Focus();

            txtID.Text = "01";
            txtDATA_ADD.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
