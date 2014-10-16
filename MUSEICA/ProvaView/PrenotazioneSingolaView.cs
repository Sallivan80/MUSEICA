using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.Controllers;
using MUSEICA.Model;

namespace MUSEICA.ProvaView
{
    public partial class PrenotazioneSingolaView : Form
    {
        private MainController _controller;
        private string operazione;
        private PrenotazioneSingola _selectedPrenotazione;
       
        
        public PrenotazioneSingolaView(string operazione, Object selectedItem)
        {
            InitializeComponent();
            this._controller = new MainController(this);
            this.operazione = operazione;
            this._selectedPrenotazione = (PrenotazioneSingola) selectedItem;
            SetValue();
        }

        private void SetValue()
        {
            if (operazione == "Modifica")
            {
                this.Text = "Modifica Prenotazione Singola";

                if(this._selectedPrenotazione.Cliente.GetType() == typeof(ClienteRegistrato))
                {
                    ClienteRegistrato clienteRegiTemp = (ClienteRegistrato) this._selectedPrenotazione.Cliente;
                    this._comboBoxIdTesseraPrenotazione.Text = clienteRegiTemp.IdTessera;

                    this._comboBoxIdTesseraPrenotazione.Enabled = false;
                }
                this._textBoxNomePrenotazione.Text = this._selectedPrenotazione.Cliente.Nome;
                this._textBoxCognomePrenotazione.Text = this._selectedPrenotazione.Cliente.Cognome;
                this._textBoxTelefonoPrenotazione.Text = this._selectedPrenotazione.Cliente.Telefono;
                this._textBoxIndirizzoPrenotazione.Text = this._selectedPrenotazione.Cliente.Indirizzo;
                this._dateTimePickerDataPrenotazione.Value = this._selectedPrenotazione.Data;
                this._comboBoxSalaPrenotazione.Text = this._selectedPrenotazione.Sala.NomeSala;
                this._textBoxTipoSala.Text = this._selectedPrenotazione.Sala.Tipo.NomeTipologia;
                this._comboBoxOraInizioPrenotazione.Text = this._selectedPrenotazione.OraInizio.ToString();
                this._comboBoxOraFinePrenotazione.Text = this._selectedPrenotazione.OraFine.ToString();

                this._textBoxNomePrenotazione.Enabled = false;
                this._textBoxCognomePrenotazione.Enabled = false;
                this._textBoxTelefonoPrenotazione.Enabled = false;
                this._textBoxIndirizzoPrenotazione.Enabled = false;
                this._comboBoxSalaPrenotazione.Enabled = false;

                SetComboOraValue();

            }
            else if (operazione == "Aggiungi")
            {
                foreach (ClienteRegistrato c in CentroSaleProve.GetIstance().Clienti)
                {
                    this._comboBoxIdTesseraPrenotazione.Items.Add(c.IdTessera);
                }

                foreach (Sala s in CentroSaleProve.GetIstance().Sale)
                {
                    this._comboBoxSalaPrenotazione.Items.Add(s.NomeSala);
                }

                SetComboBoxAggiunteStrumenti();
                SetComboOraValue();

            }
        }

        private void SetComboOraValue()
        {
            string[] ore = new string[14];
            for (int i = 9; i < 23; i++)
                ore[i-9] = i.ToString();

            _comboBoxOraInizioPrenotazione.Items.AddRange(ore);
            _comboBoxOraFinePrenotazione.Items.AddRange(ore);
        }

        private void SetComboBoxAggiunteStrumenti()
        {
            Type aggiuntaType = typeof(Aggiunta);
            var q = from subType in Assembly.GetExecutingAssembly().GetTypes()
                    where subType.IsSubclassOf(aggiuntaType)
                    select subType.Name;

            foreach (string t in q)
            {
                _comboBoxStrumenti.Items.Add(t);
            }

            
        }

        private void PrenotazioneView_Load(object sender, EventArgs e)
        {
                    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _comboBoxIdTesseraPrenotazione_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteRegistrato clienteRegistrato = this._controller.RicercaClienteRegistratoById(this._comboBoxIdTesseraPrenotazione.SelectedItem.ToString());

            if (clienteRegistrato == null)
                throw new ArgumentNullException("clienteRegistrato == null");

            this._textBoxNomePrenotazione.Text = clienteRegistrato.Nome;
            this._textBoxCognomePrenotazione.Text = clienteRegistrato.Cognome;
            this._textBoxTelefonoPrenotazione.Text = clienteRegistrato.Telefono;
            this._textBoxIndirizzoPrenotazione.Text = clienteRegistrato.Indirizzo;
        }

        private void _comboBoxSalaPrenotazione_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sala sala = this._controller.RicercaSalaByName(this._comboBoxSalaPrenotazione.SelectedItem.ToString());

            if (sala == null)
                throw new ArgumentNullException("sala == null");

            this._textBoxTipoSala.Text = sala.Tipo.NomeTipologia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_comboBoxStrumenti.SelectedItem == null )
                MessageBox.Show("Scegliere uno strumento ");
            else
            {

                _listBoxAggiunteStrumenti.Items.Add(String.Format("{0}", _comboBoxStrumenti.SelectedItem.ToString()));
            }
                
        }

       

        private void _buttonRimuovi_Click(object sender, EventArgs e)
        {
            if (_listBoxAggiunteStrumenti.SelectedItem == null)
                MessageBox.Show("Selezionare un elemento prima di eliminarlo");
            else
            {
                _listBoxAggiunteStrumenti.Items.Remove(_listBoxAggiunteStrumenti.SelectedItem);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _comboBoxIdTesseraPrenotazione.Enabled = true;
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            CheckParameters();
            PrenotazioneSingola prenotazioneSingola = BuildPrenotazione();
            if(_controller.AggiungiPrenotazione(prenotazioneSingola))
            {
                if(_listBoxAggiunteStrumenti.Items.Count!=0)
                    SetAggiunte(prenotazioneSingola);
                
            }
            _controller.ChangeView("DescrizioneView", prenotazioneSingola, "PrenotazioneSingola");
           
        }

        private void SetAggiunte(PrenotazioneSingola prenotazioneSingola)
        {
            foreach (string nomeAggiunta in _listBoxAggiunteStrumenti.Items)
            {
                switch (nomeAggiunta)
                {
                    case "Chitarra":
                        Aggiunta aggiuntaChitarra = new Chitarra(prenotazioneSingola);
                        break;
                    case "Basso":
                        Aggiunta aggiuntaBasso = new Basso(prenotazioneSingola);
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

      

        private PrenotazioneSingola BuildPrenotazione()
        {
            Cliente c;
            string idPrenotazione=CentroSaleProve.GetIstance().Agenda.Prenotazioni.Count.ToString();
            Sala s = _controller.RicercaSalaByName(_comboBoxSalaPrenotazione.SelectedItem.ToString());
            DateTime data = _dateTimePickerDataPrenotazione.Value.ToLocalTime();
            int oraInizio =Convert.ToInt32( _comboBoxOraInizioPrenotazione.SelectedItem.ToString());
            int oraFine = Convert.ToInt32(_comboBoxOraFinePrenotazione.SelectedItem.ToString());
           if(_checkBoxClienteRegistrato.Checked)
               c=_controller.RicercaClienteRegistratoById(_comboBoxIdTesseraPrenotazione.Text);
           else
              c= _controller.RicercaClienteNormaleByName(_textBoxNomePrenotazione.Text, _textBoxNomePrenotazione.Text);

           return new PrenotazioneSingola(idPrenotazione, c, s, data, oraInizio, oraFine);

        }

        private void CheckParameters()
        {
            if (_textBoxCognomePrenotazione.Text == "" || _textBoxNomePrenotazione.Text == "" || _textBoxIndirizzoPrenotazione.Text == "" || _textBoxTelefonoPrenotazione.Text == ""
                || _comboBoxSalaPrenotazione.SelectedItem == null || _comboBoxOraInizioPrenotazione.SelectedItem == null || _comboBoxOraFinePrenotazione.SelectedItem == null)
                MessageBox.Show("Tutti i campi tranne le aggiunte sono obbligatori");
        }
    }
}
