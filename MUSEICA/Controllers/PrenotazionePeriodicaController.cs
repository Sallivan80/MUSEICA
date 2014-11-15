using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.View;
using MUSEICA.Model;

namespace MUSEICA.Controllers
{
    class PrenotazionePeriodicaController : PrenotazioneController
    {

        public PrenotazionePeriodicaController() : base() { }

        internal void ShowAggiungiGiornoView(string idPrenotazione,ClienteRegistrato selectedClienteRegistrato, Sala selectedSala, List<PrenotazioneSingola> prenotazioniSingole)
        {
            ShowView(new AggiungiGiornoView(idPrenotazione,selectedClienteRegistrato,selectedSala,prenotazioniSingole,this));
        }

        internal void AggiungiPrenotazionePeriodica(PrenotazionePeriodica prenotazionePeriodica,List<PrenotazioneSingola> prenotazioniSingoleToCreate)
        {

            CreaPrenotazionePeriodica(prenotazioniSingoleToCreate, prenotazionePeriodica);
            if (CheckPrenotazione(prenotazionePeriodica))
            {
                DialogResult result = DialogResult.No;
                PrezzoProvider.CalcolaScontoPrenotazionePeriodica(prenotazionePeriodica);
                string resoconto = String.Format(" IdPrenotazione: {0} \r\n Cliente: {1} {2} \r\n Sala: {3} \r\n DataInizio:{4}  \r\n DatFine:{5} \r\n Totale: {6} €",
                    prenotazionePeriodica.IdPrenotazione, prenotazionePeriodica.Cliente.Nome, prenotazionePeriodica.Cliente.Cognome, prenotazionePeriodica.Sala.NomeSala, prenotazionePeriodica.DataInizio.ToShortDateString(),
                    prenotazionePeriodica.DataFine, prenotazionePeriodica.Totale);
                result = MessageBox.Show(resoconto, "Conferma Prenotazione", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    CentroSaleProve.GetIstance().Agenda.AggiungiPrenotazione(prenotazionePeriodica);
                    this.DataManager.SavePrenotazionePeriodica(prenotazionePeriodica);

                    MessageBox.Show("Prenotazione aggiunta con successo ");
                }
            }

        }

        private void CreaPrenotazionePeriodica(List<PrenotazioneSingola>prenotazioniSingole,PrenotazionePeriodica prenotazionePeriodica)
        {
            

            foreach (PrenotazioneSingola ps in prenotazioniSingole)
            {
                for (int i = 0; i < prenotazionePeriodica.DataFine.DayOfYear - ps.DataInizio.DayOfYear; i++)
                {
                    DateTime dataTemp = ps.DataInizio.AddDays(7 * i);
                    if (dataTemp.CompareTo(prenotazionePeriodica.DataFine) < 0)
                    {
                        PrenotazioneSingola newPrenotazioneSingola = new PrenotazioneSingola(prenotazionePeriodica.IdPrenotazione, prenotazionePeriodica.Cliente, prenotazionePeriodica.Sala, dataTemp, ps.OraInizio, ps.OraFine);
                        prenotazionePeriodica.Prenotazioni.Add(newPrenotazioneSingola);
                    }
                    else
                        break;
                }

            }
        }



        internal void UpdatePrenotazionePeriodica(PrenotazioneSingola newPrenotazioneSingola, PrenotazioneSingola oldPrenotazioneSingola)
        {
            DialogResult result = DialogResult.No;
            if(CheckPrenotazione(newPrenotazioneSingola))
            {
                result = MessageBox.Show("Confermare la modifica?", "Modifica Prenotazione", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Modifico l'istanza della prenotazione nell'agenda
                    PrenotazionePeriodica prenotazionePeriodicaToUpdate= CentroSaleProve.GetIstance().Agenda.ModificaPrenotazionePeriodica(newPrenotazioneSingola,oldPrenotazioneSingola);
                                        
                    //Rendo persistente la modifica
                    this.DataManager.UpdatePrenotazionePeriodica(prenotazionePeriodicaToUpdate);

                    MessageBox.Show("Prenotazione modificata con successo ");
                }
            }
            
                            
        }

      
    }
}
