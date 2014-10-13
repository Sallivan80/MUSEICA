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
            this._textBoxEmail = new System.Windows.Forms.TextBox();
            this._textBoxTelefono = new System.Windows.Forms.TextBox();
            this._textBoxIndirizzo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._abilitaModificheImpostaProfilo = new System.Windows.Forms.CheckBox();
            this._textBoxNomeCentroSaleProva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this._tabGestioneProfilo.Margin = new System.Windows.Forms.Padding(4);
            this._tabGestioneProfilo.Name = "_tabGestioneProfilo";
            this._tabGestioneProfilo.SelectedIndex = 0;
            this._tabGestioneProfilo.Size = new System.Drawing.Size(868, 327);
            this._tabGestioneProfilo.TabIndex = 0;
            // 
            // _tabPageImpostaProfilo
            // 
            this._tabPageImpostaProfilo.Controls.Add(this._textBoxEmail);
            this._tabPageImpostaProfilo.Controls.Add(this._textBoxTelefono);
            this._tabPageImpostaProfilo.Controls.Add(this._textBoxIndirizzo);
            this._tabPageImpostaProfilo.Controls.Add(this.label4);
            this._tabPageImpostaProfilo.Controls.Add(this._abilitaModificheImpostaProfilo);
            this._tabPageImpostaProfilo.Controls.Add(this._textBoxNomeCentroSaleProva);
            this._tabPageImpostaProfilo.Controls.Add(this.label1);
            this._tabPageImpostaProfilo.Controls.Add(this.label2);
            this._tabPageImpostaProfilo.Controls.Add(this.label3);
            this._tabPageImpostaProfilo.Location = new System.Drawing.Point(4, 25);
            this._tabPageImpostaProfilo.Margin = new System.Windows.Forms.Padding(4);
            this._tabPageImpostaProfilo.Name = "_tabPageImpostaProfilo";
            this._tabPageImpostaProfilo.Padding = new System.Windows.Forms.Padding(4);
            this._tabPageImpostaProfilo.Size = new System.Drawing.Size(860, 298);
            this._tabPageImpostaProfilo.TabIndex = 0;
            this._tabPageImpostaProfilo.Text = "Imposta Profilo";
            this._tabPageImpostaProfilo.UseVisualStyleBackColor = true;
            this._tabPageImpostaProfilo.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // _textBoxEmail
            // 
            this._textBoxEmail.Enabled = false;
            this._textBoxEmail.Location = new System.Drawing.Point(271, 154);
            this._textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxEmail.Name = "_textBoxEmail";
            this._textBoxEmail.Size = new System.Drawing.Size(160, 22);
            this._textBoxEmail.TabIndex = 21;
            // 
            // _textBoxTelefono
            // 
            this._textBoxTelefono.Enabled = false;
            this._textBoxTelefono.Location = new System.Drawing.Point(271, 108);
            this._textBoxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxTelefono.Name = "_textBoxTelefono";
            this._textBoxTelefono.Size = new System.Drawing.Size(160, 22);
            this._textBoxTelefono.TabIndex = 20;
            // 
            // _textBoxIndirizzo
            // 
            this._textBoxIndirizzo.Enabled = false;
            this._textBoxIndirizzo.Location = new System.Drawing.Point(271, 65);
            this._textBoxIndirizzo.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxIndirizzo.Name = "_textBoxIndirizzo";
            this._textBoxIndirizzo.Size = new System.Drawing.Size(160, 22);
            this._textBoxIndirizzo.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "eMail:";
            // 
            // _abilitaModificheImpostaProfilo
            // 
            this._abilitaModificheImpostaProfilo.AutoSize = true;
            this._abilitaModificheImpostaProfilo.Location = new System.Drawing.Point(29, 255);
            this._abilitaModificheImpostaProfilo.Margin = new System.Windows.Forms.Padding(4);
            this._abilitaModificheImpostaProfilo.Name = "_abilitaModificheImpostaProfilo";
            this._abilitaModificheImpostaProfilo.Size = new System.Drawing.Size(132, 21);
            this._abilitaModificheImpostaProfilo.TabIndex = 17;
            this._abilitaModificheImpostaProfilo.Text = "Abilita Modifiche";
            this._abilitaModificheImpostaProfilo.UseVisualStyleBackColor = true;
            this._abilitaModificheImpostaProfilo.CheckedChanged += new System.EventHandler(this._abilitaModificheImpostaProfilo_CheckedChanged_1);
            // 
            // _textBoxNomeCentroSaleProva
            // 
            this._textBoxNomeCentroSaleProva.Enabled = false;
            this._textBoxNomeCentroSaleProva.Location = new System.Drawing.Point(271, 23);
            this._textBoxNomeCentroSaleProva.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxNomeCentroSaleProva.Name = "_textBoxNomeCentroSaleProva";
            this._textBoxNomeCentroSaleProva.Size = new System.Drawing.Size(160, 22);
            this._textBoxNomeCentroSaleProva.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Indirizzo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome Centro Sale Prova:";
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
            this._tabPageGestionePolitica.Margin = new System.Windows.Forms.Padding(4);
            this._tabPageGestionePolitica.Name = "_tabPageGestionePolitica";
            this._tabPageGestionePolitica.Padding = new System.Windows.Forms.Padding(4);
            this._tabPageGestionePolitica.Size = new System.Drawing.Size(860, 298);
            this._tabPageGestionePolitica.TabIndex = 1;
            this._tabPageGestionePolitica.Text = "Gestione Politica";
            this._tabPageGestionePolitica.UseVisualStyleBackColor = true;
            // 
            // _abilitaModificheGestionePolitica
            // 
            this._abilitaModificheGestionePolitica.AutoSize = true;
            this._abilitaModificheGestionePolitica.Location = new System.Drawing.Point(29, 255);
            this._abilitaModificheGestionePolitica.Margin = new System.Windows.Forms.Padding(4);
            this._abilitaModificheGestionePolitica.Name = "_abilitaModificheGestionePolitica";
            this._abilitaModificheGestionePolitica.Size = new System.Drawing.Size(132, 21);
            this._abilitaModificheGestionePolitica.TabIndex = 10;
            this._abilitaModificheGestionePolitica.Text = "Abilita Modifiche";
            this._abilitaModificheGestionePolitica.UseVisualStyleBackColor = true;
            this._abilitaModificheGestionePolitica.CheckedChanged += new System.EventHandler(this._abilitaModificheGestionePolitica_CheckedChanged);
            // 
            // _textBoxPreavvisoDisdetta
            // 
            this._textBoxPreavvisoDisdetta.Enabled = false;
            this._textBoxPreavvisoDisdetta.Location = new System.Drawing.Point(261, 18);
            this._textBoxPreavvisoDisdetta.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxPreavvisoDisdetta.Name = "_textBoxPreavvisoDisdetta";
            this._textBoxPreavvisoDisdetta.Size = new System.Drawing.Size(160, 22);
            this._textBoxPreavvisoDisdetta.TabIndex = 6;
            this._textBoxPreavvisoDisdetta.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // _comboBoxScontoClienteRegistrato
            // 
            this._comboBoxScontoClienteRegistrato.Enabled = false;
            this._comboBoxScontoClienteRegistrato.FormattingEnabled = true;
            this._comboBoxScontoClienteRegistrato.Location = new System.Drawing.Point(261, 62);
            this._comboBoxScontoClienteRegistrato.Margin = new System.Windows.Forms.Padding(4);
            this._comboBoxScontoClienteRegistrato.Name = "_comboBoxScontoClienteRegistrato";
            this._comboBoxScontoClienteRegistrato.Size = new System.Drawing.Size(160, 24);
            this._comboBoxScontoClienteRegistrato.TabIndex = 5;
            this._comboBoxScontoClienteRegistrato.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // _comboBoxScontoPrenotazionePeriodica
            // 
            this._comboBoxScontoPrenotazionePeriodica.Enabled = false;
            this._comboBoxScontoPrenotazionePeriodica.FormattingEnabled = true;
            this._comboBoxScontoPrenotazionePeriodica.Location = new System.Drawing.Point(261, 105);
            this._comboBoxScontoPrenotazionePeriodica.Margin = new System.Windows.Forms.Padding(4);
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
            this._tabPageGestioneSale.Margin = new System.Windows.Forms.Padding(4);
            this._tabPageGestioneSale.Name = "_tabPageGestioneSale";
            this._tabPageGestioneSale.Padding = new System.Windows.Forms.Padding(4);
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
            this._listBoxDescrizioneSaleGestioneSale.Margin = new System.Windows.Forms.Padding(4);
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
            this._listBoxSaleGestioneSale.Margin = new System.Windows.Forms.Padding(4);
            this._listBoxSaleGestioneSale.Name = "_listBoxSaleGestioneSale";
            this._listBoxSaleGestioneSale.Size = new System.Drawing.Size(273, 244);
            this._listBoxSaleGestioneSale.TabIndex = 3;
            this._listBoxSaleGestioneSale.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // _eliminaSalaButton
            // 
            this._eliminaSalaButton.Location = new System.Drawing.Point(35, 242);
            this._eliminaSalaButton.Margin = new System.Windows.Forms.Padding(4);
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
            this._modificaSalaButton.Margin = new System.Windows.Forms.Padding(4);
            this._modificaSalaButton.Name = "_modificaSalaButton";
            this._modificaSalaButton.Size = new System.Drawing.Size(100, 28);
            this._modificaSalaButton.TabIndex = 1;
            this._modificaSalaButton.Text = "Modifica";
            this._modificaSalaButton.UseVisualStyleBackColor = true;
            // 
            // _aggiungiSalaButton
            // 
            this._aggiungiSalaButton.Location = new System.Drawing.Point(35, 52);
            this._aggiungiSalaButton.Margin = new System.Windows.Forms.Padding(4);
            this._aggiungiSalaButton.Name = "_aggiungiSalaButton";
            this._aggiungiSalaButton.Size = new System.Drawing.Size(100, 28);
            this._aggiungiSalaButton.TabIndex = 0;
            this._aggiungiSalaButton.Text = "Aggiungi";
            this._aggiungiSalaButton.UseVisualStyleBackColor = true;
            this._aggiungiSalaButton.Click += new System.EventHandler(this.button1_Click);
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
            this._tabPageGestioneClientiRegistrati.Margin = new System.Windows.Forms.Padding(4);
            this._tabPageGestioneClientiRegistrati.Name = "_tabPageGestioneClientiRegistrati";
            this._tabPageGestioneClientiRegistrati.Padding = new System.Windows.Forms.Padding(4);
            this._tabPageGestioneClientiRegistrati.Size = new System.Drawing.Size(860, 298);
            this._tabPageGestioneClientiRegistrati.TabIndex = 3;
            this._tabPageGestioneClientiRegistrati.Text = "Gestione Clienti Registrati";
            this._tabPageGestioneClientiRegistrati.UseVisualStyleBackColor = true;
            // 
            // _storicoPrenotazioniButton
            // 
            this._storicoPrenotazioniButton.Location = new System.Drawing.Point(35, 123);
            this._storicoPrenotazioniButton.Margin = new System.Windows.Forms.Padding(4);
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
            this._listBoxDettagliGestioneClientiRegistrati.Margin = new System.Windows.Forms.Padding(4);
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
            this._listBoxClientiRegistratiGestioneClientiRegistrati.Margin = new System.Windows.Forms.Padding(4);
            this._listBoxClientiRegistratiGestioneClientiRegistrati.Name = "_listBoxClientiRegistratiGestioneClientiRegistrati";
            this._listBoxClientiRegistratiGestioneClientiRegistrati.Size = new System.Drawing.Size(273, 244);
            this._listBoxClientiRegistratiGestioneClientiRegistrati.TabIndex = 17;
            this._listBoxClientiRegistratiGestioneClientiRegistrati.SelectedIndexChanged += new System.EventHandler(this._listBoxClientiRegistratiGestioneClientiRegistrati_SelectedIndexChanged_1);
            // 
            // _eliminaClienteRegistratoButton
            // 
            this._eliminaClienteRegistratoButton.Location = new System.Drawing.Point(35, 242);
            this._eliminaClienteRegistratoButton.Margin = new System.Windows.Forms.Padding(4);
            this._eliminaClienteRegistratoButton.Name = "_eliminaClienteRegistratoButton";
            this._eliminaClienteRegistratoButton.Size = new System.Drawing.Size(100, 28);
            this._eliminaClienteRegistratoButton.TabIndex = 16;
            this._eliminaClienteRegistratoButton.Text = "Elimina";
            this._eliminaClienteRegistratoButton.UseVisualStyleBackColor = true;
            // 
            // _modificaClienteRegistratoButton
            // 
            this._modificaClienteRegistratoButton.Location = new System.Drawing.Point(35, 87);
            this._modificaClienteRegistratoButton.Margin = new System.Windows.Forms.Padding(4);
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
            this._aggiungiClienteRegistratoButton.Margin = new System.Windows.Forms.Padding(4);
            this._aggiungiClienteRegistratoButton.Name = "_aggiungiClienteRegistratoButton";
            this._aggiungiClienteRegistratoButton.Size = new System.Drawing.Size(100, 28);
            this._aggiungiClienteRegistratoButton.TabIndex = 14;
            this._aggiungiClienteRegistratoButton.Text = "Aggiungi";
            this._aggiungiClienteRegistratoButton.UseVisualStyleBackColor = true;
            this._aggiungiClienteRegistratoButton.Click += new System.EventHandler(this._aggiungiClienteRegistratoButton_Click);
            // 
            // _panelOkAnnullaGestioneProfilo
            // 
            this._panelOkAnnullaGestioneProfilo.Controls.Add(this._annullaButton);
            this._panelOkAnnullaGestioneProfilo.Controls.Add(this._okButton);
            this._panelOkAnnullaGestioneProfilo.Location = new System.Drawing.Point(7, 334);
            this._panelOkAnnullaGestioneProfilo.Margin = new System.Windows.Forms.Padding(4);
            this._panelOkAnnullaGestioneProfilo.Name = "_panelOkAnnullaGestioneProfilo";
            this._panelOkAnnullaGestioneProfilo.Size = new System.Drawing.Size(863, 52);
            this._panelOkAnnullaGestioneProfilo.TabIndex = 1;
            // 
            // _annullaButton
            // 
            this._annullaButton.Location = new System.Drawing.Point(748, 15);
            this._annullaButton.Margin = new System.Windows.Forms.Padding(4);
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
            this._okButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfiloView";
            this.Text = "Profilo";
            this.Load += new System.EventHandler(this.ProfiloView_Load_1);
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
        private System.Windows.Forms.TabPage _tabPageImpostaProfilo;
        private System.Windows.Forms.TextBox _textBoxEmail;
        private System.Windows.Forms.TextBox _textBoxTelefono;
        private System.Windows.Forms.TextBox _textBoxIndirizzo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox _abilitaModificheImpostaProfilo;
        private System.Windows.Forms.TextBox _textBoxNomeCentroSaleProva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}