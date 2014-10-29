using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.Persistence;
using MUSEICA.View;
using MUSEICA.Model;
using MUSEICA.Controllers;

namespace MUSEICA.Controllers
{
    public class ProfiloController : MainController
    {
       private SalaController _controllerSala;
       private ClienteController _controllerCliente;
       private ClienteRegistrato _clienteSelected;
       private Sala _salaSelected;

        public ProfiloController()
            : base()
        {
            if (_controllerSala == null)
                _controllerSala = new SalaController();
            if (_controllerCliente == null)
                _controllerCliente = new ClienteController();
        }      

      

        public override void ChangeView(string nomeView, Object selectItem, string operazione)
        {
            switch (nomeView)
            {

                case "SalaView":
                      ShowView(new SalaView(_controllerSala,operazione, (string)selectItem));
                    break;
                case "ClienteView":
                     ShowView(new ClienteView(_controllerCliente,operazione,(string)selectItem));
                    break;
                case "StoricoView":
                       ShowView(new StoricoView(selectItem,operazione));
                    break;              
                default:
                    throw new ArgumentException();
            }
        }

        internal void UpdateListBoxDescrizioneSale(string nomeSala, ListBox _listBoxDescrizioneSale)
        {
            _salaSelected = _controllerSala.FindSalaByName(nomeSala);  

            _listBoxDescrizioneSale.Items.Clear();
            _listBoxDescrizioneSale.Items.Add("IdSala: " + _salaSelected.IdSala);
            _listBoxDescrizioneSale.Items.Add("Indirizzo: " + _salaSelected.Indirizzo);
            _listBoxDescrizioneSale.Items.Add("Tipologia: " + _salaSelected.Tipo.NomeTipologia);
            _listBoxDescrizioneSale.Items.Add("Prezzo: " + _salaSelected.Prezzo + "  €/h ");
        }

        internal void UpdateListBoxDescrizioneClienti(string nomeCognomeCliente, ListBox _listBoxDettagliCliente)
        {
           _clienteSelected = _controllerCliente.FindClienteRegistratoByName(nomeCognomeCliente);

            _listBoxDettagliCliente.Items.Clear();
            _listBoxDettagliCliente.Items.Add("IdTessera: " + _clienteSelected.IdTessera);
            _listBoxDettagliCliente.Items.Add("Indirizzo: " + _clienteSelected.Indirizzo);
            _listBoxDettagliCliente.Items.Add("Telefono: " + _clienteSelected.Telefono);
            _listBoxDettagliCliente.Items.Add("Scadenza Tessera: " + _clienteSelected.ScadenzaTessera.ToShortDateString());
        }

        internal void DeleteClienteRegistrato(string nomeCognomeCliente)
        {
           
            _controllerCliente.EliminaClienteRegistrato(_controllerCliente.FindClienteRegistratoByName(nomeCognomeCliente));           
        }

        internal void DeleteSala(string nomeSala)
        {
            _salaSelected = _controllerSala.FindSalaByName(nomeSala);
            _controllerSala.EliminaSala(_salaSelected);
        }
    }
}
