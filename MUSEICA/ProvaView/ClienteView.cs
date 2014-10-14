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


    public partial class ClienteView : Form
    {
        ControllerProfilo _controller;
        
        private ClienteRegistrato _selectedCliente;
        private string _operazione;
        public ClienteView(string operazione,Object selectedCliente)
        {
            InitializeComponent();
            _controller = new ControllerProfilo(this);
            this._operazione = operazione;
            this._selectedCliente =(ClienteRegistrato) selectedCliente;
            SetFormValue();
        }

        public ClienteView(string operazione)
        {
            InitializeComponent();
            _controller = new ControllerProfilo(this);
            this._operazione = operazione;            
            SetFormValue();
        }

        private void SetFormValue()
        {
            if (_operazione == "Modifica")
            {
                this.Text = "Modifica Cliente";
                foreach (Cliente c in CentroSaleProve.GetIstance().Clienti)
                    if (c.GetType() == typeof(ClienteRegistrato) )
                    {
                        ClienteRegistrato temp = (ClienteRegistrato)c;
                        if(temp.IdTessera==_selectedCliente.IdTessera)
                        {
                            _textBoxNomeRegistrazione.Text = temp.Nome;
                            _textBoxCognomeRegistrazione.Text = temp.Cognome;
                            _textBoxNumeroTesseraRegistrazione.Text = temp.IdTessera;                           
                            _textBoxIndirizzoRegistrazione.Text = temp.Indirizzo;
                            _textBoxTelefonoRegistrazione.Text = temp.Telefono;
                            
                            _textBoxNomeRegistrazione.Enabled = false;
                            _textBoxCognomeRegistrazione.Enabled = false;
                            _textBoxNumeroTesseraRegistrazione.Enabled = false;
                        }
                      
                    }

            }
            else
                this.Text = "Registra Cliente";
        }

        private void _okButtonRegistrazione_Click(object sender, EventArgs e)
        {
            string nome = _textBoxNomeRegistrazione.Text;
            string cognome = _textBoxCognomeRegistrazione.Text;
            string telefono = _textBoxTelefonoRegistrazione.Text;
            string indirizzo = _textBoxIndirizzoRegistrazione.Text;
            string idTessera = _textBoxNumeroTesseraRegistrazione.Text;
            DateTime scadenzaTessera = DateTime.Parse(_dateTimePickerScadenzaTesseraRegistrazione.Text);

            if (nome == "" || cognome == "" || telefono == "" || indirizzo == "")
                MessageBox.Show("Tutti i campi sono obbligatori", "ATTENZIONE");
            else
            {
                ClienteRegistrato clienteRegistrato = new ClienteRegistrato(nome, cognome, telefono, indirizzo, idTessera, scadenzaTessera);
                if (!_controller.CheckClienteRegistrato(clienteRegistrato) && _operazione == "Aggiungi")
                    MessageBox.Show("Cliente con Nome e Cognome inseriti già presente!");
                else
                {
                    _controller.ChangeView("ConfermaView", clienteRegistrato, _operazione);
                    this.Close();
                }
                
            }   
        }

        private void _annullaButtonRegistrazione_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
