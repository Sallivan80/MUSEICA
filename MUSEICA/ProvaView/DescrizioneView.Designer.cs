namespace MUSEICA.ProvaView
{
    partial class DescrizioneView
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
            this._descrizioneTipologia = new System.Windows.Forms.TextBox();
            this._buttonAggiungi = new System.Windows.Forms.Button();
            this._buttonAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _labelDescrizione
            // 
            this._labelDescrizione.AutoSize = true;
            this._labelDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDescrizione.Location = new System.Drawing.Point(15, 12);
            this._labelDescrizione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelDescrizione.Name = "_labelDescrizione";
            this._labelDescrizione.Size = new System.Drawing.Size(98, 17);
            this._labelDescrizione.TabIndex = 19;
            this._labelDescrizione.Text = "Descrizione:";
            // 
            // _descrizioneTipologia
            // 
            this._descrizioneTipologia.Enabled = false;
            this._descrizioneTipologia.Location = new System.Drawing.Point(19, 33);
            this._descrizioneTipologia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._descrizioneTipologia.Multiline = true;
            this._descrizioneTipologia.Name = "_descrizioneTipologia";
            this._descrizioneTipologia.Size = new System.Drawing.Size(343, 272);
            this._descrizioneTipologia.TabIndex = 20;
            // 
            // _buttonAggiungi
            // 
            this._buttonAggiungi.Location = new System.Drawing.Point(208, 326);
            this._buttonAggiungi.Name = "_buttonAggiungi";
            this._buttonAggiungi.Size = new System.Drawing.Size(75, 28);
            this._buttonAggiungi.TabIndex = 21;
            this._buttonAggiungi.Text = "Aggiungi";
            this._buttonAggiungi.UseVisualStyleBackColor = true;
            // 
            // _buttonAnnulla
            // 
            this._buttonAnnulla.Location = new System.Drawing.Point(292, 326);
            this._buttonAnnulla.Name = "_buttonAnnulla";
            this._buttonAnnulla.Size = new System.Drawing.Size(75, 28);
            this._buttonAnnulla.TabIndex = 22;
            this._buttonAnnulla.Text = "Annulla";
            this._buttonAnnulla.UseVisualStyleBackColor = true;
            // 
            // DescrizioneView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 366);
            this.Controls.Add(this._buttonAnnulla);
            this.Controls.Add(this._buttonAggiungi);
            this.Controls.Add(this._descrizioneTipologia);
            this.Controls.Add(this._labelDescrizione);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DescrizioneView";
            this.Text = "DescrizioneView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelDescrizione;
        private System.Windows.Forms.TextBox _descrizioneTipologia;
        private System.Windows.Forms.Button _buttonAggiungi;
        private System.Windows.Forms.Button _buttonAnnulla;
    }
}