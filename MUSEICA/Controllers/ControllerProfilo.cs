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
           
        }

        public void ChangeView(string nomeView)
        {
            switch (nomeView)
            {
                case "AggiungiSala":
                    SetView(new AggiungiSalaView());
                    break;
                case "AggiungiCliente":
                    SetView(new RegistrazioneNuovoClienteView());
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
