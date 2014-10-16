using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUSEICA.Persistence;
using MUSEICA.Model;
using MUSEICA.ProvaView;
using System.Windows.Forms;

namespace MUSEICA.Controllers
{
   public  class MainController : AbstractController
    {

       
       
       public MainController(Form view):base(view)
       {
           
           
       }

       public void ChangeView(string nomeView, Object selectedItem, string operazione)
       {
           switch (nomeView)
           {
               case "Profilo":
                   SetView(new ProfiloView());
                   break;
              case "ClienteView":
                   SetView(new ClienteView(operazione));
                   break;
              case "DescrizioneView":
                   SetView(new DescrizioneView(selectedItem,operazione));
                   break;
               case "PrenotazioneSingolaView":
                   SetView(new PrenotazioneSingolaView(operazione, selectedItem));
                   break;
               /* case "Login":
                   SetView(new ViewLogin(this));
                   break;*/
               default:
                   throw new ArgumentException();
           }
       }

       public ClienteRegistrato RicercaClienteRegistratoById(string idTessera)
       {
         foreach (ClienteRegistrato c in CentroSaleProve.GetIstance().Clienti)
           {
               if (c.IdTessera == idTessera)
               {
                   return c;
               }
           }

           return null;
       }

       public Sala RicercaSalaByName(string nomeSala)
       {
           foreach (Sala s in CentroSaleProve.GetIstance().Sale)
           {
               if (s.NomeSala == nomeSala)
               {
                   return s;
               }
           }
           return null;
       }





       internal Cliente RicercaClienteNormaleByName(string nome, string cognome)
       {
           foreach (Cliente c in CentroSaleProve.GetIstance().Clienti)
           {
               if (c.Nome.ToLower() == nome.ToLower() && c.Cognome.ToLower()==cognome.ToLower() && c.GetType()!=typeof(ClienteRegistrato))
               {
                   return c;
               }
           }

           return null;
       }

       public bool AggiungiPrenotazione(Prenotazione prenotazione)
       {
           if(prenotazione.GetType()==typeof(PrenotazioneSingola))
           {
               
               if (CheckPrenotazioneSingola((PrenotazioneSingola)prenotazione))
               {
                   CentroSaleProve.GetIstance().Agenda.Prenotazioni.Add(prenotazione);
                   return true;
               }
                   
           }

           if (prenotazione.GetType() == typeof(PrenotazionePeriodica))
           {               
                   CentroSaleProve.GetIstance().Agenda.Prenotazioni.Add(prenotazione);
                   return true;              
                   
           }

           return false;
       }

      

       private bool CheckPrenotazioneSingola(PrenotazioneSingola prenotazione)
       {
           foreach(PrenotazioneSingola ps in CentroSaleProve.GetIstance().Agenda.Prenotazioni)
           {
               if (ps.Data == prenotazione.Data)
               {
                   if (ps.OraInizio == prenotazione.OraInizio)
                       return false;
                   else if (ps.OraFine < prenotazione.OraInizio)
                       return false;
               }
           }

           return true;
               
       }
    }
}
