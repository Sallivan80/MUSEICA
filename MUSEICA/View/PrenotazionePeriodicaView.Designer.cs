﻿namespace MUSEICA.View
{
    partial class PrenotazionePeriodicaView
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
            this._listBoxGiornIPrenPeriodica = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this._dateTimePickerInizioPeriodo = new System.Windows.Forms.DateTimePicker();
            this._buttonRimuoviGiorno = new System.Windows.Forms.Button();
            this._listBoxGiorniAggiunti = new System.Windows.Forms.ListBox();
            this._buttonAggiungiGiorno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._dateTimePickerFinePeriodo = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._comboBoxIdTessera = new System.Windows.Forms.ComboBox();
            this._labelIdClientePrenotazione = new System.Windows.Forms.Label();
            this._textBoxIndirizzoCliente = new System.Windows.Forms.TextBox();
            this._labelIndirizzoPrenotazione = new System.Windows.Forms.Label();
            this._textBoxTelefono = new System.Windows.Forms.TextBox();
            this._textBoxCognomeCliente = new System.Windows.Forms.TextBox();
            this._textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this._labelTelefonoPrenotazione = new System.Windows.Forms.Label();
            this._labelCognomePrenotazione = new System.Windows.Forms.Label();
            this._labelNomeClientePrenotazione = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._textBoxTipoSala = new System.Windows.Forms.TextBox();
            this._comboBoxSala = new System.Windows.Forms.ComboBox();
            this._labelTipoSalaPrenotazione = new System.Windows.Forms.Label();
            this._labelSalaPrenotazione = new System.Windows.Forms.Label();
            this._panelOkAnnullaPrenotazione = new System.Windows.Forms.Panel();
            this._buttonOK = new System.Windows.Forms.Button();
            this._buttonAnnulla = new System.Windows.Forms.Button();
            this._listBoxGiornIPrenPeriodica.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this._panelOkAnnullaPrenotazione.SuspendLayout();
            this.SuspendLayout();
            // 
            // _listBoxGiornIPrenPeriodica
            // 
            this._listBoxGiornIPrenPeriodica.Controls.Add(this.label2);
            this._listBoxGiornIPrenPeriodica.Controls.Add(this._dateTimePickerInizioPeriodo);
            this._listBoxGiornIPrenPeriodica.Controls.Add(this._buttonRimuoviGiorno);
            this._listBoxGiornIPrenPeriodica.Controls.Add(this._listBoxGiorniAggiunti);
            this._listBoxGiornIPrenPeriodica.Controls.Add(this._buttonAggiungiGiorno);
            this._listBoxGiornIPrenPeriodica.Controls.Add(this.label3);
            this._listBoxGiornIPrenPeriodica.Controls.Add(this.label1);
            this._listBoxGiornIPrenPeriodica.Controls.Add(this._dateTimePickerFinePeriodo);
            this._listBoxGiornIPrenPeriodica.Location = new System.Drawing.Point(10, 277);
            this._listBoxGiornIPrenPeriodica.Name = "_listBoxGiornIPrenPeriodica";
            this._listBoxGiornIPrenPeriodica.Size = new System.Drawing.Size(380, 259);
            this._listBoxGiornIPrenPeriodica.TabIndex = 25;
            this._listBoxGiornIPrenPeriodica.TabStop = false;
            this._listBoxGiornIPrenPeriodica.Text = "Durata periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Inizio Periodo";
            // 
            // _dateTimePickerInizioPeriodo
            // 
            this._dateTimePickerInizioPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dateTimePickerInizioPeriodo.Location = new System.Drawing.Point(17, 46);
            this._dateTimePickerInizioPeriodo.Name = "_dateTimePickerInizioPeriodo";
            this._dateTimePickerInizioPeriodo.Size = new System.Drawing.Size(100, 20);
            this._dateTimePickerInizioPeriodo.TabIndex = 49;
            // 
            // _buttonRimuoviGiorno
            // 
            this._buttonRimuoviGiorno.Location = new System.Drawing.Point(21, 140);
            this._buttonRimuoviGiorno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._buttonRimuoviGiorno.Name = "_buttonRimuoviGiorno";
            this._buttonRimuoviGiorno.Size = new System.Drawing.Size(70, 24);
            this._buttonRimuoviGiorno.TabIndex = 48;
            this._buttonRimuoviGiorno.Text = "Rimuovi";
            this._buttonRimuoviGiorno.UseVisualStyleBackColor = true;
            this._buttonRimuoviGiorno.Click += new System.EventHandler(this._buttonRimuoviGiorno_Click);
            // 
            // _listBoxGiorniAggiunti
            // 
            this._listBoxGiorniAggiunti.FormattingEnabled = true;
            this._listBoxGiorniAggiunti.Location = new System.Drawing.Point(122, 89);
            this._listBoxGiorniAggiunti.Name = "_listBoxGiorniAggiunti";
            this._listBoxGiorniAggiunti.Size = new System.Drawing.Size(248, 160);
            this._listBoxGiorniAggiunti.TabIndex = 47;
            // 
            // _buttonAggiungiGiorno
            // 
            this._buttonAggiungiGiorno.Location = new System.Drawing.Point(21, 110);
            this._buttonAggiungiGiorno.Name = "_buttonAggiungiGiorno";
            this._buttonAggiungiGiorno.Size = new System.Drawing.Size(70, 24);
            this._buttonAggiungiGiorno.TabIndex = 46;
            this._buttonAggiungiGiorno.Text = "Aggiungi";
            this._buttonAggiungiGiorno.UseVisualStyleBackColor = true;
            this._buttonAggiungiGiorno.Click += new System.EventHandler(this._buttonAggiungiGiorno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Giorni:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Fine Periodo";
            // 
            // _dateTimePickerFinePeriodo
            // 
            this._dateTimePickerFinePeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dateTimePickerFinePeriodo.Location = new System.Drawing.Point(231, 46);
            this._dateTimePickerFinePeriodo.Name = "_dateTimePickerFinePeriodo";
            this._dateTimePickerFinePeriodo.Size = new System.Drawing.Size(100, 20);
            this._dateTimePickerFinePeriodo.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._comboBoxIdTessera);
            this.groupBox2.Controls.Add(this._labelIdClientePrenotazione);
            this.groupBox2.Controls.Add(this._textBoxIndirizzoCliente);
            this.groupBox2.Controls.Add(this._labelIndirizzoPrenotazione);
            this.groupBox2.Controls.Add(this._textBoxTelefono);
            this.groupBox2.Controls.Add(this._textBoxCognomeCliente);
            this.groupBox2.Controls.Add(this._textBoxNomeCliente);
            this.groupBox2.Controls.Add(this._labelTelefonoPrenotazione);
            this.groupBox2.Controls.Add(this._labelCognomePrenotazione);
            this.groupBox2.Controls.Add(this._labelNomeClientePrenotazione);
            this.groupBox2.Location = new System.Drawing.Point(10, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 177);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dati cliente";
            // 
            // _comboBoxIdTessera
            // 
            this._comboBoxIdTessera.FormattingEnabled = true;
            this._comboBoxIdTessera.Location = new System.Drawing.Point(176, 30);
            this._comboBoxIdTessera.Name = "_comboBoxIdTessera";
            this._comboBoxIdTessera.Size = new System.Drawing.Size(198, 21);
            this._comboBoxIdTessera.TabIndex = 27;
            this._comboBoxIdTessera.SelectedIndexChanged += new System.EventHandler(this._comboBoxIdTessera_SelectedIndexChanged_1);
            // 
            // _labelIdClientePrenotazione
            // 
            this._labelIdClientePrenotazione.AutoSize = true;
            this._labelIdClientePrenotazione.Location = new System.Drawing.Point(15, 33);
            this._labelIdClientePrenotazione.Name = "_labelIdClientePrenotazione";
            this._labelIdClientePrenotazione.Size = new System.Drawing.Size(60, 13);
            this._labelIdClientePrenotazione.TabIndex = 26;
            this._labelIdClientePrenotazione.Text = "Id Tessera:";
            // 
            // _textBoxIndirizzoCliente
            // 
            this._textBoxIndirizzoCliente.Location = new System.Drawing.Point(176, 132);
            this._textBoxIndirizzoCliente.Name = "_textBoxIndirizzoCliente";
            this._textBoxIndirizzoCliente.Size = new System.Drawing.Size(198, 20);
            this._textBoxIndirizzoCliente.TabIndex = 24;
            // 
            // _labelIndirizzoPrenotazione
            // 
            this._labelIndirizzoPrenotazione.AutoSize = true;
            this._labelIndirizzoPrenotazione.Location = new System.Drawing.Point(14, 136);
            this._labelIndirizzoPrenotazione.Name = "_labelIndirizzoPrenotazione";
            this._labelIndirizzoPrenotazione.Size = new System.Drawing.Size(48, 13);
            this._labelIndirizzoPrenotazione.TabIndex = 23;
            this._labelIndirizzoPrenotazione.Text = "Indirizzo:";
            // 
            // _textBoxTelefono
            // 
            this._textBoxTelefono.Location = new System.Drawing.Point(176, 107);
            this._textBoxTelefono.Name = "_textBoxTelefono";
            this._textBoxTelefono.Size = new System.Drawing.Size(198, 20);
            this._textBoxTelefono.TabIndex = 22;
            // 
            // _textBoxCognomeCliente
            // 
            this._textBoxCognomeCliente.Location = new System.Drawing.Point(176, 82);
            this._textBoxCognomeCliente.Name = "_textBoxCognomeCliente";
            this._textBoxCognomeCliente.Size = new System.Drawing.Size(198, 20);
            this._textBoxCognomeCliente.TabIndex = 21;
            // 
            // _textBoxNomeCliente
            // 
            this._textBoxNomeCliente.Location = new System.Drawing.Point(176, 57);
            this._textBoxNomeCliente.Name = "_textBoxNomeCliente";
            this._textBoxNomeCliente.Size = new System.Drawing.Size(198, 20);
            this._textBoxNomeCliente.TabIndex = 20;
            // 
            // _labelTelefonoPrenotazione
            // 
            this._labelTelefonoPrenotazione.AutoSize = true;
            this._labelTelefonoPrenotazione.Location = new System.Drawing.Point(14, 110);
            this._labelTelefonoPrenotazione.Name = "_labelTelefonoPrenotazione";
            this._labelTelefonoPrenotazione.Size = new System.Drawing.Size(52, 13);
            this._labelTelefonoPrenotazione.TabIndex = 19;
            this._labelTelefonoPrenotazione.Text = "Telefono:";
            // 
            // _labelCognomePrenotazione
            // 
            this._labelCognomePrenotazione.AutoSize = true;
            this._labelCognomePrenotazione.Location = new System.Drawing.Point(14, 84);
            this._labelCognomePrenotazione.Name = "_labelCognomePrenotazione";
            this._labelCognomePrenotazione.Size = new System.Drawing.Size(55, 13);
            this._labelCognomePrenotazione.TabIndex = 18;
            this._labelCognomePrenotazione.Text = "Cognome:";
            // 
            // _labelNomeClientePrenotazione
            // 
            this._labelNomeClientePrenotazione.AutoSize = true;
            this._labelNomeClientePrenotazione.Location = new System.Drawing.Point(14, 59);
            this._labelNomeClientePrenotazione.Name = "_labelNomeClientePrenotazione";
            this._labelNomeClientePrenotazione.Size = new System.Drawing.Size(38, 13);
            this._labelNomeClientePrenotazione.TabIndex = 17;
            this._labelNomeClientePrenotazione.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._textBoxTipoSala);
            this.groupBox1.Controls.Add(this._comboBoxSala);
            this.groupBox1.Controls.Add(this._labelTipoSalaPrenotazione);
            this.groupBox1.Controls.Add(this._labelSalaPrenotazione);
            this.groupBox1.Location = new System.Drawing.Point(10, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 76);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sala e tipologia";
            // 
            // _textBoxTipoSala
            // 
            this._textBoxTipoSala.Location = new System.Drawing.Point(176, 49);
            this._textBoxTipoSala.Name = "_textBoxTipoSala";
            this._textBoxTipoSala.ReadOnly = true;
            this._textBoxTipoSala.Size = new System.Drawing.Size(198, 20);
            this._textBoxTipoSala.TabIndex = 17;
            // 
            // _comboBoxSala
            // 
            this._comboBoxSala.FormattingEnabled = true;
            this._comboBoxSala.Location = new System.Drawing.Point(176, 24);
            this._comboBoxSala.Name = "_comboBoxSala";
            this._comboBoxSala.Size = new System.Drawing.Size(198, 21);
            this._comboBoxSala.TabIndex = 16;
            this._comboBoxSala.SelectedIndexChanged += new System.EventHandler(this._comboBoxSala_SelectedIndexChanged);
            // 
            // _labelTipoSalaPrenotazione
            // 
            this._labelTipoSalaPrenotazione.AutoSize = true;
            this._labelTipoSalaPrenotazione.Location = new System.Drawing.Point(15, 52);
            this._labelTipoSalaPrenotazione.Name = "_labelTipoSalaPrenotazione";
            this._labelTipoSalaPrenotazione.Size = new System.Drawing.Size(31, 13);
            this._labelTipoSalaPrenotazione.TabIndex = 15;
            this._labelTipoSalaPrenotazione.Text = "Tipo:";
            // 
            // _labelSalaPrenotazione
            // 
            this._labelSalaPrenotazione.AutoSize = true;
            this._labelSalaPrenotazione.Location = new System.Drawing.Point(15, 26);
            this._labelSalaPrenotazione.Name = "_labelSalaPrenotazione";
            this._labelSalaPrenotazione.Size = new System.Drawing.Size(31, 13);
            this._labelSalaPrenotazione.TabIndex = 14;
            this._labelSalaPrenotazione.Text = "Sala:";
            // 
            // _panelOkAnnullaPrenotazione
            // 
            this._panelOkAnnullaPrenotazione.Controls.Add(this._buttonOK);
            this._panelOkAnnullaPrenotazione.Controls.Add(this._buttonAnnulla);
            this._panelOkAnnullaPrenotazione.Location = new System.Drawing.Point(10, 543);
            this._panelOkAnnullaPrenotazione.Name = "_panelOkAnnullaPrenotazione";
            this._panelOkAnnullaPrenotazione.Size = new System.Drawing.Size(380, 41);
            this._panelOkAnnullaPrenotazione.TabIndex = 27;
            // 
            // _buttonOK
            // 
            this._buttonOK.Location = new System.Drawing.Point(224, 6);
            this._buttonOK.Name = "_buttonOK";
            this._buttonOK.Size = new System.Drawing.Size(70, 24);
            this._buttonOK.TabIndex = 1;
            this._buttonOK.Text = "Ok";
            this._buttonOK.UseVisualStyleBackColor = true;
            this._buttonOK.Click += new System.EventHandler(this._buttonOK_Click);
            // 
            // _buttonAnnulla
            // 
            this._buttonAnnulla.Location = new System.Drawing.Point(299, 6);
            this._buttonAnnulla.Name = "_buttonAnnulla";
            this._buttonAnnulla.Size = new System.Drawing.Size(70, 24);
            this._buttonAnnulla.TabIndex = 0;
            this._buttonAnnulla.Text = "Annulla";
            this._buttonAnnulla.UseVisualStyleBackColor = true;
            this._buttonAnnulla.Click += new System.EventHandler(this._buttonAnnulla_Click);
            // 
            // PrenotazionePeriodicaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 592);
            this.Controls.Add(this._panelOkAnnullaPrenotazione);
            this.Controls.Add(this._listBoxGiornIPrenPeriodica);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrenotazionePeriodicaView";
            this.Text = "PrenotazionePeriodicaView";
            this._listBoxGiornIPrenPeriodica.ResumeLayout(false);
            this._listBoxGiornIPrenPeriodica.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this._panelOkAnnullaPrenotazione.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _listBoxGiornIPrenPeriodica;
        private System.Windows.Forms.ListBox _listBoxGiorniAggiunti;
        private System.Windows.Forms.Button _buttonAggiungiGiorno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker _dateTimePickerFinePeriodo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox _comboBoxIdTessera;
        private System.Windows.Forms.Label _labelIdClientePrenotazione;
        private System.Windows.Forms.TextBox _textBoxIndirizzoCliente;
        private System.Windows.Forms.Label _labelIndirizzoPrenotazione;
        private System.Windows.Forms.TextBox _textBoxTelefono;
        private System.Windows.Forms.TextBox _textBoxCognomeCliente;
        private System.Windows.Forms.TextBox _textBoxNomeCliente;
        private System.Windows.Forms.Label _labelTelefonoPrenotazione;
        private System.Windows.Forms.Label _labelCognomePrenotazione;
        private System.Windows.Forms.Label _labelNomeClientePrenotazione;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _textBoxTipoSala;
        private System.Windows.Forms.ComboBox _comboBoxSala;
        private System.Windows.Forms.Label _labelTipoSalaPrenotazione;
        private System.Windows.Forms.Label _labelSalaPrenotazione;
        private System.Windows.Forms.Panel _panelOkAnnullaPrenotazione;
        private System.Windows.Forms.Button _buttonOK;
        private System.Windows.Forms.Button _buttonAnnulla;
        private System.Windows.Forms.Button _buttonRimuoviGiorno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker _dateTimePickerInizioPeriodo;
    }
}