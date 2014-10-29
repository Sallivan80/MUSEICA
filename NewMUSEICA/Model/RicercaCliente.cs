using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace NewMUSEICA.Model
{
    public class RicercaCliente : IRicercaProvider
    {

        private string _nome;
        private string _cognome;

        public RicercaCliente(string nome,string cognome)
        {
            _nome = nome;
            _cognome = cognome;
        }

        public List<Prenotazione> Ricerca(List<Prenotazione> prenotazioni)
        {
            List<Prenotazione> result = new List<Prenotazione>();
            foreach (Prenotazione p in prenotazioni)
            {
                
                if (_cognome.ToLower()==p.Cliente.Cognome.ToLower()  && 
                    _nome.ToLower()== p.Cliente.Nome.ToLower()  )
                    result.Add(p);
            }

            return result;
        }

    }
}