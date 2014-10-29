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
                if (p.GetType() == typeof(PrenotazioneSingola))
                    if (_iTipologiaSalaToFind.NomeTipologia == p.Sala.Tipo.NomeTipologia)
                        result.Add(p as PrenotazioneSingola);
                if (p.GetType() == typeof(PrenotazionePeriodica))
                    foreach (PrenotazioneSingola ps in (p as PrenotazionePeriodica).Prenotazioni)
                        if (_iTipologiaSalaToFind.NomeTipologia == ps.Sala.Tipo.NomeTipologia)
                            result.Add(ps);        
                

            }
            return result;
        }

    }
}