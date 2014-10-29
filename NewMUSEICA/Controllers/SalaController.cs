using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using NewMUSEICA.Controllers;
using NewMUSEICA.Model;


namespace NewMUSEICA.Controllers
{
     class  SalaController : MainController
    {
        public SalaController() : base() { }

        public  override void ChangeView(string nomeView, Object selectItem, string operazione)
        {
            switch (nomeView)
            {
                            
                case "ConfermaView":
                    //  ShowView(new ConfermaView(operazione, selectItem));
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public Sala FindSalaByName(string nomeSala)
        {
            if (nomeSala == null)
                return null;
            else
            {
                var query = (from sala in CentroSaleProve.GetIstance().Sale
                             where sala.NomeSala == nomeSala
                             select sala);
                return query.ToList().Count == 0 ? null : query.First() as Sala;
            }
        }


        internal bool AggiungiSala(Sala sala)
        {
            if (FindSalaByName(sala.NomeSala) == null)
            {
                ShowConfirm("Aggiungi", sala);
                return true;
            }
            else
            {
                MessageBox.Show("Sala con stesso id e nome già presente");
                return false;
            }
        }

        internal bool ModificaSala(Sala sala)
        {
            if (FindSalaByName(sala.NomeSala) != null)
            {
                ShowConfirm("Modifica", sala);
                return true;
            }
            else
            {
                MessageBox.Show("Cliente con stesso nome e cognome già presente");
                return false;
            }
        }

        private void ShowConfirm(string operazione, Sala sala)
        {
            DialogResult result = DialogResult.No;
            switch (operazione)
            {

                case "Aggiungi":
                    result = MessageBox.Show("Confermare l'aggiunta della nuova sala?", "Conferma Aggiunta SAla", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        CentroSaleProve.GetIstance().AggiungiSala(sala);
                        this.DataManager.SaveSale();
                        MessageBox.Show("Sala aggiunta con successo ");
                    }

                    break;
                case "Modifica":
                    result = MessageBox.Show("Confermare la modifica?", "Modifica Sala", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        CentroSaleProve.GetIstance().ModificaSala(sala);
                        this.DataManager.SaveSale();
                        MessageBox.Show("Sala moodificata con successo ");
                    }
                    break;

            }
        }

        internal void EliminaSala(Sala salaSelected)
        {
            DialogResult result = MessageBox.Show("Confermare l'eliminazione?", "Conferma Eliminazione", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CentroSaleProve.GetIstance().RimuoviSala(salaSelected);
                this.DataManager.DeleteSala(salaSelected);
                MessageBox.Show("Sala eliminata con successo ");
            }
        }
    }
}
