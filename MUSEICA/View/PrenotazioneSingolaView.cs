using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.Controllers;
using MUSEICA.Model;

namespace MUSEICA.View
{
    public partial class PrenotazioneSingolaView : Form
    {
        private PrenotazioneSingolaController _controllerPrenotazioneSingola;
        private PrenotazionePeriodicaController _controllerPrenotazionePeriodica;
        private string _operazione;
        private string _idPrenotazione;
        private ClienteRegistrato _selectedClienteRegistrato;
        private Sala _selectedSala;
        private PrenotazioneSingola _selectedPrenotazione;
        

        public PrenotazioneSingolaView(Object selectedItem, string operazione)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            _idPrenotazione = selectedItem as string;
            this._operazione = operazione;
            if(_controllerPrenotazioneSingola==null)
                _controllerPrenotazioneSingola = new PrenotazioneSingolaController();
            if(_controllerPrenotazionePeriodica==null)
                _controllerPrenotazionePeriodica = new PrenotazionePeriodicaController();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            switch (_operazione)
            {
                case "Aggiungi":
                    this.Text = "Aggiungi Nuova Prenotazione Singola";
                    _buttonOK.Text = "Aggiungi";
                    AggiungiModeComponents();
                    break;
                case "Modifica":
                    this.Text = "Modifica Prenotazione";
                    _buttonOK.Text = "Modifica";
                    ModificaModeComponents();
                    break;

            }
        }
       
        private void ModificaModeComponents()
        {
            _selectedPrenotazione = _controllerPrenotazioneSingola.FindPrenotazioneSingolaById(_idPrenotazione);            
            _idPrenotazione = _selectedPrenotazione.IdPrenotazione;
            SetValueModificaMode(_selectedPrenotazione);
        }

        private void SetValueModificaMode(PrenotazioneSingola selectedPrenotazione)
        {
            _comboBoxIdTessera.Enabled = false;
            SetValueClienteModificaMode(selectedPrenotazione);
            SetValueSalaModificaMode(selectedPrenotazione.Sala);           
            SetValueDataOreModificaMode(selectedPrenotazione.DataInizio,selectedPrenotazione.OraInizio,selectedPrenotazione.OraFine);
           
        }

        private void SetValueClienteModificaMode(PrenotazioneSingola selectedPrenotazione)
        {
            if (selectedPrenotazione.Cliente.GetType() == typeof(ClienteRegistrato))
                SetValueClienteRegistratoModificaMode(selectedPrenotazione.Cliente as ClienteRegistrato);
            _textBoxNomeCliente.Text = selectedPrenotazione.Cliente.Nome;
            _textBoxCognomeCliente.Text = selectedPrenotazione.Cliente.Cognome;
            _textBoxIndirizzoCliente.Text = selectedPrenotazione.Cliente.Indirizzo;
            _textBoxTelefono.Text = selectedPrenotazione.Cliente.Telefono;
        }

        private void SetValueClienteRegistratoModificaMode(ClienteRegistrato clienteRegistrato)
        {
            _selectedClienteRegistrato = clienteRegistrato;
            _comboBoxIdTessera.Text = clienteRegistrato.IdTessera;
            
            _checkBoxClienteRegistrato.Checked = true;
        }

        private void SetValueSalaModificaMode(Sala sala)
        {
            _comboBoxSala.SelectedText = sala.NomeSala;
            _comboBoxSala.Enabled = false;
            _textBoxTipoSala.Text = sala.Tipo.NomeTipologia;
            _selectedSala = sala;
        }

        private void SetValueDataOreModificaMode(DateTime data,int oraInizio,int oraFine)
        {
            _dateTimePickerDataPrenotazione.Value = data;
            _numericUpDownOraFine.Value = Convert.ToDecimal(oraFine);
            _numericUpDownOraInizio.Value=Convert.ToDecimal(oraInizio);
        }

        private void AggiungiModeComponents()
        {
            Random rnd = new Random();
            _idPrenotazione = "S000" + (rnd.Next(0, 1000000000));
            LoadComboBoxIdTessera();
            LoadComboBoxSale();
        }

        private void LoadComboBoxSale()
        {
            foreach (Sala s in CentroSaleProve.GetIstance().Sale)
                _comboBoxSala.Items.Add(s.NomeSala);
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

        private void _checkBoxClienteRegistrato_CheckedChanged(object sender, EventArgs e)
        {
            
                _comboBoxIdTessera.Enabled = !_comboBoxIdTessera.Enabled;
                _textBoxNomeCliente.Enabled = !_textBoxNomeCliente.Enabled;
                _textBoxCognomeCliente.Enabled = !_textBoxCognomeCliente.Enabled;
                _textBoxIndirizzoCliente.Enabled = !_textBoxIndirizzoCliente.Enabled;
                _textBoxTelefono.Enabled = !_textBoxTelefono.Enabled;
            
           
        }

        private void _comboBoxIdTessera_SelectedIndexChanged(object sender, EventArgs e)
        {
           _selectedClienteRegistrato=_controllerPrenotazioneSingola.FindClienteRegistratoByIdTessera(_comboBoxIdTessera.SelectedItem.ToString());
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

        private void _buttonOK_Click(object sender, EventArgs e)
        {
            
            if (CheckParameters())
            {
                int oraInizio = Convert.ToInt32(_numericUpDownOraInizio.Value);
                int oraFine = Convert.ToInt32(_numericUpDownOraFine.Value);
                Cliente cliente = BuildCliente();
                PrenotazioneSingola newPrenotazioneSingola = new PrenotazioneSingola(_idPrenotazione, cliente, _selectedSala, _dateTimePickerDataPrenotazione.Value, oraInizio, oraFine);
                if (_idPrenotazione.StartsWith("S"))
                    AggiungiModificaPrenotazioneSingola(newPrenotazioneSingola);
                else if (_idPrenotazione.StartsWith("P"))
                    ModificaPrenotazionePeriodica(newPrenotazioneSingola,_selectedPrenotazione);
            }

            this.Close();
        }

        private void ModificaPrenotazionePeriodica(PrenotazioneSingola newPrenotazioneSingola, PrenotazioneSingola oldPrenotazioneSingola)
        {
            _controllerPrenotazionePeriodica.UpdatePrenotazionePeriodica(newPrenotazioneSingola, oldPrenotazioneSingola);
        }

       

        public void AggiungiModificaPrenotazioneSingola(PrenotazioneSingola prenotazioneSingola)
        {
           switch (_operazione)
            {
                case "Aggiungi":
                    if (_controllerPrenotazioneSingola.AggiungiPrenotazioneSingola(prenotazioneSingola))
                        this.Close();
                    break;
                case "Modifica":
                    if (_controllerPrenotazioneSingola.ModificaPrenotazioneSingola(prenotazioneSingola))
                        this.Close();
                    break;
            }    
        }
        private Cliente BuildCliente()
        {
            if (!_checkBoxClienteRegistrato.Checked)
            {
                return new Cliente(_textBoxNomeCliente.Text, _textBoxCognomeCliente.Text, _textBoxTelefono.Text, _textBoxIndirizzoCliente.Text);

            }
            else
                return _selectedClienteRegistrato;
            
        }        


        private bool CheckParameters()
        {
            if (_textBoxNomeCliente.Text == "" || _textBoxCognomeCliente.Text == "" || _textBoxIndirizzoCliente.Text == "" || _textBoxTelefono.Text == ""
               )
            {
                MessageBox.Show("Tutti i cambi sono obbligatori");
                return false;
            }
            return true;
                
        }

        private void _buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
