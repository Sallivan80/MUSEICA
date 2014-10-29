namespace NewMUSEICA.View
{
    partial class ClienteView
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
            this._panelOkAnnullaRegistrazione = new System.Windows.Forms.Panel();
            this._buttonOK = new System.Windows.Forms.Button();
            this._buttonAnnulla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._textBoxNumeroTessera = new System.Windows.Forms.TextBox();
            this._dateTimePickerScadenzaTessera = new System.Windows.Forms.DateTimePicker();
            this._labelNumeroTesseraRegistrazione = new System.Windows.Forms.Label();
            this._labelScadenzaTesseraRegistrazione = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._textBoxIndirizzo = new System.Windows.Forms.TextBox();
            this._labelIndirizzoRegistrazione = new System.Windows.Forms.Label();
            this._textBoxTelefono = new System.Windows.Forms.TextBox();
            this._textBoxCognome = new System.Windows.Forms.TextBox();
            this._textBoxNome = new System.Windows.Forms.TextBox();
            this._labelTelefonoRegistrazione = new System.Windows.Forms.Label();
            this._labelCognomeRegistrazione = new System.Windows.Forms.Label();
            this._labelNomeClienteRegistrazione = new System.Windows.Forms.Label();
            this._panelOkAnnullaRegistrazione.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelOkAnnullaRegistrazione
            // 
            this._panelOkAnnullaRegistrazione.Controls.Add(this._buttonOK);
            this._panelOkAnnullaRegistrazione.Controls.Add(this._buttonAnnulla);
            this._panelOkAnnullaRegistrazione.Location = new System.Drawing.Point(16, 282);
            this._panelOkAnnullaRegistrazione.Margin = new System.Windows.Forms.Padding(4);
            this._panelOkAnnullaRegistrazione.Name = "_panelOkAnnullaRegistrazione";
            this._panelOkAnnullaRegistrazione.Size = new System.Drawing.Size(488, 50);
            this._panelOkAnnullaRegistrazione.TabIndex = 17;
            // 
            // _buttonOK
            // 
            this._buttonOK.Location = new System.Drawing.Point(251, 11);
            this._buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this._buttonOK.Name = "_buttonOK";
            this._buttonOK.Size = new System.Drawing.Size(100, 28);
            this._buttonOK.TabIndex = 1;
            this._buttonOK.Text = "Ok";
            this._buttonOK.UseVisualStyleBackColor = true;
            this._buttonOK.Click += new System.EventHandler(this._buttonOK_Click);
            // 
            // _buttonAnnulla
            // 
            this._buttonAnnulla.Location = new System.Drawing.Point(359, 11);
            this._buttonAnnulla.Margin = new System.Windows.Forms.Padding(4);
            this._buttonAnnulla.Name = "_buttonAnnulla";
            this._buttonAnnulla.Size = new System.Drawing.Size(100, 28);
            this._buttonAnnulla.TabIndex = 0;
            this._buttonAnnulla.Text = "Annulla";
            this._buttonAnnulla.UseVisualStyleBackColor = true;
            this._buttonAnnulla.Click += new System.EventHandler(this._buttonAnnulla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._textBoxNumeroTessera);
            this.groupBox1.Controls.Add(this._dateTimePickerScadenzaTessera);
            this.groupBox1.Controls.Add(this._labelNumeroTesseraRegistrazione);
            this.groupBox1.Controls.Add(this._labelScadenzaTesseraRegistrazione);
            this.groupBox1.Location = new System.Drawing.Point(16, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 95);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dati Tessera";
            // 
            // _textBoxNumeroTessera
            // 
            this._textBoxNumeroTessera.Enabled = false;
            this._textBoxNumeroTessera.Location = new System.Drawing.Point(177, 26);
            this._textBoxNumeroTessera.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxNumeroTessera.Name = "_textBoxNumeroTessera";
            this._textBoxNumeroTessera.Size = new System.Drawing.Size(280, 22);
            this._textBoxNumeroTessera.TabIndex = 17;
            // 
            // _dateTimePickerScadenzaTessera
            // 
            this._dateTimePickerScadenzaTessera.Location = new System.Drawing.Point(177, 60);
            this._dateTimePickerScadenzaTessera.Margin = new System.Windows.Forms.Padding(4);
            this._dateTimePickerScadenzaTessera.Name = "_dateTimePickerScadenzaTessera";
            this._dateTimePickerScadenzaTessera.Size = new System.Drawing.Size(280, 22);
            this._dateTimePickerScadenzaTessera.TabIndex = 18;
            // 
            // _labelNumeroTesseraRegistrazione
            // 
            this._labelNumeroTesseraRegistrazione.AutoSize = true;
            this._labelNumeroTesseraRegistrazione.Location = new System.Drawing.Point(21, 30);
            this._labelNumeroTesseraRegistrazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelNumeroTesseraRegistrazione.Name = "_labelNumeroTesseraRegistrazione";
            this._labelNumeroTesseraRegistrazione.Size = new System.Drawing.Size(78, 17);
            this._labelNumeroTesseraRegistrazione.TabIndex = 16;
            this._labelNumeroTesseraRegistrazione.Text = "Tessera n°";
            // 
            // _labelScadenzaTesseraRegistrazione
            // 
            this._labelScadenzaTesseraRegistrazione.AutoSize = true;
            this._labelScadenzaTesseraRegistrazione.Location = new System.Drawing.Point(21, 65);
            this._labelScadenzaTesseraRegistrazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelScadenzaTesseraRegistrazione.Name = "_labelScadenzaTesseraRegistrazione";
            this._labelScadenzaTesseraRegistrazione.Size = new System.Drawing.Size(127, 17);
            this._labelScadenzaTesseraRegistrazione.TabIndex = 15;
            this._labelScadenzaTesseraRegistrazione.Text = "Scadenza Tessera";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._textBoxIndirizzo);
            this.groupBox2.Controls.Add(this._labelIndirizzoRegistrazione);
            this.groupBox2.Controls.Add(this._textBoxTelefono);
            this.groupBox2.Controls.Add(this._textBoxCognome);
            this.groupBox2.Controls.Add(this._textBoxNome);
            this.groupBox2.Controls.Add(this._labelTelefonoRegistrazione);
            this.groupBox2.Controls.Add(this._labelCognomeRegistrazione);
            this.groupBox2.Controls.Add(this._labelNomeClienteRegistrazione);
            this.groupBox2.Location = new System.Drawing.Point(16, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 161);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dati Cliente";
            // 
            // _textBoxIndirizzo
            // 
            this._textBoxIndirizzo.Location = new System.Drawing.Point(177, 121);
            this._textBoxIndirizzo.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxIndirizzo.Name = "_textBoxIndirizzo";
            this._textBoxIndirizzo.Size = new System.Drawing.Size(280, 22);
            this._textBoxIndirizzo.TabIndex = 20;
            // 
            // _labelIndirizzoRegistrazione
            // 
            this._labelIndirizzoRegistrazione.AutoSize = true;
            this._labelIndirizzoRegistrazione.Location = new System.Drawing.Point(21, 125);
            this._labelIndirizzoRegistrazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelIndirizzoRegistrazione.Name = "_labelIndirizzoRegistrazione";
            this._labelIndirizzoRegistrazione.Size = new System.Drawing.Size(60, 17);
            this._labelIndirizzoRegistrazione.TabIndex = 19;
            this._labelIndirizzoRegistrazione.Text = "Indirizzo";
            // 
            // _textBoxTelefono
            // 
            this._textBoxTelefono.Location = new System.Drawing.Point(177, 91);
            this._textBoxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxTelefono.Name = "_textBoxTelefono";
            this._textBoxTelefono.Size = new System.Drawing.Size(280, 22);
            this._textBoxTelefono.TabIndex = 18;
            // 
            // _textBoxCognome
            // 
            this._textBoxCognome.Location = new System.Drawing.Point(177, 60);
            this._textBoxCognome.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxCognome.Name = "_textBoxCognome";
            this._textBoxCognome.Size = new System.Drawing.Size(280, 22);
            this._textBoxCognome.TabIndex = 17;
            // 
            // _textBoxNome
            // 
            this._textBoxNome.Location = new System.Drawing.Point(177, 29);
            this._textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxNome.Name = "_textBoxNome";
            this._textBoxNome.Size = new System.Drawing.Size(280, 22);
            this._textBoxNome.TabIndex = 16;
            // 
            // _labelTelefonoRegistrazione
            // 
            this._labelTelefonoRegistrazione.AutoSize = true;
            this._labelTelefonoRegistrazione.Location = new System.Drawing.Point(21, 94);
            this._labelTelefonoRegistrazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelTelefonoRegistrazione.Name = "_labelTelefonoRegistrazione";
            this._labelTelefonoRegistrazione.Size = new System.Drawing.Size(64, 17);
            this._labelTelefonoRegistrazione.TabIndex = 15;
            this._labelTelefonoRegistrazione.Text = "Telefono";
            // 
            // _labelCognomeRegistrazione
            // 
            this._labelCognomeRegistrazione.AutoSize = true;
            this._labelCognomeRegistrazione.Location = new System.Drawing.Point(21, 64);
            this._labelCognomeRegistrazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelCognomeRegistrazione.Name = "_labelCognomeRegistrazione";
            this._labelCognomeRegistrazione.Size = new System.Drawing.Size(68, 17);
            this._labelCognomeRegistrazione.TabIndex = 14;
            this._labelCognomeRegistrazione.Text = "Cognome";
            // 
            // _labelNomeClienteRegistrazione
            // 
            this._labelNomeClienteRegistrazione.AutoSize = true;
            this._labelNomeClienteRegistrazione.Location = new System.Drawing.Point(21, 33);
            this._labelNomeClienteRegistrazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelNomeClienteRegistrazione.Name = "_labelNomeClienteRegistrazione";
            this._labelNomeClienteRegistrazione.Size = new System.Drawing.Size(45, 17);
            this._labelNomeClienteRegistrazione.TabIndex = 13;
            this._labelNomeClienteRegistrazione.Text = "Nome";
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._panelOkAnnullaRegistrazione);
            this.Name = "ClienteView";
            this.Text = "ClienteView";
            this._panelOkAnnullaRegistrazione.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelOkAnnullaRegistrazione;
        private System.Windows.Forms.Button _buttonOK;
        private System.Windows.Forms.Button _buttonAnnulla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _textBoxNumeroTessera;
        private System.Windows.Forms.DateTimePicker _dateTimePickerScadenzaTessera;
        private System.Windows.Forms.Label _labelNumeroTesseraRegistrazione;
        private System.Windows.Forms.Label _labelScadenzaTesseraRegistrazione;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox _textBoxIndirizzo;
        private System.Windows.Forms.Label _labelIndirizzoRegistrazione;
        private System.Windows.Forms.TextBox _textBoxTelefono;
        private System.Windows.Forms.TextBox _textBoxCognome;
        private System.Windows.Forms.TextBox _textBoxNome;
        private System.Windows.Forms.Label _labelTelefonoRegistrazione;
        private System.Windows.Forms.Label _labelCognomeRegistrazione;
        private System.Windows.Forms.Label _labelNomeClienteRegistrazione;
    }
}