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
        private readonly string _nome;
        private readonly string _cognome;
        private readonly string _telefono;
        private readonly string _indirizzo;

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
            
        }

        public string Cognome
        {
            get { return _cognome; }
            
        }

        public string Telefono
        {
            get { return _telefono; }
           
        }

        public string Indirizzo
        {
            get { return _indirizzo; }
            
        }
        #endregion

        public override string ToString()
        {

            return String.Format("[Nome:{0},Cognome:{1},Telefono:{2},Indirizzo:{3}]",
                 Nome, Cognome, Telefono, Indirizzo);
        }
    }
}
