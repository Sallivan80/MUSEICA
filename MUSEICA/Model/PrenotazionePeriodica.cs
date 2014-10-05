using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{
    public class PrenotazionePeriodica : Prenotazione
    {

        private List<PrenotazioneSingola> _prenotazioni=new List<PrenotazioneSingola>();
        private DateTime _dataFine;
        

        public PrenotazionePeriodica(List<PrenotazioneSingola> prenotazioniRichieste,DateTime dataFine)            
        {
            CreaPrenotazionePeriodica(prenotazioniRichieste, dataFine);
        }        

        public DateTime DataFine
        {
            get { return _dataFine; }
            set { _dataFine = value; }
        }

        public override float getCosto()
        {

            float totalePrenotazionePeriodica = 0;
            foreach (PrenotazioneSingola p in _prenotazioni)
                totalePrenotazionePeriodica += p.getCosto();
            return totalePrenotazionePeriodica;
        }

        private void CreaPrenotazionePeriodica(List<PrenotazioneSingola> prenotazioniRichieste, DateTime dataFine)
        {

            foreach (PrenotazioneSingola p in prenotazioniRichieste)
            {
                /* int i=0;
                   while(i<dataFine.DayOfYear-p.Data.DayOfYear)
                   {
                       DateTime dataTemp = p.Data.AddDays(i);
                       if (dataTemp.CompareTo(dataFine) <= 0)
                       {
                         _prenotazioni.Add(new PrenotazioneSingola(p.IdPrenotazione, p.Cliente, p.Sala, dataTemp, p.OraInizio, p.OraFine));
                         i += 7;
                       }
                   }*/

                for (int i = 0; i < dataFine.DayOfYear - p.Data.DayOfYear; i++)
                {
                    DateTime dataTemp = p.Data.AddDays(7 * i);
                    if (dataTemp.CompareTo(dataFine) < 0)
                        _prenotazioni.Add(new PrenotazioneSingola(p.IdPrenotazione, p.Cliente, p.Sala, dataTemp, p.OraInizio, p.OraFine));

                }
            }
        }

    }//end PrenotazionePeriodica
}