using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.Persistence;
using MUSEICA.Model;

namespace MUSEICA.Controllers
{
    public abstract class  AbstractController
    {
       private DataManager _dataManager;
       private Form _view;
       
       public AbstractController(Form view)
       {
           _view = view;
           if (_dataManager == null)
               _dataManager = new DataManager();
       }

       public void LoadCompenents()
       {
           _dataManager.ReadAll();          
       }

        public void SaveAll()
       {
           _dataManager.SaveAll();
       }

        protected void SaveClienti()
        {
            _dataManager.SaveClienti();
        }

        protected void SaveSale()
        {
            _dataManager.SaveSale();
        }

        protected void SavePrenotazioni()
        {
            _dataManager.SavePrenotazioni();
        }
        protected void DeleteClienteRegistrato(ClienteRegistrato cliente)
        {
            _dataManager.DeleteCliente(cliente);
        }

        protected void DeleteSala(Sala s)
        {
            _dataManager.DeleteSala(s);
        }

       protected void SetView(Form view)
       {
           view.Activate();
           view.Show();        

       }

       public List<Prenotazione> RicercaPrenotazioneCliente(Cliente cliente)
       {
           List<Prenotazione> result=new List<Prenotazione>();
           CentroSaleProve.GetIstance().Agenda.IRicercaProvider = new RicercaCliente(cliente);
           result = CentroSaleProve.GetIstance().Agenda.RicercaPrenotazioni();
           return result;
       }

    }
}
