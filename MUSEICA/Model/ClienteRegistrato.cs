using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEICA.Model
{
    public class ClienteRegistrato : Cliente
    {
        private readonly string _idTessera;
        private readonly DateTime _scadenzaTessera;

        public ClienteRegistrato(string nome,string cognome,string telefono,string indirizzo,string idTessera,DateTime scadenzaTessera)
            : base(nome,cognome,telefono,indirizzo)
        {
            this._idTessera = idTessera;
            this._scadenzaTessera = scadenzaTessera;

        }

      

        public string IdTessera
        {
            get { return _idTessera; }
           
        }

        public DateTime ScadenzaTessera
        {
            get { return _scadenzaTessera; }
            
        }

        public override string ToString()
        {

            return String.Format("[IDTessera:{0},Scadenza:{1},Nome:{2},Cognome:{3},Telefono:{4},Indirizzo:{5}]",
                IdTessera, ScadenzaTessera, Nome, Cognome, Telefono, Indirizzo);
        }
    }
}
