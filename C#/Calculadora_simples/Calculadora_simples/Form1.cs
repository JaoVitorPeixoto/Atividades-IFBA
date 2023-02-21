namespace Calculadora_simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLIMPAR_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            lblRESULTADO.Text = "0";
        }

        private void btnSAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSOMA_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblRESULTADO.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.lblRESULTADO.ForeColor = System.Drawing.Color.Black;
                this.lblRESULTADO.Location = new System.Drawing.Point(124, 203);
                this.lblRESULTADO.Size = new System.Drawing.Size(28, 32);

                lblRESULTADO.Text = Convert.ToString(double.Parse(txtN1.Text) + double.Parse(txtN2.Text));
            }
            catch (System.FormatException)
            {
                this.lblRESULTADO.AutoSize = true;
                this.lblRESULTADO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.lblRESULTADO.ForeColor = System.Drawing.Color.Red;
                this.lblRESULTADO.Location = new System.Drawing.Point(40, 221);
                this.lblRESULTADO.Size = new System.Drawing.Size(280, 21);
                this.lblRESULTADO.Text = "Informe os números corretamente!!";
            }
            
        }

        private void btnSUBTRACAO_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblRESULTADO.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.lblRESULTADO.ForeColor = System.Drawing.Color.Black;
                this.lblRESULTADO.Location = new System.Drawing.Point(124, 203);
                this.lblRESULTADO.Size = new System.Drawing.Size(28, 32);

                lblRESULTADO.Text = Convert.ToString(double.Parse(txtN1.Text) - double.Parse(txtN2.Text));
            }
            catch (System.FormatException)
            {
                this.lblRESULTADO.AutoSize = true;
                this.lblRESULTADO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.lblRESULTADO.ForeColor = System.Drawing.Color.Red;
                this.lblRESULTADO.Location = new System.Drawing.Point(40, 221);
                this.lblRESULTADO.Size = new System.Drawing.Size(280, 21);
                this.lblRESULTADO.Text = "Informe os números corretamente!!";
            }
        }

        private void btnMULTIPLICACAO_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblRESULTADO.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.lblRESULTADO.ForeColor = System.Drawing.Color.Black;
                this.lblRESULTADO.Location = new System.Drawing.Point(124, 203);
                this.lblRESULTADO.Size = new System.Drawing.Size(28, 32);

                lblRESULTADO.Text = Convert.ToString(double.Parse(txtN1.Text) * double.Parse(txtN2.Text));
            }
            catch (System.FormatException)
            {
                this.lblRESULTADO.AutoSize = true;
                this.lblRESULTADO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.lblRESULTADO.ForeColor = System.Drawing.Color.Red;
                this.lblRESULTADO.Location = new System.Drawing.Point(40, 221);
                this.lblRESULTADO.Size = new System.Drawing.Size(280, 21);
                this.lblRESULTADO.Text = "Informe os números corretamente!!";
            }
        }

        private void btnDIVISAO_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblRESULTADO.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.lblRESULTADO.ForeColor = System.Drawing.Color.Black;
                this.lblRESULTADO.Location = new System.Drawing.Point(124, 203);
                this.lblRESULTADO.Size = new System.Drawing.Size(28, 32);

                lblRESULTADO.Text = Convert.ToString(double.Parse(txtN1.Text) / double.Parse(txtN2.Text));
            }
            catch (System.FormatException)
            {
                this.lblRESULTADO.AutoSize = true;
                this.lblRESULTADO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.lblRESULTADO.ForeColor = System.Drawing.Color.Red;
                this.lblRESULTADO.Location = new System.Drawing.Point(40, 221);
                this.lblRESULTADO.Size = new System.Drawing.Size(280, 21);
                this.lblRESULTADO.Text = "Informe os números corretamente!!";
            }
        }
    }
}