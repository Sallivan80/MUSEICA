using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using NewMUSEICA.Model;

namespace NewMUSEICA.Persistence
{
    public interface IPrenotazionePersister
    {
        IPrenotazioneLoader GetLoader(string typeFileLoader);

        IPrenotazioneSaver GetSaver(string typeFileLoader);
        IPrenotazioneRemover GetRemover(string typeFileLoader);
    }

    public interface IPrenotazioneLoader
    {
        List<PrenotazioneSingola> LoadPrenotazioniSingole();
        List<PrenotazioneSingola> LoadPrenotazioniPeriodiche();

    }

    public interface IPrenotazioneSaver
    {
        void SaveUpdatePrenotazioneSingola(PrenotazioneSingola prenotazione);
        void SaveUpdatePrenotazionePeriodica(PrenotazionePeriodica prenotazione);

    }

    public interface IPrenotazioneRemover
    {
        void RemovePrenotazione(Prenotazione prenotazione);
    }
}
