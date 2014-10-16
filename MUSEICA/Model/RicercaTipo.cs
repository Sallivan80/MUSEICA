using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{

    public class RicercaTipo : IRicercaProvider
    {
        private ITipologiaSala _iTipologiaSalaToFind;

        public RicercaTipo(ITipologiaSala iTipologiaSalaToFind)
        {
            _iTipologiaSalaToFind = iTipologiaSalaToFind;
        }

        public List<Prenotazione> Ricerca(List<Prenotazione> prenotazioni)
        {
            List<Prenotazione> result = new List<Prenotazione>();
            foreach (Prenotazione p in prenotazioni)
            {
                if (_iTipologiaSalaToFind.NomeTipologia == p.Sala.Tipo.NomeTipologia )
                    result.Add(p);
            }

            return result;
        }

    }
}