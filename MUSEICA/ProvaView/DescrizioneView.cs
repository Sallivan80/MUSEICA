using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.Model;
using MUSEICA.Controllers;
using MUSEICA.Persistence;
using MUSEICA.Properties;

namespace MUSEICA.ProvaView
{
    public partial class DescrizioneView : Form
    {
        private string nomeTipologia;
        private PrenotazioneSingola _prenotazioneSingola;
        private string _operazione;

        public DescrizioneView(Object selectedItem,string operation)
        {
            InitializeComponent();
            _operazione = operation;
            
            SetValue(selectedItem);
        }

        private void SetValue(Object selectedItem)
        {
            if(_operazione=="DescrizioneSala")
            {
                this.nomeTipologia = (string)selectedItem;
                _buttonAggiungi.Visible = false;
                _buttonAnnulla.Visible = false;
                this.Text = "Sala " + nomeTipologia;
                this._descrizioneTipologia.Text = TipologiaSalaFactory.GetTipologia(nomeTipologia).Descrizione;
            }

            if (_operazione == "PrenotazioneSingola")
            {
                _prenotazioneSingola = (PrenotazioneSingola)selectedItem;
                _buttonAggiungi.Visible = true;
                _buttonAnnulla.Visible = true;
                this.Text = "Prenotazione Singola ";
                this._descrizioneTipologia.Text = String.Format("Id:{0} Sala:{1} inizio:{2} fine:{3} costo{4}",
                    _prenotazioneSingola.IdPrenotazione, _prenotazioneSingola.Sala.NomeSala, _prenotazioneSingola.OraInizio, _prenotazioneSingola.OraFine, _prenotazioneSingola.getCosto());
            }
               
        }
    }
}
