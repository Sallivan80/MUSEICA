using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUSEICA.Persistence;
using MUSEICA.Model;
using MUSEICA.ProvaView;

namespace MUSEICA.Controllers
{
   public abstract class Controller 
    {

       private DataManager _dataManager;
       //private Main _mainView
       
       public Controller()
       {
           this._dataManager = new DataManager();
           
       }

       public void LoadCompenents()
       {
           _dataManager.ReadAll();
           CentroSaleProve.GetIstance().Clienti=_dataManager.Clienti;
           CentroSaleProve.GetIstance().Sale = _dataManager.Sale;
           CentroSaleProve.GetIstance().Agenda.Prenotazioni = _dataManager.Prenotazioni;
       }

      
    }
}
