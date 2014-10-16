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

namespace MUSEICA.ProvaView
{
    public partial class StoricoView : Form
    {
        
        private ClienteRegistrato _selectedCliente;
        private ControllerProfilo _controller;
        
        public StoricoView(Object selectedCliente)
        {
            InitializeComponent();
            _controller = new ControllerProfilo(this);
            this._selectedCliente = (ClienteRegistrato)selectedCliente;
            this.Activated += new EventHandler(StoricoView_Activated);
            _dataGridPrenotazioneSingola.DataSource = new BindingSource();
        }

        private void StoricoView_Activated(object sender, EventArgs e)
        {
            List<Prenotazione> prenotazioneCliente = _controller.RicercaPrenotazione(_selectedCliente);
            List<PrenotazioneSingola> prenotazioniSingole=new List<PrenotazioneSingola>();
            List<PrenotazionePeriodica> prenotazioniPeriodiche = new List<PrenotazionePeriodica>();
            foreach(Prenotazione p in prenotazioneCliente)
            {
                
                if(p.GetType()==typeof(PrenotazioneSingola))
                {
                   prenotazioniSingole.Add((PrenotazioneSingola)p);
                    
                }
                if (p.GetType() == typeof(PrenotazionePeriodica))
                {
                    prenotazioniPeriodiche.Add((PrenotazionePeriodica)p);
                }
                
            }
            _dataGridPrenotazioneSingola.DataSource = prenotazioniSingole;
            _dataGridPrenotazionePeriodica.DataSource = prenotazioniPeriodiche;

           
        }

       

    }
}
