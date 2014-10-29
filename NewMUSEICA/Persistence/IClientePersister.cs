using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewMUSEICA.Model;

namespace NewMUSEICA.Persistence
{
    public interface IClientePersister
    {
        IClienteLoader GetLoader(string typeFileLoader);

        IClienteSaver GetSaver(string typeFileLoader);

        IClienteRemover GetRemover(string typeFileLoader);
    }

    public interface IClienteRemover
    {
        void RemoveClienteRegistrato(ClienteRegistrato cliente);
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

