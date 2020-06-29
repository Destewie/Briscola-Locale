using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Briscola
{
    class Mano : List<Carta>
    {
        //----------------------------------------------------------------------------------------------------------------------------------

        public bool Vuota()
        {
            if (this[0].Giocata == true && this[1].Giocata == true && this[2].Giocata == true)
                return true;
            else
                return false;
        }

        //----------------------------------------------------------------------------------------------------------------------------------
    }
}
