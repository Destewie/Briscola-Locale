using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Briscola
{
    class Carta
    {
        string seme;
        int valore;
        int puntiCheVale;
        bool giocata = false;
        private int numOrdine;  //è un numero casuale per ordinare le carte in modo (si spera) casuale

        //---------------------------------------------------------------------------------------------------------------------------------

        public string Seme { get => seme; set => seme = value; }
        public int Valore { get => valore; set => valore = value; }
        public int PuntiCheVale { get => puntiCheVale; set => puntiCheVale = value; }
        public bool Giocata { get => giocata; set => giocata = value; }
        public int NumOrdine { get => numOrdine; set => numOrdine = value; }

        //----------------------------------------------------------------------------------------------------------------------------------

        public Carta(int n, int nO)
        {
        
            NumOrdine = nO;

            //da 1 a 10 sono danari, da 11 a 20 sono coppe, da 21 a 30 sono spade, da 31 a 40 sono bastoni

            if (n <= 10)
            {
                Seme = "danari";
                Valore = n;

                if (n!= 1 && n!=3 && n!=8 && n!=9 && n!=10)
                {
                    puntiCheVale = 0;
                    return;
                }

                if (n == 1)     //asso
                {
                    puntiCheVale = 11;
                    return;
                }   

                if (n == 3)     //3
                {
                    puntiCheVale = 10;
                    return;
                }
                  
                if (n == 8)     //fante
                {
                    puntiCheVale = 2;
                    return;
                }

                if (n == 9)     //cavallo
                {
                    puntiCheVale = 3;
                    return;
                }

                if (n == 10)    //re
                {
                    puntiCheVale = 4;
                    return;
                }  
     
            }

            if (n <= 20)
            {
                Seme = "coppe";
                n -= 10;
                Valore = n;

                if (n != 1 && n != 3 && n != 8 && n != 9 && n != 10)
                {
                    puntiCheVale = 0;
                    return;
                }

                if (n == 1)     //asso
                {
                    puntiCheVale = 11;
                    return;
                }

                if (n == 3)     //3
                {
                    puntiCheVale = 10;
                    return;
                }

                if (n == 8)     //fante
                {
                    puntiCheVale = 2;
                    return;
                }

                if (n == 9)     //cavallo
                {
                    puntiCheVale = 3;
                    return;
                }

                if (n == 10)    //re
                {
                    puntiCheVale = 4;
                    return;
                }
            }

            if (n <= 30)
            {
                Seme = "spade";
                n -= 20;
                Valore = n;

                if (n != 1 && n != 3 && n != 8 && n != 9 && n != 10)
                {
                    puntiCheVale = 0;
                    return;
                }

                if (n == 1)     //asso
                {
                    puntiCheVale = 11;
                    return;
                }

                if (n == 3)     //3
                {
                    puntiCheVale = 10;
                    return;
                }

                if (n == 8)     //fante
                {
                    puntiCheVale = 2;
                    return;
                }

                if (n == 9)     //cavallo
                {
                    puntiCheVale = 3;
                    return;
                }

                if (n == 10)    //re
                {
                    puntiCheVale = 4;
                    return;
                }
            }

            if (n <= 40)
            {
                Seme = "bastoni";
                n -= 30;
                Valore = n;

                if (n != 1 && n != 3 && n != 8 && n != 9 && n != 10)
                {
                    puntiCheVale = 0;
                    return;
                }

                if (n == 1)     //asso
                {
                    puntiCheVale = 11;
                    return;
                }

                if (n == 3)     //3
                {
                    puntiCheVale = 10;
                    return;
                }

                if (n == 8)     //fante
                {
                    puntiCheVale = 2;
                    return;
                }

                if (n == 9)     //cavallo
                {
                    puntiCheVale = 3;
                    return;
                }

                if (n == 10)    //re
                {
                    puntiCheVale = 4;
                    return;
                }
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        public string RitornaNome()
        {
            if (Valore > 1 && Valore < 8)
                return Valore + " di " + Seme;

            if (Valore == 1)
                return "Asso di " + Seme;

            if (Valore == 8)
                return "Fante di " + Seme;

            if (Valore == 9)
                return "Cavallo di " + Seme;

            if (Valore == 10)
                return "Re di " + Seme;

            return "ERRORE NOME CARTA";

        }

        //----------------------------------------------------------------------------------------------------------------------------------
    }
}
