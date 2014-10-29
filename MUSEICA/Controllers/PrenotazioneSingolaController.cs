using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MUSEICA.Controllers;
using MUSEICA.Model;
using MUSEICA.View;


namespace MUSEICA.Controllers
{
    class PrenotazioneSingolaController : PrenotazioneController
    {
      
        public PrenotazioneSingolaController() : base() { }    


       

        internal bool AggiungiPrenotazioneSingola(PrenotazioneSingola prenotazioneSingola)
        {
            if (CheckPrenotazione(prenotazioneSingola))
            {
                ShowConfirmPrenotazioneSingola("Aggiungi", prenotazioneSingola);
                return true;
            }
            else
            {
                MessageBox.Show("ERRORE: orario già occupato");
                return false;
            }
        }

        internal bool ModificaPrenotazioneSingola(PrenotazioneSingola prenotazioneSingola)
        {
            if (CheckPrenotazione(prenotazioneSingola))
            {
                ShowConfirmPrenotazioneSingola("Modifica", prenotazioneSingola);
                return true;
            }
            else
            {
                MessageBox.Show("ERRORE: orario già occupato");
                return false;
            }
        }

        

      

     
        private void ShowConfirmPrenotazioneSingola(string operazione, PrenotazioneSingola prenotazioneSingola)
        {
            DialogResult result = DialogResult.No;
            switch (operazione)
            {

                case "Aggiungi":
                    {
                        //Verifico se il cliente è reigstrato, in caso positivo faccio calcolare lo sconto alla classe PrezzoProvider
                        if (prenotazioneSingola.Cliente.GetType() == typeof(ClienteRegistrato)) PrezzoProvider.CalcolaScontoClienteRegistrato(prenotazioneSingola);

                        //Costruisco la stringa che mostra il resoconto della prenotazione
                        string resoconto = String.Format(" IdPrenotazione: {0} \r\n Cliente: {1} {2} \r\n Sala: {3} \r\n Data: {4}  \r\n Ora Inizio: {5} \r\n OraFine: {6} \r\n Totale: {7} €",
                            prenotazioneSingola.IdPrenotazione, prenotazioneSingola.Cliente.Nome, prenotazioneSingola.Cliente.Cognome, prenotazioneSingola.Sala.NomeSala, prenotazioneSingola.DataInizio.ToShortDateString(),
                            prenotazioneSingola.OraInizio, prenotazioneSingola.OraFine, prenotazioneSingola.GetTotale());

                        //Mostro la MessageBox, processando poi la scelta
                        result = MessageBox.Show(resoconto, "Conferma Prenotazione", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            //Aggiungo l'istanza della nuova prenotazione all'agenda
                            CentroSaleProve.GetIstance().Agenda.AggiungiPrenotazione(prenotazioneSingola);
                            //Rendo persistente su XML la nuova prenotazione
                            this.DataManager.SavePrenotazioneSingola(prenotazioneSingola);

                            MessageBox.Show("Prenotazione aggiunta con successo ");
                        }

                        break;
                    }

                case "Modifica":
                    {
                        result = MessageBox.Show("Confermare la modifica?", "Modifica Prenotazione", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            //Modifico l'istanza della prenotazione nell'agenda
                            CentroSaleProve.GetIstance().Agenda.ModificaPrenotazioneSingola(prenotazioneSingola);

                            //Rendo persistente la modifica
                            this.DataManager.UpdatePrenotazioneSingola(prenotazioneSingola);

                            MessageBox.Show("Prenotazione modificata con successo ");
                        }
                        break;
                    }

            }
        }       
    }
}
