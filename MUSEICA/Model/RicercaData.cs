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
                if (_dataToFind.DayOfYear == p.Data.DayOfYear)
                    result.Add(p);
            }

            return result;
        }

    }
}