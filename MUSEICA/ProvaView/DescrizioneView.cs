using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.Model;
using MUSEICA.Controllers;
using MUSEICA.Persistence;
using MUSEICA.Properties;

namespace MUSEICA.ProvaView
{
    public partial class DescrizioneView : Form
    {
        private string nomeTipologia;

        public DescrizioneView(Object selectedItem)
        {
            InitializeComponent(); 
            this.nomeTipologia = (string) selectedItem;
            SetValue();
        }

        private void SetValue()
        {
            this.Text = "Sala " + nomeTipologia;
            
            this._descrizioneTipologia.Text = TipologiaSalaFactory.GetTipologia(nomeTipologia).Descrizione;
        }
    }
}
