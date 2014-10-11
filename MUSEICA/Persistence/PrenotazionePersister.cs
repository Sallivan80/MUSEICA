using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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
                    DateTime data = DateTime.Parse (node.SelectSingleNode("Data").InnerText);
                    int oraInizio = Convert.ToInt32( node.SelectSingleNode("OraInizio").InnerText);
                    int oraFine = Convert.ToInt32(node.SelectSingleNode("OraFine").InnerText);
                    PrenotazioneSingola prenotazione= new PrenotazioneSingola(idPrenotazione, cliente, sala, data,oraInizio,oraFine);

                    prenotazioniSingole.Add(prenotazione);
                }
                return prenotazioniSingole;
            }

           
            public List<PrenotazionePeriodica> LoadPrenotazioniPeriodiche()
            {
                List<PrenotazionePeriodica> prenotazioniPeriodiche = new List<PrenotazionePeriodica>();

                XmlNodeList nodes = _xmlDocument.DocumentElement.SelectNodes("/Prenotazioni/PrenotazionePeriodica");

                foreach (XmlNode node in nodes)
                {
                    DateTime dataFine=DateTime.Parse( node.SelectSingleNode("DataFine").InnerText);
                    XmlNodeList nodesPrenotazioniSingole = node.SelectNodes("PrenotazioneSingola");
                    List<PrenotazioneSingola> prenotazioni = LoadPrenotazioniSingoleNodes(nodesPrenotazioniSingole);
                    
                    PrenotazionePeriodica prenotazionePeriodica = new PrenotazionePeriodica(prenotazioni,dataFine);

                    prenotazioniPeriodiche.Add(prenotazionePeriodica);
                }
                return prenotazioniPeriodiche;
            }

            #region private Method LoadClienteNodes - LoadSalaNodes - LoadPrenotazioniSingoleNodes
            private Cliente LoadClienteNodes(XmlNode clienteNode)
            {
                Cliente result = null; ;
                
                    string nome = clienteNode.SelectSingleNode("Nome").InnerText;
                    string cognome = clienteNode.SelectSingleNode("Cognome").InnerText;
                    string telefono = clienteNode.SelectSingleNode("Telefono").InnerText;
                    string indirizzo = clienteNode.SelectSingleNode("Indirizzo").InnerText;
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

            private List<PrenotazioneSingola> LoadPrenotazioniSingoleNodes(XmlNodeList prenotazioniNodes)
            {
                List<PrenotazioneSingola> result = new List<PrenotazioneSingola>();
                foreach(XmlNode node in prenotazioniNodes)
                {
                    string idPrenotazione = node.SelectSingleNode("IdPrenotazione").InnerText;
                    Cliente cliente = LoadClienteNodes(node.SelectSingleNode("Cliente"));
                    Sala sala = LoadSalaNodes(node.SelectSingleNode("Sala"));
                    DateTime data = DateTime.Parse(node.SelectSingleNode("Data").InnerText);
                    int oraInizio = Convert.ToInt32(node.SelectSingleNode("OraInizio").InnerText);
                    int oraFine = Convert.ToInt32(node.SelectSingleNode("OraFine").InnerText);
                    PrenotazioneSingola prenotazione = new PrenotazioneSingola(idPrenotazione, cliente, sala, data, oraInizio, oraFine);

                    result.Add(prenotazione);
                }

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

            public void SaveUpdatePrenotazioneSingola(PrenotazioneSingola prenotazioneSingola)
            {
                PrenotazioneSingola prenotazioneSingolaToSave = prenotazioneSingola;
                bool trovato = false;
                XmlNodeList nodes = _xmlDocument.SelectNodes("/Prenotazioni/PrenotazioneSingola");

                foreach (XmlNode node in nodes)
                {
                    string idPrenotazione = node.SelectSingleNode("IdPrenotazione").InnerText;
                   
                    if (idPrenotazione.ToLower()==prenotazioneSingola.IdPrenotazione.ToLower())
                    {
                        node.SelectSingleNode("Data").InnerText = prenotazioneSingolaToSave.Data.ToShortDateString();
                        node.SelectSingleNode("OraInizio").InnerText = prenotazioneSingolaToSave.OraInizio.ToString();
                        node.SelectSingleNode("OraFine").InnerText = prenotazioneSingolaToSave.OraFine.ToString();

                        _xmlDocument.Save(_fileName);
                        trovato = true;
                        break;
                    }
                }

                if (!trovato)//Testato e funzionante...speriamo
                {
                    XmlElement prenotazioneSingolaNode = _xmlDocument.CreateElement("PrenotazioneSingola");

                    CreaNodoPrenotazioneSingola(prenotazioneSingolaNode, prenotazioneSingola);                                    

                   
                    _xmlDocument.DocumentElement.InsertAfter(prenotazioneSingolaNode, _xmlDocument.DocumentElement.LastChild);
                }
                _xmlDocument.Save(_fileName);
            }
          
            public void SaveUpdatePrenotazionePeriodica(PrenotazionePeriodica prenotazione)
            {
                PrenotazionePeriodica prenotazionePeriodicaToSave = prenotazione;

                XmlElement prenotazionePeriodicaNode = _xmlDocument.CreateElement("PrenotazionePeriodica");
                foreach(PrenotazioneSingola p in prenotazionePeriodicaToSave.Prenotazioni)
                {
                    XmlElement prenotazioneSingolaNode = _xmlDocument.CreateElement("PrenotazioneSingola");

                    CreaNodoPrenotazioneSingola(prenotazioneSingolaNode, p);

                    prenotazionePeriodicaNode.AppendChild(prenotazioneSingolaNode);
                }

                _xmlDocument.DocumentElement.InsertAfter(prenotazionePeriodicaNode, _xmlDocument.DocumentElement.LastChild);
                _xmlDocument.Save(_fileName);

            }

            #region CreaNodi private

            private void CreaNodoPrenotazioneSingola(XmlElement prenotazioneSingolaNode, PrenotazioneSingola prenotazioneSingola)
            {
                XmlElement idPrenotazioneElement = _xmlDocument.CreateElement("IdPrenotazione");
                    XmlElement clienteNode = _xmlDocument.CreateElement("Cliente");
                    XmlElement salaNode = _xmlDocument.CreateElement("Sala");
                    XmlElement dataElement = _xmlDocument.CreateElement("Data");
                    XmlElement oraInizioElement = _xmlDocument.CreateElement("OraInizio");
                    XmlElement oraFineElement = _xmlDocument.CreateElement("OraFine");


                    idPrenotazioneElement.InnerText = prenotazioneSingola.IdPrenotazione;

                //CLIENTE
                CreaNodoCliente(clienteNode, prenotazioneSingola);
                //SALA
                CreaNodoSala(salaNode, prenotazioneSingola);

                dataElement.InnerText = prenotazioneSingola.Data.ToString();
                oraInizioElement.InnerText = prenotazioneSingola.OraInizio.ToString();
                oraFineElement.InnerText = prenotazioneSingola.OraFine.ToString();


                prenotazioneSingolaNode.AppendChild(idPrenotazioneElement);
                prenotazioneSingolaNode.AppendChild(clienteNode);
                prenotazioneSingolaNode.AppendChild(salaNode);
                prenotazioneSingolaNode.AppendChild(dataElement);
                prenotazioneSingolaNode.AppendChild(oraInizioElement);
                prenotazioneSingolaNode.AppendChild(oraFineElement);
            }

            private void CreaNodoCliente(XmlElement clienteNode, PrenotazioneSingola prenotazioneSingola)
            {
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

    }
}
