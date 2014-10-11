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
    public abstract class  Controller
    {
       private DataManager _dataManager;
       private Form _view;
       
       public Controller(Form view)
       {
           _view = view;
           if (_dataManager == null)
               _dataManager = new DataManager();
       }

       public void LoadCompenents()
       {
           _dataManager.ReadAll();
           CentroSaleProve.GetIstance().Clienti=_dataManager.Clienti;
           CentroSaleProve.GetIstance().Sale = _dataManager.Sale;
           CentroSaleProve.GetIstance().Agenda.Prenotazioni = _dataManager.Prenotazioni;
       }

       protected void SetView(Form view)
       {
           view.Activate();
           view.Show();        

       }
    }
}
