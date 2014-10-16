using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{
    public abstract class Aggiunta : Prenotazione
    {

        private readonly Prenotazione _prenotazione;
        protected float _costoAggiunta;
        

        protected Aggiunta(Prenotazione prenotazione)            
        {
            if (prenotazione == null)
                throw new ArgumentNullException("prenotazione");
            this._prenotazione=prenotazione;
            
        }



        public override float getCosto()
        {
            return _costoAggiunta + this._prenotazione.getCosto();
        }

       


    }//end Aggiunta

    public class Chitarra : Aggiunta
    {

        public Chitarra(Prenotazione prenotazione)
            : base(prenotazione)
        {
            this._costoAggiunta = 5.0F;
        }

    }

    public class Basso : Aggiunta
    {


        public Basso(Prenotazione prenotazione)
            : base(prenotazione)
        {
            this._costoAggiunta = 6.0F;
        }

    }
}