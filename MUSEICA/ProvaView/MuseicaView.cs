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
    public partial class MuseicaView : Form
    {
        private MainController _controller;
        private Prenotazione _prenotazioneSelected;

        public MuseicaView()
        {
            InitializeComponent();
            this._controller = new MainController(this);
            _controller.LoadCompenents();
            SetValue();
        }

        private void SetValue()
        {
            this._comboBoxCriterioRicerca.Items.Add("Cliente");
            this._comboBoxCriterioRicerca.Items.Add("Data");
            this._comboBoxCriterioRicerca.Items.Add("Sala");
            this._comboBoxCriterioRicerca.Items.Add("Tipo");

            this._parametroLabel.Hide();
            this._textBoxParametroRicerca.Hide();
            this._dateTimePickerRicerca.Hide();
        }

        private void gestioneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void gestioneToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            _controller.ChangeView("Profilo", null, null);
        }

        private void registraNuovoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ChangeView("ClienteView", null, "Aggiungi");
        }

        private void registrazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ChangeView("DescrizioneView", registrazioneToolStripMenuItem.Text, "DescrizioneSala");
        }

        private void mixaggioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ChangeView("DescrizioneView", mixaggioToolStripMenuItem.Text, null);
        }

        private void provaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ChangeView("DescrizioneView", provaToolStripMenuItem.Text, null);
        }

        private void prenotazioneSingolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ChangeView("PrenotazioneSingolaView", null, "Aggiungi");
        }

        private void _comboBoxCriterioRicerca_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this._comboBoxCriterioRicerca.SelectedItem.ToString())
            {
                case "Cliente":
                    SetLabelAndBox("Nome e Cognome:"); 
                    break;
                case "Data":
                    SetLabelAndBox("Data:"); 
                    break;
                case "Sala":
                    SetLabelAndBox("Id Sala:"); 
                    break;
                case "Tipo":
                    SetLabelAndBox("Nome Tipo:"); 
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private void SetLabelAndBox(string p)
        {
            if (p == "Data:")
            {
                this._parametroLabel.Visible = true;
                this._parametroLabel.Text = p;
                this._textBoxParametroRicerca.Visible = false;
                this._comboBoxSalaTipo.Visible = false;
                this._dateTimePickerRicerca.Visible = true;
                
               
            }
            else  if (p == "Nome Tipo:")
            {
                this._parametroLabel.Visible = true;
                this._parametroLabel.Text = p;
                this._comboBoxSalaTipo.Items.Clear();
                foreach (ITipologiaSala t in TipologiaSalaFactory.GetTipologie())
                     this._comboBoxSalaTipo.Items.Add(t.NomeTipologia);
                this._textBoxParametroRicerca.Visible = false;
                this._dateTimePickerRicerca.Visible = false;
                this._comboBoxSalaTipo.Visible = true;
                
            }
            else if (p == "Id Sala:")
            {
                this._parametroLabel.Visible = true;
                this._parametroLabel.Text = p;
                this._comboBoxSalaTipo.Items.Clear();
                foreach (Sala s in CentroSaleProve.GetIstance().Sale)
                    this._comboBoxSalaTipo.Items.Add(s.IdSala);
                this._textBoxParametroRicerca.Visible = false;
                this._dateTimePickerRicerca.Visible = false;
                this._comboBoxSalaTipo.Visible = true;

            }
            else
            {
                this._parametroLabel.Visible = true;
                this._parametroLabel.Text = p;
                this._dateTimePickerRicerca.Visible = false;
                this._comboBoxSalaTipo.Visible = false;
                this._textBoxParametroRicerca.Visible = true;
              
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_comboBoxCriterioRicerca.SelectedItem == null)
                MessageBox.Show("Inserire criterio ricerca ");
            else
            {
                List<Prenotazione> result = new List<Prenotazione>();
                switch (_comboBoxCriterioRicerca.SelectedItem.ToString())
                {
                    case "Cliente":
                        Cliente c = BuildCliente(_textBoxParametroRicerca.Text);
                        result = _controller.RicercaPrenotazione(c);
                        break;
                    case "Data":
                        DateTime data = _dateTimePickerRicerca.Value.ToUniversalTime();
                        result = _controller.RicercaPrenotazione(data);
                        break;
                    case "Sala":
                        result = _controller.RicercaPrenotazione(new Sala(_comboBoxSalaTipo.SelectedItem.ToString()));
                        break;
                    case "Tipo":
                        ITipologiaSala tipo = TipologiaSalaFactory.GetTipologia(_comboBoxSalaTipo.SelectedItem.ToString());
                        result = _controller.RicercaPrenotazione(tipo);
                        break;
                    case "MUSEICA.Model.ITipologiaSala":
                        break;
                    default:
                        throw new ArgumentException();
                }

                SetValueListBoxRisultati(result);
            }

        }

        private void SetValueListBoxRisultati(List<Prenotazione> result)
        {
            string prenotazioneToShow=null;
            _listBoxRisultatiRicerca.Items.Clear();
            if (result.Count == 0)
            {
                     prenotazioneToShow = "NESSUN RISULTATO";
                 _listBoxRisultatiRicerca.Items.Add(prenotazioneToShow);
            }
               
            else
            {
                foreach (Prenotazione p in result)
                {
                    if (p.GetType() == typeof(PrenotazioneSingola))
                    {
                        PrenotazioneSingola temp = (PrenotazioneSingola)p;
                        prenotazioneToShow = String.Format("Singola:{0} - {1} - {2} (dalle:{3} alle:{4}) -{5}", p.IdPrenotazione, p.Cliente.ToString(), p.Data.ToShortDateString(),
                            temp.OraInizio, temp.OraFine, temp.Sala.NomeSala);

                    }
                    if (p.GetType() == typeof(PrenotazionePeriodica))
                    {
                        PrenotazionePeriodica temp = (PrenotazionePeriodica)p;
                        prenotazioneToShow = String.Format("Periodica:{0} - {1} - Periodo:{2}/{3} - {4}", p.IdPrenotazione, p.Cliente.ToString(), p.Data.ToShortDateString(),
                            temp.DataFine.ToShortDateString(), temp.Sala.NomeSala);

                    }
                    _listBoxRisultatiRicerca.Items.Add(prenotazioneToShow);
                }
            }
                
        }

       

        private Cliente BuildCliente(string p)
        {
            
            string[] split = p.Split(new Char[] {' '});
            Cliente c = new Cliente(split[0], split[1], null, null);
            return c;

        }
    }
}
