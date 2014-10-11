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
    public partial class ProfiloView : Form
    {

        private Controller _controller;
        

        public ProfiloView(Controller controller)
        {
            InitializeComponent();
            this._controller = controller;
            SetValue();
        }

        private void SetValue()
        {
            _textBoxNomeCentroSaleProva.Text = CentroSaleProve.GetIstance().Profilo.NomeCentro;
            _textBoxIndirizzo.Text = CentroSaleProve.GetIstance().Profilo.Indirizzo;
            _textBoxTelefono.Text = CentroSaleProve.GetIstance().Profilo.Telefono;
            _textBoxEmail.Text = CentroSaleProve.GetIstance().Profilo.Email;

            _textBoxNomeCentroSaleProva.ReadOnly = !_abilitaModificheImpostaProfilo.Checked;
            _textBoxIndirizzo.ReadOnly = !_abilitaModificheImpostaProfilo.Checked;
            _textBoxTelefono.ReadOnly = !_abilitaModificheImpostaProfilo.Checked;
            _textBoxEmail.ReadOnly = !_abilitaModificheImpostaProfilo.Checked;
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void ProfiloView_Load(object sender, EventArgs e)
        {

        }

        
    }
}
