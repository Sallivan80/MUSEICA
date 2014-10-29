using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace NewMUSEICA.Model
{
    public class PrenotazioneSingola : Prenotazione
    {

        private int _oraInizio;
        private int _oraFine;

        public PrenotazioneSingola( string idPrenotazione,Cliente cliente, Sala sala, DateTime data, int oraInizio, int oraFine,string note)
        {
            
            this.IdPrenotazione = idPrenotazione;
            this.Cliente = cliente;
            this.Sala = sala;
            this.Data = data;
            OraInizio = oraInizio;
            OraFine = oraFine;
            this._totale = sala.Prezzo * (_oraFine - _oraInizio);
            this.Note = note;
        }

        #region Property
        public int OraInizio
        {
            get { return _oraInizio; }
            set { _oraInizio = value; }
        }

        public int OraFine
        {
            get { return _oraFine; }
            set { _oraFine = value; }
        }


        #endregion

        public override float GetTotale()
        {
            return _totale;        
        }

    }//end PrenotazioneSingola
}