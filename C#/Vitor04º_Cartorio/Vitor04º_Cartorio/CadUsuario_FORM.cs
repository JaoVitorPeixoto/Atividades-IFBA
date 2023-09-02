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
    public partial class CadUsuario_FORM : Form
    {
        public CadUsuario_FORM()
        {
            InitializeComponent();
        }

        private void btnLIMPAR_Click(object sender, EventArgs e)
        {
            txtNOME_USUARIO.Clear();
            txtUSUARIO.Clear();
            txtSENHA.Clear();
            txtCOMFIRMAR_SENHA.Clear();
            ckbATIVO.Checked = true;
            cmbCARGO.Text = "Funcionário";

            txtNOME_USUARIO.Focus();
        }

        private void CadUsuario_FORM_Load(object sender, EventArgs e)
        {
            cmbCARGO.Text = "Funcionário";
            txtNOME_USUARIO.Focus();

            txtID_ADD.Text = "01";
            txtNOME_ADD.Text = "João Vitor Ferreira Peixoto";

            txtID_USUARIO.Text = "02";
            txtDATA_ADD.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
