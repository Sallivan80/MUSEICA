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
   public  class MainController : Controller
    {

       
       
       public MainController(Form view):base(view)
       {
           
           
       }

       public void ChangeView(string nomeView)
       {
           switch (nomeView)
           {
               case "Profilo":
                   SetView(new ProfiloView());
                   break;
              /* case "Cliente":
                   SetView(new ViewCliente(this));
                   break;
               case "Commesso":
                   SetView(new ViewCommesso(this));
                   break;
               case "Catalogo":
                   SetView(new ViewCatalogo(this));
                   break;
               case "Login":
                   SetView(new ViewLogin(this));
                   break;*/
               default:
                   throw new ArgumentException();
           }
       }

       

      
    }
}
