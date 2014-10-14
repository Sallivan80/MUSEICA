using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.Persistence;
using MUSEICA.Model;
using MUSEICA.Controllers;

namespace MUSEICA.ProvaView
{
    public partial class SalaView : Form
    {
        ControllerProfilo _controller;
        private string _operazione;
        private Sala _salaToChange;
        public SalaView(string operazione,Object selectedObjectToChange)
        {
            InitializeComponent();
            _controller=new ControllerProfilo(this);
            this._operazione = operazione;
            this._salaToChange =(Sala) selectedObjectToChange;
            SetFormValue();
            
        }
        public SalaView(string operazione)
        {
            InitializeComponent();
            _controller = new ControllerProfilo(this);
            this._operazione = operazione;           
            SetFormValue();
        }

        
       
        private void SetFormValue()
        {
            foreach (ITipologiaSala t in TipologiaSalaFactory.GetTipologie())
                _comboBoxTipologia.Items.Add(t.NomeTipologia);

            if (_operazione == "Modifica")
            {
                this.Text = "Modifica Sala";
                foreach (Sala s in CentroSaleProve.GetIstance().Sale)
                    if (s.IdSala == _salaToChange.IdSala)
                    {
                        _textBoxIdSala.Text = s.IdSala;
                        _textBoxNomeSala.Text = s.NomeSala;
                        _comboBoxTipologia.Text = s.Tipo.NomeTipologia;
                        _textBoxIndirizzoSala.Text = s.Indirizzo;
                        _textBoxPrezzoSala.Text = s.Prezzo.ToString();
                        _textBoxIdSala.Enabled = false;
                        _textBoxNomeSala.Enabled = false;
                    }

            }
            else
                this.Text = "Aggiungi Sala";              
                
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            string idSala = _textBoxIdSala.Text;
            string nomeSala = _textBoxNomeSala.Text;
            string indirizzo = _textBoxIndirizzoSala.Text;
            string prezzoString = _textBoxPrezzoSala.Text;
            string tipologiaString = _comboBoxTipologia.Items.IndexOf(0).ToString();            

            if (idSala == "" || nomeSala== "" || indirizzo== "" || prezzoString == "" || tipologiaString=="")
                MessageBox.Show("Tutti i campi sono obbligatori", "ATTENZIONE");
            else
            {             
                try
                {
                    tipologiaString = _comboBoxTipologia.SelectedItem.ToString();
                    float prezzo = Convert.ToSingle(prezzoString);
                    ITipologiaSala tipologia = TipologiaSalaFactory.GetTipologia(_comboBoxTipologia.SelectedItem.ToString());
                    Sala s = new Sala(idSala, indirizzo, nomeSala, tipologia, prezzo);

                    if (!_controller.CheckSala(s) && _operazione == "Aggiungi")
                        MessageBox.Show("Sala con stesso Nome o Id già presente!");
                    else
                    {
                        _controller.ChangeView("SalvaModifiche", s, _operazione);
                        this.Close();
                    }
                     

                    
                }
                catch { MessageBox.Show("Formato prezzo numero,decimali !"); }
                
            }                   
           


        }

        private void _annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
