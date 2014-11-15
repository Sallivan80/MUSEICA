using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{
    public static class PrezzoProvider
    {      
        public static float CalcolaScontoPrenotazionePeriodica(PrenotazionePeriodica prenotazione)
        {
            prenotazione.Totale = prenotazione.GetTotale() - (prenotazione.GetTotale() * CentroSaleProve.GetIstance().Politica.ScontoPrenotazionePeriodica);

            return prenotazione.Totale;
        }

       
        public static float CalcolaScontoClienteRegistrato(Prenotazione prenotazione)
        {
            prenotazione.Totale= prenotazione.GetTotale() - (prenotazione.GetTotale() * CentroSaleProve.GetIstance().Politica.ScontoClienteRegistrato);
            return prenotazione.Totale;
        }
    }//end PrezzoProvider
}