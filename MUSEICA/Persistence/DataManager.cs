using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUSEICA.Model;
using MUSEICA.Persistence;

namespace MUSEICA.Persistence
{
    public class DataManager
    {
        private IClientePersister _clientePersister;
        private ISalaPersister _salaPersister;        
        private IPrenotazionePersister _prenotazionePersister;

    
           
       


        public DataManager()
        {
            _clientePersister = new ClientePersister(@"../../Files/Clienti.xml");
            _salaPersister = new SalaPersister(@"../../Files/Sale.xml");           
            _prenotazionePersister = new PrenotazionePersister(@"../../Files/Prenotazioni.xml");
        }

        public void DeleteCliente(ClienteRegistrato c)
        {
            _clientePersister.GetRemover("XML").RemoveClienteRegistrato(c);           
        }

        internal void DeleteSala(Sala s)
        {
            _salaPersister.GetRemover("XML").RemoveSala(s);
        }
        public bool ReadAll()
        {

            if (ReadClienti() && ReadPrenotazioni() &&   ReadSale())
                return true;
         
            return false;
        }

        #region ReadMethod
        private bool ReadClienti()
        {
            List<Cliente> _clientiNormali = _clientePersister.GetLoader("XML").LoadClienti();
            List<ClienteRegistrato> _clientiRegistrati = _clientePersister.GetLoader("XML").LoadClientiRegistrati();

            if (_clientiNormali == null || _clientiRegistrati == null)
                return false;

           
            foreach (ClienteRegistrato cr in _clientiRegistrati)
                CentroSaleProve.GetIstance().Clienti.Add(cr);
            foreach (Cliente c in _clientiNormali)
                CentroSaleProve.GetIstance().Clienti.Add(c);

            if (CentroSaleProve.GetIstance().Clienti == null)
                return false;

            return true;
        }

        private bool ReadSale()
        {
            CentroSaleProve.GetIstance().Sale = _salaPersister.GetLoader("XML").LoadSale();
            if (CentroSaleProve.GetIstance().Sale == null)
                return false;
            return true;
        }

       

        private bool ReadPrenotazioni()
        {
            List<PrenotazioneSingola> _prenotazioniSingole = _prenotazionePersister.GetLoader("XML").LoadPrenotazioniSingole();
            List<PrenotazionePeriodica> _prenotazioniPeriodiche = _prenotazionePersister.GetLoader("XML").LoadPrenotazioniPeriodiche();
            if (_prenotazioniSingole == null || _prenotazioniPeriodiche == null)
                return false;

           
            foreach (PrenotazioneSingola p in _prenotazioniSingole)
                CentroSaleProve.GetIstance().Agenda.AggiungiPrenotazione(p);
            foreach (PrenotazionePeriodica pp in _prenotazioniPeriodiche)
                CentroSaleProve.GetIstance().Agenda.AggiungiPrenotazione(pp);

            if (CentroSaleProve.GetIstance().Agenda.Prenotazioni == null)
                return false;

            return true;
        }
        #endregion


        public bool SaveAll()
        {
            if (SavePrenotazioni() && SaveSale() &&  SaveClienti())
                return true;
            return false;
        }

        #region SaveMethod
        public bool SavePrenotazioni()
        {
            foreach (Prenotazione p in CentroSaleProve.GetIstance().Agenda.Prenotazioni)
            {
                if (p.GetType() == typeof(PrenotazioneSingola))
                    _prenotazionePersister.GetSaver("XML").SaveUpdatePrenotazioneSingola((PrenotazioneSingola)p);
                if (p.GetType() == typeof(PrenotazionePeriodica))
                    _prenotazionePersister.GetSaver("XML").SaveUpdatePrenotazionePeriodica((PrenotazionePeriodica)p);
                
            }

            return true;
        }

        public bool SaveSale()
        {
            foreach (Sala s in CentroSaleProve.GetIstance().Sale)
                _salaPersister.GetSaver("XML").SaveUpdateSala(s);
            return true;
        }

        public bool SaveClienti()
        {
            foreach (Cliente p in CentroSaleProve.GetIstance().Clienti)
            {
                if (p.GetType() == typeof(ClienteRegistrato))
                    _clientePersister.GetSaver("XML").SaveUpdateClienteRegistrato((ClienteRegistrato)p);
                if (p.GetType() == typeof(Cliente))
                    _clientePersister.GetSaver("XML").SaveUpdateCliente(p);
            }

            return true;
        }

       
        #endregion

        #region Property
        

       
        #endregion


       
    }
}
