using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using NewMUSEICA.Controllers;
using NewMUSEICA.Model;

namespace NewMUSEICA.View
{
    public partial class MainView : Form
    {
        MainController _controller;
        private List<Prenotazione> _prenotazioniCercate;
        private PrenotazioneSingola _prenotazioneSingolaSelected;
        private PrenotazioneController _controllerPrenotazione=new PrenotazioneController();
        public MainView()
        {
            InitializeComponent();
            if (_controller == null)
                _controller = new MainController();
        }

       
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);            
            _controller.LoadCompenents();
            SetComboBoxCriterioRicerca();
        }

        private void SetComboBoxCriterioRicerca()
        {
            this._comboBoxCriterioRicerca.Items.Add("Cliente");
            this._comboBoxCriterioRicerca.Items.Add("Data");
            this._comboBoxCriterioRicerca.Items.Add("Sala");
            this._comboBoxCriterioRicerca.Items.Add("Tipo");

            this._labelParametro.Hide();
            this._textBoxNomeCognome.Hide();
            this._dateTimePickerRicerca.Hide();
        }

       
       

       

      

        private void gestioneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _controller.ChangeView("ProfiloView", null, null);
        }

        private void registraNuovoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ChangeView("ClienteView", null, "Aggiungi");
        }

        private void _comboBoxCriterioRicerca_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._labelParametro.Visible = true;

            switch (this._comboBoxCriterioRicerca.SelectedItem.ToString())
            {
                case "Cliente":
                    this._labelParametro.Text = "Nome e Cognome:";
                    this._dateTimePickerRicerca.Visible = false;
                    this._comboBoxSalaTipo.Visible = false;
                    this._textBoxNomeCognome.Visible = true;
                    break;
                case "Data":
                    this._labelParametro.Text = "Data:";
                    this._textBoxNomeCognome.Visible = false;
                    this._comboBoxSalaTipo.Visible = false;
                    this._dateTimePickerRicerca.Visible = true;
                    break;
                case "Sala":
                    this._labelParametro.Text = "Id Sala:";
                    this._comboBoxSalaTipo.Items.Clear();
                    foreach (Sala s in CentroSaleProve.GetIstance().Sale)
                        this._comboBoxSalaTipo.Items.Add(s.IdSala);
                    this._textBoxNomeCognome.Visible = false;
                    this._dateTimePickerRicerca.Visible = false;
                    this._comboBoxSalaTipo.Visible = true;
                    break;
                case "Tipo":
                    this._labelParametro.Text = "Nome Tipologia:";
                    this._comboBoxSalaTipo.Items.Clear();
                    foreach (ITipologiaSala t in TipologiaSalaFactory.GetTipologie())
                        this._comboBoxSalaTipo.Items.Add(t.NomeTipologia);
                    this._textBoxNomeCognome.Visible = false;
                    this._dateTimePickerRicerca.Visible = false;
                    this._comboBoxSalaTipo.Visible = true;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private void _buttonCerca_Click(object sender, EventArgs e)
        {

            if (_comboBoxCriterioRicerca.SelectedItem == null)
                MessageBox.Show("Inserire criterio ricerca ");
            else
            {
                List<Prenotazione> result = new List<Prenotazione>();
                switch (_comboBoxCriterioRicerca.SelectedItem.ToString())
                {
                    case "Cliente":
                        _prenotazioniCercate = _controller.RicercaPrenotazionePerCliente(_textBoxNomeCognome.Text);
                        break;
                    case "Data":
                        _prenotazioniCercate = _controller.RicercaPrenotazionePerData(_dateTimePickerRicerca.Value.ToUniversalTime());
                        break;
                    case "Sala":
                        if (_comboBoxSalaTipo.SelectedItem != null)
                            _prenotazioniCercate = _controller.RicercaPrenotazionePerIdSala(_comboBoxSalaTipo.SelectedItem.ToString());
                        break;
                    case "Tipo":
                        if (_comboBoxSalaTipo.SelectedItem != null)
                            _prenotazioniCercate = _controller.RicercaPrenotazionePerTipo(TipologiaSalaFactory.GetTipologia(_comboBoxSalaTipo.SelectedItem.ToString()));
                        break;
                    default:
                        throw new ArgumentException();
                }

                SetValueListBoxRisultati(_prenotazioniCercate);
            }
        }

        private void SetValueListBoxRisultati(List<Prenotazione> result)
        {
            string prenotazioneToShow = null;
            _listBoxRisultatiRicerca.Items.Clear();
            _labelRisultati.Text = String.Format("Risultati: {0} corrispondenze trovate", result.Count);
            if (result.Count == 0)
            {
                MessageBox.Show("Nessun Risultato Trovato");
            }

            else
            {
               
                foreach (Prenotazione p in result)
                {
                    PrenotazioneSingola temp = (PrenotazioneSingola)p;
                    prenotazioneToShow = String.Format("{0}- {1} - {2} ({3}:00/{4}:00) - {5} - {6} €", p.IdPrenotazione, p.Cliente.ToString(), p.Data.ToShortDateString(),
                        temp.OraInizio, temp.OraFine, temp.Sala.NomeSala, temp.GetTotale());
                    _listBoxRisultatiRicerca.Items.Add(prenotazioneToShow);
                }
            }
        }

        private void prenotazioneSingolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ChangeView("PrenotazioneSingolaView", null, "Aggiungi");
        }

        private void _buttonModifica_Click(object sender, EventArgs e)
        {
            if (_listBoxRisultatiRicerca.SelectedItem == null)
                MessageBox.Show("Selezionare una prenotazione singola prima di poterla modificare");
            else               
                _controller.ChangeView("PrenotazioneSingolaView", _listBoxRisultatiRicerca.SelectedItem.ToString(), "Modifica");
            
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_listBoxRisultatiRicerca.SelectedItem == null)
                MessageBox.Show("Selezionare una prenotazione singola prima di poterla modificare");
            else
                _controllerPrenotazione.DeletePrenotazione(_listBoxRisultatiRicerca.SelectedItem.ToString());
        }

        private void prenotazionePeriodicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ChangeView("PrenotazionePeriodicaView", null, "Aggiungi");
        }     
       
    }
}
