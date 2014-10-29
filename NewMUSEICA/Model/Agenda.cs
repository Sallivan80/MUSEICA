using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewMUSEICA.Model
{
    public class Agenda
    {
        private List<Prenotazione> _prenotazioni;
        private IRicercaProvider _iRicercaProvider;

        public Agenda(List<Prenotazione> prenotazioni) 
        {
            Prenotazioni = prenotazioni;
        }

        public bool AggiungiPrenotazione(Prenotazione prenotazione)
        {
            if (!_prenotazioni.Contains(prenotazione))
            {
                _prenotazioni.Add(prenotazione);
                return true;
            }
            return false;
        }
   
        public bool RimuoviPrenotazione(Prenotazione prenotazione)
        {
            if (_prenotazioni.Contains(prenotazione))
            {
                _prenotazioni.Remove(prenotazione);
                return true;
            }
            return false;
        }

        public List<Prenotazione> RicercaPrenotazioni()
        {
            return _iRicercaProvider.Ricerca(_prenotazioni);
        }

        internal void ModificaPrenotazioneSingola(PrenotazioneSingola prenotazioneSingola)
        {
            foreach (PrenotazioneSingola p in _prenotazioni)
            {
                if (p.IdPrenotazione==prenotazioneSingola.IdPrenotazione)
                {
                    p.Data= prenotazioneSingola.Data;
                    p.OraInizio = prenotazioneSingola.OraInizio;
                    p.OraFine = prenotazioneSingola.OraFine;
                    p.Totale = prenotazioneSingola.GetTotale();
                }


            }
        }

        #region Property

        public List<Prenotazione> Prenotazioni 
        {
            get { return _prenotazioni; }
            set { _prenotazioni = value; }
        }

        public IRicercaProvider IRicercaProvider
          {
              get {
                  if (_iRicercaProvider == null)
                      throw new InvalidOperationException("_iRicercaProvider == null");
                  return _iRicercaProvider; }
              set { _iRicercaProvider = value; }
          }

        #endregion


       
    }
}
