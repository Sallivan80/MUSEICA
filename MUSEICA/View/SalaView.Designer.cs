namespace MUSEICA.View
{
    partial class SalaView
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
            this._buttonOK = new System.Windows.Forms.Button();
            this._buttonAnnulla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._textBoxPrezzoSala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._comboBoxTipologia = new System.Windows.Forms.ComboBox();
            this._textBoxIndirizzoSala = new System.Windows.Forms.TextBox();
            this._labelIndirizzoPrenotazione = new System.Windows.Forms.Label();
            this._textBoxNomeSala = new System.Windows.Forms.TextBox();
            this._textBoxIdSala = new System.Windows.Forms.TextBox();
            this._labelTelefonoPrenotazione = new System.Windows.Forms.Label();
            this._labelCognomePrenotazione = new System.Windows.Forms.Label();
            this._labelNomeClientePrenotazione = new System.Windows.Forms.Label();
            this._panelOkAnnullaPrenotazione.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelOkAnnullaPrenotazione
            // 
            this._panelOkAnnullaPrenotazione.Controls.Add(this._buttonOK);
            this._panelOkAnnullaPrenotazione.Controls.Add(this._buttonAnnulla);
            this._panelOkAnnullaPrenotazione.Location = new System.Drawing.Point(10, 178);
            this._panelOkAnnullaPrenotazione.Name = "_panelOkAnnullaPrenotazione";
            this._panelOkAnnullaPrenotazione.Size = new System.Drawing.Size(331, 41);
            this._panelOkAnnullaPrenotazione.TabIndex = 17;
            // 
            // _buttonOK
            // 
            this._buttonOK.Location = new System.Drawing.Point(172, 9);
            this._buttonOK.Name = "_buttonOK";
            this._buttonOK.Size = new System.Drawing.Size(75, 23);
            this._buttonOK.TabIndex = 1;
            this._buttonOK.Text = "Ok";
            this._buttonOK.UseVisualStyleBackColor = true;
            this._buttonOK.Click += new System.EventHandler(this._buttonOK_Click);
            // 
            // _buttonAnnulla
            // 
            this._buttonAnnulla.Location = new System.Drawing.Point(253, 9);
            this._buttonAnnulla.Name = "_buttonAnnulla";
            this._buttonAnnulla.Size = new System.Drawing.Size(75, 23);
            this._buttonAnnulla.TabIndex = 0;
            this._buttonAnnulla.Text = "Annulla";
            this._buttonAnnulla.UseVisualStyleBackColor = true;
            this._buttonAnnulla.Click += new System.EventHandler(this._buttonAnnulla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._textBoxPrezzoSala);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._comboBoxTipologia);
            this.groupBox1.Controls.Add(this._textBoxIndirizzoSala);
            this.groupBox1.Controls.Add(this._labelIndirizzoPrenotazione);
            this.groupBox1.Controls.Add(this._textBoxNomeSala);
            this.groupBox1.Controls.Add(this._textBoxIdSala);
            this.groupBox1.Controls.Add(this._labelTelefonoPrenotazione);
            this.groupBox1.Controls.Add(this._labelCognomePrenotazione);
            this.groupBox1.Controls.Add(this._labelNomeClientePrenotazione);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(331, 162);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dati della Sala";
            // 
            // _textBoxPrezzoSala
            // 
            this._textBoxPrezzoSala.Location = new System.Drawing.Point(142, 122);
            this._textBoxPrezzoSala.Name = "_textBoxPrezzoSala";
            this._textBoxPrezzoSala.Size = new System.Drawing.Size(144, 20);
            this._textBoxPrezzoSala.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Prezzo:";
            // 
            // _comboBoxTipologia
            // 
            this._comboBoxTipologia.FormattingEnabled = true;
            this._comboBoxTipologia.Location = new System.Drawing.Point(142, 72);
            this._comboBoxTipologia.Name = "_comboBoxTipologia";
            this._comboBoxTipologia.Size = new System.Drawing.Size(144, 21);
            this._comboBoxTipologia.TabIndex = 39;
            // 
            // _textBoxIndirizzoSala
            // 
            this._textBoxIndirizzoSala.Location = new System.Drawing.Point(142, 97);
            this._textBoxIndirizzoSala.Name = "_textBoxIndirizzoSala";
            this._textBoxIndirizzoSala.Size = new System.Drawing.Size(144, 20);
            this._textBoxIndirizzoSala.TabIndex = 38;
            // 
            // _labelIndirizzoPrenotazione
            // 
            this._labelIndirizzoPrenotazione.AutoSize = true;
            this._labelIndirizzoPrenotazione.Location = new System.Drawing.Point(5, 100);
            this._labelIndirizzoPrenotazione.Name = "_labelIndirizzoPrenotazione";
            this._labelIndirizzoPrenotazione.Size = new System.Drawing.Size(48, 13);
            this._labelIndirizzoPrenotazione.TabIndex = 37;
            this._labelIndirizzoPrenotazione.Text = "Indirizzo:";
            // 
            // _textBoxNomeSala
            // 
            this._textBoxNomeSala.Location = new System.Drawing.Point(142, 46);
            this._textBoxNomeSala.Name = "_textBoxNomeSala";
            this._textBoxNomeSala.Size = new System.Drawing.Size(144, 20);
            this._textBoxNomeSala.TabIndex = 36;
            // 
            // _textBoxIdSala
            // 
            this._textBoxIdSala.Location = new System.Drawing.Point(142, 22);
            this._textBoxIdSala.Name = "_textBoxIdSala";
            this._textBoxIdSala.Size = new System.Drawing.Size(144, 20);
            this._textBoxIdSala.TabIndex = 35;
            // 
            // _labelTelefonoPrenotazione
            // 
            this._labelTelefonoPrenotazione.AutoSize = true;
            this._labelTelefonoPrenotazione.Location = new System.Drawing.Point(5, 75);
            this._labelTelefonoPrenotazione.Name = "_labelTelefonoPrenotazione";
            this._labelTelefonoPrenotazione.Size = new System.Drawing.Size(53, 13);
            this._labelTelefonoPrenotazione.TabIndex = 34;
            this._labelTelefonoPrenotazione.Text = "Tipologia:";
            // 
            // _labelCognomePrenotazione
            // 
            this._labelCognomePrenotazione.AutoSize = true;
            this._labelCognomePrenotazione.Location = new System.Drawing.Point(5, 50);
            this._labelCognomePrenotazione.Name = "_labelCognomePrenotazione";
            this._labelCognomePrenotazione.Size = new System.Drawing.Size(60, 13);
            this._labelCognomePrenotazione.TabIndex = 33;
            this._labelCognomePrenotazione.Text = "Nome sala:";
            // 
            // _labelNomeClientePrenotazione
            // 
            this._labelNomeClientePrenotazione.AutoSize = true;
            this._labelNomeClientePrenotazione.Location = new System.Drawing.Point(5, 24);
            this._labelNomeClientePrenotazione.Name = "_labelNomeClientePrenotazione";
            this._labelNomeClientePrenotazione.Size = new System.Drawing.Size(43, 13);
            this._labelNomeClientePrenotazione.TabIndex = 32;
            this._labelNomeClientePrenotazione.Text = "Id Sala:";
            // 
            // SalaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 229);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._panelOkAnnullaPrenotazione);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalaView";
            this.Text = "SalaView";
            this._panelOkAnnullaPrenotazione.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelOkAnnullaPrenotazione;
        private System.Windows.Forms.Button _buttonOK;
        private System.Windows.Forms.Button _buttonAnnulla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _textBoxPrezzoSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _comboBoxTipologia;
        private System.Windows.Forms.TextBox _textBoxIndirizzoSala;
        private System.Windows.Forms.Label _labelIndirizzoPrenotazione;
        private System.Windows.Forms.TextBox _textBoxNomeSala;
        private System.Windows.Forms.TextBox _textBoxIdSala;
        private System.Windows.Forms.Label _labelTelefonoPrenotazione;
        private System.Windows.Forms.Label _labelCognomePrenotazione;
        private System.Windows.Forms.Label _labelNomeClientePrenotazione;
    }
}