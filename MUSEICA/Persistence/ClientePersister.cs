using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MUSEICA.Model;

namespace MUSEICA.Persistence
{
    public class ClientePersister : IClientePersister
    {
        private readonly string _fileNameClienti;

        public ClientePersister(string fileNameClienti)
        {
            _fileNameClienti = fileNameClienti;
        }

        public IClienteLoader GetLoader(string type)
        {
            switch (type)
            {
                case "XML":
                    return new ClienteXmlLoader(_fileNameClienti);
                default:
                    throw new ArgumentException("Type non esistente");
            }
        }

        public IClienteSaver GetSaver(string type)
        {
            switch (type)
            {
                case "XML":
                    return new ClienteXmlSaver(_fileNameClienti);
                default:
                    throw new ArgumentException("Tipo saver non disponibile");
            }
        }


        #region ClienteXmlLoader

        private class ClienteXmlLoader : IClienteLoader
        {
            private readonly XmlDocument _xmlDocument;

            #region Costruttore

            public ClienteXmlLoader(string fileName)
            {
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            #endregion

            #region IClienteLoader

            public List<Cliente> LoadClienti()
            {
                List<Cliente> clienti = new List<Cliente>();

                XmlNodeList nodes = _xmlDocument.DocumentElement.SelectNodes("/Clienti/Cliente");

                foreach (XmlNode node in nodes)
                {
                    string nome = node.SelectSingleNode("Nome").InnerText;
                    string cognome = node.SelectSingleNode("Cognome").InnerText;
                    string telefono = node.SelectSingleNode("Telefono").InnerText;
                    string indirizzo = node.SelectSingleNode("Indirizzo").InnerText;
                    Cliente cliente = new Cliente(nome, cognome, telefono, indirizzo);

                    clienti.Add(cliente);
                }
                return clienti;
            }

            public List<ClienteRegistrato> LoadClientiRegistrati()
            {
                List<ClienteRegistrato> clientiRegistrati = new List<ClienteRegistrato>();

                XmlNodeList nodes = _xmlDocument.DocumentElement.SelectNodes("/Clienti/ClienteRegistrato");

                foreach (XmlNode node in nodes)
                {
                    string idTessera = node.SelectSingleNode("IDTessera").InnerText;
                    DateTime scadenzaTessera = DateTime.Parse(node.SelectSingleNode("ScadenzaTessera").InnerText);
                    string nome = node.SelectSingleNode("Nome").InnerText;
                    string cognome = node.SelectSingleNode("Cognome").InnerText;
                    string telefono = node.SelectSingleNode("Telefono").InnerText;
                    string indirizzo = node.SelectSingleNode("Indirizzo").InnerText;
                    ClienteRegistrato cliente = new ClienteRegistrato(nome, cognome, telefono, indirizzo, idTessera, scadenzaTessera);

                    clientiRegistrati.Add(cliente);
                }
                return clientiRegistrati;
            }

            #endregion
        }
        #endregion

        #region ClienteXmlSaver

        private class ClienteXmlSaver : IClienteSaver
        {
            private XmlDocument _xmlDocument;
            private string _fileName;

            #region Costruttore

            public ClienteXmlSaver(string fileName)
            {
                _fileName = fileName;
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            #endregion

            public void SaveUpdateCliente(Cliente cliente)
            {
                Cliente clientToSave = cliente;
                bool trovato = false;
                XmlNodeList nodes = _xmlDocument.SelectNodes("/Clienti/Cliente");

                foreach (XmlNode node in nodes)
                {
                    string nome = node.SelectSingleNode("Nome").InnerText;
                    string cognome = node.SelectSingleNode("Cognome").InnerText;
                   

                    if (cliente.Nome.ToLower().Equals(nome.ToLower()) && cliente.Cognome.ToLower().Equals(cognome.ToLower()))
                    {
                        node.SelectSingleNode("Telefono").InnerText = clientToSave.Telefono;
                        node.SelectSingleNode("Indirizzo").InnerText = clientToSave.Indirizzo;

                        _xmlDocument.Save(_fileName);
                        trovato = true;
                        break;
                    }
                }

                if (!trovato)//Testato e funzionante...speriamo
                {
                    XmlElement clienteNode = _xmlDocument.CreateElement("Cliente");

                    XmlElement nomeElement = _xmlDocument.CreateElement("Nome");
                    XmlElement cognomeElement = _xmlDocument.CreateElement("Cognome");
                    XmlElement telefonoElement = _xmlDocument.CreateElement("Telefono");
                    XmlElement indirizzoElement = _xmlDocument.CreateElement("Indirizzo");

                    nomeElement.InnerText = cliente.Nome;
                    cognomeElement.InnerText = cliente.Cognome;
                    telefonoElement.InnerText = cliente.Telefono;
                    indirizzoElement.InnerText = cliente.Indirizzo;

                    clienteNode.AppendChild(nomeElement);
                    clienteNode.AppendChild(cognomeElement);
                    clienteNode.AppendChild(telefonoElement);
                    clienteNode.AppendChild(indirizzoElement);

                   
                    _xmlDocument.DocumentElement.InsertAfter(clienteNode, _xmlDocument.DocumentElement.LastChild);
                }
                _xmlDocument.Save(_fileName);
            }

            public void SaveUpdateClienteRegistrato(ClienteRegistrato cliente)
            {
                ClienteRegistrato clientRegisterToSave = cliente;
                bool trovato = false;
                XmlNodeList nodes = _xmlDocument.SelectNodes("/Clienti/ClienteRegistrato");

                foreach (XmlNode node in nodes)
                {
                    string idTessera = node.SelectSingleNode("IDTessera").InnerText;
                    


                    if (cliente.IdTessera.ToLower().Equals(idTessera.ToLower()))
                    {

                        node.SelectSingleNode("ScadenzaTessera").InnerText = clientRegisterToSave.ScadenzaTessera.ToString();
                        node.SelectSingleNode("Telefono").InnerText = clientRegisterToSave.Telefono;
                        node.SelectSingleNode("Indirizzo").InnerText = clientRegisterToSave.Indirizzo;

                        _xmlDocument.Save(_fileName);
                        trovato = true;
                        break;
                    }
                }

                if (!trovato)//Testato e funzionante...speriamo
                {
                    XmlElement clienteNode = _xmlDocument.CreateElement("ClienteRegistrato");

                    XmlElement tesseraElement = _xmlDocument.CreateElement("IDTessera");
                    XmlElement scadenzaElement = _xmlDocument.CreateElement("ScadenzaTessera");
                    XmlElement nomeElement = _xmlDocument.CreateElement("Nome");
                    XmlElement cognomeElement = _xmlDocument.CreateElement("Cognome");
                    XmlElement telefonoElement = _xmlDocument.CreateElement("Telefono");
                    XmlElement indirizzoElement = _xmlDocument.CreateElement("Indirizzo");

                    tesseraElement.InnerText=cliente.IdTessera;
                    scadenzaElement.InnerText = cliente.ScadenzaTessera.ToString();
                    nomeElement.InnerText = cliente.Nome;
                    cognomeElement.InnerText = cliente.Cognome;
                    telefonoElement.InnerText = cliente.Telefono;
                    indirizzoElement.InnerText = cliente.Indirizzo;

                    clienteNode.AppendChild(tesseraElement);
                    clienteNode.AppendChild(scadenzaElement);
                    clienteNode.AppendChild(nomeElement);
                    clienteNode.AppendChild(cognomeElement);
                    clienteNode.AppendChild(telefonoElement);
                    clienteNode.AppendChild(indirizzoElement);


                    _xmlDocument.DocumentElement.InsertAfter(clienteNode, _xmlDocument.DocumentElement.LastChild);
                }
                _xmlDocument.Save(_fileName);
            }           
        }

        #endregion
    }
}
