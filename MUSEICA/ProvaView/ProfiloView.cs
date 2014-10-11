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

        private Controller _controller;
        

        public ProfiloView()
        {
            InitializeComponent();
            this._controller = new ControllerProfilo(this);
            SetProfiloValue();
            SetPoliticaValue();
            SetSalaValue();
            SetClientiRegistratiValue();
        }

        private void SetClientiRegistratiValue()
        {
           foreach(Cliente cliente in CentroSaleProve.GetIstance().Clienti)
           {
               if (cliente.GetType() == typeof(ClienteRegistrato))
                   _listBoxClientiRegistratiGestioneClientiRegistrati.Items.Add(cliente.Cognome + " " + cliente.Nome);
           }
        }

        private void SetSalaValue()
        {
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
            string salaSelected = _listBoxSaleGestioneSale.SelectedItem.ToString();
            foreach(Sala s in CentroSaleProve.GetIstance().Sale)
            {
                if (s.NomeSala == salaSelected)
                {
                    _listBoxDescrizioneSaleGestioneSale.Items.Add("Id Sala : " + s.IdSala);
                    _listBoxDescrizioneSaleGestioneSale.Items.Add("Tipologia : " + s.Tipo.NomeTipologia);
                    _listBoxDescrizioneSaleGestioneSale.Items.Add("Indirizzo : " + s.Indirizzo);
                    _listBoxDescrizioneSaleGestioneSale.Items.Add("Prezzo :" + s.Prezzo+" €/h" );
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       
        

        private void button1_Click(object sender, EventArgs e) { }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        

        private void label6_Click(object sender, EventArgs e) { }
       

        private void textBox5_TextChanged(object sender, EventArgs e) { }
       

        private void button12_Click(object sender, EventArgs e) { }
        

        private void button8_Click(object sender, EventArgs e) { }
        

        private void label4_Click_1(object sender, EventArgs e) { }
        

        private void ProfiloView_Load(object sender, EventArgs e) { }

        private void _abilitaModificheImpostaProfilo_CheckedChanged(object sender, EventArgs e)
        {
            if(_abilitaModificheImpostaProfilo.Checked)
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
            _listBoxDettagliGestioneClientiRegistrati.Items.Clear();
            string clienteSelected = _listBoxClientiRegistratiGestioneClientiRegistrati.SelectedItem.ToString();
            foreach(Cliente c in CentroSaleProve.GetIstance().Clienti)
            {
                if (c.Cognome + " " + c.Nome == clienteSelected && c.GetType()==typeof(ClienteRegistrato))
                {
                    ClienteRegistrato temp=(ClienteRegistrato)c;
                    _listBoxDettagliGestioneClientiRegistrati.Items.Add("N° Tessera : " + temp.IdTessera);
                    _listBoxDettagliGestioneClientiRegistrati.Items.Add("Scadenza Tessera : " + temp.ScadenzaTessera.ToShortDateString());
                    _listBoxDettagliGestioneClientiRegistrati.Items.Add("Indirizzo : " + temp.Indirizzo);
                    _listBoxDettagliGestioneClientiRegistrati.Items.Add("Telefono : " + temp.Telefono);

                }

            }
        }

        
    }
}
