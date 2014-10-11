namespace MUSEICA.ProvaView
{
    partial class ProfiloView
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
            this._tabGestioneProfilo = new System.Windows.Forms.TabControl();
            this._tabPageImpostaProfilo = new System.Windows.Forms.TabPage();
            this._abilitaModificheImpostaProfilo = new System.Windows.Forms.CheckBox();
            this._textBoxEmail = new System.Windows.Forms.TextBox();
            this._labelEmail = new System.Windows.Forms.Label();
            this._textBoxTelefono = new System.Windows.Forms.TextBox();
            this._textBoxIndirizzo = new System.Windows.Forms.TextBox();
            this._textBoxNomeCentroSaleProva = new System.Windows.Forms.TextBox();
            this._labelTelefono = new System.Windows.Forms.Label();
            this._labelIndirizzo = new System.Windows.Forms.Label();
            this._labelNomeCentroSaleProva = new System.Windows.Forms.Label();
            this._tabPageGestionePolitica = new System.Windows.Forms.TabPage();
            this._abilitaModificheGestionePolitica = new System.Windows.Forms.CheckBox();
            this._textBoxPreavvisoDisdetta = new System.Windows.Forms.TextBox();
            this._comboBoxScontoClienteRegistrato = new System.Windows.Forms.ComboBox();
            this._comboBoxScontoPrenotazionePeriodica = new System.Windows.Forms.ComboBox();
            this._labelScontoPrenotazionePeriodica = new System.Windows.Forms.Label();
            this._labelScontoClienteRegistrato = new System.Windows.Forms.Label();
            this._labelPreavvisoDisdetta = new System.Windows.Forms.Label();
            this._tabPageGestioneSale = new System.Windows.Forms.TabPage();
            this._labelDescrizioneSaleGestioneSale = new System.Windows.Forms.Label();
            this._listBoxDescrizioneSaleGestioneSale = new System.Windows.Forms.ListBox();
            this._labelSale = new System.Windows.Forms.Label();
            this._listBoxSaleGestioneSale = new System.Windows.Forms.ListBox();
            this._eliminaSalaButton = new System.Windows.Forms.Button();
            this._modificaSalaButton = new System.Windows.Forms.Button();
            this._aggiungiSalaButton = new System.Windows.Forms.Button();
            this._tabPageGestioneClientiRegistrati = new System.Windows.Forms.TabPage();
            this._storicoPrenotazioniButton = new System.Windows.Forms.Button();
            this._labelDettagliClientiRegistrati = new System.Windows.Forms.Label();
            this._listBoxDettagliGestioneClientiRegistrati = new System.Windows.Forms.ListBox();
            this._labelClientiRegistratiGestioneClienti = new System.Windows.Forms.Label();
            this._listBoxClientiRegistratiGestioneClientiRegistrati = new System.Windows.Forms.ListBox();
            this._eliminaClienteRegistratoButton = new System.Windows.Forms.Button();
            this._modificaClienteRegistratoButton = new System.Windows.Forms.Button();
            this._aggiungiClienteRegistratoButton = new System.Windows.Forms.Button();
            this._panelOkAnnullaGestioneProfilo = new System.Windows.Forms.Panel();
            this._annullaButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this._tabGestioneProfilo.SuspendLayout();
            this._tabPageImpostaProfilo.SuspendLayout();
            this._tabPageGestionePolitica.SuspendLayout();
            this._tabPageGestioneSale.SuspendLayout();
            this._tabPageGestioneClientiRegistrati.SuspendLayout();
            this._panelOkAnnullaGestioneProfilo.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tabGestioneProfilo
            // 
            this._tabGestioneProfilo.Controls.Add(this._tabPageImpostaProfilo);
            this._tabGestioneProfilo.Controls.Add(this._tabPageGestionePolitica);
            this._tabGestioneProfilo.Controls.Add(this._tabPageGestioneSale);
            this._tabGestioneProfilo.Controls.Add(this._tabPageGestioneClientiRegistrati);
            this._tabGestioneProfilo.Location = new System.Drawing.Point(1, 2);
            this._tabGestioneProfilo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tabGestioneProfilo.Name = "_tabGestioneProfilo";
            this._tabGestioneProfilo.SelectedIndex = 0;
            this._tabGestioneProfilo.Size = new System.Drawing.Size(868, 327);
            this._tabGestioneProfilo.TabIndex = 0;
            // 
            // _tabPageImpostaProfilo
            // 
            this._tabPageImpostaProfilo.Controls.Add(this._abilitaModificheImpostaProfilo);
            this._tabPageImpostaProfilo.Controls.Add(this._textBoxEmail);
            this._tabPageImpostaProfilo.Controls.Add(this._labelEmail);
            this._tabPageImpostaProfilo.Controls.Add(this._textBoxTelefono);
            this._tabPageImpostaProfilo.Controls.Add(this._textBoxIndirizzo);
            this._tabPageImpostaProfilo.Controls.Add(this._textBoxNomeCentroSaleProva);
            this._tabPageImpostaProfilo.Controls.Add(this._labelTelefono);
            this._tabPageImpostaProfilo.Controls.Add(this._labelIndirizzo);
            this._tabPageImpostaProfilo.Controls.Add(this._labelNomeCentroSaleProva);
            this._tabPageImpostaProfilo.Location = new System.Drawing.Point(4, 25);
            this._tabPageImpostaProfilo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tabPageImpostaProfilo.Name = "_tabPageImpostaProfilo";
            this._tabPageImpostaProfilo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tabPageImpostaProfilo.Size = new System.Drawing.Size(860, 298);
            this._tabPageImpostaProfilo.TabIndex = 0;
            this._tabPageImpostaProfilo.Text = "Imposta Profilo";
            this._tabPageImpostaProfilo.UseVisualStyleBackColor = true;
            this._tabPageImpostaProfilo.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // _tabPageGestionePolitica
            // 
            this._tabPageGestionePolitica.Controls.Add(this._abilitaModificheGestionePolitica);
            this._tabPageGestionePolitica.Controls.Add(this._textBoxPreavvisoDisdetta);
            this._tabPageGestionePolitica.Controls.Add(this._comboBoxScontoClienteRegistrato);
            this._tabPageGestionePolitica.Controls.Add(this._comboBoxScontoPrenotazionePeriodica);
            this._tabPageGestionePolitica.Controls.Add(this._labelScontoPrenotazionePeriodica);
            this._tabPageGestionePolitica.Controls.Add(this._labelScontoClienteRegistrato);
            this._tabPageGestionePolitica.Controls.Add(this._labelPreavvisoDisdetta);
            this._tabPageGestionePolitica.Location = new System.Drawing.Point(4, 25);
            this._tabPageGestionePolitica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tabPageGestionePolitica.Name = "_tabPageGestionePolitica";
            this._tabPageGestionePolitica.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tabPageGestionePolitica.Size = new System.Drawing.Size(860, 298);
            this._tabPageGestionePolitica.TabIndex = 1;
            this._tabPageGestionePolitica.Text = "Gestione Politica";
            this._tabPageGestionePolitica.UseVisualStyleBackColor = true;
            // 
            // _abilitaModificheGestionePolitica
            // 
            this._abilitaModificheGestionePolitica.AutoSize = true;
            this._abilitaModificheGestionePolitica.Location = new System.Drawing.Point(29, 255);
            this._abilitaModificheGestionePolitica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._abilitaModificheGestionePolitica.Name = "_abilitaModificheGestionePolitica";
            this._abilitaModificheGestionePolitica.Size = new System.Drawing.Size(132, 21);
            this._abilitaModificheGestionePolitica.TabIndex = 10;
            this._abilitaModificheGestionePolitica.Text = "Abilita Modifiche";
            this._abilitaModificheGestionePolitica.UseVisualStyleBackColor = true;
            this._abilitaModificheGestionePolitica.CheckedChanged += new System.EventHandler(this._abilitaModificheGestionePolitica_CheckedChanged);
            // 
            // _textBoxPreavvisoDisdetta
            // 
            this._textBoxPreavvisoDisdetta.Location = new System.Drawing.Point(261, 18);
            this._textBoxPreavvisoDisdetta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._textBoxPreavvisoDisdetta.Name = "_textBoxPreavvisoDisdetta";
            this._textBoxPreavvisoDisdetta.Size = new System.Drawing.Size(160, 22);
            this._textBoxPreavvisoDisdetta.TabIndex = 6;
            this._textBoxPreavvisoDisdetta.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // _comboBoxScontoClienteRegistrato
            // 
            this._comboBoxScontoClienteRegistrato.FormattingEnabled = true;
            this._comboBoxScontoClienteRegistrato.Location = new System.Drawing.Point(261, 62);
            this._comboBoxScontoClienteRegistrato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._comboBoxScontoClienteRegistrato.Name = "_comboBoxScontoClienteRegistrato";
            this._comboBoxScontoClienteRegistrato.Size = new System.Drawing.Size(160, 24);
            this._comboBoxScontoClienteRegistrato.TabIndex = 5;
            this._comboBoxScontoClienteRegistrato.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // _comboBoxScontoPrenotazionePeriodica
            // 
            this._comboBoxScontoPrenotazionePeriodica.FormattingEnabled = true;
            this._comboBoxScontoPrenotazionePeriodica.Location = new System.Drawing.Point(261, 105);
            this._comboBoxScontoPrenotazionePeriodica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._comboBoxScontoPrenotazionePeriodica.Name = "_comboBoxScontoPrenotazionePeriodica";
            this._comboBoxScontoPrenotazionePeriodica.Size = new System.Drawing.Size(160, 24);
            this._comboBoxScontoPrenotazionePeriodica.TabIndex = 4;
            // 
            // _labelScontoPrenotazionePeriodica
            // 
            this._labelScontoPrenotazionePeriodica.AutoSize = true;
            this._labelScontoPrenotazionePeriodica.Location = new System.Drawing.Point(25, 114);
            this._labelScontoPrenotazionePeriodica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelScontoPrenotazionePeriodica.Name = "_labelScontoPrenotazionePeriodica";
            this._labelScontoPrenotazionePeriodica.Size = new System.Drawing.Size(203, 17);
            this._labelScontoPrenotazionePeriodica.TabIndex = 3;
            this._labelScontoPrenotazionePeriodica.Text = "Sconto Prenotazione Periodica";
            // 
            // _labelScontoClienteRegistrato
            // 
            this._labelScontoClienteRegistrato.AutoSize = true;
            this._labelScontoClienteRegistrato.Location = new System.Drawing.Point(25, 71);
            this._labelScontoClienteRegistrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelScontoClienteRegistrato.Name = "_labelScontoClienteRegistrato";
            this._labelScontoClienteRegistrato.Size = new System.Drawing.Size(168, 17);
            this._labelScontoClienteRegistrato.TabIndex = 2;
            this._labelScontoClienteRegistrato.Text = "Sconto Cliente Registrato";
            this._labelScontoClienteRegistrato.Click += new System.EventHandler(this.label6_Click);
            // 
            // _labelPreavvisoDisdetta
            // 
            this._labelPreavvisoDisdetta.AutoSize = true;
            this._labelPreavvisoDisdetta.Location = new System.Drawing.Point(25, 27);
            this._labelPreavvisoDisdetta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelPreavvisoDisdetta.Name = "_labelPreavvisoDisdetta";
            this._labelPreavvisoDisdetta.Size = new System.Drawing.Size(126, 17);
            this._labelPreavvisoDisdetta.TabIndex = 1;
            this._labelPreavvisoDisdetta.Text = "Preavviso Disdetta";
            // 
            // _tabPageGestioneSale
            // 
            this._tabPageGestioneSale.Controls.Add(this._labelDescrizioneSaleGestioneSale);
            this._tabPageGestioneSale.Controls.Add(this._listBoxDescrizioneSaleGestioneSale);
            this._tabPageGestioneSale.Controls.Add(this._labelSale);
            this._tabPageGestioneSale.Controls.Add(this._listBoxSaleGestioneSale);
            this._tabPageGestioneSale.Controls.Add(this._eliminaSalaButton);
            this._tabPageGestioneSale.Controls.Add(this._modificaSalaButton);
            this._tabPageGestioneSale.Controls.Add(this._aggiungiSalaButton);
            this._tabPageGestioneSale.Location = new System.Drawing.Point(4, 25);
            this._tabPageGestioneSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tabPageGestioneSale.Name = "_tabPageGestioneSale";
            this._tabPageGestioneSale.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tabPageGestioneSale.Size = new System.Drawing.Size(860, 298);
            this._tabPageGestioneSale.TabIndex = 2;
            this._tabPageGestioneSale.Text = "Gestione Sale";
            this._tabPageGestioneSale.UseVisualStyleBackColor = true;
            // 
            // _labelDescrizioneSaleGestioneSale
            // 
            this._labelDescrizioneSaleGestioneSale.AutoSize = true;
            this._labelDescrizioneSaleGestioneSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDescrizioneSaleGestioneSale.Location = new System.Drawing.Point(543, 17);
            this._labelDescrizioneSaleGestioneSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelDescrizioneSaleGestioneSale.Name = "_labelDescrizioneSaleGestioneSale";
            this._labelDescrizioneSaleGestioneSale.Size = new System.Drawing.Size(98, 17);
            this._labelDescrizioneSaleGestioneSale.TabIndex = 6;
            this._labelDescrizioneSaleGestioneSale.Text = "Descrizione:";
            this._labelDescrizioneSaleGestioneSale.Click += new System.EventHandler(this.label9_Click);
            // 
            // _listBoxDescrizioneSaleGestioneSale
            // 
            this._listBoxDescrizioneSaleGestioneSale.FormattingEnabled = true;
            this._listBoxDescrizioneSaleGestioneSale.ItemHeight = 16;
            this._listBoxDescrizioneSaleGestioneSale.Location = new System.Drawing.Point(547, 37);
            this._listBoxDescrizioneSaleGestioneSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._listBoxDescrizioneSaleGestioneSale.Name = "_listBoxDescrizioneSaleGestioneSale";
            this._listBoxDescrizioneSaleGestioneSale.Size = new System.Drawing.Size(273, 244);
            this._listBoxDescrizioneSaleGestioneSale.TabIndex = 5;
            this._listBoxDescrizioneSaleGestioneSale.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // _labelSale
            // 
            this._labelSale.AutoSize = true;
            this._labelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelSale.Location = new System.Drawing.Point(207, 14);
            this._labelSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelSale.Name = "_labelSale";
            this._labelSale.Size = new System.Drawing.Size(45, 17);
            this._labelSale.TabIndex = 4;
            this._labelSale.Text = "Sale:";
            this._labelSale.Click += new System.EventHandler(this.label8_Click);
            // 
            // _listBoxSaleGestioneSale
            // 
            this._listBoxSaleGestioneSale.FormattingEnabled = true;
            this._listBoxSaleGestioneSale.ItemHeight = 16;
            this._listBoxSaleGestioneSale.Location = new System.Drawing.Point(207, 37);
            this._listBoxSaleGestioneSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._listBoxSaleGestioneSale.Name = "_listBoxSaleGestioneSale";
            this._listBoxSaleGestioneSale.Size = new System.Drawing.Size(273, 244);
            this._listBoxSaleGestioneSale.TabIndex = 3;
            this._listBoxSaleGestioneSale.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // _eliminaSalaButton
            // 
            this._eliminaSalaButton.Location = new System.Drawing.Point(35, 242);
            this._eliminaSalaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._eliminaSalaButton.Name = "_eliminaSalaButton";
            this._eliminaSalaButton.Size = new System.Drawing.Size(100, 28);
            this._eliminaSalaButton.TabIndex = 2;
            this._eliminaSalaButton.Text = "Elimina";
            this._eliminaSalaButton.UseVisualStyleBackColor = true;
            this._eliminaSalaButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // _modificaSalaButton
            // 
            this._modificaSalaButton.Location = new System.Drawing.Point(35, 87);
            this._modificaSalaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._modificaSalaButton.Name = "_modificaSalaButton";
            this._modificaSalaButton.Size = new System.Drawing.Size(100, 28);
            this._modificaSalaButton.TabIndex = 1;
            this._modificaSalaButton.Text = "Modifica";
            this._modificaSalaButton.UseVisualStyleBackColor = true;
            this._modificaSalaButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // _aggiungiSalaButton
            // 
            this._aggiungiSalaButton.Location = new System.Drawing.Point(35, 52);
            this._aggiungiSalaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._aggiungiSalaButton.Name = "_aggiungiSalaButton";
            this._aggiungiSalaButton.Size = new System.Drawing.Size(100, 28);
            this._aggiungiSalaButton.TabIndex = 0;
            this._aggiungiSalaButton.Text = "Aggiungi";
            this._aggiungiSalaButton.UseVisualStyleBackColor = true;
            this._aggiungiSalaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // _tabPageGestioneTipoSale
            // 
            this._tabPageGestioneTipoSale.Controls.Add(this._labelDescrizioneGestioneTipoSale);
            this._tabPageGestioneTipoSale.Controls.Add(this._listBoxDescrizioneGestioneTipoSale);
            this._tabPageGestioneTipoSale.Controls.Add(this._labelTipologieSale);
            this._tabPageGestioneTipoSale.Controls.Add(this._listBoxTipologieSaleGestioneTipoSale);
            this._tabPageGestioneTipoSale.Controls.Add(this._eliminaTipoSalaButton);
            this._tabPageGestioneTipoSale.Controls.Add(this._modificaTipoSalaButton);
            this._tabPageGestioneTipoSale.Controls.Add(this._aggiungiTipoSalaButton);
            this._tabPageGestioneTipoSale.Location = new System.Drawing.Point(4, 22);
            this._tabPageGestioneTipoSale.Name = "_tabPageGestioneTipoSale";
            this._tabPageGestioneTipoSale.Size = new System.Drawing.Size(643, 240);
            this._tabPageGestioneTipoSale.TabIndex = 4;
            this._tabPageGestioneTipoSale.Text = "Gestione Tipo Sale";
            this._tabPageGestioneTipoSale.UseVisualStyleBackColor = true;
            // 
            // _labelDescrizioneGestioneTipoSale
            // 
            this._labelDescrizioneGestioneTipoSale.AutoSize = true;
            this._labelDescrizioneGestioneTipoSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDescrizioneGestioneTipoSale.Location = new System.Drawing.Point(407, 14);
            this._labelDescrizioneGestioneTipoSale.Name = "_labelDescrizioneGestioneTipoSale";
            this._labelDescrizioneGestioneTipoSale.Size = new System.Drawing.Size(77, 13);
            this._labelDescrizioneGestioneTipoSale.TabIndex = 13;
            this._labelDescrizioneGestioneTipoSale.Text = "Descrizione:";
            // 
            // _listBoxDescrizioneGestioneTipoSale
            // 
            this._listBoxDescrizioneGestioneTipoSale.FormattingEnabled = true;
            this._listBoxDescrizioneGestioneTipoSale.Location = new System.Drawing.Point(410, 30);
            this._listBoxDescrizioneGestioneTipoSale.Name = "_listBoxDescrizioneGestioneTipoSale";
            this._listBoxDescrizioneGestioneTipoSale.Size = new System.Drawing.Size(206, 199);
            this._listBoxDescrizioneGestioneTipoSale.TabIndex = 12;
            // 
            // _labelTipologieSale
            // 
            this._labelTipologieSale.AutoSize = true;
            this._labelTipologieSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelTipologieSale.Location = new System.Drawing.Point(155, 11);
            this._labelTipologieSale.Name = "_labelTipologieSale";
            this._labelTipologieSale.Size = new System.Drawing.Size(92, 13);
            this._labelTipologieSale.TabIndex = 11;
            this._labelTipologieSale.Text = "Tipologie Sale:";
            // 
            // _listBoxTipologieSaleGestioneTipoSale
            // 
            this._listBoxTipologieSaleGestioneTipoSale.FormattingEnabled = true;
            this._listBoxTipologieSaleGestioneTipoSale.Location = new System.Drawing.Point(155, 30);
            this._listBoxTipologieSaleGestioneTipoSale.Name = "_listBoxTipologieSaleGestioneTipoSale";
            this._listBoxTipologieSaleGestioneTipoSale.Size = new System.Drawing.Size(206, 199);
            this._listBoxTipologieSaleGestioneTipoSale.TabIndex = 10;
            // 
            // _eliminaTipoSalaButton
            // 
            this._eliminaTipoSalaButton.Location = new System.Drawing.Point(26, 197);
            this._eliminaTipoSalaButton.Name = "_eliminaTipoSalaButton";
            this._eliminaTipoSalaButton.Size = new System.Drawing.Size(75, 23);
            this._eliminaTipoSalaButton.TabIndex = 9;
            this._eliminaTipoSalaButton.Text = "Elimina";
            this._eliminaTipoSalaButton.UseVisualStyleBackColor = true;
            // 
            // _modificaTipoSalaButton
            // 
            this._modificaTipoSalaButton.Location = new System.Drawing.Point(26, 71);
            this._modificaTipoSalaButton.Name = "_modificaTipoSalaButton";
            this._modificaTipoSalaButton.Size = new System.Drawing.Size(75, 23);
            this._modificaTipoSalaButton.TabIndex = 8;
            this._modificaTipoSalaButton.Text = "Modifica";
            this._modificaTipoSalaButton.UseVisualStyleBackColor = true;
            // 
            // _aggiungiTipoSalaButton
            // 
            this._aggiungiTipoSalaButton.Location = new System.Drawing.Point(26, 42);
            this._aggiungiTipoSalaButton.Name = "_aggiungiTipoSalaButton";
            this._aggiungiTipoSalaButton.Size = new System.Drawing.Size(75, 23);
            this._aggiungiTipoSalaButton.TabIndex = 7;
            this._aggiungiTipoSalaButton.Text = "Aggiungi";
            this._aggiungiTipoSalaButton.UseVisualStyleBackColor = true;
            // 
            // _tabPageGestioneClientiRegistrati
            // 
            this._tabPageGestioneClientiRegistrati.Controls.Add(this._storicoPrenotazioniButton);
            this._tabPageGestioneClientiRegistrati.Controls.Add(this._labelDettagliClientiRegistrati);
            this._tabPageGestioneClientiRegistrati.Controls.Add(this._listBoxDettagliGestioneClientiRegistrati);
            this._tabPageGestioneClientiRegistrati.Controls.Add(this._labelClientiRegistratiGestioneClienti);
            this._tabPageGestioneClientiRegistrati.Controls.Add(this._listBoxClientiRegistratiGestioneClientiRegistrati);
            this._tabPageGestioneClientiRegistrati.Controls.Add(this._eliminaClienteRegistratoButton);
            this._tabPageGestioneClientiRegistrati.Controls.Add(this._modificaClienteRegistratoButton);
            this._tabPageGestioneClientiRegistrati.Controls.Add(this._aggiungiClienteRegistratoButton);
            this._tabPageGestioneClientiRegistrati.Location = new System.Drawing.Point(4, 25);
            this._tabPageGestioneClientiRegistrati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tabPageGestioneClientiRegistrati.Name = "_tabPageGestioneClientiRegistrati";
            this._tabPageGestioneClientiRegistrati.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tabPageGestioneClientiRegistrati.Size = new System.Drawing.Size(860, 298);
            this._tabPageGestioneClientiRegistrati.TabIndex = 3;
            this._tabPageGestioneClientiRegistrati.Text = "Gestione Clienti Registrati";
            this._tabPageGestioneClientiRegistrati.UseVisualStyleBackColor = true;
            // 
            // _storicoPrenotazioniButton
            // 
            this._storicoPrenotazioniButton.Location = new System.Drawing.Point(35, 123);
            this._storicoPrenotazioniButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._storicoPrenotazioniButton.Name = "_storicoPrenotazioniButton";
            this._storicoPrenotazioniButton.Size = new System.Drawing.Size(100, 28);
            this._storicoPrenotazioniButton.TabIndex = 21;
            this._storicoPrenotazioniButton.Text = "Storico";
            this._storicoPrenotazioniButton.UseVisualStyleBackColor = true;
            // 
            // _labelDettagliClientiRegistrati
            // 
            this._labelDettagliClientiRegistrati.AutoSize = true;
            this._labelDettagliClientiRegistrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDettagliClientiRegistrati.Location = new System.Drawing.Point(543, 17);
            this._labelDettagliClientiRegistrati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelDettagliClientiRegistrati.Name = "_labelDettagliClientiRegistrati";
            this._labelDettagliClientiRegistrati.Size = new System.Drawing.Size(69, 17);
            this._labelDettagliClientiRegistrati.TabIndex = 20;
            this._labelDettagliClientiRegistrati.Text = "Dettagli:";
            // 
            // _listBoxDettagliGestioneClientiRegistrati
            // 
            this._listBoxDettagliGestioneClientiRegistrati.FormattingEnabled = true;
            this._listBoxDettagliGestioneClientiRegistrati.ItemHeight = 16;
            this._listBoxDettagliGestioneClientiRegistrati.Location = new System.Drawing.Point(547, 37);
            this._listBoxDettagliGestioneClientiRegistrati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._listBoxDettagliGestioneClientiRegistrati.Name = "_listBoxDettagliGestioneClientiRegistrati";
            this._listBoxDettagliGestioneClientiRegistrati.Size = new System.Drawing.Size(273, 244);
            this._listBoxDettagliGestioneClientiRegistrati.TabIndex = 19;
            // 
            // _labelClientiRegistratiGestioneClienti
            // 
            this._labelClientiRegistratiGestioneClienti.AutoSize = true;
            this._labelClientiRegistratiGestioneClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelClientiRegistratiGestioneClienti.Location = new System.Drawing.Point(207, 14);
            this._labelClientiRegistratiGestioneClienti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelClientiRegistratiGestioneClienti.Name = "_labelClientiRegistratiGestioneClienti";
            this._labelClientiRegistratiGestioneClienti.Size = new System.Drawing.Size(133, 17);
            this._labelClientiRegistratiGestioneClienti.TabIndex = 18;
            this._labelClientiRegistratiGestioneClienti.Text = "Clienti Registrati:";
            // 
            // _listBoxClientiRegistratiGestioneClientiRegistrati
            // 
            this._listBoxClientiRegistratiGestioneClientiRegistrati.FormattingEnabled = true;
            this._listBoxClientiRegistratiGestioneClientiRegistrati.ItemHeight = 16;
            this._listBoxClientiRegistratiGestioneClientiRegistrati.Location = new System.Drawing.Point(207, 37);
            this._listBoxClientiRegistratiGestioneClientiRegistrati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._listBoxClientiRegistratiGestioneClientiRegistrati.Name = "_listBoxClientiRegistratiGestioneClientiRegistrati";
            this._listBoxClientiRegistratiGestioneClientiRegistrati.Size = new System.Drawing.Size(273, 244);
            this._listBoxClientiRegistratiGestioneClientiRegistrati.TabIndex = 17;
            // 
            // _eliminaClienteRegistratoButton
            // 
            this._eliminaClienteRegistratoButton.Location = new System.Drawing.Point(35, 242);
            this._eliminaClienteRegistratoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._eliminaClienteRegistratoButton.Name = "_eliminaClienteRegistratoButton";
            this._eliminaClienteRegistratoButton.Size = new System.Drawing.Size(100, 28);
            this._eliminaClienteRegistratoButton.TabIndex = 16;
            this._eliminaClienteRegistratoButton.Text = "Elimina";
            this._eliminaClienteRegistratoButton.UseVisualStyleBackColor = true;
            // 
            // _modificaClienteRegistratoButton
            // 
            this._modificaClienteRegistratoButton.Location = new System.Drawing.Point(35, 87);
            this._modificaClienteRegistratoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._modificaClienteRegistratoButton.Name = "_modificaClienteRegistratoButton";
            this._modificaClienteRegistratoButton.Size = new System.Drawing.Size(100, 28);
            this._modificaClienteRegistratoButton.TabIndex = 15;
            this._modificaClienteRegistratoButton.Text = "Modifica";
            this._modificaClienteRegistratoButton.UseVisualStyleBackColor = true;
            this._modificaClienteRegistratoButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // _aggiungiClienteRegistratoButton
            // 
            this._aggiungiClienteRegistratoButton.Location = new System.Drawing.Point(35, 52);
            this._aggiungiClienteRegistratoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._aggiungiClienteRegistratoButton.Name = "_aggiungiClienteRegistratoButton";
            this._aggiungiClienteRegistratoButton.Size = new System.Drawing.Size(100, 28);
            this._aggiungiClienteRegistratoButton.TabIndex = 14;
            this._aggiungiClienteRegistratoButton.Text = "Aggiungi";
            this._aggiungiClienteRegistratoButton.UseVisualStyleBackColor = true;
            // 
            // _panelOkAnnullaGestioneProfilo
            // 
            this._panelOkAnnullaGestioneProfilo.Controls.Add(this._annullaButton);
            this._panelOkAnnullaGestioneProfilo.Controls.Add(this._okButton);
            this._panelOkAnnullaGestioneProfilo.Location = new System.Drawing.Point(7, 334);
            this._panelOkAnnullaGestioneProfilo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._panelOkAnnullaGestioneProfilo.Name = "_panelOkAnnullaGestioneProfilo";
            this._panelOkAnnullaGestioneProfilo.Size = new System.Drawing.Size(863, 52);
            this._panelOkAnnullaGestioneProfilo.TabIndex = 1;
            // 
            // _annullaButton
            // 
            this._annullaButton.Location = new System.Drawing.Point(748, 15);
            this._annullaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(100, 28);
            this._annullaButton.TabIndex = 1;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            this._annullaButton.Click += new System.EventHandler(this.button12_Click);
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(640, 15);
            this._okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(100, 28);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "Ok";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // ProfiloView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 389);
            this.Controls.Add(this._panelOkAnnullaGestioneProfilo);
            this.Controls.Add(this._tabGestioneProfilo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProfiloView";
            this.Text = "Profilo";
            this._tabGestioneProfilo.ResumeLayout(false);
            this._tabPageImpostaProfilo.ResumeLayout(false);
            this._tabPageImpostaProfilo.PerformLayout();
            this._tabPageGestionePolitica.ResumeLayout(false);
            this._tabPageGestionePolitica.PerformLayout();
            this._tabPageGestioneSale.ResumeLayout(false);
            this._tabPageGestioneSale.PerformLayout();
            this._tabPageGestioneClientiRegistrati.ResumeLayout(false);
            this._tabPageGestioneClientiRegistrati.PerformLayout();
            this._panelOkAnnullaGestioneProfilo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabGestioneProfilo;
        private System.Windows.Forms.TabPage _tabPageImpostaProfilo;
        private System.Windows.Forms.TabPage _tabPageGestionePolitica;
        private System.Windows.Forms.TabPage _tabPageGestioneSale;
        private System.Windows.Forms.TabPage _tabPageGestioneClientiRegistrati;
        private System.Windows.Forms.TextBox _textBoxPreavvisoDisdetta;
        private System.Windows.Forms.ComboBox _comboBoxScontoClienteRegistrato;
        private System.Windows.Forms.ComboBox _comboBoxScontoPrenotazionePeriodica;
        private System.Windows.Forms.Label _labelScontoPrenotazionePeriodica;
        private System.Windows.Forms.Label _labelScontoClienteRegistrato;
        private System.Windows.Forms.Label _labelPreavvisoDisdetta;
        private System.Windows.Forms.Label _labelDescrizioneSaleGestioneSale;
        private System.Windows.Forms.ListBox _listBoxDescrizioneSaleGestioneSale;
        private System.Windows.Forms.Label _labelSale;
        private System.Windows.Forms.ListBox _listBoxSaleGestioneSale;
        private System.Windows.Forms.Button _eliminaSalaButton;
        private System.Windows.Forms.Button _modificaSalaButton;
        private System.Windows.Forms.Button _aggiungiSalaButton;
        private System.Windows.Forms.Button _storicoPrenotazioniButton;
        private System.Windows.Forms.Label _labelDettagliClientiRegistrati;
        private System.Windows.Forms.ListBox _listBoxDettagliGestioneClientiRegistrati;
        private System.Windows.Forms.Label _labelClientiRegistratiGestioneClienti;
        private System.Windows.Forms.ListBox _listBoxClientiRegistratiGestioneClientiRegistrati;
        private System.Windows.Forms.Button _eliminaClienteRegistratoButton;
        private System.Windows.Forms.Button _modificaClienteRegistratoButton;
        private System.Windows.Forms.Button _aggiungiClienteRegistratoButton;
        private System.Windows.Forms.Panel _panelOkAnnullaGestioneProfilo;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.CheckBox _abilitaModificheGestionePolitica;
        private System.Windows.Forms.CheckBox _abilitaModificheImpostaProfilo;
        private System.Windows.Forms.TextBox _textBoxEmail;
        private System.Windows.Forms.Label _labelEmail;
        private System.Windows.Forms.TextBox _textBoxTelefono;
        private System.Windows.Forms.TextBox _textBoxIndirizzo;
        private System.Windows.Forms.TextBox _textBoxNomeCentroSaleProva;
        private System.Windows.Forms.Label _labelTelefono;
        private System.Windows.Forms.Label _labelIndirizzo;
        private System.Windows.Forms.Label _labelNomeCentroSaleProva;

    }
}