using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace NewMUSEICA.Model
{
    public static class PrezzoProvider
    {      
        public static float CalcolaScontoPrenotazionePeriodica(Prenotazione prenotazione)
        {

            prenotazione.Totale= prenotazione.GetTotale() - (prenotazione.GetTotale() * CentroSaleProve.GetIstance().Politica.ScontoPrenotazionePeriodica);
            return prenotazione.GetTotale();
        }

       
        public static float CalcolaScontoClienteRegistrato(Prenotazione prenotazione)
        {

            prenotazione.Totale= prenotazione.GetTotale() - (prenotazione.GetTotale() * CentroSaleProve.GetIstance().Politica.ScontoClienteRegistrato);
            return prenotazione.GetTotale();
        }

        public static string StampaFattura()
        {

            return "";
        }

    }//end PrezzoProvider
}