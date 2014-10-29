namespace NewMUSEICA.View
{
    partial class StoricoView
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
            this._dataGridPrenotazioneSingola = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._dataGridPrenotazionePeriodica = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridPrenotazioneSingola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridPrenotazionePeriodica)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridPrenotazioneSingola
            // 
            this._dataGridPrenotazioneSingola.AllowUserToAddRows = false;
            this._dataGridPrenotazioneSingola.AllowUserToDeleteRows = false;
            this._dataGridPrenotazioneSingola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridPrenotazioneSingola.Location = new System.Drawing.Point(17, 41);
            this._dataGridPrenotazioneSingola.Margin = new System.Windows.Forms.Padding(4);
            this._dataGridPrenotazioneSingola.Name = "_dataGridPrenotazioneSingola";
            this._dataGridPrenotazioneSingola.ReadOnly = true;
            this._dataGridPrenotazioneSingola.Size = new System.Drawing.Size(859, 178);
            this._dataGridPrenotazioneSingola.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prenotazioni singole:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenotazioni periodiche:";
            // 
            // _dataGridPrenotazionePeriodica
            // 
            this._dataGridPrenotazionePeriodica.AllowUserToAddRows = false;
            this._dataGridPrenotazionePeriodica.AllowUserToDeleteRows = false;
            this._dataGridPrenotazionePeriodica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridPrenotazionePeriodica.Location = new System.Drawing.Point(20, 252);
            this._dataGridPrenotazionePeriodica.Margin = new System.Windows.Forms.Padding(4);
            this._dataGridPrenotazionePeriodica.Name = "_dataGridPrenotazionePeriodica";
            this._dataGridPrenotazionePeriodica.ReadOnly = true;
            this._dataGridPrenotazionePeriodica.Size = new System.Drawing.Size(859, 178);
            this._dataGridPrenotazionePeriodica.TabIndex = 2;
            // 
            // StoricoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._dataGridPrenotazionePeriodica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._dataGridPrenotazioneSingola);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StoricoView";
            this.Text = "Storico Prenotazioni";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridPrenotazioneSingola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridPrenotazionePeriodica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridPrenotazioneSingola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView _dataGridPrenotazionePeriodica;
    }
}