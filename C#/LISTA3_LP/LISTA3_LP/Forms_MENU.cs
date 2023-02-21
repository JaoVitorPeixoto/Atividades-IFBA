namespace LISTA3_LP
{
    public partial class frmMENU : Form
    {
        public frmMENU()
        {
            InitializeComponent();
        }

        private void bntQUESTAO1_Click(object sender, EventArgs e)
        {

            Forms_QUESTAO1 fmrQUESTAO1 = new Forms_QUESTAO1();
            fmrQUESTAO1.ShowDialog();

        }

        private void btnVERLISTA_Click(object sender, EventArgs e)
        {
            forms_LISTA fmrLISTA = new forms_LISTA();
            fmrLISTA.Show();
            
        }

        private void btnQUESTAO2_Click(object sender, EventArgs e)
        {
            Forms_QUESTAO2 fmrQUESTAO2 = new Forms_QUESTAO2();  
            fmrQUESTAO2.ShowDialog();
        }

        private void btnQUESTAO3_Click(object sender, EventArgs e)
        {
            Forms_QUESTAO3 fmrQUESTAO3 = new Forms_QUESTAO3();  
            fmrQUESTAO3.ShowDialog();
        }

        private void btnQUESTAO4_Click(object sender, EventArgs e)
        {
            Forms1_QUESTAO4 fmrQUESTAO4 = new Forms1_QUESTAO4();
            fmrQUESTAO4.ShowDialog();
        }
    }
}