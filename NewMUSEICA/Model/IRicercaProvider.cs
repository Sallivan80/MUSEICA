using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewMUSEICA.Model
{
    public interface IRicercaProvider
    {
      List<Prenotazione> Ricerca(List<Prenotazione> prenotazioni);
    }
}
