using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitor04º_Cartorio
{
    public partial class Menu_FORM : Form
    {
        public Menu_FORM()
        {
            InitializeComponent();
        }

        // -- Quando clicam no menu superior
        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login_FORM().Show();

            this.Close();
        }

        private void documentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string link = "https://github.com/JaoVitorPeixoto?tab=repositories";

            Process.Start(link);
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // -- Definindo o parente MDI do Form CadUsuario
            var frmCadUsuario = new CadUsuario_FORM();
            frmCadUsuario.MdiParent = this; 
            frmCadUsuario.Show();
        }

        private void lblCLIENTE_CADASTRO_Click(object sender, EventArgs e)
        {
            // -- Definindo o parente MDI do Form cadCliente
            var frmCadCliente = new CadCliente_FORM();
            frmCadCliente.MdiParent = this; 
            frmCadCliente.Show();
        } 

        private void matrículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // -- Definindo o parente MDI do Form CadUsuario
            var frmTabelaMATRICULA = new Tabelas_FORM();
            frmTabelaMATRICULA.MdiParent = this;
            frmTabelaMATRICULA.Show();
        }


        // -- Faz os campos de texto do CPF e da Matrícula tere aqueles coisas escritas antes do usuário utilizar
        private void txtREGISTRO_CLIENTE_CPF_Leave(object sender, EventArgs e)
        {
            if (txtREGISTRO_CLIENTE_CPF.Text == "")
            {
                txtREGISTRO_CLIENTE_CPF.Text = "CPF";
                txtREGISTRO_CLIENTE_CPF.ForeColor = Color.Gray;
                txtREGISTRO_CLIENTE_CPF.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                txtREGISTRO_CLIENTE_CPF.TextAlign = HorizontalAlignment.Center;
            }  
        }

        private void txtREGISTRO_CLIENTE_CPF_Enter(object sender, EventArgs e)
        {
            if (txtREGISTRO_CLIENTE_CPF.Text == "CPF" && txtREGISTRO_CLIENTE_CPF.ForeColor == Color.Gray)
            {
                txtREGISTRO_CLIENTE_CPF.Text = "";
                txtREGISTRO_CLIENTE_CPF.ForeColor = Color.Black;
                txtREGISTRO_CLIENTE_CPF.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                txtREGISTRO_CLIENTE_CPF.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void txtAVERBACAO_MATRICULA_NUMERO_Leave(object sender, EventArgs e)
        {
            if (txtAVERBACAO_MATRICULA_NUMERO.Text == "")
            {
                txtAVERBACAO_MATRICULA_NUMERO.Text = "Nº Matrícula";
                txtAVERBACAO_MATRICULA_NUMERO.ForeColor = Color.Gray;
                txtAVERBACAO_MATRICULA_NUMERO.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                txtAVERBACAO_MATRICULA_NUMERO.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void txtAVERBACAO_MATRICULA_NUMERO_Enter(object sender, EventArgs e)
        {
            if (txtAVERBACAO_MATRICULA_NUMERO.Text == "Nº Matrícula" && txtAVERBACAO_MATRICULA_NUMERO.ForeColor == Color.Gray)
            {
                txtAVERBACAO_MATRICULA_NUMERO.Text = "";
                txtAVERBACAO_MATRICULA_NUMERO.ForeColor = Color.Black;
                txtAVERBACAO_MATRICULA_NUMERO.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                txtAVERBACAO_MATRICULA_NUMERO.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void txtTRANSFERENCIA_MATRICULA_NUMERO_Enter(object sender, EventArgs e)
        {
            if (txtTRANSFERENCIA_MATRICULA_NUMERO.Text == "Nº Matrícula" && txtTRANSFERENCIA_MATRICULA_NUMERO.ForeColor == Color.Gray)
            {
                txtTRANSFERENCIA_MATRICULA_NUMERO.Text = "";
                txtTRANSFERENCIA_MATRICULA_NUMERO.ForeColor = Color.Black;
                txtTRANSFERENCIA_MATRICULA_NUMERO.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                txtTRANSFERENCIA_MATRICULA_NUMERO.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void txtTRANSFERENCIA_MATRICULA_NUMERO_Leave(object sender, EventArgs e)
        {
            if (txtTRANSFERENCIA_MATRICULA_NUMERO.Text == "")
            {
                txtTRANSFERENCIA_MATRICULA_NUMERO.Text = "Nº Matrícula";
                txtTRANSFERENCIA_MATRICULA_NUMERO.ForeColor = Color.Gray;
                txtTRANSFERENCIA_MATRICULA_NUMERO.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                txtTRANSFERENCIA_MATRICULA_NUMERO.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF_Enter(object sender, EventArgs e)
        {
            if (txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.Text == "CPF" && txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.ForeColor == Color.Gray)
            {
                txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.Text = "";
                txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.ForeColor = Color.Black;
                txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF_Leave(object sender, EventArgs e)
        {
            if (txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.Text == "")
            {
                txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.Text = "CPF";
                txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.ForeColor = Color.Gray;
                txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.TextAlign = HorizontalAlignment.Center;
            }
        }


        // -- Eventos de limpeza de caixa de textos
        private void btnREGISTRO_CLIENTE_LIMPAR_Click(object sender, EventArgs e)
            {
                txtREGISTRO_CLIENTE_CPF.Focus();
                txtREGISTRO_CLIENTE_CPF.Clear();
            }

        private void btnREGISTRO_IMOVEL_LIMPAR_Click(object sender, EventArgs e)
        {
            txtREGISTRO_IMOVEL_ID_ADD.Text = "01";
            txtREGISTRO_IMOVEL_NOME_ADD.Text = "João Vitor Ferreira Peixoto";
            txtREGISTRO_IMOVEL_ID.Text = "01";
            txtREGISTRO_IMOVEL_DATA_ADD.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtREGISTRO_IMOVEL_LOCALIZACAO.Clear();
            txtREGISTRO_IMOVEL_AREA.Clear();
            txtREGISTRO_IMOVEL_LOTE.Clear();
            cmbREGISTRO_IMOVEL_TERRENO.Text = "Urbano";
        }
        
        private void btnAVERBACAO_MATRICULA_LIMPAR_Click(object sender, EventArgs e)
        {
            txtAVERBACAO_MATRICULA_NUMERO.Focus();
            txtAVERBACAO_MATRICULA_NUMERO.Clear();
        }

        private void btnAVERBACAO_ADICIONARAVERBACAO_LIMPAR_Click(object sender, EventArgs e)
        {
            txtAVERBCACAO_ADICIONARAVERBACAO_ID_ADD.Text = "01";
            txtAVERBACAO_ADICIONARAVERBACAO_NOME_ADD.Text = "João Vitor Ferreira Peixoto";

            txtAVERBACAO_ADICIONARAVERBACAO_ID.Text = "01";
            txtAVERBACAO_ADICIONARAVERBACAO_DATA_ADD.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtAVERBACAO_ADICIONARAVERBACAO_DESCRICAOAVERBACAO.Clear();
            dtpAVERBACAO_ADICIONARAVERBACAO_DATA_AVERBACAO.Value = DateTime.Now;
        }

        private void btnTRANSFERENCIA_MATRICULA_LIMPAR_Click(object sender, EventArgs e)
        {
            txtTRANSFERENCIA_MATRICULA_NUMERO.Focus();
            txtTRANSFERENCIA_MATRICULA_NUMERO.Clear();
        }

        private void btnTRANSFERENCIA_NOVOPROPRIETARIO_LIMPAR_Click(object sender, EventArgs e)
        {
            txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.Focus();
            txtTRANSFERENCIA_NOVOPROPRIETARIO_CPF.Clear();
        }


        // -- Eventos para abrir as janelas dos botões laterais
        private void btnREGISTRAR_Click(object sender, EventArgs e)
        {
            pnlREGISTRO.BringToFront();
            pnlREGISTRO.Visible = true;
        }   

        private void btnTRANSFERENCIA_Click(object sender, EventArgs e)
        {
            pnlTRANSFERENCIA.BringToFront();
            pnlTRANSFERENCIA.Visible = true;
        }   
        
        private void btnAVERBACAO_Click(object sender, EventArgs e)
        {
            pnlAVERBACAO.BringToFront();
            pnlAVERBACAO.Visible = true;
        }


        // -- Eventos que fecham as janelas
        private void btn_FECHARregistro_Click(object sender, EventArgs e)
        {
            pnlREGISTRO.Visible = false;
        }

        private void btnAVERBACAO_FECHAR_Click(object sender, EventArgs e)
        {
            pnlAVERBACAO.Visible = false;
        }  
        
        private void Menu_FORM_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Fecha a aplicação caso não tenha nenhum Forms aberto
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
               
            }
        } 

        private void btnTRANSFERENCIA_FECHAR_Click(object sender, EventArgs e)
        {
            pnlTRANSFERENCIA.Visible = false;
        }


        // -- Eventos de quando as janelas carregam
        private void Menu_FORM_Load_1(object sender, EventArgs e)
        {
            // -- Pegando data atual e colocando na constante lblDATA
            lblDATA.Text = lblDATA.Text + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void pnlREGISTRO_VisibleChanged(object sender, EventArgs e)
        {
            this.btnREGISTRO_CLIENTE_LIMPAR_Click(sender, e);
            this.btnREGISTRO_IMOVEL_LIMPAR_Click(sender, e);
        }

        private void pnlAVERBACAO_VisibleChanged(object sender, EventArgs e)
        {
            this.btnAVERBACAO_MATRICULA_LIMPAR_Click(sender, e);
            this.btnAVERBACAO_ADICIONARAVERBACAO_LIMPAR_Click(sender, e);
        }

        private void pnlTRANSFERENCIA_VisibleChanged(object sender, EventArgs e)
        {
            btnTRANSFERENCIA_MATRICULA_LIMPAR_Click(sender, e);
            btnTRANSFERENCIA_NOVOPROPRIETARIO_LIMPAR_Click(sender, e);
        }

       
    }
}
