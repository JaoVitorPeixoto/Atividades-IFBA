using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA3_LP
{
    public partial class Forms_QUESTAO2 : Form
    {

        public Forms_QUESTAO2()
        {
            InitializeComponent();
            meto();
        }
        public void meto()
        {
            for (int i = 500; i <= 1000; i++)
            {
                if (i % 17 == 0 || i % 31 == 0)
                {
                    txtNums.Text = txtNums.Text + i + "   ";
                }
            }

        }

    }
}

