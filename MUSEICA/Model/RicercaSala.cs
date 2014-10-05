using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace MUSEICA.Model {
    public class RicercaSala : IRicercaProvider
    {
        private Sala _salaToFind;

        public RicercaSala(Sala salaToFind)
        {
            _salaToFind = salaToFind;
        }

        public List<Prenotazione> Ricerca(List<Prenotazione> prenotazioni)
        {
            List<Prenotazione> result = new List<Prenotazione>();
            foreach (Prenotazione p in prenotazioni)
            {
                if (_salaToFind.IdSala.ToLower().Equals(p.Sala.IdSala.ToLower()))
                    result.Add(p);
            }

            return result;
        }

    }
}