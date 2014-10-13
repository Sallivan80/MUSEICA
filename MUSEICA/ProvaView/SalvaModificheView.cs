using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEICA.Persistence;
using MUSEICA.Model;
using MUSEICA.Controllers;

namespace MUSEICA.ProvaView
{
    public partial class SalvaModificheView : Form
    {
        ControllerProfilo _controller;
        public SalvaModificheView()
        {
            InitializeComponent();
        }

        private void _salvaButton_Click(object sender, EventArgs e)
        {

            _controller.SaveAll();
        }

    }
}
