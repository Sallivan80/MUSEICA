using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using MUSEICA.Model;

namespace MUSEICA.Persistence
{
    class PrenotazionePersister:IPrenotazionePersister
    {
        private readonly string _fileNamePrenotazioni;

         public PrenotazionePersister(string fileNamePrenotazioni)
        {
            _fileNamePrenotazioni = fileNamePrenotazioni;
        }

         #region GetLoader GetSaver GetRemover
         public IPrenotazioneLoader GetLoader(string type)
        {
            switch (type)
            {
                case "XML":
                    return new PrenotazioneXmlLoader(_fileNamePrenotazioni);
                default:
                    throw new ArgumentException("Type non esistente");
            }
        }
         public IPrenotazioneSaver GetSaver(string type)
        {
            switch (type)
            {
                case "XML":
                    return new PrenotazioneXmlSaver(_fileNamePrenotazioni);
                default:
                    throw new ArgumentException("Tipo saver non disponibile");
            }
        }
         public IPrenotazioneRemover GetRemover(string type)
         {
             switch (type)
             {
                 case "XML":
                     return new PrenotazioneXmlRemover(_fileNamePrenotazioni);
                 default:
                     throw new ArgumentException("Tipo saver non disponibile");
             }
         }
         #endregion


         private class PrenotazioneXmlRemover : IPrenotazioneRemover
         {
             private string _fileName;

             public PrenotazioneXmlRemover(string fileName)
             {
                 this._fileName = fileName;
             }

             public void RemovePrenotazione(Prenotazione p)
             {
                 var doc = XDocument.Load(_fileName);
                 //qui faccio una query LINQ che mi estrae i nodi interessati
                 var nodiDaRimuovere = from nodo in doc.Descendants("IdPrenotazione") //seleziono i nodi chiamati "IdTessera"
                                       where nodo.Value == p.IdPrenotazione//ecco la clausola where in cui controllo il valore del nodo                                      
                                       select nodo.Parent;                  //seleziono il genitore, cioè il cliente
                 //rimuovo tutti i nodi trovati
                 nodiDaRimuovere.Remove();
                 doc.Save(_fileName);
             }

         }
        

         #region PrenotazioneXmlLoader

         private class PrenotazioneXmlLoader : IPrenotazioneLoader
        {
            private readonly XmlDocument _xmlDocument;

            #region Costruttore

            public PrenotazioneXmlLoader(string fileName)
            {
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            #endregion

            #region IPrenotazioneLoader

            public List<PrenotazioneSingola> LoadPrenotazioniSingole()
            {
                List<PrenotazioneSingola> prenotazioniSingole = new List<PrenotazioneSingola>();

                XmlNodeList nodes = _xmlDocument.DocumentElement.SelectNodes("/Prenotazioni/PrenotazioneSingola");

                foreach (XmlNode node in nodes)
                {
                    string idPrenotazione = node.SelectSingleNode("IdPrenotazione").InnerText;
                    Cliente cliente = LoadClienteNodes(node.SelectSingleNode("Cliente"));
                    Sala sala = LoadSalaNodes(node.SelectSingleNode("Sala"));
                    DateTime data = DateTime.Parse (node.SelectSingleNode("DataInizio").InnerText);
                    int oraInizio = Convert.ToInt32( node.SelectSingleNode("OraInizio").InnerText);
                    int oraFine = Convert.ToInt32(node.SelectSingleNode("OraFine").InnerText);                    
                    float totale = Convert.ToSingle(node.SelectSingleNode("Totale").InnerText);
                    PrenotazioneSingola prenotazione= new PrenotazioneSingola( idPrenotazione,cliente, sala, data,oraInizio,oraFine);
                    prenotazione.Totale = totale;

                    prenotazioniSingole.Add(prenotazione);
                }
                return prenotazioniSingole;
            }

           
            public List<PrenotazionePeriodica> LoadPrenotazioniPeriodiche()
            {
                
                List<PrenotazionePeriodica> prenotazionePeriodiche = new List<PrenotazionePeriodica>();

                XmlNodeList nodeListPrenotazionePeriodica = _xmlDocument.DocumentElement.SelectNodes("/Prenotazioni/PrenotazionePeriodica");
               
                foreach (XmlNode node in nodeListPrenotazionePeriodica)
                {
                    //Recupero le istanze che sono comuni anche alle prenotazioni singole intere, quali Id Cliente Sala DataInizio
                    string idPrenotazionePeriodica = node.SelectSingleNode("IdPrenotazione").InnerText;
                    Cliente cliente = LoadClienteNodes(node.SelectSingleNode("Cliente"));
                    Sala sala = LoadSalaNodes(node.SelectSingleNode("Sala"));
                    DateTime dataInizio = DateTime.Parse(node.SelectSingleNode("DataInizio").InnerText); 
                    DateTime dataFine=DateTime.Parse( node.SelectSingleNode("DataFine").InnerText);                    
                    XmlNodeList nodesPrenotazioniSingole = node.SelectNodes("PrenotazioneSingola"); 

                    //Carico le prenotazioni singole delle della prenotazione perdiodica
                    List<PrenotazioneSingola> prenotazioniSingoleInPeriodica = LoadPrenotazioniSingoleNodes(idPrenotazionePeriodica,cliente,sala,nodesPrenotazioniSingole);
                   
                    //Costruisco l'istanza di prenotazione periodica e l'aggiungo alla lista
                    prenotazionePeriodiche.Add(new PrenotazionePeriodica(idPrenotazionePeriodica,cliente,sala,dataInizio,dataFine,prenotazioniSingoleInPeriodica));                
                   
                }
                return prenotazionePeriodiche;
                
            }

            private List<PrenotazioneSingola> LoadPrenotazioniSingoleNodes(string idPrenotazionePeriodica, Cliente cliente, Sala sala, XmlNodeList nodesPrenotazioniSingole)
            {

                List<PrenotazioneSingola> result = new List<PrenotazioneSingola>();
                foreach (XmlNode node in nodesPrenotazioniSingole)
                {                   
                    DateTime data = DateTime.Parse(node.SelectSingleNode("DataInizio").InnerText);
                    int oraInizio = Convert.ToInt32(node.SelectSingleNode("OraInizio").InnerText);
                    int oraFine = Convert.ToInt32(node.SelectSingleNode("OraFine").InnerText);                   
                    float totale = Convert.ToSingle(node.SelectSingleNode("Totale").InnerText);

                    //NOTA BENE: IdPrenotazione Cliente Sala vengono passate al metodo perchè sono le stesse istanze della prenotazione periodica
                    PrenotazioneSingola prenotazione = new PrenotazioneSingola(idPrenotazionePeriodica, cliente, sala, data, oraInizio, oraFine);
                    prenotazione.Totale = totale;
                    result.Add(prenotazione);
                }

                return result;
            }

            #region private Method LoadClienteNodes - LoadSalaNodes - LoadPrenotazioniSingoleNodes
            private Cliente LoadClienteNodes(XmlNode clienteNode)
            {
                //NOTA BENE : Le prenotazioni Periodiche sono effettuabili solo da Clienti Registrati
                Cliente result = null; 
                string IdTessera=null;
                DateTime dataScadenza=new DateTime();

                string nome = clienteNode.SelectSingleNode("Nome").InnerText;
                string cognome = clienteNode.SelectSingleNode("Cognome").InnerText;
                string telefono = clienteNode.SelectSingleNode("Telefono").InnerText;
                string indirizzo = clienteNode.SelectSingleNode("Indirizzo").InnerText;

                if (clienteNode.SelectSingleNode("IdTessera") != null)
                {
                    IdTessera = clienteNode.SelectSingleNode("IdTessera").InnerText;
                    dataScadenza = Convert.ToDateTime(clienteNode.SelectSingleNode("ScadenzaTessera").InnerText);
                    result = new ClienteRegistrato(nome, cognome, telefono, indirizzo, IdTessera, dataScadenza);
                }
                else
                    result = new Cliente(nome, cognome, telefono, indirizzo);
                                   
                
              
                    
                         
                return result;
            }

            private Sala LoadSalaNodes(XmlNode salaNode)
            {
                Sala result = null; 

                string idSala = salaNode.SelectSingleNode("IdSala").InnerText;
                string indirizzo = salaNode.SelectSingleNode("Indirizzo").InnerText;
                string nomeSala = salaNode.SelectSingleNode("NomeSala").InnerText;
                ITipologiaSala tipologia = TipologiaSalaFactory.GetTipologia(salaNode.SelectSingleNode("Tipologia").InnerText);
                XmlNode prezzoNode = salaNode.SelectSingleNode("Prezzo");
                float prezzo = Convert.ToSingle(prezzoNode.InnerText);
                    result = new Sala(idSala, indirizzo, nomeSala, tipologia,prezzo);
                return result;
            }

            

            #endregion
        }

            #endregion
        #endregion

        #region PrenotazioneXmlSaver

        private class PrenotazioneXmlSaver : IPrenotazioneSaver
        {
            private XmlDocument _xmlDocument;
            private string _fileName;

            #region Costruttore

            public PrenotazioneXmlSaver(string fileName)
            {
                _fileName = fileName;
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            #endregion
            #region SaveOrUpdatePrenotazioneSingola
            /*
            public void UpdatePrenotazioneSingola(PrenotazioneSingola prenotazioneSingolaToUpdate)
            {
                               
                XmlNodeList nodes = _xmlDocument.SelectNodes("/Prenotazioni/PrenotazioneSingola");

                foreach (XmlNode node in nodes)
                {
                    string idPrenotazione = node.SelectSingleNode("IdPrenotazione").InnerText;

                    if (idPrenotazione.ToLower() == prenotazioneSingolaToUpdate.IdPrenotazione.ToLower())
                    {
                        node.SelectSingleNode("DataInizio").InnerText = prenotazioneSingolaToUpdate.DataInizio.ToShortDateString();
                        node.SelectSingleNode("OraInizio").InnerText = prenotazioneSingolaToUpdate.OraInizio.ToString();
                        node.SelectSingleNode("OraFine").InnerText = prenotazioneSingolaToUpdate.OraFine.ToString();
                        node.SelectSingleNode("Totale").InnerText = prenotazioneSingolaToUpdate.GetTotale().ToString();                                     
                        
                    }
                }
              
                _xmlDocument.Save(_fileName);
            }
            */
            public void SavePrenotazioneSingola(PrenotazioneSingola prenotazioneSingolaToSave)
            {              
                XmlNodeList nodes = _xmlDocument.SelectNodes("/Prenotazioni/PrenotazioneSingola");
                XmlElement prenotazioneSingolaNode = _xmlDocument.CreateElement("PrenotazioneSingola");
                CreaNodoPrenotazioneSingola(prenotazioneSingolaNode, prenotazioneSingolaToSave);
                _xmlDocument.DocumentElement.InsertAfter(prenotazioneSingolaNode, _xmlDocument.DocumentElement.LastChild);
                _xmlDocument.Save(_fileName);
            }

            private void CreaNodoPrenotazioneSingola(XmlElement prenotazioneSingolaNode, PrenotazioneSingola prenotazioneSingola)
            {
                XmlElement idPrenotazioneElement = _xmlDocument.CreateElement("IdPrenotazione");
                XmlElement clienteNode = _xmlDocument.CreateElement("Cliente");
                XmlElement salaNode = _xmlDocument.CreateElement("Sala");
                XmlElement dataElement = _xmlDocument.CreateElement("DataInizio");
                XmlElement oraInizioElement = _xmlDocument.CreateElement("OraInizio");
                XmlElement oraFineElement = _xmlDocument.CreateElement("OraFine");             
                XmlElement totaleElement = _xmlDocument.CreateElement("Totale");


                idPrenotazioneElement.InnerText = prenotazioneSingola.IdPrenotazione;

                //CLIENTE
                CreaNodoCliente(clienteNode, prenotazioneSingola);
                //SALA
                CreaNodoSala(salaNode, prenotazioneSingola);

                dataElement.InnerText = prenotazioneSingola.DataInizio.ToString();
                oraInizioElement.InnerText = prenotazioneSingola.OraInizio.ToString();
                oraFineElement.InnerText = prenotazioneSingola.OraFine.ToString();               
                totaleElement.InnerText = prenotazioneSingola.GetTotale().ToString();


                prenotazioneSingolaNode.AppendChild(idPrenotazioneElement);
                prenotazioneSingolaNode.AppendChild(clienteNode);
                prenotazioneSingolaNode.AppendChild(salaNode);
                prenotazioneSingolaNode.AppendChild(dataElement);
                prenotazioneSingolaNode.AppendChild(oraInizioElement);
                prenotazioneSingolaNode.AppendChild(oraFineElement);              
                prenotazioneSingolaNode.AppendChild(totaleElement);
            }
            #endregion

            #region SaveOrUpdate PrenotazionePeriodica
            public void SavePrenotazionePeriodica(PrenotazionePeriodica prenotazione)
            {
                PrenotazionePeriodica prenotazionePeriodicaToSave = prenotazione;

                XmlElement prenotazionePeriodicaNode = _xmlDocument.CreateElement("PrenotazionePeriodica");

                XmlElement IdPrenotazionePeriodicaNode = _xmlDocument.CreateElement("IdPrenotazione");
                IdPrenotazionePeriodicaNode.InnerText = prenotazione.IdPrenotazione;

                XmlElement clienteNode = _xmlDocument.CreateElement("Cliente");
                XmlElement salaNode = _xmlDocument.CreateElement("Sala");

                //Sfrutto il metodo CreaNodoCliente fatto in precedenza per creare un nodo di cliente, passando come prenotazione singola una qualsiasi
                //prenotazione singola interna a prenotazione periodica, sapendo a priori che il cliente sarà sicuramente un cliente registrato
                CreaNodoCliente(clienteNode, prenotazione.Prenotazioni.First());

                //stesse considerazioni per la sala, a differenza che non ce alcuna distinzione
                CreaNodoSala(salaNode,prenotazione.Prenotazioni.First());

                XmlElement dataFineElement = _xmlDocument.CreateElement("DataFine");
                XmlElement dataInizioElement = _xmlDocument.CreateElement("DataInizio");
                
                dataFineElement.InnerText = prenotazione.DataFine.ToShortDateString();
                dataInizioElement.InnerText = prenotazione.DataInizio.ToShortDateString();

                //Appendo inizialmente i nodi creati
                prenotazionePeriodicaNode.AppendChild(IdPrenotazionePeriodicaNode);
                prenotazionePeriodicaNode.AppendChild(clienteNode);
                prenotazionePeriodicaNode.AppendChild(salaNode);
                prenotazionePeriodicaNode.AppendChild(dataInizioElement);
                prenotazionePeriodicaNode.AppendChild(dataFineElement);

               
                foreach(PrenotazioneSingola ps in prenotazionePeriodicaToSave.Prenotazioni)
                {
                    XmlElement prenotazioneSingolaNode = _xmlDocument.CreateElement("PrenotazioneSingola");
                    CreaNodoPrenotazioneSingolaForPrenotazionePeriodica(ps, prenotazioneSingolaNode,prenotazionePeriodicaNode);
                }

                _xmlDocument.DocumentElement.InsertAfter(prenotazionePeriodicaNode, _xmlDocument.DocumentElement.LastChild);
                _xmlDocument.Save(_fileName);

            }

          
            /*
            public void UpdatePrenotazionePeriodica(PrenotazionePeriodica prenotazionePeriodicaToUpdate)
            {
                
                XmlNodeList nodes = _xmlDocument.SelectNodes("/Prenotazioni/PrenotazionePeriodica");
                foreach (XmlNode prenotazionePeriodicaNode in nodes)
                {
                    string idPrenotazione = prenotazionePeriodicaNode.SelectSingleNode("IdPrenotazione").InnerText;

                    //verifico prima l'ID Padre delle prenotazione periodica
                    if (idPrenotazione.ToLower() == prenotazionePeriodicaToUpdate.IdPrenotazione.ToLower())
                    {
                        //Riscrivo la prenotazione periodica e la salvo con le nuove prenotazioni
                        var doc = XDocument.Load(_fileName);
                      

                        var nodiDaRimuovere = from nodo in doc.Descendants("IdPrenotazione") 
                                              where nodo.Value == prenotazionePeriodicaToUpdate.IdPrenotazione
                                              select nodo.Parent; //seleziono il genitore, cioè la prenotazione Periodica
                        string parent = nodiDaRimuovere.ToList().First().ToString();
                        //rimuovo il nodo padre, cioe la prenotazione Periodica
                        nodiDaRimuovere.Remove();
                        _xmlDocument.Save(_fileName);
                        doc.Save(_fileName);
                        break;
                    }
                }
                //Ricreo la prenotazione periodica
                SavePrenotazionePeriodica(prenotazionePeriodicaToUpdate);

            }            */

            #region CreaNodi private

            private void CreaNodoPrenotazioneSingolaForPrenotazionePeriodica(PrenotazioneSingola ps, XmlElement prenotazioneSingolaNode, XmlNode prenotazionePeriodicaNode)
            {
                //Per le prenotazioni singole che fanno parte delle prenotazioni periodiche salvo solamente
                //la data interessata , ora inizio , ora fine, e il totale di quella determinata prenotazione singola
                XmlElement dataElement = _xmlDocument.CreateElement("DataInizio");
                XmlElement oraInizioElement = _xmlDocument.CreateElement("OraInizio");
                XmlElement oraFineElement = _xmlDocument.CreateElement("OraFine");
                XmlElement totaleElement = _xmlDocument.CreateElement("Totale");

                dataElement.InnerText = ps.DataInizio.ToShortDateString();
                oraInizioElement.InnerText = ps.OraInizio.ToString();
                oraFineElement.InnerText = ps.OraFine.ToString();
                totaleElement.InnerText = ps.GetTotale().ToString();

                prenotazioneSingolaNode.AppendChild(dataElement);
                prenotazioneSingolaNode.AppendChild(oraInizioElement);
                prenotazioneSingolaNode.AppendChild(oraFineElement);
                prenotazioneSingolaNode.AppendChild(totaleElement);

                prenotazionePeriodicaNode.AppendChild(prenotazioneSingolaNode);
            }

            private void CreaNodoCliente(XmlElement clienteNode, PrenotazioneSingola prenotazioneSingola)
            {
                XmlElement IdTesseraElement = null;
                XmlElement scadenzaTesseraElement = null;

                //Qui vero obbligato se le prenotazione singola fa parte di una prenotazione periodica
                if(prenotazioneSingola.Cliente.GetType()==typeof(ClienteRegistrato))
                {
                     IdTesseraElement = _xmlDocument.CreateElement("IdTessera");
                     scadenzaTesseraElement = _xmlDocument.CreateElement("ScadenzaTessera");
                     IdTesseraElement.InnerText = (prenotazioneSingola.Cliente as ClienteRegistrato).IdTessera;
                     scadenzaTesseraElement.InnerText = (prenotazioneSingola.Cliente as ClienteRegistrato).ScadenzaTessera.ToShortDateString();
                     clienteNode.AppendChild(IdTesseraElement);
                     clienteNode.AppendChild(scadenzaTesseraElement);
                }

                XmlElement nomeElement = _xmlDocument.CreateElement("Nome");
                XmlElement cognomeElement = _xmlDocument.CreateElement("Cognome");
                XmlElement telefonoElement = _xmlDocument.CreateElement("Telefono");
                XmlElement indirizzoElement = _xmlDocument.CreateElement("Indirizzo");

                        nomeElement.InnerText = prenotazioneSingola.Cliente.Nome;
                        cognomeElement.InnerText = prenotazioneSingola.Cliente.Cognome;
                        telefonoElement.InnerText = prenotazioneSingola.Cliente.Telefono;
                        indirizzoElement.InnerText = prenotazioneSingola.Cliente.Indirizzo;

                        clienteNode.AppendChild(nomeElement);
                        clienteNode.AppendChild(cognomeElement);
                        clienteNode.AppendChild(telefonoElement);
                        clienteNode.AppendChild(indirizzoElement);


            }

            private void CreaNodoSala(XmlElement salaNode, PrenotazioneSingola prenotazioneSingola)
            {
                XmlElement idSalaElement = _xmlDocument.CreateElement("IdSala");
                XmlElement indirizzoSalaElement = _xmlDocument.CreateElement("Indirizzo");
                XmlElement nomeSalaElement = _xmlDocument.CreateElement("NomeSala");
                XmlElement tipologiaElement = _xmlDocument.CreateElement("Tipologia");
                XmlElement prezzoElement = _xmlDocument.CreateElement("Prezzo");

                        idSalaElement.InnerText = prenotazioneSingola.Sala.IdSala;
                        indirizzoSalaElement.InnerText = prenotazioneSingola.Sala.Indirizzo;
                        nomeSalaElement.InnerText = prenotazioneSingola.Sala.NomeSala;
                        tipologiaElement.InnerText = prenotazioneSingola.Sala.Tipo.NomeTipologia;
                        prezzoElement.InnerText = prenotazioneSingola.Sala.Prezzo.ToString();
                        

                        salaNode.AppendChild(idSalaElement);
                        salaNode.AppendChild(indirizzoSalaElement);
                        salaNode.AppendChild(nomeSalaElement);
                        salaNode.AppendChild(tipologiaElement);
                        salaNode.AppendChild(prezzoElement);

              
            }           
            #endregion
        }

        #endregion

        #endregion

    }
}
