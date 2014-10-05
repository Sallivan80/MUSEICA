using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MUSEICA.Model;

namespace MUSEICA.Persistence
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
        #endregion

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

            #region ISalaLoader

            public List<Sala> LoadSale()
            {
                List<Sala> sale = new List<Sala>();

                XmlNodeList nodes = _xmlDocument.DocumentElement.SelectNodes("/Sale/Sala");

                foreach (XmlNode node in nodes)
                {
                    string idSala= node.SelectSingleNode("IdSala").InnerText;
                    string indirizzo = node.SelectSingleNode("Indirizzo").InnerText;
                    string nomeSala = node.SelectSingleNode("NomeSala").InnerText;
                    ITipologiaSala tipologia = TipologiaSalaFactory.GetTipologia(node.SelectSingleNode("Tipologia").InnerText);
                    
                    Sala sala= new Sala(idSala,indirizzo,nomeSala,tipologia);

                    sale.Add(sala);
                }
                return sale;
            }
            #endregion
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

                    idSalaElement.InnerText = sala.IdSala;
                    indirizzoElement.InnerText = sala.Indirizzo;
                    nomeSalaElement.InnerText = sala.NomeSala;
                    tipologiaElement.InnerText = sala.Tipo.NomeTipologia;

                    salaNode.AppendChild(idSalaElement);
                    salaNode.AppendChild(indirizzoElement);
                    salaNode.AppendChild(nomeSalaElement);
                    salaNode.AppendChild(tipologiaElement);


                    _xmlDocument.DocumentElement.InsertAfter(salaNode, _xmlDocument.DocumentElement.LastChild);
                }
                _xmlDocument.Save(_fileName);
            }
        }
        #endregion

    }
}
