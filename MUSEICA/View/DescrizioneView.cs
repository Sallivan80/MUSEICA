using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSEICA.View
{
    public partial class DescrizioneView : Form
    {
        private string nomeView;

        public DescrizioneView(string nomeView)
        {
            InitializeComponent();
            this.nomeView = nomeView;
            SetView();
        }

        private void SetView()
        {
            switch(this.nomeView)
            {
                case "Registrazione":
                    this.Text = "Sala Registrazione"; 
                    this._textBoxDescrizione.Text = "" + "Una sala di registrazione consiste in una sala chiamata 'live room', destinata ad ospitare chi (o cosa) produce il suono. "
                                                        + "Questa sala è isolata acusticamente, se deve ospitare degli strumenti molto rumorosi, e per evitare "
                                                          + "che il suono che viene prodotto venga registrato da microfoni presenti eventualmente in altre sale. Le sale sono progettate in base ai principi dell'acustica: oltre ad essere isolate, possono essere rivestite "
                                                           + "di materiali che ne modificano la risposta acustica favorendo o eliminando le riflessioni del suono all'interno. Questa sala è attrezzata "
                                                            + "con apparecchi adatti a registrare i vari suoni su supporto.";
                    break;
                case "Mixaggio":
                    this.Text = "Sala Mixaggio"; 
                    this._textBoxDescrizione.Text = "" + "La sala mixaggio è l'ambiente, anch'esso acusticamente isolato e curato, " 
                                                        + "dove si trovano il mixer, i monitor ed altri processori di segnale tra cui "
                                                         + "multieffetto, DEC, DAT e altri ancora. "
                                                          + "In questo ambiente si possono modificare e miscelare i segnali audio.";
                    break;
                case "Prova":
                    this.Text = "Sala Prova"; 
                    this._textBoxDescrizione.Text = "" + "E' una sala dove è presente una gamma di strumenti musicali per permettere, a chi la prenota, di "
                                                        + "poter provare pezzi musicali di ogni tipo. Al suo interno sono presenti: amplificatori per basso, chitarra e tastiera, una batteria, aste e microfoni, cavistiche varie, casse altoparlanti."
                                                         + " Tutto il resto della strumentazione, come ad esempio: chitarre, bassi, tastiere ecc... non è presente all'interno della sala, quindi coloro che la prenoteranno dovranno esserne forniti.";
                    break;
                default:
                    throw new ArgumentException();
            }
        }


    }
}
