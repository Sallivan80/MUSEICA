using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MUSEICA.Model
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

        public List<Prenotazione> RicercaPrenotazioni(List<Prenotazione> _prenotazioniDaFiltrare)
        {
            return _iRicercaProvider.Ricerca(_prenotazioniDaFiltrare);
        }

        internal PrenotazioneSingola ModificaPrenotazioneSingola(PrenotazioneSingola prenotazioneSingola)
        {
            foreach (Prenotazione p in _prenotazioni)
            {
                if (p.IdPrenotazione==prenotazioneSingola.IdPrenotazione && p.GetType()==typeof(PrenotazioneSingola))
                {
                    (p as PrenotazioneSingola).DataInizio= prenotazioneSingola.DataInizio;
                    (p as PrenotazioneSingola).OraInizio = prenotazioneSingola.OraInizio;
                    (p as PrenotazioneSingola).OraFine = prenotazioneSingola.OraFine;
                    (p as PrenotazioneSingola).Totale = prenotazioneSingola.GetTotale();

                    return p as PrenotazioneSingola;
                }


            }
            return null;
        }

        internal PrenotazionePeriodica ModificaPrenotazionePeriodica(PrenotazioneSingola newPrenotazioneSingola,PrenotazioneSingola oldPrenotazioneSingola)
        {
            foreach (Prenotazione p in CentroSaleProve.GetIstance().Agenda.Prenotazioni)
                if (p.IdPrenotazione == oldPrenotazioneSingola.IdPrenotazione && p.GetType()==typeof(PrenotazionePeriodica))
                    foreach (PrenotazioneSingola ps in (p as PrenotazionePeriodica).Prenotazioni)
                        if (ps.DataInizio == oldPrenotazioneSingola.DataInizio)
                        {
                            ps.DataInizio = newPrenotazioneSingola.DataInizio;
                            ps.OraFine = newPrenotazioneSingola.OraFine;
                            ps.OraInizio = newPrenotazioneSingola.OraInizio;
                            return p as PrenotazionePeriodica;
                        }
            return null;
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
