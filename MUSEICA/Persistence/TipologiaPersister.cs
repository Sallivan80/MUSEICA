using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MUSEICA.Model;

namespace MUSEICA.Persistence
{
    class TipologiaPersister:ITipologiaPersister
    {
        private readonly string _fileNameTipologie;

        public TipologiaPersister(string fileNameTipologie)
        {
            _fileNameTipologie = fileNameTipologie;
        }

        #region GetLoader & GetSaver
        public ITipologiaLoader GetLoader(string type)
        {
            switch (type)
            {
                case "XML":
                    return new TipologiaXmlLoader(_fileNameTipologie);
                default:
                    throw new ArgumentException("Type non esistente");
            }
        }

        public ITipologiaSaver GetSaver(string type)
        {
            switch (type)
            {
                case "XML":
                    return new TipologiaXmlSaver(_fileNameTipologie);
                default:
                    throw new ArgumentException("Tipo saver non disponibile");
            }
        }
        #endregion

        #region TipologiaXmlLoader

        private class TipologiaXmlLoader : ITipologiaLoader
        {
            private readonly XmlDocument _xmlDocument;

            #region Costruttore

            public TipologiaXmlLoader(string fileName)
            {
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            #endregion           

            public List<ITipologiaSala> LoadTipologie()
            {
                List<ITipologiaSala> tipologie = new List<ITipologiaSala>();

                XmlNodeList nodes = _xmlDocument.DocumentElement.SelectNodes("/Tipologie/Tipologia");

                foreach (XmlNode node in nodes)
                {
                    string nomeTipo= node.SelectSingleNode("NomeTipo").InnerText;
                    string descrizione = node.SelectSingleNode("Descrizione").InnerText;
                    string prezzo = node.SelectSingleNode("Prezzo").InnerText;

                    ITipologiaSala tipologia = TipologiaSalaFactory.GetTipologia(nomeTipo);

                    tipologie.Add(tipologia);
                }
                return tipologie;
            }
            
        }
        #endregion

        #region TipologiaXmlSaver

        private class TipologiaXmlSaver : ITipologiaSaver
        {
            private XmlDocument _xmlDocument;
            private string _fileName;

            #region Costruttore

            public TipologiaXmlSaver(string fileName)
            {
                _fileName = fileName;
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            #endregion

            public void SaveUpdateTipologia(ITipologiaSala tipologia)
            {
                ITipologiaSala tipologiaToSave = tipologia;
                bool trovato = false;
                XmlNodeList nodes = _xmlDocument.SelectNodes("/Tipologie/Tipologia");

                foreach (XmlNode node in nodes)
                {
                    string nomeTipo = node.SelectSingleNode("NomeTipo").InnerText;

                    if (tipologia.NomeTipologia.ToLower().Equals(nomeTipo.ToLower()))
                    {
                        node.SelectSingleNode("Descrizione").InnerText = tipologiaToSave.Descrizione;
                        node.SelectSingleNode("Prezzo").InnerText = tipologiaToSave.Prezzo.ToString();
                       

                        _xmlDocument.Save(_fileName);
                        trovato = true;
                        break;
                    }
                }

                if (!trovato)//Testato e funzionante...speriamo
                {
                    XmlElement tipologiaNode = _xmlDocument.CreateElement("Tipologia");

                    XmlElement nomeTipoElement = _xmlDocument.CreateElement("NomeTipo");
                    XmlElement descrizioneElement = _xmlDocument.CreateElement("Descrizione");
                    XmlElement prezzoElement = _xmlDocument.CreateElement("Prezzo");
                   

                    nomeTipoElement.InnerText = tipologia.NomeTipologia;
                    descrizioneElement.InnerText = tipologia.Descrizione;
                    prezzoElement.InnerText = tipologia.Prezzo.ToString();
                    

                    tipologiaNode.AppendChild(nomeTipoElement);
                    tipologiaNode.AppendChild(descrizioneElement);
                    tipologiaNode.AppendChild(prezzoElement);                    


                    _xmlDocument.DocumentElement.InsertAfter(tipologiaNode, _xmlDocument.DocumentElement.LastChild);
                }
                _xmlDocument.Save(_fileName);
            }
        }
        #endregion
    }
}
