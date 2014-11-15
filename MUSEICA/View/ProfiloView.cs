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
    public partial class ProfiloView : Form
    {
        ProfiloController _controller;

        public ProfiloView(ProfiloController controller)
        {
            InitializeComponent();
            _controller = controller;
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadDataProfilo();
            LoadDataPolitica();
            LoadDataClienti();
            LoadDataSale();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadDataClienti();
            LoadDataSale();

        }

        private void LoadDataSale()
        {
            _listBoxSale.Items.Clear();
            _listBoxDescrizioneSale.Items.Clear();
            foreach (Sala sala in CentroSaleProve.GetIstance().Sale)
                _listBoxSale.Items.Add(sala.NomeSala);
        }

        private void LoadDataClienti()
        {
            _listBoxClienti.Items.Clear();
            _listBoxDettagliCliente.Items.Clear();
            foreach (ClienteRegistrato cliente in CentroSaleProve.GetIstance().Clienti)
                _listBoxClienti.Items.Add(cliente.Nome + " " + cliente.Cognome);               
        }

        private void LoadDataPolitica()
        {
            _textBoxPreavvisoDisdetta.Text = CentroSaleProve.GetIstance().Politica.PreavvisoDisdetta.ToString();
            _comboBoxScontoClienteRegistrato.Items.AddRange(ScontoRange());
            _comboBoxScontoPrenotazionePeriodica.Items.AddRange(ScontoRange());
            _comboBoxScontoClienteRegistrato.Text = (CentroSaleProve.GetIstance().Politica.ScontoClienteRegistrato * 100).ToString();
            _comboBoxScontoPrenotazionePeriodica.Text = (CentroSaleProve.GetIstance().Politica.ScontoPrenotazionePeriodica * 100).ToString();
        }

        private object[] ScontoRange()
        {
            int i = 0;
            int index = 0;
            string[] range = new string[21];
            while (i <= 100)
            {
                range[index] = i.ToString();
                i += 5;
                index++;
            }
            return range;
        }

        private void LoadDataProfilo()
        {
            _textBoxNomeCentroSaleProva.Text = CentroSaleProve.GetIstance().Profilo.NomeCentro;
            _textBoxIndirizzo.Text = CentroSaleProve.GetIstance().Profilo.Indirizzo;
            _textBoxEmail.Text = CentroSaleProve.GetIstance().Profilo.Email;
            _textBoxTelefono.Text = CentroSaleProve.GetIstance().Profilo.Telefono;
        }

        private void _comboBoxModifichePolitica_CheckedChanged(object sender, EventArgs e)
        {
            _textBoxPreavvisoDisdetta.Enabled = !_textBoxPreavvisoDisdetta.Enabled;
            _comboBoxScontoPrenotazionePeriodica.Enabled = !_comboBoxScontoPrenotazionePeriodica.Enabled;
            _comboBoxScontoClienteRegistrato.Enabled = !_comboBoxScontoClienteRegistrato.Enabled;              
        }

        private void _checkBoxModificheProfilo_CheckedChanged(object sender, EventArgs e)
        {
            _textBoxNomeCentroSaleProva.Enabled = !_textBoxNomeCentroSaleProva.Enabled;
            _textBoxIndirizzo.Enabled = !_textBoxIndirizzo.Enabled;
            _textBoxTelefono.Enabled = !_textBoxTelefono.Enabled;
            _textBoxEmail.Enabled = !_textBoxEmail.Enabled;            
        }

        private void _listBoxSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_listBoxSale.SelectedItem == null)
                MessageBox.Show("Scegliere una sala per vederne i dettagli");
            else
                _controller.UpdateListBoxDescrizioneSale(_listBoxSale.SelectedItem.ToString(), _listBoxDescrizioneSale);
        }

        private void _buttonAggiungiSala_Click(object sender, EventArgs e)
        {
            _controller.ChangeView("SalaView", null, "Aggiungi");
        }

        private void _buttonModificaSala_Click(object sender, EventArgs e)
        {
            if (_listBoxSale.SelectedItem == null)
                MessageBox.Show("Scegliere una sala per modificarla");
            else
                _controller.ChangeView("SalaView", _listBoxSale.SelectedItem.ToString(), "Modifica");
        }

        private void _buttonAggiungiCliente_Click(object sender, EventArgs e)
        {
            _controller.ChangeView("ClienteView", null, "Aggiungi");
        }

        private void _buttonModificaCliente_Click(object sender, EventArgs e)
        {

            if (_listBoxClienti.SelectedItem == null)
                MessageBox.Show("Scegliere un cliente per modificarlo");
            else
                _controller.ChangeView("ClienteView", _listBoxClienti.SelectedItem.ToString(), "Modifica");
        }

        private void _buttonStoricoCliente_Click(object sender, EventArgs e)
        {
            if (_listBoxClienti.SelectedItem == null)
                MessageBox.Show("Scegliere un cliente per visualizzare lo storico");
            else
                _controller.ChangeView("StoricoView",_controller,  _listBoxClienti.SelectedItem.ToString());
        }

        private void _listBoxClienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_listBoxClienti.SelectedItem == null)
                MessageBox.Show("Scegliere una cliente per vederne i dettagli");
            else
                _controller.UpdateListBoxDescrizioneClienti(_listBoxClienti.SelectedItem.ToString(), _listBoxDettagliCliente);
        }

        private void _buttonEliminaCliente_Click(object sender, EventArgs e)
        {
            if (_listBoxClienti.SelectedItem == null)
                MessageBox.Show("Scegliere un cliente per poterlo eliminare");
            else
                _controller.DeleteClienteRegistrato(_listBoxClienti.SelectedItem.ToString());
        }

        private void _buttonEliminaSala_Click(object sender, EventArgs e)
        {
            if (_listBoxSale.SelectedItem == null)
                MessageBox.Show("Scegliere una sala per poterla eliminare");
            else
                _controller.DeleteSala(_listBoxSale.SelectedItem.ToString());
        }

        private void _buttonOK_Click(object sender, EventArgs e)
        {
            if(this._checkBoxModificheProfilo.Checked || this._comboBoxModifichePolitica.Checked)
                _controller.SetParameters(this._textBoxNomeCentroSaleProva.Text, this._textBoxIndirizzo.Text, this._textBoxEmail.Text, this._textBoxTelefono.Text,
                                            this._textBoxPreavvisoDisdetta.Text, this._comboBoxScontoClienteRegistrato.SelectedItem.ToString(), this._comboBoxScontoPrenotazionePeriodica.SelectedItem.ToString());
            this.Close();
        }

        private void _buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
