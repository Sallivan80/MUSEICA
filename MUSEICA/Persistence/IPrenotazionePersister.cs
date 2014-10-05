using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUSEICA.Model;

namespace MUSEICA.Persistence
{
    public interface IPrenotazionePersister
    {
        IPrenotazioneLoader GetLoader(string typeFileLoader);

        IPrenotazioneSaver GetSaver(string typeFileLoader);
    }

    public interface IPrenotazioneLoader
    {
        List<PrenotazioneSingola> LoadPrenotazioniSingole();
        List<PrenotazionePeriodica> LoadPrenotazioniPeriodiche();

    }

    public interface IPrenotazioneSaver
    {
        void SaveUpdatePrenotazioneSingola(PrenotazioneSingola prenotazione);
        void SaveUpdatePrenotazionePeriodica(PrenotazionePeriodica prenotazione);

    }
}
