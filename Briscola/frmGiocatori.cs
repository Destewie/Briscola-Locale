using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Briscola
{
    public partial class frmGiocatori : Form
    {
        private string nome1;
        private string nome2;

        //----------------------------------------------------------------------------------------------------------------------------------

        public string Nome1 { get => nome1; set => nome1 = value; }
        public string Nome2 { get => nome2; set => nome2 = value; }

        //----------------------------------------------------------------------------------------------------------------------------------

        public frmGiocatori()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        private void btnGioca_Click(object sender, EventArgs e)
        {
            Nome1 = txtNomeGiocatore1.Text;
            Nome2 = txtNomeGiocatore2.Text;
        }

        //----------------------------------------------------------------------------------------------------------------------------------
    }
}
