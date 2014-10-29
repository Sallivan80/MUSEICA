using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using NewMUSEICA.Model;

namespace NewMUSEICA.Persistence
{
    class SalaPersister : ISalaPersister
    {
        private readonly string _fileNameSale;

        public SalaPersister(string fileNameSale)
        {
            _fileNameSale = fileNameSale;
        }

        #region GetLoader & GetSaver
        public ISalaLoader GetLoader(string type)
        {
            switch (type)
            {
                case "XML":
                    return new SalaXmlLoader(_fileNameSale);
                default:
                    throw new ArgumentException("Type non esistente");
            }
        }

        public ISalaSaver GetSaver(string type)
        {
            switch (type)
            {
                case "XML":
                    return new SalaXmlSaver(_fileNameSale);
                default:
                    throw new ArgumentException("Tipo saver non disponibile");
            }
        }

        public ISalaRemover GetRemover(string type)
        {
            switch (type)
            {
                case "XML":
                    return new SalaXmlRemover(_fileNameSale);
                default:
                    throw new ArgumentException("Tipo saver non disponibile");
            }
        }
        #endregion

        private class SalaXmlRemover:ISalaRemover
        {
            private string _fileName;

            public SalaXmlRemover(string fileName)
            {
                this._fileName = fileName;
            }

            public void RemoveSala(Sala s)
            {
                var doc = XDocument.Load(_fileName);
                //qui faccio una query LINQ che mi estrae i nodi interessati
                var nodiDaRimuovere = from nodo in doc.Descendants("IdSala") //seleziono i nodi chiamati "IdTessera"
                                      where nodo.Value == s.IdSala//ecco la clausola where in cui controllo il valore del nodo
                                      select nodo.Parent;                  //seleziono il genitore, cioè il cliente
                //rimuovo tutti i nodi trovati
                nodiDaRimuovere.Remove();
                doc.Save(_fileName); 
            }

        }
        #region SalaXmlLoader

        private class SalaXmlLoader : ISalaLoader
        {
            private readonly XmlDocument _xmlDocument;

            #region Costruttore

            public SalaXmlLoader(string fileName)
            {
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            #endregion           

            public List<Sala> LoadSale()
            {
                List<Sala> sale = new List<Sala>();

                XmlNodeList nodes = _xmlDocument.DocumentElement.SelectNodes("/Sale/Sala");

                foreach (XmlNode node in nodes)
                {
                    string idSala= node.SelectSingleNode("IdSala").InnerText;
                    string indirizzo = node.SelectSingleNode("Indirizzo").InnerText;
                    string nomeSala = node.SelectSingleNode("NomeSala").InnerText;
                    float prezzoSala = Convert.ToSingle(node.SelectSingleNode("Prezzo").InnerText);
                    ITipologiaSala tipologia = TipologiaSalaFactory.GetTipologia(node.SelectSingleNode("Tipologia").InnerText);
                    
                    Sala sala= new Sala(idSala,indirizzo,nomeSala,tipologia,prezzoSala);

                    sale.Add(sala);
                }
                return sale;
            }
            
        }
        #endregion

        #region SalaXmlSaver

        private class SalaXmlSaver : ISalaSaver
        {
            private XmlDocument _xmlDocument;
            private string _fileName;

            #region Costruttore

            public SalaXmlSaver(string fileName)
            {
                _fileName = fileName;
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            #endregion

            public void SaveUpdateSala(Sala sala)
            {
                Sala salaToSave = sala;
                bool trovato = false;
                XmlNodeList nodes = _xmlDocument.SelectNodes("/Sale/Sala");

                foreach (XmlNode node in nodes)
                {
                    string idSala = node.SelectSingleNode("IdSala").InnerText;

                    if (sala.IdSala.ToLower().Equals(idSala.ToLower()))
                    {
                        node.SelectSingleNode("Indirizzo").InnerText = salaToSave.Indirizzo;
                        node.SelectSingleNode("Tipologia").InnerText = salaToSave.Tipo.NomeTipologia;
                        node.SelectSingleNode("Prezzo").InnerText = salaToSave.Prezzo.ToString();
                       

                        _xmlDocument.Save(_fileName);
                        trovato = true;
                        break;
                    }
                }

                if (!trovato)//Testato e funzionante...speriamo
                {
                    XmlElement salaNode = _xmlDocument.CreateElement("Sala");

                    XmlElement idSalaElement = _xmlDocument.CreateElement("IdSala");
                    XmlElement indirizzoElement = _xmlDocument.CreateElement("Indirizzo");
                    XmlElement nomeSalaElement = _xmlDocument.CreateElement("NomeSala");
                    XmlElement tipologiaElement = _xmlDocument.CreateElement("Tipologia");
                    XmlElement prezzoElement = _xmlDocument.CreateElement("Prezzo");


                    idSalaElement.InnerText = sala.IdSala;
                    indirizzoElement.InnerText = sala.Indirizzo;
                    nomeSalaElement.InnerText = sala.NomeSala;
                    tipologiaElement.InnerText = sala.Tipo.NomeTipologia;
                    prezzoElement.InnerText = sala.Prezzo.ToString();

                    salaNode.AppendChild(idSalaElement);
                    salaNode.AppendChild(indirizzoElement);
                    salaNode.AppendChild(nomeSalaElement);
                    salaNode.AppendChild(tipologiaElement);
                    salaNode.AppendChild(prezzoElement);


                    _xmlDocument.DocumentElement.InsertAfter(salaNode, _xmlDocument.DocumentElement.LastChild);
                }
                _xmlDocument.Save(_fileName);
            }
        }
        #endregion

    }
}
