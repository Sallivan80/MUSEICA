using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{
    public static class PrezzoProvider
    {      
        public static float CalcolaScontoPrenotazionePeriodica(Prenotazione prenotazione,PoliticaCentro politica)
        {

            return prenotazione.getCosto()-(prenotazione.getCosto() * politica.ScontoPrenotazionePeriodica);
        }

       
        public static float CalcolaScontoClienteRegistrato(Prenotazione prenotazione,PoliticaCentro politica)
        {

            return prenotazione.getCosto() - (prenotazione.getCosto() * politica.ScontoClienteRegistrato);
        }

        public static string StampaFattura()
        {

            return "";
        }

    }//end PrezzoProvider
}