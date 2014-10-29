using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewMUSEICA.Controllers;
using NewMUSEICA.Model;

namespace NewMUSEICA.View
{
    public partial class AggiungiGiornoView : Form
    {
        private ClienteRegistrato _selectedClienteRegistrato;
        private Sala _selectedSala;
        private List<PrenotazioneSingola> _prenotazioniSingole;
        private PrenotazioneController _prenotazioneController;
        private string _idPrenotazione;
             

        public AggiungiGiornoView(string idPrenotazione,ClienteRegistrato selectedClienteRegistrato, Sala selectedSala, List<PrenotazioneSingola> prenotazioniSingole, MainController prenotazioneController)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this._selectedClienteRegistrato = selectedClienteRegistrato;
            this._selectedSala = selectedSala;
            this._prenotazioniSingole = prenotazioniSingole;
            this._prenotazioneController = prenotazioneController as PrenotazioneController;
            _idPrenotazione = idPrenotazione;
        }

        private void _buttonAggiungi_Click(object sender, EventArgs e)
        {
            DateTime data = _dateTimePickerDataPrenotazione.Value;
            int oraInizio = Convert.ToInt32(_numericBoxOraInizio.Value);
            int oraFine = Convert.ToInt32(_numericBoxOraFine.Value);
            string note = _textBoxNote.Text;
            string idPrenotazione = _idPrenotazione;
            PrenotazioneSingola newPrenotazione = new PrenotazioneSingola(idPrenotazione, _selectedClienteRegistrato, _selectedSala, data, oraInizio, oraFine, note);
            if (_prenotazioneController.CheckPrenotazioneSingola(newPrenotazione))
            {
                _prenotazioniSingole.Add(newPrenotazione);
                this.Close();
            }
            else
                MessageBox.Show("ERRORE: orario già occupato");
               

        }




    }
}
