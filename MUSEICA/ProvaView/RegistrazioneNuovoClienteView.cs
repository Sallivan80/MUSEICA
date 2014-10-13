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


    public partial class RegistrazioneNuovoClienteView : Form
    {
        ControllerProfilo _controller;

        public RegistrazioneNuovoClienteView()
        {
            InitializeComponent();
            _controller = new ControllerProfilo(this);
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
                Cliente clienteRegistrato = new ClienteRegistrato(nome, cognome, telefono, indirizzo, idTessera, scadenzaTessera);
                CentroSaleProve.GetIstance().Clienti.Add(clienteRegistrato);
                this.Close();
            }   
        }

        private void _annullaButtonRegistrazione_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
