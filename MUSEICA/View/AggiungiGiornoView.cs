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
    public partial class AggiungiGiornoView : Form
    {
        private ClienteRegistrato _selectedClienteRegistrato;
        private Sala _selectedSala;
        private List<PrenotazioneSingola> _prenotazioniSingole;
        private PrenotazionePeriodicaController _prenotazioneController;
        private string _idPrenotazione;
             

        public AggiungiGiornoView(string idPrenotazione,ClienteRegistrato selectedClienteRegistrato, Sala selectedSala, List<PrenotazioneSingola> prenotazioniSingole, MainController prenotazioneController)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this._selectedClienteRegistrato = selectedClienteRegistrato;
            this._selectedSala = selectedSala;
            this._prenotazioniSingole = prenotazioniSingole;
            this._prenotazioneController = prenotazioneController as PrenotazionePeriodicaController;
            _idPrenotazione = idPrenotazione;
        }

        private void _buttonAggiungi_Click(object sender, EventArgs e)
        {
            DateTime data = _dateTimePickerDataPrenotazione.Value;
            int oraInizio = Convert.ToInt32(_numericBoxOraInizio.Value);
            int oraFine = Convert.ToInt32(_numericBoxOraFine.Value);
           
            string idPrenotazione = _idPrenotazione;
            PrenotazioneSingola newPrenotazione = new PrenotazioneSingola(idPrenotazione, _selectedClienteRegistrato, _selectedSala, data, oraInizio, oraFine);
            if (_prenotazioneController.CheckPrenotazione(newPrenotazione))
            {
                _prenotazioniSingole.Add(newPrenotazione);
                this.Close();
            }
            else
                MessageBox.Show("ERRORE: orario già occupato");
        }

        private void _annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
