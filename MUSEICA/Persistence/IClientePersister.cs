using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUSEICA.Model;

namespace MUSEICA.Persistence
{
    public interface IClientePersister
    {
        IClienteLoader GetLoader(string typeFileLoader);

        IClienteSaver GetSaver(string typeFileLoader);
    }

    public interface IClienteLoader
    {
            List<Cliente> LoadClienti();
            List<ClienteRegistrato> LoadClientiRegistrati();
    }

    public interface IClienteSaver
    {
         void SaveUpdateCliente(Cliente cliente);
         void SaveUpdateClienteRegistrato(ClienteRegistrato cliente);
    }
}

