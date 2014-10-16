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

       public List<Prenotazione> RicercaPrenotazione(Object objectToFind)
       {
           List<Prenotazione> result=new List<Prenotazione>();
           
           switch (objectToFind.GetType().ToString())
           {
               case "MUSEICA.Model.ClienteRegistrato":
                   CentroSaleProve.GetIstance().Agenda.IRicercaProvider = new RicercaCliente((Cliente)objectToFind);
                   break;
               case "MUSEICA.Model.Cliente":
                   CentroSaleProve.GetIstance().Agenda.IRicercaProvider = new RicercaCliente((Cliente)objectToFind);
                   break;
               case "System.DateTime":
                   CentroSaleProve.GetIstance().Agenda.IRicercaProvider = new RicercaData((DateTime)objectToFind);
                   break;
               case "MUSEICA.Model.Sala":
                   CentroSaleProve.GetIstance().Agenda.IRicercaProvider = new RicercaSala((Sala)objectToFind);
                   break;
               case "MUSEICA.Model.TipologiaSalaFactory+TipologiaSala":
                   CentroSaleProve.GetIstance().Agenda.IRicercaProvider = new RicercaTipo((ITipologiaSala)objectToFind);
                   break;             
               default:
                   throw new ArgumentException();
           }           
           result = CentroSaleProve.GetIstance().Agenda.RicercaPrenotazioni();
           return result;
       }



    }
}
