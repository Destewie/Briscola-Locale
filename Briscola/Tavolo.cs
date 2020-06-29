using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Briscola
{
    public partial class frmTavolo : Form
    {
        List<Carta> Mazzo = new List<Carta>();
        int nCarteRimanenti = 40;
        int indiceCarta = 0;

        Mano manoGiocatore1 = new Mano();
        Mano manoGiocatore2 = new Mano();
        //static List<Carta> manoGiocatore1 = new List<Carta>();
        //static List<Carta> manoGiocatore2 = new List<Carta>();

        List<Carta> PigliGiocatore1 = new List<Carta>();
        List<Carta> PigliGiocatore2 = new List<Carta>();

        Carta primaCartaInTavola;
        Carta secondaCartaInTavola;

        string nomeGiocatore1;
        string nomeGiocatore2;

        int indPerEliminazioneTavoloEPesca = 0;

        Carta cartaDiBriscola;

        Boolean turnoGiocatore1 = true; //inizia il giocatore 1


        //----------------------------------------------------------------------------------------------------------------------------------

        public frmTavolo()
        {
            InitializeComponent();

            InizializzaMazzo();  
            DareLeCarte();

            lblCartaTavolo1.Text = "";
            lblCartaTavolo2.Text = "";
            lblChiHaPreso.Text = "";
            lblNomeGiocatorePrimaCarta.Text = "";
            lblNomeGiocatoreSecondaCarta.Text = "";


            this.Hide();

            frmGiocatori formPlayers = new frmGiocatori();
            if (formPlayers.ShowDialog() == DialogResult.OK)
            {
                if(formPlayers.Nome1 != "")
                    nomeGiocatore1 = formPlayers.Nome1;
                else
                    nomeGiocatore1 = "Giocatore 1";

                if (formPlayers.Nome2 != "")
                    nomeGiocatore2 = formPlayers.Nome2;
                else
                    nomeGiocatore2 = "Giocatore 2";
            }
            else
            {
                nomeGiocatore1 = "Giocatore 1";
                nomeGiocatore2 = "Giocatore 2";
            }

            //inizia il giocatore 1     //QUESTA PARTE DOVRAI SPOSTARLA ALL'INIZIO DEL GIOCO
            lblTurno.Text = "Turno di " + nomeGiocatore1;
            VisualizzaMano(manoGiocatore1);

        }

        //----------------------------------------------------------------------------------------------------------------------------------

        public void InizializzaMazzo()
        {
            for (int i = 1; i<41; i++)
            {
                System.Threading.Thread.Sleep(InteroRandom(31, 59)); //per cambiare il seme del random

                Carta c = new Carta(i, InteroRandom(1345, 576423));

                Mazzo.Add(c);
            }

            Mazzo = Mazzo.OrderBy(k => k.NumOrdine).ToList();    //ordina il mazzo in base al campo casuale creato prima (in pratica è ordinarlo seguendo dei numeri casuali)
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        public int InteroRandom(int minimo, int massimo)    //random >= minimo       random < massimo
        {
            Random random = new Random();
            return random.Next(minimo, massimo);
        }

        //----------------------------------------------------------------------------------------------------------------------------------
        
        void DareLeCarte() //Inizierà il giocatore 1, quindi pesca per primo il 2
        {
            //pesca il giocatore 2
            manoGiocatore2.Add(Mazzo[indiceCarta]);
            indiceCarta = indiceCarta + 1;
            manoGiocatore2.Add(Mazzo[indiceCarta]);
            indiceCarta = indiceCarta + 1;
            manoGiocatore2.Add(Mazzo[indiceCarta]);
            indiceCarta = indiceCarta + 1;

            //pesca il giocatore 1
            manoGiocatore1.Add(Mazzo[indiceCarta]);
            indiceCarta = indiceCarta + 1;
            manoGiocatore1.Add(Mazzo[indiceCarta]);
            indiceCarta = indiceCarta + 1;
            manoGiocatore1.Add(Mazzo[indiceCarta]);
            indiceCarta = indiceCarta + 1;

            //Aggiorno il numero delle carte del mazzo
            nCarteRimanenti -= 6;
            lblNCarte.Text = Convert.ToString(nCarteRimanenti);

            //La carta in fondo al mazzo rappresenterà la briscola
            cartaDiBriscola = Mazzo[39];
            lblBriscola.Text = "Briscola:  " + cartaDiBriscola.RitornaNome();

        }

        //----------------------------------------------------------------------------------------------------------------------------------

        void VisualizzaMano(Mano hand)
        {
            lblCarta1.Text = hand[0].RitornaNome();
            lblCarta2.Text = hand[1].RitornaNome();
            lblCarta3.Text = hand[2].RitornaNome();
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        private void btnCarta1_Click(object sender, EventArgs e)
        {

            if(lblCartaTavolo1.Text == "")  //se la prima posizione nel tavolo è vuota, allora vuol dire che la carta che sta per essere gicota è la prima della giocata attuale
            {
                if (turnoGiocatore1 == true)  //serve per capire di chi è il turno e di conseguenza capire da che mano prendere le carte
                {
                    manoGiocatore1[0].Giocata = true;
                    primaCartaInTavola = manoGiocatore1[0];

                    lblNomeGiocatorePrimaCarta.Text = nomeGiocatore1;   //fa vedere sopra la relativa carta in tavola, chi la ha giocata

                    turnoGiocatore1 = false;
                }
                else   //serve per capire di chi è il turno e di conseguenza capire da che mano prendere le carte
                {
                    manoGiocatore2[0].Giocata = true;
                    primaCartaInTavola = manoGiocatore2[0];

                    lblNomeGiocatorePrimaCarta.Text = nomeGiocatore2;   //fa vedere sopra la relativa carta in tavola, chi la ha giocata

                    turnoGiocatore1 = true;
                }

                lblCartaTavolo1.Text = primaCartaInTavola.RitornaNome();

            }
            else //se la prima posizione è occupata, allora quella che si sta andando a giocare è la seconda carta
            {
                if (turnoGiocatore1 == true)  //serve per capire di chi è il turno e di conseguenza capire da che mano prendere le carte
                {
                    manoGiocatore1[0].Giocata = true;
                    secondaCartaInTavola = manoGiocatore1[0];

                    lblNomeGiocatoreSecondaCarta.Text = nomeGiocatore1; //fa vedere sopra la relativa carta in tavola, chi la ha giocata

                    lblCartaTavolo2.Text = secondaCartaInTavola.RitornaNome();

                    turnoGiocatore1 = DecidereChiPrende(false, secondaCartaInTavola, primaCartaInTavola); //se adesso è il turno del giocatore1, allora vuole dire che la carta giocata dal giocatore1 sarà la seconda e quella del giocatore2 la prima
                }
                else   //serve per capire di chi è il turno e di conseguenza capire da che mano prendere le carte
                {
                    manoGiocatore2[0].Giocata = true;
                    secondaCartaInTavola = manoGiocatore2[0];

                    lblNomeGiocatoreSecondaCarta.Text = nomeGiocatore2; //fa vedere sopra la relativa carta in tavola, chi la ha giocata

                    lblCartaTavolo2.Text = secondaCartaInTavola.RitornaNome();

                    turnoGiocatore1 = DecidereChiPrende(true, primaCartaInTavola, secondaCartaInTavola); //se adesso è il turno del giocatore2, allora vuol dire che la carta giocata dal giocatore1 sarà stata la prima ad andare in tavola e quella del giocatore2 la seconda
                }

                if (turnoGiocatore1 == true) //per stampare il nome del giocatore che ha vinto la mano
                {
                    lblChiHaPreso.Text = "Mano vinta da " + nomeGiocatore1;
                }
                else
                {
                    lblChiHaPreso.Text = "Mano vinta da " + nomeGiocatore2;
                }

            }

            CambioPlayer(turnoGiocatore1);


        }

        //----------------------------------------------------------------------------------------------------------------------------------

        private void btnCarta2_Click(object sender, EventArgs e)
        {

            if (lblCartaTavolo1.Text == "")  //se la prima posizione nel tavolo è vuota, allora vuol dire che la carta che sta per essere gicota è la prima della giocata attuale
            {
                if (turnoGiocatore1 == true)  //serve per capire di chi è il turno e di conseguenza capire da che mano prendere le carte
                {
                    manoGiocatore1[1].Giocata = true;
                    primaCartaInTavola = manoGiocatore1[1];

                    lblNomeGiocatorePrimaCarta.Text = nomeGiocatore1;   //fa vedere sopra la relativa carta in tavola, chi la ha giocata

                    turnoGiocatore1 = false;
                }
                else   //serve per capire di chi è il turno e di conseguenza capire da che mano prendere le carte
                {
                    manoGiocatore2[1].Giocata = true;
                    primaCartaInTavola = manoGiocatore2[1];

                    lblNomeGiocatorePrimaCarta.Text = nomeGiocatore2;   //fa vedere sopra la relativa carta in tavola, chi la ha giocata

                    turnoGiocatore1 = true;
                }

                lblCartaTavolo1.Text = primaCartaInTavola.RitornaNome();

            }
            else //se la prima posizione è occupata, allora quella che si sta andando a giocare è la seconda carta
            {
                if (turnoGiocatore1 == true)  //serve per capire di chi è il turno e di conseguenza capire da che mano prendere le carte
                {
                    manoGiocatore1[1].Giocata = true;
                    secondaCartaInTavola = manoGiocatore1[1];

                    lblNomeGiocatoreSecondaCarta.Text = nomeGiocatore1; //fa vedere sopra la relativa carta in tavola, chi la ha giocata

                    lblCartaTavolo2.Text = secondaCartaInTavola.RitornaNome();

                    turnoGiocatore1 = DecidereChiPrende(false, secondaCartaInTavola, primaCartaInTavola); //se adesso è il turno del giocatore1, allora vuole dire che la carta giocata dal giocatore1 sarà la seconda e quella del giocatore2 la prima
                }
                else   //serve per capire di chi è il turno e di conseguenza capire da che mano prendere le carte
                {
                    manoGiocatore2[1].Giocata = true;
                    secondaCartaInTavola = manoGiocatore2[1];

                    lblNomeGiocatoreSecondaCarta.Text = nomeGiocatore2; //fa vedere sopra la relativa carta in tavola, chi la ha giocata

                    lblCartaTavolo2.Text = secondaCartaInTavola.RitornaNome();

                    turnoGiocatore1 = DecidereChiPrende(true, primaCartaInTavola, secondaCartaInTavola); //se adesso è il turno del giocatore2, allora vuol dire che la carta giocata dal giocatore1 sarà stata la prima ad andare in tavola e quella del giocatore2 la seconda
                }

                if (turnoGiocatore1 == true) //per stampare il nome del giocatore che ha vinto la mano
                {
                    lblChiHaPreso.Text = "Mano vinta da " + nomeGiocatore1;
                }
                else
                {
                    lblChiHaPreso.Text = "Mano vinta da " + nomeGiocatore2;
                }

            }

            CambioPlayer(turnoGiocatore1);


        }

        //----------------------------------------------------------------------------------------------------------------------------------

        private void btnCarta3_Click(object sender, EventArgs e)
        {
            if (lblCartaTavolo1.Text == "")  //se la prima posizione nel tavolo è vuota, allora vuol dire che la carta che sta per essere gicota è la prima della giocata attuale
            {
                if (turnoGiocatore1 == true)  //serve per capire di chi è il turno e di conseguenza capire da che mano prendere le carte
                {
                    manoGiocatore1[2].Giocata = true;
                    primaCartaInTavola = manoGiocatore1[2];

                    lblNomeGiocatorePrimaCarta.Text = nomeGiocatore1;   //fa vedere sopra la relativa carta in tavola, chi la ha giocata

                    turnoGiocatore1 = false;
                }
                else   //serve per capire di chi è il turno e di conseguenza capire da che mano prendere le carte
                {
                    manoGiocatore2[2].Giocata = true;
                    primaCartaInTavola = manoGiocatore2[2];

                    lblNomeGiocatorePrimaCarta.Text = nomeGiocatore2;   //fa vedere sopra la relativa carta in tavola, chi la ha giocata

                    turnoGiocatore1 = true;
                }

                lblCartaTavolo1.Text = primaCartaInTavola.RitornaNome();

            }
            else //se la prima posizione è occupata, allora quella che si sta andando a giocare è la seconda carta
            {
                if (turnoGiocatore1 == true)  //serve per capire di chi è il turno e di conseguenza capire da che mano prendere le carte
                {
                    manoGiocatore1[2].Giocata = true;
                    secondaCartaInTavola = manoGiocatore1[2];

                    lblNomeGiocatoreSecondaCarta.Text = nomeGiocatore1; //fa vedere sopra la relativa carta in tavola, chi la ha giocata

                    lblCartaTavolo2.Text = secondaCartaInTavola.RitornaNome();

                    turnoGiocatore1 = DecidereChiPrende(false, secondaCartaInTavola, primaCartaInTavola); //se adesso è il turno del giocatore1, allora vuole dire che la carta giocata dal giocatore1 sarà la seconda e quella del giocatore2 la prima
                }
                else   //serve per capire di chi è il turno e di conseguenza capire da che mano prendere le carte
                {
                    manoGiocatore2[2].Giocata = true;
                    secondaCartaInTavola = manoGiocatore2[2];

                    lblNomeGiocatoreSecondaCarta.Text = nomeGiocatore2; //fa vedere sopra la relativa carta in tavola, chi la ha giocata

                    lblCartaTavolo2.Text = secondaCartaInTavola.RitornaNome();

                    turnoGiocatore1 = DecidereChiPrende(true, primaCartaInTavola, secondaCartaInTavola); //se adesso è il turno del giocatore2, allora vuol dire che la carta giocata dal giocatore1 sarà stata la prima ad andare in tavola e quella del giocatore2 la seconda
                }

                if (turnoGiocatore1 == true) //per stampare il nome del giocatore che ha vinto la mano
                {
                    lblChiHaPreso.Text = "Mano vinta da " + nomeGiocatore1;
                }
                else
                {
                    lblChiHaPreso.Text = "Mano vinta da " + nomeGiocatore2;
                }

            }

            CambioPlayer(turnoGiocatore1);


        }

        //----------------------------------------------------------------------------------------------------------------------------------

        private bool DecidereChiPrende(bool primaCartaGiocataDaPlayer1, Carta cartaInTavola1, Carta cartaInTavola2) //Gli si deve passare chi ha tirato la prima carta e le due carte in tavola
        {

            if (secondaCartaInTavola.Seme != primaCartaInTavola.Seme && secondaCartaInTavola.Seme != cartaDiBriscola.Seme)
            {
                if (primaCartaGiocataDaPlayer1 == true)
                {
                    PigliGiocatore1.Add(cartaInTavola1);
                    PigliGiocatore1.Add(cartaInTavola2);
                    return true; //il prossimo turno sarà del giocatore1
                }
                else
                {
                    PigliGiocatore2.Add(cartaInTavola1);
                    PigliGiocatore2.Add(cartaInTavola2);
                    return false; //il prossimo turno sarà del giocatore2
                }
            }


            if (secondaCartaInTavola.Seme == primaCartaInTavola.Seme)
            {

                if(secondaCartaInTavola.PuntiCheVale == primaCartaInTavola.PuntiCheVale)  //se sono entrambe delle scartelle bisogna vedere quale delle due ha il numero più alto
                {
                    if(secondaCartaInTavola.Valore < primaCartaInTavola.Valore) //la prima carta ha il numero più alto
                    {
                        if (primaCartaGiocataDaPlayer1 == true) //se la prima carta è più alta e la ha giocata il player1, prenderà lui
                        {
                            PigliGiocatore1.Add(cartaInTavola1);
                            PigliGiocatore1.Add(cartaInTavola2);
                            return true; //il prossimo turno sarà del giocatore1
                        }
                        else   //se mo prenderà il Player2
                        {
                            PigliGiocatore2.Add(cartaInTavola1);
                            PigliGiocatore2.Add(cartaInTavola2);
                            return false; //il prossimo turno sarà del giocatore2
                        }
                    }
                    else  //contrario
                    {
                        if (primaCartaGiocataDaPlayer1 == false)
                        {
                            PigliGiocatore1.Add(cartaInTavola1);
                            PigliGiocatore1.Add(cartaInTavola2);
                            return true; //il prossimo turno sarà del giocatore1
                        }
                        else
                        {
                            PigliGiocatore2.Add(cartaInTavola1);
                            PigliGiocatore2.Add(cartaInTavola2);
                            return false; //il prossimo turno sarà del giocatore2
                        }
                    }
                }
                else  //se sono dello stesso seme ma valgono punti diversi
                {
                    if(primaCartaInTavola.PuntiCheVale > secondaCartaInTavola.PuntiCheVale) //se la prima carta giocata vale di più e entrambe hanno lo stesso seme
                    {
                        if (primaCartaGiocataDaPlayer1 == true) //se la prima carta è più alta e la ha giocata il player1, prenderà lui
                        {
                            PigliGiocatore1.Add(cartaInTavola1);
                            PigliGiocatore1.Add(cartaInTavola2);
                            return true; //il prossimo turno sarà del giocatore1
                        }
                        else   //se mo prenderà il Player2
                        {
                            PigliGiocatore2.Add(cartaInTavola1);
                            PigliGiocatore2.Add(cartaInTavola2);
                            return false; //il prossimo turno sarà del giocatore2
                        }
                    }
                    else // se la seconda carta giocata valesse di più
                    {
                        if (primaCartaGiocataDaPlayer1 == false)
                        {
                            PigliGiocatore1.Add(cartaInTavola1);
                            PigliGiocatore1.Add(cartaInTavola2);

                            return true; //il prossimo turno sarà del giocatore1
                        }
                        else
                        {
                            PigliGiocatore2.Add(cartaInTavola1);
                            PigliGiocatore2.Add(cartaInTavola2);

                            return false; //il prossimo turno sarà del giocatore2
                        }
                    }
                }
            }


            if(secondaCartaInTavola.Seme == cartaDiBriscola.Seme && primaCartaInTavola.Seme != cartaDiBriscola.Seme)
            {
                if (primaCartaGiocataDaPlayer1 == false)
                {
                    PigliGiocatore1.Add(cartaInTavola1);
                    PigliGiocatore1.Add(cartaInTavola2);
                    return true; //il prossimo turno sarà del giocatore1
                }
                else
                {
                    PigliGiocatore2.Add(cartaInTavola1);
                    PigliGiocatore2.Add(cartaInTavola2);
                    return false; //il prossimo turno sarà del giocatore2
                }
            }

            MessageBox.Show("VAI AD AGGIUNGERE QUESTO TIPO DI PIGLIO, NON DOVRESTI MAI ARRIVARE A QUESTO PUNTO NEL CODICE", "Critical Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return true; //return a caso, non si dovrebbe arrivare a questo punto
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        async void CambioPlayer(bool turnoPlayer1) 
        {
            indPerEliminazioneTavoloEPesca ++;  

            pnlCambioPlayer.BringToFront(); //copre la mano per cambiare giocatore

            lblTurno.Text = "";  //elimina la scritta del turno

            if (turnoPlayer1 == true)
            {
                lblCambioGiocatore1.Text = "Si prepari " + nomeGiocatore1;
            }
            else
            {
                lblCambioGiocatore1.Text = "Si prepari " + nomeGiocatore2;
            }

            
            //Aspetta 4 secondi per cambiare player
            lblTimer.Text = "4";
            await Task.Delay(1000);
            lblTimer.Text = "3";
            await Task.Delay(1000);
            lblTimer.Text = "2";
            await Task.Delay(1000);
            lblTimer.Text = "1";
            await Task.Delay(1000);
            

            if (indPerEliminazioneTavoloEPesca % 2 == 0)
            {
                lblCartaTavolo1.Text = "";                  //pulizia scritte
                lblCartaTavolo2.Text = "";                  //pulizia scritte
                lblChiHaPreso.Text = "";                    //pulizia scritte
                lblNomeGiocatorePrimaCarta.Text = "";       //pulizia scritte
                lblNomeGiocatoreSecondaCarta.Text = "";     //pulizia scritte


                if(nCarteRimanenti > 0)
                {
                    if (turnoPlayer1 == true)
                    {
                        Pesca(manoGiocatore1);
                        Pesca(manoGiocatore2);

                        lblTurno.Text = "Turno di " + nomeGiocatore1;
                        VisualizzaMano(manoGiocatore1);
                    }
                    else
                    {
                        Pesca(manoGiocatore2);
                        Pesca(manoGiocatore1);

                        lblTurno.Text = "Turno di " + nomeGiocatore2;
                        VisualizzaMano(manoGiocatore2);
                    }
                }
                
            }


            btnCarta1.Enabled = false;
            btnCarta2.Enabled = false;
            btnCarta3.Enabled = false;


            if (turnoPlayer1 == true && manoGiocatore1.Vuota() == false)
            {
                if (manoGiocatore1[0].Giocata == false)
                {
                    btnCarta1.Enabled = true;
                }
                if (manoGiocatore1[1].Giocata == false)
                {
                    btnCarta2.Enabled = true;
                }
                if (manoGiocatore1[2].Giocata == false)
                {
                    btnCarta3.Enabled = true;
                }

                lblTurno.Text = "Turno di " + nomeGiocatore1;
                VisualizzaMano(manoGiocatore1);
            }

            if (turnoPlayer1 == false && manoGiocatore2.Vuota() == false)
            {
                if (manoGiocatore2[0].Giocata == false)
                {
                    btnCarta1.Enabled = true;
                }
                if (manoGiocatore2[1].Giocata == false)
                {
                    btnCarta2.Enabled = true;
                }
                if (manoGiocatore2[2].Giocata == false)
                {
                    btnCarta3.Enabled = true;
                }

                lblTurno.Text = "Turno di " + nomeGiocatore2;
                VisualizzaMano(manoGiocatore2);
            }

            if(manoGiocatore1.Vuota() && manoGiocatore2.Vuota())
            {
                int ptiGiocatore1 = CalcolaPunti(PigliGiocatore1);
                int ptiGiocatore2 = CalcolaPunti(PigliGiocatore2);

                if (ptiGiocatore1 > ptiGiocatore2)
                {
                    frmFinePartita formVincitore = new frmFinePartita(false, nomeGiocatore1, ptiGiocatore1, nomeGiocatore2, ptiGiocatore2);
                    this.Hide();
                    if(formVincitore.ShowDialog() != DialogResult.OK) //non ritornerà mai OK perchè non ci sono bottoni che tornano OK nella form vincitori
                    {
                        Application.Exit();
                    }
                }
                if (ptiGiocatore1 < ptiGiocatore2)
                {
                    frmFinePartita formVincitore = new frmFinePartita(false, nomeGiocatore2, ptiGiocatore2, nomeGiocatore1, ptiGiocatore1);
                    this.Hide();
                    if (formVincitore.ShowDialog() != DialogResult.OK) //non ritornerà mai OK perchè non ci sono bottoni che tornano OK nella form vincitori
                    {
                        Application.Exit();
                    }
                }
                if (ptiGiocatore1 == ptiGiocatore2)
                {
                    frmFinePartita formVincitore = new frmFinePartita(true, nomeGiocatore2, ptiGiocatore2, nomeGiocatore1, ptiGiocatore1);
                    this.Hide();
                    if (formVincitore.ShowDialog() != DialogResult.OK) //non ritornerà mai OK perchè non ci sono bottoni che tornano OK nella form vincitori
                    {
                        Application.Exit();
                    }
                }

            }

            pnlMano.BringToFront();
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        private void Pesca(List<Carta> hand)
        {
            for(int i = 0; i<3; i++)
            {
                if(hand[i].Giocata == true)
                {
                    hand[i] = Mazzo[indiceCarta];
                    indiceCarta = indiceCarta + 1;

                    nCarteRimanenti = nCarteRimanenti - 1;
                    lblNCarte.Text = Convert.ToString(nCarteRimanenti);
                }  
            }    
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        private int CalcolaPunti(List<Carta> Pigli)
        {
            int pti = 0;

            foreach(Carta c in Pigli)
            {
                pti += c.PuntiCheVale;
            }

            return pti;
        }

        //----------------------------------------------------------------------------------------------------------------------------------
    }
}