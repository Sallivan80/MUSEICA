using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MUSEICA.Model
{
    public class Cliente
    {
        private  string _nome;
        private  string _cognome;
        private  string _telefono;
        private  string _indirizzo;

        public Cliente(string nome,string cognome,string telefono,string indirizzo)
        {
            this._nome = nome;
            this._cognome = cognome;
            this._telefono = telefono;
            this._indirizzo = indirizzo;
        }

        #region Property
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
            
        }

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
           
        }

        public string Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; }
            
        }
        #endregion

        public override string ToString()
        {

            return _nome + " " + _cognome;
        }
    }
}
