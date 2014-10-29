using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace NewMUSEICA.Model {
    public class RicercaSala : IRicercaProvider
    {
        private string _salaToFind;

        public RicercaSala(string salaToFind)
        {
            _salaToFind = salaToFind;
        }

        public List<Prenotazione> Ricerca(List<Prenotazione> prenotazioni)
        {
            List<Prenotazione> result = new List<Prenotazione>();
            foreach (Prenotazione p in prenotazioni)
            {
                if (_salaToFind.ToLower()==p.Sala.IdSala.ToLower())
                    result.Add(p);
            }

            return result;
        }

    }
}