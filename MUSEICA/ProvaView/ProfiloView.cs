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
    public partial class ProfiloView : Form
    {

        private ControllerProfilo _controller;
        private ClienteRegistrato _clienteSelected;
        private Sala _salaSelected;

        public ProfiloView()
        {
            InitializeComponent();
            this._controller = new ControllerProfilo(this);
            this.Activated += new EventHandler(ProfiloView_Activated);
        }
        void ProfiloView_Activated(object sender, EventArgs e)
        {
            SetProfiloValue();
            SetPoliticaValue();
            SetSalaValue();
            SetClientiRegistratiValue();
        }
        private void SetClientiRegistratiValue()
        {
            _listBoxClientiRegistratiGestioneClientiRegistrati.Items.Clear();
           foreach(Cliente cliente in CentroSaleProve.GetIstance().Clienti)
           {
               if (cliente.GetType() == typeof(ClienteRegistrato))
                   _listBoxClientiRegistratiGestioneClientiRegistrati.Items.Add(cliente.Cognome + " " + cliente.Nome);
           }
        }

        private void SetSalaValue()
        {
            _listBoxSaleGestioneSale.Items.Clear();
            foreach (Sala s in CentroSaleProve.GetIstance().Sale)
                _listBoxSaleGestioneSale.Items.Add(s.NomeSala);
        }

        private void SetPoliticaValue()
        {
            _textBoxPreavvisoDisdetta.Text = CentroSaleProve.GetIstance().Politica.PreavvisoDisdetta.ToString();
            _comboBoxScontoClienteRegistrato.Text = (CentroSaleProve.GetIstance().Politica.ScontoClienteRegistrato)*100+" %";
            _comboBoxScontoPrenotazionePeriodica.Text = (CentroSaleProve.GetIstance().Politica.ScontoPrenotazionePeriodica)*100+" %";           
        }

        private void SetProfiloValue()
        {
            _textBoxNomeCentroSaleProva.Text = CentroSaleProve.GetIstance().Profilo.NomeCentro;
            _textBoxIndirizzo.Text = CentroSaleProve.GetIstance().Profilo.Indirizzo;
            _textBoxTelefono.Text = CentroSaleProve.GetIstance().Profilo.Telefono;
            _textBoxEmail.Text = CentroSaleProve.GetIstance().Profilo.Email;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _listBoxDescrizioneSaleGestioneSale.Items.Clear();
            string salaSelectedText=null;
            if(_listBoxSaleGestioneSale.SelectedItem!=null)
               salaSelectedText = _listBoxSaleGestioneSale.SelectedItem.ToString();
            foreach(Sala s in CentroSaleProve.GetIstance().Sale)
            {
                if (s.NomeSala == salaSelectedText)
                {
                    _salaSelected = s;
                    _listBoxDescrizioneSaleGestioneSale.Items.Add("Id Sala : " + s.IdSala);
                    _listBoxDescrizioneSaleGestioneSale.Items.Add("Tipologia : " + s.Tipo.NomeTipologia);
                    _listBoxDescrizioneSaleGestioneSale.Items.Add("Indirizzo : " + s.Indirizzo);
                    _listBoxDescrizioneSaleGestioneSale.Items.Add("Prezzo :" + s.Prezzo+" €/h" );
                }
            }
        }

    



        private void button3_Click(object sender, EventArgs e)
        {
            if (_salaSelected == null)
                MessageBox.Show("Selezionare una sala prima di poterla eliminare!");
            else
                _controller.ChangeView("ConfermaView", _salaSelected, "EliminaSala");
        }

       
        

        private void button1_Click(object sender, EventArgs e) 
        {
            _controller.ChangeView("SalaView",null,"Aggiungi");
        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        

        private void label6_Click(object sender, EventArgs e) { }
       

        private void textBox5_TextChanged(object sender, EventArgs e) { }
       

        private void button12_Click(object sender, EventArgs e) { }
        

        private void button8_Click(object sender, EventArgs e) 
        {
            if (_listBoxClientiRegistratiGestioneClientiRegistrati.SelectedItem == null)
                MessageBox.Show("Selezionare un cliente prima di poterlo modificare");
            else
                _controller.ChangeView("ClienteView", _clienteSelected,"Modifica");
        }
        

        private void label4_Click_1(object sender, EventArgs e) { }
        

        private void ProfiloView_Load(object sender, EventArgs e) { }

        private void _abilitaModificheImpostaProfilo_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void _abilitaModificheGestionePolitica_CheckedChanged(object sender, EventArgs e)
        {
            if(_abilitaModificheGestionePolitica.Checked)
            {
                _textBoxPreavvisoDisdetta.Enabled = true;
                _comboBoxScontoClienteRegistrato.Enabled = true;
                _comboBoxScontoPrenotazionePeriodica.Enabled = true;

                _comboBoxScontoClienteRegistrato.Items.AddRange(ScontiRange());
                _comboBoxScontoPrenotazionePeriodica.Items.AddRange(ScontiRange());
            }
            else
            {
                _textBoxPreavvisoDisdetta.Enabled = false;
                _comboBoxScontoClienteRegistrato.Enabled = false;
                _comboBoxScontoPrenotazionePeriodica.Enabled = false;

            }
        }

        private string[] ScontiRange()
        {
            int i = 0;
            int index = 0;
            string[] valori = new string[21];
            while (i <= 100)
            {
                valori[index] = i.ToString() + " %";
                i += 5;
                index++;
            }
            return valori;
        }

        private void _listBoxClientiRegistratiGestioneClientiRegistrati_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void _abilitaModificheImpostaProfilo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (_abilitaModificheImpostaProfilo.Checked)
            {
                _textBoxNomeCentroSaleProva.Enabled = true;
                _textBoxIndirizzo.Enabled = true;
                _textBoxTelefono.Enabled = true;
                _textBoxEmail.Enabled = true;
            }
            else
            {
                _textBoxNomeCentroSaleProva.Enabled = false;
                _textBoxIndirizzo.Enabled = false;
                _textBoxTelefono.Enabled = false;
                _textBoxEmail.Enabled = false;
            }
        }

        private void _listBoxClientiRegistratiGestioneClientiRegistrati_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _listBoxDettagliGestioneClientiRegistrati.Items.Clear();
             string clienteSelected =null;
            if(_listBoxClientiRegistratiGestioneClientiRegistrati.SelectedItem!=null)
                 clienteSelected = _listBoxClientiRegistratiGestioneClientiRegistrati.SelectedItem.ToString();
            foreach (Cliente c in CentroSaleProve.GetIstance().Clienti)
            {
                if (c.Cognome + " " + c.Nome == clienteSelected && c.GetType() == typeof(ClienteRegistrato))
                {
                    _clienteSelected = (ClienteRegistrato)c;
                    _listBoxDettagliGestioneClientiRegistrati.Items.Add("N° Tessera : " + _clienteSelected.IdTessera);
                    _listBoxDettagliGestioneClientiRegistrati.Items.Add("Scadenza Tessera : " + _clienteSelected.ScadenzaTessera.ToShortDateString());
                    _listBoxDettagliGestioneClientiRegistrati.Items.Add("Indirizzo : " + _clienteSelected.Indirizzo);
                    _listBoxDettagliGestioneClientiRegistrati.Items.Add("Telefono : " + _clienteSelected.Telefono);

                }

            }
        }

        private void ProfiloView_Load_1(object sender, EventArgs e)
        {

        }

        private void _aggiungiClienteRegistratoButton_Click(object sender, EventArgs e)
        {
             _controller.ChangeView("ClienteView",null,"Aggiungi");
        }

        private void _modificaSalaButton_Click(object sender, EventArgs e)
        {
            if (_listBoxSaleGestioneSale.SelectedItem == null)
                MessageBox.Show("Selezionare una Sala prima di poterla modificare");
            else
                 _controller.ChangeView("SalaView", _salaSelected,"Modifica");
        }

        private void _storicoPrenotazioniButton_Click(object sender, EventArgs e)
        {
            if(_listBoxClientiRegistratiGestioneClientiRegistrati.SelectedItem==null)
                MessageBox.Show("Selezionare una cliente prima di poterne vedere lo storico");
            else
                _controller.ChangeView("StoricoCliente", _clienteSelected,null);
        }

        private void _eliminaClienteRegistratoButton_Click(object sender, EventArgs e)
        {
            if (_clienteSelected == null)
                MessageBox.Show("Selezionare un cliente prima di poterlo eliminare");
            else
                _controller.ChangeView("ConfermaView", _clienteSelected, "EliminaCliente");
        }

        
    }
}
