namespace MUSEICA.ProvaView
{
    partial class SalaProveView
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
            this._descrizioneSalaProve = new System.Windows.Forms.ListBox();
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
            this._labelDescrizione.TabIndex = 19;
            this._labelDescrizione.Text = "Descrizione:";
            this._labelDescrizione.Visible = false;
            // 
            // _descrizioneSalaProve
            // 
            this._descrizioneSalaProve.BackColor = System.Drawing.SystemColors.Menu;
            this._descrizioneSalaProve.Enabled = false;
            this._descrizioneSalaProve.FormattingEnabled = true;
            this._descrizioneSalaProve.Location = new System.Drawing.Point(14, 26);
            this._descrizioneSalaProve.Name = "_descrizioneSalaProve";
            this._descrizioneSalaProve.Size = new System.Drawing.Size(260, 225);
            this._descrizioneSalaProve.TabIndex = 18;
            // 
            // SalaProveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._labelDescrizione);
            this.Controls.Add(this._descrizioneSalaProve);
            this.Name = "SalaProveView";
            this.Text = "Sala Prove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelDescrizione;
        private System.Windows.Forms.ListBox _descrizioneSalaProve;
    }
}