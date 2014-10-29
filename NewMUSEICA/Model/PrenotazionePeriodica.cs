using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace NewMUSEICA.Model
{
    public class PrenotazionePeriodica : Prenotazione
    {

        private List<PrenotazioneSingola> _prenotazioni = new List<PrenotazioneSingola>();
        private DateTime _dataFine;
        


        public PrenotazionePeriodica(List<PrenotazioneSingola> prenotazioniRichieste, DateTime dataFine)
        {
            
            CreaPrenotazionePeriodica(prenotazioniRichieste, dataFine);
            
            
        }

        public DateTime DataFine
        {
            get { return _dataFine; }
            set { _dataFine = value; }
        }

        public List<PrenotazioneSingola> Prenotazioni
        {
            get { return _prenotazioni; }
            set { _prenotazioni = value; }
        }

        public override float GetTotale()
        {

            float totalePrenotazionePeriodica = 0;
            foreach (PrenotazioneSingola p in _prenotazioni)
                totalePrenotazionePeriodica += p.GetTotale();
            this.Totale = totalePrenotazionePeriodica;
            return _totale;
        }


        private void CreaPrenotazionePeriodica(List<PrenotazioneSingola> prenotazioniRichieste, DateTime dataFine)
        {
            this.Cliente = prenotazioniRichieste[0].Cliente;
            this.Sala = prenotazioniRichieste[0].Sala;
            this.IdPrenotazione = prenotazioniRichieste[0].IdPrenotazione;
            this.DataFine = dataFine;

            foreach (PrenotazioneSingola p in prenotazioniRichieste)
            {
                for (int i = 0; i < dataFine.DayOfYear - p.Data.DayOfYear; i++)
                {
                    DateTime dataTemp = p.Data.AddDays(7 * i);
                    if (dataTemp.CompareTo(dataFine) < 0)
                    {
                        PrenotazioneSingola newPrenotazioneSingola = new PrenotazioneSingola(p.IdPrenotazione, p.Cliente, p.Sala, dataTemp, p.OraInizio, p.OraFine,p.Note);
                        _prenotazioni.Add(newPrenotazioneSingola);
                    }
                    else
                         break;
                }
                
            }
        }
           
                

    }//end PrenotazionePeriodica
}