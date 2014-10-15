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
            this.SuspendLayout();
            // 
            // _labelDescrizione
            // 
            this._labelDescrizione.AutoSize = true;
            this._labelDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDescrizione.Location = new System.Drawing.Point(11, 10);
            this._labelDescrizione.Name = "_labelDescrizione";
            this._labelDescrizione.Size = new System.Drawing.Size(77, 13);
            this._labelDescrizione.TabIndex = 19;
            this._labelDescrizione.Text = "Descrizione:";
            // 
            // _descrizioneTipologia
            // 
            this._descrizioneTipologia.Enabled = false;
            this._descrizioneTipologia.Location = new System.Drawing.Point(14, 27);
            this._descrizioneTipologia.Multiline = true;
            this._descrizioneTipologia.Name = "_descrizioneTipologia";
            this._descrizioneTipologia.Size = new System.Drawing.Size(258, 222);
            this._descrizioneTipologia.TabIndex = 20;
            // 
            // DescrizioneView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._descrizioneTipologia);
            this.Controls.Add(this._labelDescrizione);
            this.Name = "DescrizioneView";
            this.Text = "DescrizioneView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelDescrizione;
        private System.Windows.Forms.TextBox _descrizioneTipologia;
    }
}