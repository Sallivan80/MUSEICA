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

        private string _idPrenotazione;
        private Cliente _cliente;
        private Sala _sala;
        private DateTime _dataInizio;        
        protected float _totale;
        


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

        public DateTime DataInizio
        {
            get { return _dataInizio; }
            set { _dataInizio = value; }

        }

      

        public float Totale
        {
            get { return _totale; }
            set { _totale = value; }
        }
       
        #endregion



        public abstract float GetTotale();

    }//end Prenotazione
}