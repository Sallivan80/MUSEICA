using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewMUSEICA.Model;
using NewMUSEICA.Controllers;

namespace NewMUSEICA.View
{
    public partial class StoricoView : Form
    {
        
        private string _selectedCliente;
        private MainController _controller;
        
        public StoricoView(Object controller,string selectedCliente)
        {
            InitializeComponent();
            _controller = controller as MainController;
            this._selectedCliente = selectedCliente;           
            _dataGridPrenotazioneSingola.DataSource = new BindingSource();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            List<Prenotazione> prenotazioniCliente = _controller.RicercaPrenotazionePerCliente(_selectedCliente);

            _dataGridPrenotazioneSingola.DataSource = FiltraPrenotazioniSingoleCliente(prenotazioniCliente);
            _dataGridPrenotazionePeriodica.DataSource = FiltraPrenotazioniPeriodicheCliente(prenotazioniCliente);

            _dataGridPrenotazionePeriodica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;         
            _dataGridPrenotazioneSingola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private object FiltraPrenotazioniPeriodicheCliente(List<Prenotazione> prenotazioniCliente)
        {
            var query = from prenotazione in prenotazioniCliente
                        where prenotazione.GetType() == typeof(PrenotazionePeriodica)
                        select prenotazione;
            return query.ToList();
        }

        private object FiltraPrenotazioniSingoleCliente(List<Prenotazione> prenotazioniCliente)
        {
            var query = from prenotazione in prenotazioniCliente
                        where prenotazione.GetType() == typeof(PrenotazioneSingola)
                        select prenotazione;
            return query.ToList();
        }

        

       

    }
}
