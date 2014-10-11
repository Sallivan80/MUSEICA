using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.Controllers;
using MUSEICA.Model;


namespace MUSEICA.ProvaView
{
    public partial class MuseicaView : Form
    {
        private MainController _controller;
        public MuseicaView()
        {
            InitializeComponent();
            this._controller = new MainController(this);
            _controller.LoadCompenents();
        }

        private void gestioneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void gestioneToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            _controller.ChangeView("Profilo");
        }
    }
}
