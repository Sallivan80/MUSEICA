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
    public partial class ConfermaView : Form
    {
        ControllerProfilo _controller;
        private Object _objectToChange;
        private string _operazione;
        public ConfermaView(string operazione,Object modifica)
        {
            InitializeComponent();
            this._objectToChange = modifica;
            _controller = new ControllerProfilo(this);
            this._operazione = operazione;
            SetComponent();
           
        }

        private void SetComponent()
        {
            if(_operazione=="EliminaCliente" || _operazione=="EliminaSala")
            {
                this.Text = "Conferma Eliminazione";
                _labelText.Text = "Vuoi confermare l'eliminazione?";
                _nonSalvareButton.Text = "OK";
                _salvaButton.Hide();
            }
        }

        private void _salvaButton_Click(object sender, EventArgs e)
        {

            if (_objectToChange.GetType() == typeof(Sala))                
                _controller.SaveOrUpdateSala((Sala)_objectToChange,_operazione);
            if (_objectToChange.GetType() == typeof(ClienteRegistrato))
                _controller.SaveOrUpdateClienteRegistrato((ClienteRegistrato)_objectToChange,_operazione);
            this.Close();
            

        }

        private void _annullaButton_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void _nonSalvareButton_Click(object sender, EventArgs e)
        {
            if (_operazione == "EliminaCliente")
                _controller.EliminaClienteRegistrato((ClienteRegistrato)_objectToChange);
            if (_operazione == "EliminaSala")
                _controller.EliminaSala((Sala)_objectToChange);
            this.Close();
        }

    }
}
