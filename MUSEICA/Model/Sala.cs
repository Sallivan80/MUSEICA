using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{
    public class Sala
    {

        private readonly string _idSala;
        private readonly string _indirizzo;
        private readonly string _nomeSala;
        private readonly ITipologiaSala _tipoSala;


        public Sala(string idSala, string indirizzo, string nomeSala, ITipologiaSala tipoSala)
        {
            this._idSala = idSala;
            this._indirizzo = indirizzo;
            this._nomeSala = nomeSala;
            this._tipoSala = tipoSala;

        }

        #region Property
        public string IdSala
        {
            get { return _idSala; }
        }

        public string NomeSala
        {
            get { return _nomeSala; }
        }

        public string Indirizzo
        {
            get { return _indirizzo; }
        }

        public ITipologiaSala Tipo
        {
            get { return _tipoSala; }
        }
        #endregion

    }//end Sala
}