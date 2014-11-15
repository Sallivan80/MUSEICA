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

namespace MUSEICA.View
{
    public partial class PrenotazionePeriodicaView : Form
    {
        private string _idPrenotazione;
        private ClienteRegistrato _selectedClienteRegistrato;
        private Sala _selectedSala;
        private PrenotazionePeriodicaController _controllerPrenotazione = new PrenotazionePeriodicaController();
        private List<PrenotazioneSingola> _prenotazioniSingole = new List<PrenotazioneSingola>();
        public PrenotazionePeriodicaView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Text = "Aggiungi Nuova Prenotazione Periodica";
            _buttonOK.Text = "Aggiungi";
            _textBoxNomeCliente.Enabled = false;
            _textBoxCognomeCliente.Enabled = false;
            _textBoxIndirizzoCliente.Enabled = false;
            _textBoxTelefono.Enabled = false;
            AggiungiModeComponents();


        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            _listBoxGiorniAggiunti.Items.Clear();
            foreach (PrenotazioneSingola ps in _prenotazioniSingole)
                _listBoxGiorniAggiunti.Items.Add(ps.DataInizio.DayOfWeek.ToString());
        }


        #region LoadView
        private void AggiungiModeComponents()
        {
            Random rnd = new Random();
            _idPrenotazione = "P000" + (rnd.Next(0, 1000000000));
            LoadComboBoxIdTessera();
            LoadComboBoxSale();
        }

        private void LoadComboBoxIdTessera()
        {
            List<ClienteRegistrato> orderedList = new List<ClienteRegistrato>(); ;

            foreach (ClienteRegistrato cliente in CentroSaleProve.GetIstance().Clienti)
                orderedList.Add(cliente);

            orderedList.OrderBy(cliente => cliente.IdTessera);
            foreach (ClienteRegistrato cliente in orderedList)
                _comboBoxIdTessera.Items.Add(cliente.IdTessera);

        }

        private void LoadComboBoxSale()
        {
            foreach (Sala s in CentroSaleProve.GetIstance().Sale)
                _comboBoxSala.Items.Add(s.NomeSala);
        }

        private void _comboBoxIdTessera_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _selectedClienteRegistrato = _controllerPrenotazione.FindClienteRegistratoByIdTessera(_comboBoxIdTessera.SelectedItem.ToString());
            LoadTextBoxCliente(_selectedClienteRegistrato);
        }
        private void LoadTextBoxCliente(ClienteRegistrato clienteRegistratoSelected)
        {
            _textBoxNomeCliente.Text = clienteRegistratoSelected.Nome;
            _textBoxCognomeCliente.Text = clienteRegistratoSelected.Cognome;
            _textBoxIndirizzoCliente.Text = clienteRegistratoSelected.Indirizzo;
            _textBoxTelefono.Text = clienteRegistratoSelected.Telefono;


            _textBoxNomeCliente.Enabled = false;
            _textBoxCognomeCliente.Enabled = false;
            _textBoxIndirizzoCliente.Enabled = false;
            _textBoxTelefono.Enabled = false;

        }

        private void _comboBoxSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Sala sala in CentroSaleProve.GetIstance().Sale)
                if (sala.NomeSala == _comboBoxSala.SelectedItem.ToString())
                {
                    _textBoxTipoSala.Text = sala.Tipo.NomeTipologia;
                    _selectedSala = sala;
                }
        }
        #endregion

        private void _buttonAggiungiGiorno_Click(object sender, EventArgs e)
        {
            if (_selectedClienteRegistrato != null || _selectedSala != null || _comboBoxIdTessera.Text != "" || _comboBoxSala.Text != "")
            {
                _controllerPrenotazione.ShowAggiungiGiornoView(_idPrenotazione, _selectedClienteRegistrato, _selectedSala, _prenotazioniSingole);

            }
            else
                MessageBox.Show("Compilare prima i dati su Sala e Cliente");
        }

        private void _buttonRimuoviGiorno_Click(object sender, EventArgs e)
        {
            if (_listBoxGiorniAggiunti.Items.Count == 0 || _listBoxGiorniAggiunti.SelectedItem == null)
                MessageBox.Show("Selezionare un giorno");
            else
                foreach (PrenotazioneSingola ps in _prenotazioniSingole)
                    if (ps.DataInizio.DayOfWeek.ToString() == _listBoxGiorniAggiunti.SelectedItem.ToString())
                    {
                        _prenotazioniSingole.Remove(ps);
                        this.OnActivated(new EventArgs());
                        break;
                    }
        }

        private void _buttonOK_Click(object sender, EventArgs e)
        {
            if (CheckParameters())
            {
                DateTime dataFine = _dateTimePickerFinePeriodo.Value;
                PrenotazionePeriodica prenotazionePeriodica = new PrenotazionePeriodica(_idPrenotazione, _selectedClienteRegistrato, _selectedSala, _dateTimePickerInizioPeriodo.Value, _dateTimePickerFinePeriodo.Value, new List<PrenotazioneSingola>());
                _controllerPrenotazione.AggiungiPrenotazionePeriodica(prenotazionePeriodica,_prenotazioniSingole);
            }

            this.Close();
        }

        private bool CheckParameters()
        {
            if (_prenotazioniSingole.Count == 0)
                return false;
            return true;
        }

        private void _buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

        


    }
}
