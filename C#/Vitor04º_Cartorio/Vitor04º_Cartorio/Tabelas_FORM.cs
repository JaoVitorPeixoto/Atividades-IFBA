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
    public partial class Tabelas_FORM : Form
    {
        public Tabelas_FORM()
        {
            InitializeComponent();
        }

        private void txtBUSCAR_Enter(object sender, EventArgs e)
        {
            if (txtBUSCAR.Text == "Buscar" && txtBUSCAR.ForeColor == Color.Gray)
            {
                txtBUSCAR.Text = "";
                txtBUSCAR.ForeColor = Color.Black;
                txtBUSCAR.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                txtBUSCAR.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void txtBUSCAR_Leave(object sender, EventArgs e)
        {
            if (txtBUSCAR.Text == "")
            {
                txtBUSCAR.Text = "Buscar";
                txtBUSCAR.ForeColor = Color.Gray;
                txtBUSCAR.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                txtBUSCAR.TextAlign = HorizontalAlignment.Center;
            }
        }
    }
}
