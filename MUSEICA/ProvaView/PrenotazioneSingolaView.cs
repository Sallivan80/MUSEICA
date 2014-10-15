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
            ClienteRegistrato clienteRegistrato = this._controller.RicercaClienteRegistrato(this._comboBoxIdTesseraPrenotazione.SelectedItem.ToString());

            if (clienteRegistrato == null)
                throw new ArgumentNullException("clienteRegistrato == null");

            this._textBoxNomePrenotazione.Text = clienteRegistrato.Nome;
            this._textBoxCognomePrenotazione.Text = clienteRegistrato.Cognome;
            this._textBoxTelefonoPrenotazione.Text = clienteRegistrato.Telefono;
            this._textBoxIndirizzoPrenotazione.Text = clienteRegistrato.Indirizzo;
        }

        private void _comboBoxSalaPrenotazione_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sala sala = this._controller.RicercaSala(this._comboBoxSalaPrenotazione.SelectedItem.ToString());

            if (sala == null)
                throw new ArgumentNullException("sala == null");

            this._textBoxTipoSala.Text = sala.Tipo.NomeTipologia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
