﻿namespace MUSEICA.View
{
    partial class AggiungiGiornoView
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
            this._panelOkAnnullaPrenotazione = new System.Windows.Forms.Panel();
            this._buttonAggiungi = new System.Windows.Forms.Button();
            this._annullaButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._numericBoxOraFine = new System.Windows.Forms.NumericUpDown();
            this._numericBoxOraInizio = new System.Windows.Forms.NumericUpDown();
            this._dateTimePickerDataPrenotazione = new System.Windows.Forms.DateTimePicker();
            this._labelOraFinePrenotazione = new System.Windows.Forms.Label();
            this._labelOraInizioPrenotazione = new System.Windows.Forms.Label();
            this._labelDataPrenotazione = new System.Windows.Forms.Label();
            this._panelOkAnnullaPrenotazione.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericBoxOraFine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericBoxOraInizio)).BeginInit();
            this.SuspendLayout();
            // 
            // _panelOkAnnullaPrenotazione
            // 
            this._panelOkAnnullaPrenotazione.Controls.Add(this._buttonAggiungi);
            this._panelOkAnnullaPrenotazione.Controls.Add(this._annullaButton);
            this._panelOkAnnullaPrenotazione.Location = new System.Drawing.Point(17, 144);
            this._panelOkAnnullaPrenotazione.Margin = new System.Windows.Forms.Padding(4);
            this._panelOkAnnullaPrenotazione.Name = "_panelOkAnnullaPrenotazione";
            this._panelOkAnnullaPrenotazione.Size = new System.Drawing.Size(477, 50);
            this._panelOkAnnullaPrenotazione.TabIndex = 29;
            // 
            // _buttonAggiungi
            // 
            this._buttonAggiungi.Location = new System.Drawing.Point(255, 11);
            this._buttonAggiungi.Margin = new System.Windows.Forms.Padding(4);
            this._buttonAggiungi.Name = "_buttonAggiungi";
            this._buttonAggiungi.Size = new System.Drawing.Size(100, 28);
            this._buttonAggiungi.TabIndex = 1;
            this._buttonAggiungi.Text = "Aggiungi";
            this._buttonAggiungi.UseVisualStyleBackColor = true;
            this._buttonAggiungi.Click += new System.EventHandler(this._buttonAggiungi_Click);
            // 
            // _annullaButton
            // 
            this._annullaButton.Location = new System.Drawing.Point(363, 11);
            this._annullaButton.Margin = new System.Windows.Forms.Padding(4);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(100, 28);
            this._annullaButton.TabIndex = 0;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._numericBoxOraFine);
            this.groupBox3.Controls.Add(this._numericBoxOraInizio);
            this.groupBox3.Controls.Add(this._dateTimePickerDataPrenotazione);
            this.groupBox3.Controls.Add(this._labelOraFinePrenotazione);
            this.groupBox3.Controls.Add(this._labelOraInizioPrenotazione);
            this.groupBox3.Controls.Add(this._labelDataPrenotazione);
            this.groupBox3.Location = new System.Drawing.Point(17, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(477, 124);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data e ora";
            // 
            // _numericBoxOraFine
            // 
            this._numericBoxOraFine.Location = new System.Drawing.Point(164, 89);
            this._numericBoxOraFine.Margin = new System.Windows.Forms.Padding(4);
            this._numericBoxOraFine.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this._numericBoxOraFine.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this._numericBoxOraFine.Name = "_numericBoxOraFine";
            this._numericBoxOraFine.Size = new System.Drawing.Size(64, 22);
            this._numericBoxOraFine.TabIndex = 22;
            this._numericBoxOraFine.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // _numericBoxOraInizio
            // 
            this._numericBoxOraInizio.Location = new System.Drawing.Point(164, 59);
            this._numericBoxOraInizio.Margin = new System.Windows.Forms.Padding(4);
            this._numericBoxOraInizio.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this._numericBoxOraInizio.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this._numericBoxOraInizio.Name = "_numericBoxOraInizio";
            this._numericBoxOraInizio.Size = new System.Drawing.Size(64, 22);
            this._numericBoxOraInizio.TabIndex = 21;
            this._numericBoxOraInizio.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // _dateTimePickerDataPrenotazione
            // 
            this._dateTimePickerDataPrenotazione.Location = new System.Drawing.Point(164, 27);
            this._dateTimePickerDataPrenotazione.Margin = new System.Windows.Forms.Padding(4);
            this._dateTimePickerDataPrenotazione.Name = "_dateTimePickerDataPrenotazione";
            this._dateTimePickerDataPrenotazione.Size = new System.Drawing.Size(280, 22);
            this._dateTimePickerDataPrenotazione.TabIndex = 20;
            // 
            // _labelOraFinePrenotazione
            // 
            this._labelOraFinePrenotazione.AutoSize = true;
            this._labelOraFinePrenotazione.Location = new System.Drawing.Point(20, 91);
            this._labelOraFinePrenotazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelOraFinePrenotazione.Name = "_labelOraFinePrenotazione";
            this._labelOraFinePrenotazione.Size = new System.Drawing.Size(67, 17);
            this._labelOraFinePrenotazione.TabIndex = 19;
            this._labelOraFinePrenotazione.Text = "Ora Fine:";
            // 
            // _labelOraInizioPrenotazione
            // 
            this._labelOraInizioPrenotazione.AutoSize = true;
            this._labelOraInizioPrenotazione.Location = new System.Drawing.Point(20, 62);
            this._labelOraInizioPrenotazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelOraInizioPrenotazione.Name = "_labelOraInizioPrenotazione";
            this._labelOraInizioPrenotazione.Size = new System.Drawing.Size(72, 17);
            this._labelOraInizioPrenotazione.TabIndex = 16;
            this._labelOraInizioPrenotazione.Text = "Ora Inizio:";
            // 
            // _labelDataPrenotazione
            // 
            this._labelDataPrenotazione.AutoSize = true;
            this._labelDataPrenotazione.Location = new System.Drawing.Point(20, 34);
            this._labelDataPrenotazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelDataPrenotazione.Name = "_labelDataPrenotazione";
            this._labelDataPrenotazione.Size = new System.Drawing.Size(42, 17);
            this._labelDataPrenotazione.TabIndex = 15;
            this._labelDataPrenotazione.Text = "Data:";
            // 
            // AggiungiGiornoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 214);
            this.Controls.Add(this._panelOkAnnullaPrenotazione);
            this.Controls.Add(this.groupBox3);
            this.Name = "AggiungiGiornoView";
            this.Text = "AggiungiGiornoView";
            this._panelOkAnnullaPrenotazione.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericBoxOraFine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericBoxOraInizio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelOkAnnullaPrenotazione;
        private System.Windows.Forms.Button _buttonAggiungi;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown _numericBoxOraFine;
        private System.Windows.Forms.NumericUpDown _numericBoxOraInizio;
        private System.Windows.Forms.DateTimePicker _dateTimePickerDataPrenotazione;
        private System.Windows.Forms.Label _labelOraFinePrenotazione;
        private System.Windows.Forms.Label _labelOraInizioPrenotazione;
        private System.Windows.Forms.Label _labelDataPrenotazione;
    }
}