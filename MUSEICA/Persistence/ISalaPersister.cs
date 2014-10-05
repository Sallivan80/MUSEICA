using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUSEICA.Model;

namespace MUSEICA.Persistence
{
    public interface ISalaPersister
    {
        ISalaLoader GetLoader(string typeFileLoader);

        ISalaSaver GetSaver(string typeFileLoader);
    }

    public interface ISalaLoader
    {
        List<Sala> LoadSale();
       
    }

    public interface ISalaSaver
    {
        void SaveUpdateSala(Sala sala);
        
    }
}
