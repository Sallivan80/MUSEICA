using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUSEICA.Persistence;
using MUSEICA.ProvaView;
using MUSEICA.Model;
using System.Windows.Forms;

namespace MUSEICA.Controllers
{
    public class ControllerProfilo:Controller
    {
        private Form _view;
        
        public ControllerProfilo(Form view):base(view)
        {
            this._view = view;
        }

        public bool CheckSala(Sala s)
        {
            foreach(Sala sala in CentroSaleProve.GetIstance().Sale)
            {
                if (sala.NomeSala == s.NomeSala || sala.IdSala == s.IdSala)
                    return false;
            }
            return true;
        }

        public bool CheckClienteRegistrato(ClienteRegistrato c)
        {
            foreach (Cliente cliente in CentroSaleProve.GetIstance().Clienti)
            {
                if (cliente.GetType() == typeof(ClienteRegistrato))
                {
                    ClienteRegistrato cr = (ClienteRegistrato)cliente;
                    if (cr.IdTessera == c.IdTessera || (c.Nome == cr.Nome && c.Cognome == cr.Cognome))
                        return false;
                }
            }
            return true;
                    
        }

        public void ChangeView(string nomeView, Object selectItem,string operazione)
        {
            switch (nomeView)
            {
                
                case "SalaView":
                    SetView(new SalaView(operazione, selectItem));
                    break;                
                 case "ClienteView":
                     SetView(new ClienteView(operazione, selectItem));
                     break;               
                 case "StoricoCliente":
                     SetView(new StoricoView(selectItem));
                     break;
                 case "ConfermaView":
                     SetView(new ConfermaView(operazione,selectItem));
                     break;
                default:
                    throw new ArgumentException();
            }
        }





        internal void SaveOrUpdateSala(Sala s, string _operazione)
        {
            if ( _operazione == "Aggiungi")            
                CentroSaleProve.GetIstance().Sale.Add(s);                       
            
            if (_operazione == "Modifica")
            {
                foreach (Sala temp in CentroSaleProve.GetIstance().Sale)
                    if (s.IdSala == temp.IdSala)
                    {
                        temp.Indirizzo = s.Indirizzo;
                        temp.Prezzo = s.Prezzo;
                        temp.Tipo = s.Tipo;                        
                        break;
                    }
            }            

            SaveSale();
            
        }

        internal void SaveOrUpdateClienteRegistrato(ClienteRegistrato clienteRegistrato, string _operazione)
        {
            if (_operazione == "Aggiungi")
               CentroSaleProve.GetIstance().Clienti.Add(clienteRegistrato);            
            
                
            if (_operazione == "Modifica")
            {
                foreach (Cliente c in CentroSaleProve.GetIstance().Clienti)
                    if (c.GetType() == typeof(ClienteRegistrato))
                    {
                        ClienteRegistrato temp = (ClienteRegistrato)c;
                        if(temp.IdTessera==clienteRegistrato.IdTessera)
                        {
                            temp.Indirizzo = clienteRegistrato.Indirizzo;
                            temp.Telefono = clienteRegistrato.Telefono;
                            temp.ScadenzaTessera = clienteRegistrato.ScadenzaTessera;
                            break;
                        }
                        
                    }
            }            

            SaveClienti();
        }



        internal void EliminaClienteRegistrato(ClienteRegistrato _clienteSelected)
        {
            
            CentroSaleProve.GetIstance().RimuoviClienteRegistrato(_clienteSelected);
            DeleteClienteRegistrato(_clienteSelected);
        }

        internal void EliminaSala(Sala sala)
        {
            CentroSaleProve.GetIstance().RimuoviSala(sala);
            DeleteSala(sala); 
        }

       
    }
}
