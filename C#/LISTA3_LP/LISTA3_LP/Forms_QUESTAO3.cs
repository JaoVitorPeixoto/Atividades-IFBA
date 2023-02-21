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
    public partial class Forms_QUESTAO3 : Form
    {
        public Forms_QUESTAO3()
        {
            InitializeComponent();
            Graus();
        }

        public void Graus()
        {
            float cel;
            
            for(int f = 50; f <= 65; f++)
            {
                cel = 5 / 9f * (f - 32);
                lblGRAUS.Text = lblGRAUS.Text + f +"F°     |     "+ cel.ToString("F") + "C°\n";
            }
        }
    }
}
