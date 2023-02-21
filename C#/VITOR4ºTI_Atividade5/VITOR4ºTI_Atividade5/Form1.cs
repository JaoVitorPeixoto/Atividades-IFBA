namespace VITOR4ºTI_Atividade5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnENVIAR_vendedor_Click(object sender, EventArgs e)
        {
            String nome = txtNOME_vendedor.Text;
            String comissao = txtCOMISSAO_vendedor.Text;
            String area = txtAREA_vendedor.Text;

            StreamWriter vendedor = new StreamWriter("C:\\Users\\joaot\\source\\repos\\VITOR4ºTI_Atividade5\\VITOR4ºTI_Atividade5\\Resources\\Dados\\IFBAVendedor\\ifbaVENDEDOR.txt");
            vendedor.WriteLine(nome + ";" + comissao + ";" + area);
            vendedor.Close();

            MessageBox.Show("Vendedor salvo com sucesso!");

            txtNOME_vendedor.Clear();
            txtCOMISSAO_vendedor.Clear();
            txtAREA_vendedor.Clear();
            txtNOME_vendedor.Focus();
        }

        private void btnENVIAR_socio_Click(object sender, EventArgs e)
        {

            String nome = txtNOME_socio.Text;
            String dtNascimento = dtpDTNASCIMENTO_socio.Text;
            String area = txtAREA_socio.Text;

            StreamWriter socio = new StreamWriter("C:\\Users\\joaot\\source\\repos\\VITOR4ºTI_Atividade5\\VITOR4ºTI_Atividade5\\Resources\\Dados\\IFBASocio\\ifbaSOCIO.txt");
            socio.WriteLine(nome + ";" + dtNascimento + ";" + area);
            socio.Close();

            MessageBox.Show("Sócio salvo com sucesso!");

            txtNOME_socio.Clear();
            dtpDTNASCIMENTO_socio.Value = DateTime.Now;
            txtAREA_socio.Clear();
            txtNOME_socio.Focus();

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_Produto_FORM fmrCadastrar = new Cadastrar_Produto_FORM();
            fmrCadastrar.ShowDialog();

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCLIENTE_Click(object sender, EventArgs e)
        {
            Cliente_FORM fmrCliente = new Cliente_FORM();
            fmrCliente.ShowDialog();

        }
    }
}