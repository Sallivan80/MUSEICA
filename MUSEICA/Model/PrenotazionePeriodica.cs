using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{
    public class PrenotazionePeriodica : Prenotazione
    {

        private List<PrenotazioneSingola> _prenotazioni = null;
        private DateTime _dataFine;
        


        public PrenotazionePeriodica(string idPrenotazione,Cliente cliente, Sala sala, DateTime dataInizio, DateTime dataFine, List<PrenotazioneSingola> prenotazioniRichieste)
        {

            this.IdPrenotazione = idPrenotazione;
            this.Cliente = cliente;
            this.Sala = sala;
            this.DataInizio = dataInizio;
            this.DataFine = dataFine;
            _prenotazioni = prenotazioniRichieste;
            
            
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


      
           
                

    }//end PrenotazionePeriodica
}