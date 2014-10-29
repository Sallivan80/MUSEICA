namespace NewMUSEICA.View
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registraNuovoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prenotazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prenotazioneSingolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prenotazionePeriodicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipologieSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mixaggioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._groupBoxRicercaPrenotazioni = new System.Windows.Forms.GroupBox();
            this._comboBoxSalaTipo = new System.Windows.Forms.ComboBox();
            this._listBoxRisultatiRicerca = new System.Windows.Forms.ListBox();
            this._buttonCerca = new System.Windows.Forms.Button();
            this._labelParametro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._dateTimePickerRicerca = new System.Windows.Forms.DateTimePicker();
            this._textBoxNomeCognome = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this._buttonModifica = new System.Windows.Forms.Button();
            this._labelRisultati = new System.Windows.Forms.Label();
            this._comboBoxCriterioRicerca = new System.Windows.Forms.ComboBox();
            this._groupBoxAgenda = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this._groupBoxRicercaPrenotazioni.SuspendLayout();
            this._groupBoxAgenda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gestioneToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.prenotazioneToolStripMenuItem,
            this.tipologieSalaToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1811, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.esciToolStripMenuItem.Text = "Esci";
            // 
            // gestioneToolStripMenuItem
            // 
            this.gestioneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestioneToolStripMenuItem1});
            this.gestioneToolStripMenuItem.Name = "gestioneToolStripMenuItem";
            this.gestioneToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.gestioneToolStripMenuItem.Text = "Gestione";
            // 
            // gestioneToolStripMenuItem1
            // 
            this.gestioneToolStripMenuItem1.Name = "gestioneToolStripMenuItem1";
            this.gestioneToolStripMenuItem1.Size = new System.Drawing.Size(257, 24);
            this.gestioneToolStripMenuItem1.Text = "Gestione Centro Sale Prova";
            this.gestioneToolStripMenuItem1.Click += new System.EventHandler(this.gestioneToolStripMenuItem1_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registraNuovoClienteToolStripMenuItem});
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.clientiToolStripMenuItem.Text = "Clienti";
            // 
            // registraNuovoClienteToolStripMenuItem
            // 
            this.registraNuovoClienteToolStripMenuItem.Name = "registraNuovoClienteToolStripMenuItem";
            this.registraNuovoClienteToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.registraNuovoClienteToolStripMenuItem.Text = "Registra Nuovo Cliente";
            this.registraNuovoClienteToolStripMenuItem.Click += new System.EventHandler(this.registraNuovoClienteToolStripMenuItem_Click);
            // 
            // prenotazioneToolStripMenuItem
            // 
            this.prenotazioneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovaToolStripMenuItem});
            this.prenotazioneToolStripMenuItem.Name = "prenotazioneToolStripMenuItem";
            this.prenotazioneToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.prenotazioneToolStripMenuItem.Text = "Prenotazione";
            // 
            // nuovaToolStripMenuItem
            // 
            this.nuovaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prenotazioneSingolaToolStripMenuItem,
            this.prenotazionePeriodicaToolStripMenuItem});
            this.nuovaToolStripMenuItem.Name = "nuovaToolStripMenuItem";
            this.nuovaToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.nuovaToolStripMenuItem.Text = "Nuova";
            // 
            // prenotazioneSingolaToolStripMenuItem
            // 
            this.prenotazioneSingolaToolStripMenuItem.Name = "prenotazioneSingolaToolStripMenuItem";
            this.prenotazioneSingolaToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.prenotazioneSingolaToolStripMenuItem.Text = "Prenotazione Singola";
            this.prenotazioneSingolaToolStripMenuItem.Click += new System.EventHandler(this.prenotazioneSingolaToolStripMenuItem_Click);
            // 
            // prenotazionePeriodicaToolStripMenuItem
            // 
            this.prenotazionePeriodicaToolStripMenuItem.Name = "prenotazionePeriodicaToolStripMenuItem";
            this.prenotazionePeriodicaToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.prenotazionePeriodicaToolStripMenuItem.Text = "Prenotazione Periodica";
            this.prenotazionePeriodicaToolStripMenuItem.Click += new System.EventHandler(this.prenotazionePeriodicaToolStripMenuItem_Click);
            // 
            // tipologieSalaToolStripMenuItem
            // 
            this.tipologieSalaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrazioneToolStripMenuItem,
            this.mixaggioToolStripMenuItem,
            this.provaToolStripMenuItem});
            this.tipologieSalaToolStripMenuItem.Name = "tipologieSalaToolStripMenuItem";
            this.tipologieSalaToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.tipologieSalaToolStripMenuItem.Text = "Tipologie Sala";
            // 
            // registrazioneToolStripMenuItem
            // 
            this.registrazioneToolStripMenuItem.Name = "registrazioneToolStripMenuItem";
            this.registrazioneToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.registrazioneToolStripMenuItem.Text = "Registrazione";
            // 
            // mixaggioToolStripMenuItem
            // 
            this.mixaggioToolStripMenuItem.Name = "mixaggioToolStripMenuItem";
            this.mixaggioToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.mixaggioToolStripMenuItem.Text = "Mixaggio";
            // 
            // provaToolStripMenuItem
            // 
            this.provaToolStripMenuItem.Name = "provaToolStripMenuItem";
            this.provaToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.provaToolStripMenuItem.Text = "Prova";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.helpToolStripMenuItem.Text = "Aiuto";
            // 
            // _groupBoxRicercaPrenotazioni
            // 
            this._groupBoxRicercaPrenotazioni.AutoSize = true;
            this._groupBoxRicercaPrenotazioni.Controls.Add(this._comboBoxSalaTipo);
            this._groupBoxRicercaPrenotazioni.Controls.Add(this._listBoxRisultatiRicerca);
            this._groupBoxRicercaPrenotazioni.Controls.Add(this._buttonCerca);
            this._groupBoxRicercaPrenotazioni.Controls.Add(this._labelParametro);
            this._groupBoxRicercaPrenotazioni.Controls.Add(this.label7);
            this._groupBoxRicercaPrenotazioni.Controls.Add(this.label6);
            this._groupBoxRicercaPrenotazioni.Controls.Add(this.label4);
            this._groupBoxRicercaPrenotazioni.Controls.Add(this._dateTimePickerRicerca);
            this._groupBoxRicercaPrenotazioni.Controls.Add(this._textBoxNomeCognome);
            this._groupBoxRicercaPrenotazioni.Controls.Add(this.button2);
            this._groupBoxRicercaPrenotazioni.Controls.Add(this._buttonModifica);
            this._groupBoxRicercaPrenotazioni.Controls.Add(this._labelRisultati);
            this._groupBoxRicercaPrenotazioni.Controls.Add(this._comboBoxCriterioRicerca);
            this._groupBoxRicercaPrenotazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._groupBoxRicercaPrenotazioni.Location = new System.Drawing.Point(875, 39);
            this._groupBoxRicercaPrenotazioni.Name = "_groupBoxRicercaPrenotazioni";
            this._groupBoxRicercaPrenotazioni.Size = new System.Drawing.Size(921, 653);
            this._groupBoxRicercaPrenotazioni.TabIndex = 3;
            this._groupBoxRicercaPrenotazioni.TabStop = false;
            this._groupBoxRicercaPrenotazioni.Text = "Ricerca Prenotazioni";
            // 
            // _comboBoxSalaTipo
            // 
            this._comboBoxSalaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this._comboBoxSalaTipo.FormattingEnabled = true;
            this._comboBoxSalaTipo.Location = new System.Drawing.Point(213, 91);
            this._comboBoxSalaTipo.Name = "_comboBoxSalaTipo";
            this._comboBoxSalaTipo.Size = new System.Drawing.Size(173, 24);
            this._comboBoxSalaTipo.TabIndex = 33;
            this._comboBoxSalaTipo.Visible = false;
            // 
            // _listBoxRisultatiRicerca
            // 
            this._listBoxRisultatiRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this._listBoxRisultatiRicerca.FormattingEnabled = true;
            this._listBoxRisultatiRicerca.ItemHeight = 16;
            this._listBoxRisultatiRicerca.Location = new System.Drawing.Point(37, 270);
            this._listBoxRisultatiRicerca.Name = "_listBoxRisultatiRicerca";
            this._listBoxRisultatiRicerca.Size = new System.Drawing.Size(737, 340);
            this._listBoxRisultatiRicerca.Sorted = true;
            this._listBoxRisultatiRicerca.TabIndex = 32;
            // 
            // _buttonCerca
            // 
            this._buttonCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this._buttonCerca.Location = new System.Drawing.Point(286, 138);
            this._buttonCerca.Margin = new System.Windows.Forms.Padding(4);
            this._buttonCerca.Name = "_buttonCerca";
            this._buttonCerca.Size = new System.Drawing.Size(100, 29);
            this._buttonCerca.TabIndex = 31;
            this._buttonCerca.Text = "Cerca";
            this._buttonCerca.UseVisualStyleBackColor = true;
            this._buttonCerca.Click += new System.EventHandler(this._buttonCerca_Click);
            // 
            // _labelParametro
            // 
            this._labelParametro.AutoSize = true;
            this._labelParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this._labelParametro.Location = new System.Drawing.Point(34, 94);
            this._labelParametro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelParametro.Name = "_labelParametro";
            this._labelParametro.Size = new System.Drawing.Size(78, 17);
            this._labelParametro.TabIndex = 30;
            this._labelParametro.Text = "Parametro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.Location = new System.Drawing.Point(34, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Criterio ricerca:";
            // 
            // _dateTimePickerRicerca
            // 
            this._dateTimePickerRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this._dateTimePickerRicerca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dateTimePickerRicerca.Location = new System.Drawing.Point(213, 93);
            this._dateTimePickerRicerca.Margin = new System.Windows.Forms.Padding(4);
            this._dateTimePickerRicerca.Name = "_dateTimePickerRicerca";
            this._dateTimePickerRicerca.Size = new System.Drawing.Size(173, 22);
            this._dateTimePickerRicerca.TabIndex = 21;
            this._dateTimePickerRicerca.Visible = false;
            // 
            // _textBoxNomeCognome
            // 
            this._textBoxNomeCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this._textBoxNomeCognome.Location = new System.Drawing.Point(213, 91);
            this._textBoxNomeCognome.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxNomeCognome.Name = "_textBoxNomeCognome";
            this._textBoxNomeCognome.Size = new System.Drawing.Size(173, 22);
            this._textBoxNomeCognome.TabIndex = 26;
            this._textBoxNomeCognome.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button2.Location = new System.Drawing.Point(802, 306);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 25;
            this.button2.Text = "Elimina";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _buttonModifica
            // 
            this._buttonModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this._buttonModifica.Location = new System.Drawing.Point(802, 270);
            this._buttonModifica.Margin = new System.Windows.Forms.Padding(4);
            this._buttonModifica.Name = "_buttonModifica";
            this._buttonModifica.Size = new System.Drawing.Size(100, 29);
            this._buttonModifica.TabIndex = 24;
            this._buttonModifica.Text = "Modifica";
            this._buttonModifica.UseVisualStyleBackColor = true;
            this._buttonModifica.Click += new System.EventHandler(this._buttonModifica_Click);
            // 
            // _labelRisultati
            // 
            this._labelRisultati.AutoSize = true;
            this._labelRisultati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelRisultati.Location = new System.Drawing.Point(33, 227);
            this._labelRisultati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelRisultati.Name = "_labelRisultati";
            this._labelRisultati.Size = new System.Drawing.Size(88, 24);
            this._labelRisultati.TabIndex = 23;
            this._labelRisultati.Text = "Risultati:";
            // 
            // _comboBoxCriterioRicerca
            // 
            this._comboBoxCriterioRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this._comboBoxCriterioRicerca.FormattingEnabled = true;
            this._comboBoxCriterioRicerca.Location = new System.Drawing.Point(213, 53);
            this._comboBoxCriterioRicerca.Margin = new System.Windows.Forms.Padding(4);
            this._comboBoxCriterioRicerca.Name = "_comboBoxCriterioRicerca";
            this._comboBoxCriterioRicerca.Size = new System.Drawing.Size(173, 24);
            this._comboBoxCriterioRicerca.TabIndex = 22;
            this._comboBoxCriterioRicerca.SelectedIndexChanged += new System.EventHandler(this._comboBoxCriterioRicerca_SelectedIndexChanged);
            // 
            // _groupBoxAgenda
            // 
            this._groupBoxAgenda.AutoSize = true;
            this._groupBoxAgenda.Controls.Add(this.panel1);
            this._groupBoxAgenda.Controls.Add(this.dataGridView1);
            this._groupBoxAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._groupBoxAgenda.Location = new System.Drawing.Point(13, 39);
            this._groupBoxAgenda.Name = "_groupBoxAgenda";
            this._groupBoxAgenda.Size = new System.Drawing.Size(846, 653);
            this._groupBoxAgenda.TabIndex = 4;
            this._groupBoxAgenda.TabStop = false;
            this._groupBoxAgenda.Text = "Agenda";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(8, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 234);
            this.panel1.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(4, 4);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 354);
            this.dataGridView1.TabIndex = 6;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1811, 697);
            this.Controls.Add(this._groupBoxAgenda);
            this.Controls.Add(this._groupBoxRicercaPrenotazioni);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "MainView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._groupBoxRicercaPrenotazioni.ResumeLayout(false);
            this._groupBoxRicercaPrenotazioni.PerformLayout();
            this._groupBoxAgenda.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registraNuovoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prenotazioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prenotazioneSingolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prenotazionePeriodicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipologieSalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrazioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mixaggioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox _groupBoxRicercaPrenotazioni;
        private System.Windows.Forms.ComboBox _comboBoxSalaTipo;
        private System.Windows.Forms.ListBox _listBoxRisultatiRicerca;
        private System.Windows.Forms.Button _buttonCerca;
        private System.Windows.Forms.Label _labelParametro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker _dateTimePickerRicerca;
        private System.Windows.Forms.TextBox _textBoxNomeCognome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button _buttonModifica;
        private System.Windows.Forms.Label _labelRisultati;
        private System.Windows.Forms.ComboBox _comboBoxCriterioRicerca;
        private System.Windows.Forms.GroupBox _groupBoxAgenda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}