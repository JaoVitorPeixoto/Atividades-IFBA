using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vitor04º_Cartorio
{
    public partial class Login_FORM : Form
    {
        public Login_FORM()
        {
            InitializeComponent();
        }   

        public void txtSENHA_Padrao() // -- Método que reseta o "txtSENHA" 
        {
            txtSENHA.Text = "Senha";
            txtSENHA.ForeColor = Color.Gray;
            txtSENHA.Font = new Font("Arial Narrow", 12, FontStyle.Italic);
            txtSENHA.PasswordChar = '\0';
        } 

        public void txtUSUARIO_Padrao() // -- Método que reseta o "txtUSUARIO" 
        {
            txtUSUARIO.Text = "Usuário";
            txtUSUARIO.ForeColor = Color.Gray;
            txtUSUARIO.Font = new Font("Arial Narrow", 12, FontStyle.Italic);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUSUARIO.Text == "Usuário" && txtUSUARIO.ForeColor == Color.Gray)
            {
                txtUSUARIO.Text = "";
                txtUSUARIO.ForeColor = Color.Black;
                txtUSUARIO.Font = new Font("Arial Narrow", 12, FontStyle.Regular);
            }
        }

        private void txtUSUARIO_Leave(object sender, EventArgs e)
        {
            if (txtUSUARIO.Text == "")
            {
                txtUSUARIO_Padrao();
            }
        }

        private void txtSENHA_Leave(object sender, EventArgs e)
        {
            if (txtSENHA.Text == "")
            {
                txtSENHA_Padrao();
            }
        }

        private void txtSENHA_Enter(object sender, EventArgs e)
        {
            if (txtSENHA.Text == "Senha" && txtSENHA.ForeColor == Color.Gray)
            {
                txtSENHA.Text = "";
                txtSENHA.ForeColor = Color.Black;
                txtSENHA.Font = new Font("Arial Narrow", 12, FontStyle.Regular);
                txtSENHA.PasswordChar = '*';
            }
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            string usuario = txtUSUARIO.Text.Trim();
            string senha = txtSENHA.Text.Trim();

            // -- Valida os textBox do usuário e da senha
            if (usuario == "" || senha == "" || txtUSUARIO.ForeColor == Color.Gray || txtSENHA.ForeColor == Color.Gray)
            {
                txtUSUARIO.Focus();

                txtSENHA_Padrao();

                lblSTATUS.Location = new Point(70, 251);
                lblSTATUS.Text = "Informe os dados de login!";

            }
            // -- faz a validação dos dados para login e abre o form "Menu_FORM"
            else if (txtUSUARIO.Text == "1" && txtSENHA.Text == "1")
            {
                new Menu_FORM().Show();
                this.Close();

            }
            else
            {
                txtUSUARIO.Focus();

                txtSENHA_Padrao();

                lblSTATUS.Location = new Point(60, 251);
                lblSTATUS.Text = "Usuário ou senha incorretos!";
            }
        }

        private void Login_FORM_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Fecha a aplicação caso não tenha nenhum Forms aberto
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

     
    }
}