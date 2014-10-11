namespace MUSEICA.ProvaView
{
    partial class SalaMixaggioView
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
            this._descrizioneMixaggio = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _labelDescrizione
            // 
            this._labelDescrizione.AutoSize = true;
            this._labelDescrizione.Enabled = false;
            this._labelDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDescrizione.Location = new System.Drawing.Point(11, 10);
            this._labelDescrizione.Name = "_labelDescrizione";
            this._labelDescrizione.Size = new System.Drawing.Size(77, 13);
            this._labelDescrizione.TabIndex = 17;
            this._labelDescrizione.Text = "Descrizione:";
            this._labelDescrizione.Visible = false;
            // 
            // _descrizioneMixaggio
            // 
            this._descrizioneMixaggio.BackColor = System.Drawing.SystemColors.Menu;
            this._descrizioneMixaggio.Enabled = false;
            this._descrizioneMixaggio.FormattingEnabled = true;
            this._descrizioneMixaggio.Location = new System.Drawing.Point(14, 26);
            this._descrizioneMixaggio.Name = "_descrizioneMixaggio";
            this._descrizioneMixaggio.Size = new System.Drawing.Size(260, 225);
            this._descrizioneMixaggio.TabIndex = 16;
            // 
            // SalaMixaggioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._labelDescrizione);
            this.Controls.Add(this._descrizioneMixaggio);
            this.Name = "SalaMixaggioView";
            this.Text = "Sala Mixaggio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelDescrizione;
        private System.Windows.Forms.ListBox _descrizioneMixaggio;
    }
}