using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{
    public class CentroSaleProve
    {

        private List<Cliente> _clienti;
        private List<Sala> _sale;
        private static CentroSaleProve _istance;
        private Profilo _profilo;
        private PoliticaCentro _politica;
        private Agenda _agenda;


        private CentroSaleProve(List<Cliente> clienti, List<Sala> sale, Profilo profilo, PoliticaCentro politica, Agenda agenda)
        {
            Clienti = clienti;
            Sale = sale;
            Profilo = profilo;
            Politica = politica;
            Agenda = agenda;
        }

        public static CentroSaleProve GetIstance()
        {

            if (_istance == null)
                _istance= new CentroSaleProve(new List<Cliente>(), new List<Sala>(), 
                    new Profilo("Museica", "Viale Risorgimento", "0517893456", "museicaAffitti@gmail.com"),
                    new PoliticaCentro(0.05F,0.15F,2), new Agenda(new List<Prenotazione>()));
            return _istance;
        }

       
        public bool AggiungiCliente(Cliente cliente)
        {

            if (!_clienti.Contains(cliente))
            {
                _clienti.Add(cliente);
                return true;
            }
            return false;
        }

       
        public bool RimuoviCliente(Cliente cliente)
        {


            if (_clienti.Contains(cliente))
            {
                _clienti.Remove(cliente);
                return true;
            }
            return false;
        }

        
        public bool AggiungiSala(Sala sala)
        {


            if (!_sale.Contains(sala))
            {
                _sale.Add(sala);
                return true;
            }
            return false;
        }

       
        public bool RimuoviSala(Sala sala)
        {
            if (_sale.Contains(sala))
            {
                _sale.Remove(sala);
                return true;
            }
            return false;
        }

        public Cliente RimuoviClienteRegistrato(ClienteRegistrato clienteRegistrato)
        {

            foreach (Cliente c in _clienti)
                if (c.Nome == clienteRegistrato.Nome
                    && c.Cognome == clienteRegistrato.Cognome
                    && c.GetType() == typeof(ClienteRegistrato))
                {
                    _clienti.Remove(c);
                    break;
                }
            return null;
        }
        #region Property
        public List<Cliente> Clienti
        {
            get { return _clienti; }
            set { _clienti = value; }
        }

        public List<Sala> Sale
        {
            get { return _sale; }
            set { _sale = value; }
        }     

        public Profilo Profilo
        {
            get { return _profilo; }
            set { _profilo = value; }
        }

        public PoliticaCentro Politica
        {
            get { return _politica; }
            set { _politica = value; }
        }

        public Agenda Agenda
        {
            get { return _agenda; }
            set { _agenda = value; }
        }
        #endregion

    }//end CentroSaleProve
}