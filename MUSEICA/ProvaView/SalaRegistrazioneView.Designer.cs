namespace MUSEICA.ProvaView
{
    partial class SalaRegistrazioneView
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
            this._labelDescrizione = new System.Windows.Forms.Label();
            this._descrizioneRegistrazione = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _labelDescrizione
            // 
            this._labelDescrizione.AutoSize = true;
            this._labelDescrizione.Enabled = false;
            this._labelDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDescrizione.Location = new System.Drawing.Point(9, 7);
            this._labelDescrizione.Name = "_labelDescrizione";
            this._labelDescrizione.Size = new System.Drawing.Size(77, 13);
            this._labelDescrizione.TabIndex = 15;
            this._labelDescrizione.Text = "Descrizione:";
            this._labelDescrizione.Visible = false;
            // 
            // _descrizioneRegistrazione
            // 
            this._descrizioneRegistrazione.BackColor = System.Drawing.SystemColors.Menu;
            this._descrizioneRegistrazione.Enabled = false;
            this._descrizioneRegistrazione.FormattingEnabled = true;
            this._descrizioneRegistrazione.Location = new System.Drawing.Point(12, 23);
            this._descrizioneRegistrazione.Name = "_descrizioneRegistrazione";
            this._descrizioneRegistrazione.Size = new System.Drawing.Size(260, 225);
            this._descrizioneRegistrazione.TabIndex = 14;
            // 
            // SalaRegistrazioneView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._labelDescrizione);
            this.Controls.Add(this._descrizioneRegistrazione);
            this.Name = "SalaRegistrazioneView";
            this.Text = "Sala Registrazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelDescrizione;
        private System.Windows.Forms.ListBox _descrizioneRegistrazione;
    }
}