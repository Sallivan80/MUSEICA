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
            string indirizzo = _textBoxPrezzoSala.Text;
            float prezzo = Convert.ToSingle(_textBoxPrezzoSala.Text);

            ITipologiaSala tipologia = TipologiaSalaFactory.GetTipologia(_comboBoxTipologia.SelectedItem.ToString());

            CentroSaleProve.GetIstance().Sale.Add(new Sala(idSala, indirizzo, nomeSala, tipologia, prezzo));
            
            this.Close();


        }

        private void _annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
