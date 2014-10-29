using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewMUSEICA.Persistence;
using NewMUSEICA.Model;
using NewMUSEICA.View;
using NewMUSEICA.Controllers;

namespace NewMUSEICA.Controllers
{
    public class MainController
    {
        private DataManager _dataManager;       
        

        public MainController()
        {           
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

        protected void ShowView(Form view)
        {
            view.Activate();
            view.Show();

        }
       
        public DataManager DataManager
        {
            get { return _dataManager; }
        }

        public  List<Prenotazione> RicercaPrenotazionePerCliente(string cliente)
        {
            string[] splitString = cliente.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            List<Prenotazione> result = new List<Prenotazione>();
            if (splitString.Length != 2)
                MessageBox.Show("Inserire <Nome> <Cognome>");
            else
            {
                CentroSaleProve.GetIstance().Agenda.IRicercaProvider = new RicercaCliente(splitString[0], splitString[1]);
                result= CentroSaleProve.GetIstance().Agenda.RicercaPrenotazioni();
            }
            return result;
        }

        public  List<Prenotazione> RicercaPrenotazionePerData(DateTime dateTime)
        {
            CentroSaleProve.GetIstance().Agenda.IRicercaProvider = new RicercaData(dateTime);
            return CentroSaleProve.GetIstance().Agenda.RicercaPrenotazioni();
        }

        public  List<Prenotazione> RicercaPrenotazionePerIdSala(string idSala)
        {
            CentroSaleProve.GetIstance().Agenda.IRicercaProvider = new RicercaSala(idSala);
            return CentroSaleProve.GetIstance().Agenda.RicercaPrenotazioni();
        }

        public  List<Prenotazione> RicercaPrenotazionePerTipo(ITipologiaSala tipologiaSala)
        {
            CentroSaleProve.GetIstance().Agenda.IRicercaProvider = new RicercaTipo(tipologiaSala);
            return CentroSaleProve.GetIstance().Agenda.RicercaPrenotazioni();
        }

        public virtual void ChangeView(string nomeView, Object selectedItem, string operazione)
        {
            switch (nomeView)
            {
                case "ProfiloView":
                     ShowView(new ProfiloView(new ProfiloController()));
                     break;
                case "ClienteView":
                     ShowView(new ClienteView(new ClienteController(), operazione,(string)selectedItem));
                    break;
                case "PrenotazioneSingolaView":
                     ShowView(new PrenotazioneSingolaView(selectedItem, operazione));
                    break;               
                case "PrenotazionePeriodicaView":
                     ShowView(new PrenotazionePeriodicaView());
                    break;
                default:
                    throw new ArgumentException();
            }
        }




       
    }
}
