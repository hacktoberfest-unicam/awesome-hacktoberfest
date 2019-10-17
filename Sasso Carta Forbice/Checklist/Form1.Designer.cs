namespace Checklist
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
            this.btnInizia = new System.Windows.Forms.Button();
            this.btnSasso = new System.Windows.Forms.Button();
            this.btnCarta = new System.Windows.Forms.Button();
            this.btnForbice = new System.Windows.Forms.Button();
            this.lblris = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPunt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInizia
            // 
            this.btnInizia.Location = new System.Drawing.Point(188, 12);
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(90, 35);
            this.btnInizia.TabIndex = 0;
            this.btnInizia.Text = "Inizia";
            this.btnInizia.UseVisualStyleBackColor = true;
            this.btnInizia.Click += new System.EventHandler(this.btnInizia_Click);
            // 
            // btnSasso
            // 
            this.btnSasso.Location = new System.Drawing.Point(12, 61);
            this.btnSasso.Name = "btnSasso";
            this.btnSasso.Size = new System.Drawing.Size(75, 23);
            this.btnSasso.TabIndex = 1;
            this.btnSasso.Text = "Sasso";
            this.btnSasso.UseVisualStyleBackColor = true;
            this.btnSasso.Click += new System.EventHandler(this.btnSasso_Click);
            // 
            // btnCarta
            // 
            this.btnCarta.Location = new System.Drawing.Point(12, 91);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(75, 23);
            this.btnCarta.TabIndex = 2;
            this.btnCarta.Text = "Carta";
            this.btnCarta.UseVisualStyleBackColor = true;
            this.btnCarta.Click += new System.EventHandler(this.btnCarta_Click);
            // 
            // btnForbice
            // 
            this.btnForbice.Location = new System.Drawing.Point(12, 121);
            this.btnForbice.Name = "btnForbice";
            this.btnForbice.Size = new System.Drawing.Size(75, 23);
            this.btnForbice.TabIndex = 3;
            this.btnForbice.Text = "Forbice";
            this.btnForbice.UseVisualStyleBackColor = true;
            this.btnForbice.Click += new System.EventHandler(this.btnForbice_Click);
            // 
            // lblris
            // 
            this.lblris.AutoSize = true;
            this.lblris.Location = new System.Drawing.Point(108, 180);
            this.lblris.Name = "lblris";
            this.lblris.Size = new System.Drawing.Size(0, 13);
            this.lblris.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Risultato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BOT:";
            // 
            // lblBot
            // 
            this.lblBot.AutoSize = true;
            this.lblBot.Location = new System.Drawing.Point(90, 157);
            this.lblBot.Name = "lblBot";
            this.lblBot.Size = new System.Drawing.Size(0, 13);
            this.lblBot.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Punteggio: ";
            // 
            // lblPunt
            // 
            this.lblPunt.AutoSize = true;
            this.lblPunt.Location = new System.Drawing.Point(108, 205);
            this.lblPunt.Name = "lblPunt";
            this.lblPunt.Size = new System.Drawing.Size(0, 13);
            this.lblPunt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 305);
            this.Controls.Add(this.lblPunt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblris);
            this.Controls.Add(this.btnForbice);
            this.Controls.Add(this.btnCarta);
            this.Controls.Add(this.btnSasso);
            this.Controls.Add(this.btnInizia);
            this.Name = "Form1";
            this.Text = "Sasso, carta, forbice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInizia;
        private System.Windows.Forms.Button btnSasso;
        private System.Windows.Forms.Button btnCarta;
        private System.Windows.Forms.Button btnForbice;
        private System.Windows.Forms.Label lblris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPunt;
    }
}

