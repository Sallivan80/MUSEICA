namespace MUSEICA.ProvaView
{
    partial class SalvaModificheView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalvaModificheView));
            this.panel1 = new System.Windows.Forms.Panel();
            this._salvaButton = new System.Windows.Forms.Button();
            this._nonSalvareButton = new System.Windows.Forms.Button();
            this._annullaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._salvaButton);
            this.panel1.Controls.Add(this._nonSalvareButton);
            this.panel1.Controls.Add(this._annullaButton);
            this.panel1.Location = new System.Drawing.Point(16, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 65);
            this.panel1.TabIndex = 0;
            // 
            // _salvaButton
            // 
            this._salvaButton.Location = new System.Drawing.Point(189, 18);
            this._salvaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._salvaButton.Name = "_salvaButton";
            this._salvaButton.Size = new System.Drawing.Size(100, 28);
            this._salvaButton.TabIndex = 2;
            this._salvaButton.Text = "Salva";
            this._salvaButton.UseVisualStyleBackColor = true;
            this._salvaButton.Click += new System.EventHandler(this._salvaButton_Click);
            // 
            // _nonSalvareButton
            // 
            this._nonSalvareButton.Location = new System.Drawing.Point(297, 18);
            this._nonSalvareButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._nonSalvareButton.Name = "_nonSalvareButton";
            this._nonSalvareButton.Size = new System.Drawing.Size(100, 28);
            this._nonSalvareButton.TabIndex = 1;
            this._nonSalvareButton.Text = "Non salvare";
            this._nonSalvareButton.UseVisualStyleBackColor = true;
            // 
            // _annullaButton
            // 
            this._annullaButton.Location = new System.Drawing.Point(405, 18);
            this._annullaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(100, 28);
            this._annullaButton.TabIndex = 0;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(105, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vuoi salvare le modifiche?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SalvaModificheView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 151);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SalvaModificheView";
            this.Text = "Salva Modifiche";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _salvaButton;
        private System.Windows.Forms.Button _nonSalvareButton;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}