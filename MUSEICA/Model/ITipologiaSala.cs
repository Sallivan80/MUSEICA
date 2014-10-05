

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace MUSEICA.Model
{
    public interface ITipologiaSala
    {

        string NomeTipologia { get; }

        string Descrizione { get; }

        float Prezzo { get; }
    }//end ITipologiaSala
}