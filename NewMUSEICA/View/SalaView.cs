using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewMUSEICA.Model;
using NewMUSEICA.Controllers;

namespace NewMUSEICA.View
{
    public partial class SalaView : Form
    {
        private string _operazione;
        private SalaController _controllerSala;
        private Sala _selectedSala;

     

        public SalaView(MainController controller,string operazione,string _selectedItemString)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this._operazione = operazione;
            _controllerSala = controller as SalaController;
            _selectedSala = _controllerSala.FindSalaByName(_selectedItemString);
        }

        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
            switch (_operazione)
            {
                case "Aggiungi":
                    this.Text = "Aggiungi Nuova Sala";
                    _buttonOK.Text = "Aggiungi";
                    AggiungiModeComponents();
                    break;
                case "Modifica":
                    this.Text = "Modifica Sala";
                    _buttonOK.Text = "Modifica";
                    ModificaModeComponents();
                    break;

            }
          
        }

        private void AggiungiModeComponents()
        {
            Random rnd = new Random();
            _textBoxIdSala.Text = "000" + (rnd.Next(CentroSaleProve.GetIstance().Clienti.Count, 1000000000));
            LoadComboBoxTipologiaValue();
        }

        private void LoadComboBoxTipologiaValue()
        {
            foreach (ITipologiaSala tipologia in TipologiaSalaFactory.GetTipologie())
                _comboBoxTipologia.Items.Add(tipologia.NomeTipologia);
        }

        private void ModificaModeComponents()
        {
           
            _textBoxIdSala.Text = _selectedSala.IdSala;
            _textBoxNomeSala.Text = _selectedSala.NomeSala;
            _comboBoxTipologia.Text = _selectedSala.Tipo.NomeTipologia;
            _textBoxIndirizzoSala.Text = _selectedSala.Indirizzo;
            _textBoxPrezzoSala.Text = _selectedSala.Prezzo.ToString();
            LoadComboBoxTipologiaValue();

            _textBoxIdSala.Enabled = false;
            _textBoxNomeSala.Enabled = false;
            
        }

        private void _buttonOK_Click(object sender, EventArgs e)
        {
            Sala sala=null;
            if (CheckParameters())
            {
                try
                {
                    sala = new Sala(_textBoxIdSala.Text, _textBoxIndirizzoSala.Text, _textBoxNomeSala.Text,
                    TipologiaSalaFactory.GetTipologia(_comboBoxTipologia.SelectedItem.ToString()), Convert.ToSingle(_textBoxPrezzoSala.Text));

                    switch (_operazione)
                    {
                        case "Aggiungi":
                            if (_controllerSala.AggiungiSala(sala))
                                this.Close();
                            break;
                        case "Modifica":
                            if (_controllerSala.ModificaSala(sala))
                                this.Close();
                            break;

                    }
                }catch(FormatException ex)
                {
                    MessageBox.Show("Formato prezzo: [number],[decimal], "+ex.ToString());
                }
            }    
        }

        private bool CheckParameters()
        {
            if (_textBoxNomeSala.Text == "" || _textBoxIdSala.Text == "" || _textBoxIndirizzoSala.Text == "" || _textBoxPrezzoSala.Text=="" || _comboBoxTipologia.SelectedItem==null)
            {
                MessageBox.Show("Tutti i campi devono essere selezionati o compilati");
                return false;
            }

            return true;
        }

       

      
    }
}
