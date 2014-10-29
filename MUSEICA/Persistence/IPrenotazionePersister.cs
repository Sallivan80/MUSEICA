using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using MUSEICA.Model;

namespace MUSEICA.Persistence
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
        List<PrenotazionePeriodica> LoadPrenotazioniPeriodiche();

    }

    public interface IPrenotazioneSaver
    {
        void SavePrenotazioneSingola(PrenotazioneSingola prenotazione);
       /* void UpdatePrenotazioneSingola(PrenotazioneSingola prenotazione);*/
        void SavePrenotazionePeriodica(PrenotazionePeriodica prenotazione);
       // void UpdatePrenotazionePeriodica(PrenotazionePeriodica prenotazione);
            

    }

    public interface IPrenotazioneRemover
    {
        void RemovePrenotazione(Prenotazione prenotazione);
    }
}
