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
    public partial class frmFinePartita : Form
    {
        public frmFinePartita(bool pareggio, string nomeVincitore, int ptiVincitore, string nomePerdente, int ptiPerdente)
        {
            InitializeComponent();

            lblPuntiVincitore.Text = "Punti " + nomeVincitore + ": " + ptiVincitore;
            lblPuntiPerdente.Text = "Punti " + nomePerdente + ": " + ptiPerdente;

            if (!pareggio)
            {
                lblVincitore.Text = nomeVincitore;
            }
            else
            {
                lblVincitore.Text = "Incredibile,";
                lblVinceLaPartita.Text = "PAREGGIO!";
            }
        }
    }
}
