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
    public partial class AggiungiSalaView : Form
    {
        ControllerProfilo _controller;
        public AggiungiSalaView()
        {
            InitializeComponent();
            _controller=new ControllerProfilo(this);
            SetFormValue();
            
        }

        private void SetFormValue()
        {
            foreach (ITipologiaSala t in TipologiaSalaFactory.GetTipologie())
                _comboBoxTipologia.Items.Add(t.NomeTipologia);            
                
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
                tipologiaString = _comboBoxTipologia.SelectedItem.ToString();
                float prezzo = 0; 
                try
                {
                    prezzo = Convert.ToSingle(prezzoString);
                    ITipologiaSala tipologia = TipologiaSalaFactory.GetTipologia(_comboBoxTipologia.SelectedItem.ToString());
                    CentroSaleProve.GetIstance().Sale.Add(new Sala(idSala, indirizzo, nomeSala, tipologia, prezzo));
                    this.Close();
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
