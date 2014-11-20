namespace MUSEICA.View
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
            this._descrizioneLabel = new System.Windows.Forms.Label();
            this._textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _descrizioneLabel
            // 
            this._descrizioneLabel.AutoSize = true;
            this._descrizioneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._descrizioneLabel.Location = new System.Drawing.Point(12, 9);
            this._descrizioneLabel.Name = "_descrizioneLabel";
            this._descrizioneLabel.Size = new System.Drawing.Size(108, 20);
            this._descrizioneLabel.TabIndex = 0;
            this._descrizioneLabel.Text = "Descrizione:";
            // 
            // _textBoxDescrizione
            // 
            this._textBoxDescrizione.Enabled = false;
            this._textBoxDescrizione.Location = new System.Drawing.Point(12, 30);
            this._textBoxDescrizione.Multiline = true;
            this._textBoxDescrizione.Name = "_textBoxDescrizione";
            this._textBoxDescrizione.ReadOnly = true;
            this._textBoxDescrizione.Size = new System.Drawing.Size(272, 270);
            this._textBoxDescrizione.TabIndex = 1;
            // 
            // DescrizioneView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 308);
            this.Controls.Add(this._textBoxDescrizione);
            this.Controls.Add(this._descrizioneLabel);
            this.Name = "DescrizioneView";
            this.Text = "DescrizioneView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _descrizioneLabel;
        private System.Windows.Forms.TextBox _textBoxDescrizione;
    }
}