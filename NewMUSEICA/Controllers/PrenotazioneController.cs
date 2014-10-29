using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using NewMUSEICA.Controllers;
using NewMUSEICA.Model;
using NewMUSEICA.View;


namespace NewMUSEICA.Controllers
{
    class PrenotazioneController : MainController
    {
      
        public PrenotazioneController() : base() { }

        public override void ChangeView(string nomeView, Object selectItem, string operazione)
        {
            switch (nomeView)
            {
                
                case "ConfermaView":
                    // ShowView(new ConfermaView(operazione, selectItem));
                    break;
                default:
                    throw new ArgumentException();
            }
        }


        internal ClienteRegistrato FindClienteRegistratoByIdTessera(string idTessera)
        {
            foreach (ClienteRegistrato cliente in CentroSaleProve.GetIstance().Clienti)
                if (cliente.IdTessera == idTessera)
                    return cliente;
            return null;
            
        }

        internal bool AggiungiPrenotazioneSingola(PrenotazioneSingola prenotazioneSingola)
        {
            if (CheckPrenotazioneSingola(prenotazioneSingola))
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

        

        public bool CheckPrenotazioneSingola(PrenotazioneSingola prenotazioneSingola)
        {
            foreach (PrenotazioneSingola p in CentroSaleProve.GetIstance().Agenda.Prenotazioni)
                if (p.Data.DayOfYear == prenotazioneSingola.Data.DayOfYear)
                    if (p.Sala.IdSala == prenotazioneSingola.Sala.IdSala)
                        if (p.OraInizio == prenotazioneSingola.OraInizio ||
                            (p.OraInizio < prenotazioneSingola.OraInizio && prenotazioneSingola.OraInizio < p.OraFine))
                            return false;
                                                  
            return true;
                            
        }

        internal bool ModificaPrenotazioneSingola(PrenotazioneSingola prenotazioneSingola)
        {
            if (CheckPrenotazioneSingola(prenotazioneSingola))
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
                    if (prenotazioneSingola.Cliente.GetType() == typeof(ClienteRegistrato)) PrezzoProvider.CalcolaScontoClienteRegistrato(prenotazioneSingola);
                    string resoconto = String.Format(" IdPrenotazione: {0} \r\n Cliente: {1} {2} \r\n Sala: {3} \r\n Data: {4}  \r\n Ora Inizio: {5} \r\n OraFine: {6} \r\n Totale: {7} €",
                        prenotazioneSingola.IdPrenotazione, prenotazioneSingola.Cliente.Nome, prenotazioneSingola.Cliente.Cognome, prenotazioneSingola.Sala.NomeSala, prenotazioneSingola.Data.ToShortDateString(),
                        prenotazioneSingola.OraInizio, prenotazioneSingola.OraFine, prenotazioneSingola.GetTotale());
                    result = MessageBox.Show(resoconto, "Conferma Prenotazione", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        CentroSaleProve.GetIstance().Agenda.AggiungiPrenotazione(prenotazioneSingola);
                        this.DataManager.SavePrenotazioni();
                        MessageBox.Show("Prenotazione aggiunta con successo ");
                    }

                    break;
                case "Modifica":
                    result = MessageBox.Show("Confermare la modifica?", "Modifica Prenotazione", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        CentroSaleProve.GetIstance().Agenda.ModificaPrenotazioneSingola(prenotazioneSingola);
                        this.DataManager.SavePrenotazioni();
                        MessageBox.Show("Prenotazione modificata con successo ");
                    }
                    break;

            }
        }

      

        internal PrenotazioneSingola FindPrenotazioneById(string idPrenotazione)
        {
            string[] splitString = idPrenotazione.Split(new Char[] { '-',':'});
            foreach (PrenotazioneSingola s in CentroSaleProve.GetIstance().Agenda.Prenotazioni)
                if (splitString[0].Trim()==s.IdPrenotazione)
                    return s;
            return null;
        }



        internal void DeletePrenotazione(string p)
        {
            Prenotazione prenotazione = FindPrenotazioneById(p);
            DialogResult result = MessageBox.Show("Confermare l'eliminazione?", "Conferma Eliminazione", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CentroSaleProve.GetIstance().Agenda.RimuoviPrenotazione(prenotazione);
                this.DataManager.DeletePrenotazione(prenotazione);
                MessageBox.Show("Prenotazione eliminata con successo ");
            }

        }

        internal void ShowAggiungiGiornoView(string idPrenotazione,ClienteRegistrato selectedClienteRegistrato, Sala selectedSala, List<PrenotazioneSingola> prenotazioniSingole)
        {
            ShowView(new AggiungiGiornoView(idPrenotazione,selectedClienteRegistrato,selectedSala,prenotazioniSingole,this));
        }

        internal void AggiungiPrenotazionePeriodica(PrenotazionePeriodica prenotazionePeriodica)
        {
            DialogResult result = DialogResult.No;
            PrezzoProvider.CalcolaScontoClienteRegistrato(prenotazionePeriodica);
            PrezzoProvider.CalcolaScontoPrenotazionePeriodica(prenotazionePeriodica);
            string resoconto = String.Format(" IdPrenotazione: {0} \r\n Cliente: {1} {2} \r\n Sala: {3} \r\n DataInizio:{4}  \r\n DatFine:{5} \r\n Totale: {6} €",
                prenotazionePeriodica.IdPrenotazione, prenotazionePeriodica.Cliente.Nome, prenotazionePeriodica.Cliente.Cognome, prenotazionePeriodica.Sala.NomeSala, prenotazionePeriodica.Prenotazioni.First().Data.ToShortDateString(),
                prenotazionePeriodica.DataFine, prenotazionePeriodica.GetTotale());
            result = MessageBox.Show(resoconto, "Conferma Prenotazione", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
                CentroSaleProve.GetIstance().Agenda.AggiungiPrenotazione(prenotazionePeriodica);
                this.DataManager.SavePrenotazioni();
                foreach (PrenotazioneSingola ps in prenotazionePeriodica.Prenotazioni)
                    CentroSaleProve.GetIstance().Agenda.AggiungiPrenotazione(ps);
                MessageBox.Show("Prenotazione aggiunta con successo ");
            }            

        }
    }
}
