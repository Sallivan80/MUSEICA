using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{
    public class PrenotazioneSingola : Prenotazione
    {

        private int _oraInizio;
        private int _oraFine;

        public PrenotazioneSingola(string idPrenotazione,Cliente cliente,Sala sala,DateTime data,int oraInizio,int oraFine)           
        {
            this.IdPrenotazione = idPrenotazione;
            this.Cliente = cliente;
            this.Sala = sala;
            this.Data = data;
            OraInizio = oraInizio;
            OraFine = oraFine;
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

        public override float getCosto()
        {

            return Sala.Tipo.Prezzo;
        }

    }//end PrenotazioneSingola
}