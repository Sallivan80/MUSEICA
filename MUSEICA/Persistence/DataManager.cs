using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUSEICA.Model;

namespace MUSEICA.Persistence
{
    public class DataManager
    {
        private IClientePersister _clientePersister;
        private ISalaPersister _salaPersister;        
        private IPrenotazionePersister _prenotazionePersister;

        private List<Sala> _sale;
        private List<Cliente> _clienti;        
        private List<Prenotazione> _prenotazioni;


        public DataManager()
        {
            _clientePersister = new ClientePersister(@"../../Files/Clienti.xml");
            _salaPersister = new SalaPersister(@"../../Files/Sale.xml");           
            _prenotazionePersister = new PrenotazionePersister(@"../../Files/Prenotazioni.xml");
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

            _clienti = new List<Cliente>();
            foreach (ClienteRegistrato cr in _clientiRegistrati)
                _clienti.Add(cr);
            foreach (Cliente c in _clientiNormali)
                _clienti.Add(c);

            if (_clienti == null)
                return false;

            return true;
        }

        private bool ReadSale()
        {
            _sale = _salaPersister.GetLoader("XML").LoadSale();
            if (_sale == null)
                return false;
            return true;
        }

       

        private bool ReadPrenotazioni()
        {
            List<PrenotazioneSingola> _prenotazioniSingole = _prenotazionePersister.GetLoader("XML").LoadPrenotazioniSingole();
            List<PrenotazionePeriodica> _prenotazioniPeriodiche = _prenotazionePersister.GetLoader("XML").LoadPrenotazioniPeriodiche();
            if (_prenotazioniSingole == null || _prenotazioniPeriodiche == null)
                return false;

            _prenotazioni = new List<Prenotazione>();
            foreach (PrenotazioneSingola p in _prenotazioniSingole)
                _prenotazioni.Add(p);
            foreach (PrenotazionePeriodica pp in _prenotazioniPeriodiche)
                _prenotazioni.Add(pp);

            if (_prenotazioni == null)
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
        private bool SavePrenotazioni()
        {
            foreach (Prenotazione p in _prenotazioni)
            {
                if (p.GetType() == typeof(PrenotazioneSingola))
                    _prenotazionePersister.GetSaver("XML").SaveUpdatePrenotazioneSingola((PrenotazioneSingola)p);
                if (p.GetType() == typeof(PrenotazionePeriodica))
                    _prenotazionePersister.GetSaver("XML").SaveUpdatePrenotazionePeriodica((PrenotazionePeriodica)p);
                
            }

            return true;
        }

        private bool SaveSale()
        {
            foreach (Sala s in _sale)
                _salaPersister.GetSaver("XML").SaveUpdateSala(s);
            return true;
        }

        private bool SaveClienti()
        {
            foreach (Cliente p in _clienti)
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
        public List<Sala> Sale
        {
            get { return _sale; }
            set { _sale= value; }
        }
        public List<Prenotazione> Prenotazioni
        {
            get { return _prenotazioni; }
            set { _prenotazioni= value; }
        }

        public List<Cliente> Clienti
        {
            get { return _clienti; }
            set { _clienti= value; }
        }

       
        #endregion

    }
}
