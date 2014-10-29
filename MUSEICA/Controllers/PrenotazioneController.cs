using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.Model;
using MUSEICA.View;

namespace MUSEICA.Controllers
{
    class PrenotazioneController:MainController
    {

        
        internal bool CheckPrenotazione(Prenotazione prenotazione)
        {
            bool trovato =true;

            //Verifico il tipo di prenotazione passata
            if(prenotazione.GetType()==typeof(PrenotazioneSingola))
            {
                //Controllo prima sovrapposizione con le prenotazioniSingole
               PrenotazioneSingola  prenotazioneToCheck=prenotazione as PrenotazioneSingola;
               var querySingola = from prenotazioniSingole in CentroSaleProve.GetIstance().Agenda.Prenotazioni
                           where prenotazioniSingole.GetType() == typeof(PrenotazioneSingola)
                           select prenotazioniSingole;

               foreach (PrenotazioneSingola p in querySingola)
                     if (p.DataInizio.DayOfYear == prenotazioneToCheck.DataInizio.DayOfYear)
                           if (p.Sala.IdSala == prenotazioneToCheck.Sala.IdSala)
                              if (p.OraInizio == prenotazioneToCheck.OraInizio ||
                                   (p.OraInizio < prenotazioneToCheck.OraInizio && prenotazioneToCheck.OraInizio < p.OraFine))
                              {
                                  trovato = false;
                                  break;
                              }
                                        

                //Poi controllo le prenotazioniSingole all'interno delle prenotazioniPeriodiche
                 var queryPeriodica = from prenotazioniPeriodiche in CentroSaleProve.GetIstance().Agenda.Prenotazioni
                             where prenotazioniPeriodiche.GetType() == typeof(PrenotazionePeriodica)
                             select prenotazioniPeriodiche;

                foreach(PrenotazionePeriodica pp in queryPeriodica)
                    foreach(PrenotazioneSingola ps in pp.Prenotazioni)
                         if (ps.DataInizio.DayOfYear == prenotazioneToCheck.DataInizio.DayOfYear)
                           if (ps.Sala.IdSala == prenotazioneToCheck.Sala.IdSala)
                              if (ps.OraInizio == prenotazioneToCheck.OraInizio ||
                                   (ps.OraInizio < prenotazioneToCheck.OraInizio && prenotazioneToCheck.OraInizio < ps.OraFine))
                              {
                                  trovato = false;
                                  break;
                              }
                                  

            }

            else if(prenotazione.GetType()==typeof(PrenotazionePeriodica))
            {
                 PrenotazionePeriodica prenotazioneToCheck=prenotazione as PrenotazionePeriodica;
                foreach(PrenotazioneSingola ps in prenotazioneToCheck.Prenotazioni)
                    //Mando in ricorsione la funzione che verifichera per ogni prenotazioneSingola che stiamo andando ad aggiungere 
                    //non ci sia una sovrapposizione
                    CheckPrenotazione(ps);

            }



            return trovato;

        }

        internal PrenotazioneSingola FindPrenotazioneSingolaById(string selectedStringListBoxRisultatiRicerca)
        {
            string[] splitString = selectedStringListBoxRisultatiRicerca.Split(new Char[] { '-', ':',' ' });
            string idPrenotaizone = splitString[0].Trim();
            string data=splitString[8].Trim();
            if (idPrenotaizone.StartsWith("P"))
            {
                foreach (Prenotazione p in CentroSaleProve.GetIstance().Agenda.Prenotazioni)
                    if (p.IdPrenotazione == idPrenotaizone && p.GetType()==typeof(PrenotazionePeriodica))
                        foreach (PrenotazioneSingola ps in (p as PrenotazionePeriodica).Prenotazioni)
                            if (ps.DataInizio.ToShortDateString() == data)
                                return ps;


            }
            else
            {
                foreach (Prenotazione p in CentroSaleProve.GetIstance().Agenda.Prenotazioni)
                    if (idPrenotaizone == p.IdPrenotazione)
                        return (p as PrenotazioneSingola);
            }
            return null;
        }

        internal ClienteRegistrato FindClienteRegistratoByIdTessera(string idTessera)
        {
            foreach (ClienteRegistrato cliente in CentroSaleProve.GetIstance().Clienti)
                if (cliente.IdTessera == idTessera)
                    return cliente;
            return null;

        }

        internal void DeletePrenotazione(string p)
        {
            Prenotazione prenotazione = FindPrenotazioneSingolaById(p);
            DialogResult result = MessageBox.Show("Confermare l'eliminazione?", "Conferma Eliminazione", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CentroSaleProve.GetIstance().Agenda.RimuoviPrenotazione(prenotazione);
                this.DataManager.DeletePrenotazione(prenotazione);
                MessageBox.Show("Prenotazione eliminata con successo ");
            }

        }


    }
}
