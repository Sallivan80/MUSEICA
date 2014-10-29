using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace MUSEICA.Model {
    public class RicercaData : IRicercaProvider
    {
        private DateTime _dataToFind;

        public RicercaData(DateTime dataToFind)
        {
            _dataToFind = dataToFind;
        }

        public List<Prenotazione> Ricerca(List<Prenotazione> prenotazioni)
        {
            List<Prenotazione> result = new List<Prenotazione>();            
            foreach (Prenotazione p in prenotazioni)
            {
                if (p.GetType() == typeof(PrenotazioneSingola))
                    if (_dataToFind.DayOfYear == p.DataInizio.DayOfYear)
                        result.Add(p as PrenotazioneSingola);
                if (p.GetType() == typeof(PrenotazionePeriodica))
                    foreach(PrenotazioneSingola ps in (p as PrenotazionePeriodica).Prenotazioni)
                      if (_dataToFind.DayOfYear == ps.DataInizio.DayOfYear)
                            result.Add(ps);


            }

            return result;
        }

    }
}