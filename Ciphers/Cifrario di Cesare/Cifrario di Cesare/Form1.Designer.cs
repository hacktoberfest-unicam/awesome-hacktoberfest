namespace Esercizio_RadioButton
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTesto = new System.Windows.Forms.Label();
            this.txtTesto = new System.Windows.Forms.TextBox();
            this.btnCifra = new System.Windows.Forms.Button();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.btnDecifra = new System.Windows.Forms.Button();
            this.lblDecript = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTesto
            // 
            this.lblTesto.AutoSize = true;
            this.lblTesto.Location = new System.Drawing.Point(12, 21);
            this.lblTesto.Name = "lblTesto";
            this.lblTesto.Size = new System.Drawing.Size(71, 13);
            this.lblTesto.TabIndex = 0;
            this.lblTesto.Text = "Inserisci testo";
            // 
            // txtTesto
            // 
            this.txtTesto.Location = new System.Drawing.Point(89, 18);
            this.txtTesto.Name = "txtTesto";
            this.txtTesto.Size = new System.Drawing.Size(100, 20);
            this.txtTesto.TabIndex = 2;
            // 
            // btnCifra
            // 
            this.btnCifra.Location = new System.Drawing.Point(15, 62);
            this.btnCifra.Name = "btnCifra";
            this.btnCifra.Size = new System.Drawing.Size(100, 29);
            this.btnCifra.TabIndex = 4;
            this.btnCifra.Text = "Cifra";
            this.btnCifra.UseVisualStyleBackColor = true;
            this.btnCifra.Click += new System.EventHandler(this.btnCifra_Click);
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(121, 70);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(0, 13);
            this.lblRisultato.TabIndex = 5;
            // 
            // btnDecifra
            // 
            this.btnDecifra.Location = new System.Drawing.Point(15, 97);
            this.btnDecifra.Name = "btnDecifra";
            this.btnDecifra.Size = new System.Drawing.Size(100, 29);
            this.btnDecifra.TabIndex = 6;
            this.btnDecifra.Text = "Decifra";
            this.btnDecifra.UseVisualStyleBackColor = true;
            this.btnDecifra.Click += new System.EventHandler(this.btnDecifra_Click);
            // 
            // lblDecript
            // 
            this.lblDecript.AutoSize = true;
            this.lblDecript.Location = new System.Drawing.Point(121, 105);
            this.lblDecript.Name = "lblDecript";
            this.lblDecript.Size = new System.Drawing.Size(0, 13);
            this.lblDecript.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(333, 242);
            this.Controls.Add(this.lblDecript);
            this.Controls.Add(this.btnDecifra);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.btnCifra);
            this.Controls.Add(this.txtTesto);
            this.Controls.Add(this.lblTesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cifrario di cesare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTesto;
        private System.Windows.Forms.TextBox txtTesto;
        private System.Windows.Forms.Button btnCifra;
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.Button btnDecifra;
        private System.Windows.Forms.Label lblDecript;
    }
}

