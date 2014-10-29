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
            List<Prenotazione> prenotazioniCliente = _controller.RicercaPrenotazionePerCliente(_selectedCliente,CentroSaleProve.GetIstance().Agenda.Prenotazioni);

            
            _dataGridPrenotazioneSingola.DataSource = FiltraPrenotazioniSingoleCliente(prenotazioniCliente);
            _dataGridPrenotazionePeriodica.DataSource = FiltraPrenotazioniPeriodicheCliente(prenotazioniCliente);

            _dataGridPrenotazionePeriodica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;         
            _dataGridPrenotazioneSingola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private List<PrenotazioneSingola> FiltraPrenotazioniSingoleCliente(List<Prenotazione> prenotazioniCliente)
        {
            List<PrenotazioneSingola> result=new List<PrenotazioneSingola>();
            foreach (Prenotazione p in prenotazioniCliente)
                if (p.IdPrenotazione.StartsWith("S"))
                    result.Add(p as PrenotazioneSingola);
            return result;
        }

        private object FiltraPrenotazioniPeriodicheCliente(List<Prenotazione> prenotazioniCliente)
        {
            List<PrenotazionePeriodica> result = new List<PrenotazionePeriodica>();
            foreach (Prenotazione p in prenotazioniCliente)
                if (p.IdPrenotazione.StartsWith("P"))                    
                    FindPrenotazioniPeriodicheById(p.IdPrenotazione,result);
            return result;
          
        }

        private List<PrenotazionePeriodica> FindPrenotazioniPeriodicheById(string IdPrenotazione,List<PrenotazionePeriodica> result)
        {
             
             foreach (Prenotazione p in CentroSaleProve.GetIstance().Agenda.Prenotazioni)
                 if (p.GetType() == typeof(PrenotazionePeriodica) && p.IdPrenotazione == IdPrenotazione)
                     if(!result.Contains(p as PrenotazionePeriodica))
                         result.Add(p as PrenotazionePeriodica);
             return result;

        }

        

       

    }
}
