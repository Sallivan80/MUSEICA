

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{
    public class PoliticaCentro
    {

        private float _scontoClienteRegistrato;
        private float _scontoPrenotazionePeriodica;
        private int _preavvisoDisdetta;

        public PoliticaCentro(float scontoClienteRegistrato, float scontoPrenotazionePeriodica, int preavvisoDisdetta)
        {
            ScontoClienteRegistrato = scontoClienteRegistrato;
            ScontoPrenotazionePeriodica = scontoPrenotazionePeriodica;
            PreavvisoDisdetta = preavvisoDisdetta;
        }



        public float ScontoClienteRegistrato
        {
            get { return _scontoClienteRegistrato; }
            set { _scontoClienteRegistrato = value; }
        }

        public float ScontoPrenotazionePeriodica
        {
            get { return _scontoPrenotazionePeriodica; }
            set { _scontoPrenotazionePeriodica = value; }
        }

        public int PreavvisoDisdetta
        {
            get { return _preavvisoDisdetta; }
            set { _preavvisoDisdetta = value; }
        }

    }//end PoliticaCentro
}