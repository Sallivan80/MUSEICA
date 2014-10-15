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
            _controller.ChangeView("DescrizioneView", registrazioneToolStripMenuItem.Text, null);
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
                this._dateTimePickerRicerca.Visible = true;
            }
            else
            {
                this._parametroLabel.Visible = true;
                this._parametroLabel.Text = p;
                this._textBoxParametroRicerca.Visible = true;
                this._dateTimePickerRicerca.Visible = false;
            }

        }
    }
}
