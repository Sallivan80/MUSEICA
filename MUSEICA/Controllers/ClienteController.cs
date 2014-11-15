using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.Controllers;
using MUSEICA.Model;

namespace MUSEICA.Controllers
{
    class ClienteController: MainController
    {
        public ClienteController():base(){}

      
        internal ClienteRegistrato FindClienteRegistratoByName(string nomeCognomeCliente)
        {
             string[] splitString = nomeCognomeCliente.Split(new Char[] { ' ', ',', '.', ':', '\t' });
             var query = (from cliente in CentroSaleProve.GetIstance().Clienti
                          where cliente.GetType() == typeof(ClienteRegistrato)
                          && cliente.Nome == splitString[0].Trim() && cliente.Cognome == splitString[1].Trim()
                          select cliente);      

             return query.ToList().Count==0 ? null : query.First() as ClienteRegistrato;
        }

        internal bool AggiungiClienteResitrato(ClienteRegistrato cliente)
        {
            if (FindClienteRegistratoByName(cliente.Nome.Trim() + " " + cliente.Cognome.Trim()) == null)
            {
                ShowConfirm("Aggiungi",cliente);              
                return true;
            }                
            else
            {
                MessageBox.Show("Cliente con stesso nome e cognome già presente");
                return false;
            }
               
        }
        internal bool ModificaClienteRegistrato(ClienteRegistrato cliente)
        {
            if (FindClienteRegistratoByName(cliente.Nome + " " + cliente.Cognome) != null)
            {
                ShowConfirm("Modifica", cliente);
                return true;
            }
            else
            {
                MessageBox.Show("Cliente con stesso nome e cognome già presente");
                return false;
            }

        }

        private void ShowConfirm(string operazione,ClienteRegistrato cliente)
        {
            DialogResult result = DialogResult.No;
            switch(operazione)
            {
                   
                case "Aggiungi":
                     result = MessageBox.Show("Confermare la registrazione?", "Conferma Registrazione", MessageBoxButtons.YesNo);             
                    if (result == DialogResult.Yes)
                    {
                        CentroSaleProve.GetIstance().AggiungiCliente(cliente);
                        this.DataManager.SaveClienti();
                        MessageBox.Show("Cliente registrato con successo ");
                    }
                   
                    break;
                case "Modifica":
                    result = MessageBox.Show("Confermare la modifica?", "Modifica Cliente", MessageBoxButtons.YesNo);  
                    if (result == DialogResult.Yes)
                    {
                        CentroSaleProve.GetIstance().ModificaClienteRegistrato(cliente);
                        this.DataManager.SaveClienti();
                        MessageBox.Show("Cliente moodificato con successo ");
                    }
                    break;
                       
            }
        }





        internal void EliminaClienteRegistrato(ClienteRegistrato clienteSelected)
        {
            DialogResult result = MessageBox.Show("Confermare l'eliminazione?", "Conferma Eliminazione", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CentroSaleProve.GetIstance().RimuoviCliente(clienteSelected);
                this.DataManager.DeleteCliente(clienteSelected);
                MessageBox.Show("Cliente eliminato con successo ");
            }
        }
    }
}
