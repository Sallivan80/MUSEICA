using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUSEICA.Model;

namespace MUSEICA.Persistence
{
    public interface ITipologiaPersister
    {
        ITipologiaLoader GetLoader(string typeFileLoader);

        ITipologiaSaver GetSaver(string typeFileLoader);
    }

    public interface ITipologiaLoader
    {
        List<ITipologiaSala> LoadTipologie();

    }

    public interface ITipologiaSaver
    {
        void SaveUpdateTipologia(ITipologiaSala tipologia);

    }
}
