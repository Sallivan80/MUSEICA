using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{
    public class Profilo
    {

        private string _nomeCentro;
        private string _indirizzo;
        private string _telefono;
        private string _email;

        public Profilo(string nomeCentro, string indirizzo, string telefono, string email)
        {
            NomeCentro = nomeCentro;
            Indirizzo = indirizzo;
            Telefono = telefono;
            Email = email;
        }



        public string NomeCentro
        {
            get { return _nomeCentro; }
            set { _nomeCentro = value; }
        }

        public string Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }//end Profilo
}