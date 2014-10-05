using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{
    public static class TipologiaSalaFactory
    {

        private static readonly Dictionary<string, ITipologiaSala> _flyweights = new Dictionary<string, ITipologiaSala>();



        public static ITipologiaSala GetTipologia(string nome_tipologia)
        {

            if (!_flyweights.ContainsKey(nome_tipologia))
                _flyweights.Add(nome_tipologia, CreateIstance(nome_tipologia));
            return _flyweights[nome_tipologia];
        }

        public static IEnumerable<ITipologiaSala> GetTipologie()
        {
            if (_flyweights.Values.Count > 0)
                return _flyweights.Values;
            else
                throw new InvalidOperationException("_flyweights.Values.Count > 0");
        }


        public static bool RimuoviTipologia(string nome)
        {

            if (_flyweights.ContainsKey(nome))
            {
                _flyweights.Remove(nome);
                return true;
            }
            else
                return false;
        }

        private static ITipologiaSala CreateIstance(string nome_tipologia)
        {

            switch (nome_tipologia)
            {
                case "Handrix":
                    return new TipologiaSala(nome_tipologia, "descrizione sconosciuta", 5.3F);
                case "Morrison":
                    return new TipologiaSala(nome_tipologia, "descrizione sconosciuta", 3.3F);
                case "Caparezza":
                    return new TipologiaSala(nome_tipologia, "descrizione sconosciuta", 4.0F);
                default:
                    throw new ArgumentException(nome_tipologia + " non consentita ");
            }
        }



        private class TipologiaSala : ITipologiaSala
        {
            private readonly string _nomeTipo;
            private readonly string _descrizione;
            private readonly float _prezzo;

            public TipologiaSala(string nomeTipo, string descrizione, float prezzo)
            {
                this._nomeTipo = nomeTipo;
                this._descrizione = descrizione;
                this._prezzo = prezzo;

            }
            public override string ToString()
            {
                return String.Format("[NomeTipologia:{0},Descrizione:{1},Prezzo:{2}", _nomeTipo, _descrizione, _prezzo);
            }

            #region Property
            public string NomeTipologia
            {
                get { return _nomeTipo; }

            }

            public string Descrizione
            {
                get { return _descrizione; }

            }

            public float Prezzo
            {
                get { return _prezzo; }

            }
            #endregion
        }//end TipologiaSala



    }//end TipologiaSalaFactory
}