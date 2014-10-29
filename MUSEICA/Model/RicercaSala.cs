using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace MUSEICA.Model {
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
                if (p.GetType() == typeof(PrenotazioneSingola))
                    if (_salaToFind.ToLower() == p.Sala.NomeSala.ToLower())
                        result.Add(p as PrenotazioneSingola);
                if (p.GetType() == typeof(PrenotazionePeriodica))
                    foreach (PrenotazioneSingola ps in (p as PrenotazionePeriodica).Prenotazioni)
                        if (_salaToFind.ToLower() == ps.Sala.IdSala.ToLower())
                            result.Add(ps);                  


            }
            return result;
        }

    }
}