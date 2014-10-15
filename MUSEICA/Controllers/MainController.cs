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
                   SetView(new DescrizioneView(selectedItem));
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

       public ClienteRegistrato RicercaClienteRegistrato(string idTessera)
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

       public Sala RicercaSala(string nomeSala)
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

      
    }
}
