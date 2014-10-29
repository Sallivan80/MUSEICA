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
    public partial class ClienteView : Form
    {
        private string _operazione;
        private ClienteController _controllerCliente;
        private string _selectedClienteString;      

        

        public ClienteView(MainController controllerCliente, string operazione,string selectedItem)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this._controllerCliente = (ClienteController)controllerCliente;
            this._selectedClienteString = selectedItem;
            this._operazione = operazione;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            switch(_operazione)
            {
                case "Aggiungi":
                    this.Text = "Registra Nuovo Cliente";
                    _buttonOK.Text = "Registra";
                    AggiungiModeComponents();
                    break;
                case "Modifica":
                    this.Text = "Modifica Cliente Registrato";
                    _buttonOK.Text = "Modifica";
                    ModificaModeComponents();
                    break;
               
            }
        }

        private void AggiungiModeComponents()
        {
            Random rnd = new Random();
            _textBoxNumeroTessera.Text = "000" + (rnd.Next(CentroSaleProve.GetIstance().Clienti.Count,1000000000));
            
        }

      

        private void ModificaModeComponents()
        {
            ClienteRegistrato selectedCliente = _controllerCliente.FindClienteRegistratoByName(_selectedClienteString);
            _textBoxNome.Text = selectedCliente.Nome;
            _textBoxCognome.Text = selectedCliente.Cognome;
            _textBoxIndirizzo.Text = selectedCliente.Indirizzo;
            _textBoxTelefono.Text = selectedCliente.Telefono;
            _dateTimePickerScadenzaTessera.Value = selectedCliente.ScadenzaTessera;
            _textBoxNumeroTessera.Text = selectedCliente.IdTessera;

            _textBoxNome.Enabled = false;
            _textBoxCognome.Enabled = false;
        }

        private void _buttonOK_Click(object sender, EventArgs e)
        {
            if(CheckParameters())
            {
                ClienteRegistrato cliente = new ClienteRegistrato(_textBoxNome.Text, _textBoxCognome.Text, _textBoxTelefono.Text, _textBoxIndirizzo.Text, _textBoxNumeroTessera.Text, _dateTimePickerScadenzaTessera.Value);
                switch(_operazione)
                {
                    case "Aggiungi":
                         if (_controllerCliente.AggiungiClienteResitrato(cliente))
                             this.Close();
                        break;
                    case "Modifica":
                        if(_controllerCliente.ModificaClienteRegistrato(cliente))
                            this.Close();
                        break;

                }                
               
            }        

        }

        private bool CheckParameters()
        {
            if (_textBoxNome.Text == "" || _textBoxCognome.Text == "" || _textBoxIndirizzo.Text == "" || _textBoxTelefono.Text == "")
            {
                MessageBox.Show("Tutti i campi sono obbligatori");
                return false;
            }

            return true;
        }

        private void _buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
