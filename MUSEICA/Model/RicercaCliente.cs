using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace MUSEICA.Model
{
    public class RicercaCliente : IRicercaProvider
    {

        private Cliente _clienteToFind;

        public RicercaCliente(Cliente clienteToFind)
        {
            _clienteToFind = clienteToFind;
        }

        public List<Prenotazione> Ricerca(List<Prenotazione> prenotazioni)
        {
            List<Prenotazione> result = new List<Prenotazione>();
            foreach (Prenotazione p in prenotazioni)
            {
                
                if (_clienteToFind.Cognome.ToLower()==p.Cliente.Cognome.ToLower()  && 
                    _clienteToFind.Nome.ToLower()== p.Cliente.Nome.ToLower()  )
                    result.Add(p);
            }

            return result;
        }

    }
}