using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace NewMUSEICA.Model
{
    public abstract class Prenotazione
    {

        private Cliente _cliente;
        private Sala _sala;
        private DateTime _data;
        private string _idPrenotazione;
        protected float _totale;
        private string _note;


        #region Property
        public string IdPrenotazione
        {
            get { return _idPrenotazione; }
            set { _idPrenotazione = value; }
        }

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public Sala Sala
        {
            get { return _sala; }
            set { _sala = value; }

        }

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }

        }

      

        public float Totale
        {
            set { _totale = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }
        #endregion



        public abstract float GetTotale();

    }//end Prenotazione
}