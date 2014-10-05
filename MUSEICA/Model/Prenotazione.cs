using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace MUSEICA.Model
{
    public abstract class Prenotazione
    {

        private  Cliente _cliente;
        private  Sala _sala;
        private  DateTime _data;
        private  string _idPrenotazione;

       
        #region Property
        public string IdPrenotazione
        {
            get { return _idPrenotazione; }
            set { _idPrenotazione = value; }
        }

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente=value;  }
        }

        public Sala Sala
        {
            get { return _sala; }
            set { _sala= value; }

        }

        public DateTime Data
        {
            get { return _data; }
            set { _data= value; }

        }
        #endregion



        public abstract float getCosto();

    }//end Prenotazione
}