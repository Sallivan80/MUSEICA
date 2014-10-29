using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace NewMUSEICA.Model
{
    public class Sala
    {

        private string _idSala;
        private string _indirizzo;
        private string _nomeSala;
        private ITipologiaSala _tipoSala;
        private float _prezzo;



        public Sala(string idSala, string indirizzo, string nomeSala, ITipologiaSala tipoSala, float prezzo)
        {
            this._idSala = idSala;
            this._indirizzo = indirizzo;
            this._nomeSala = nomeSala;
            this._tipoSala = tipoSala;
            this._prezzo = prezzo;

        }
       

        public override string ToString()
        {
            return _nomeSala;
        }
        #region Property
        public string IdSala
        {
            get { return _idSala; }
            set { _idSala = value; }
        }

        public string NomeSala
        {
            get { return _nomeSala; }
            set { _nomeSala = value; }
        }

        public string Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; }
        }

        public ITipologiaSala Tipo
        {
            get { return _tipoSala; }
            set { _tipoSala = value; }
        }

        public float Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }
        #endregion

    }//end Sala
}