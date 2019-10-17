namespace Hacktoberfest2019DZ
{
    partial class MainForm
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.url_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.url_short_button = new MetroFramework.Controls.MetroButton();
            this.url_to_short = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.cipher_keybox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cipher_decode_button = new MetroFramework.Controls.MetroButton();
            this.cipher_encode_button = new MetroFramework.Controls.MetroButton();
            this.cipher_modes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cipher_output = new MetroFramework.Controls.MetroTextBox();
            this.cipher_input = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.hashing_output = new MetroFramework.Controls.MetroTextBox();
            this.hashing_input = new MetroFramework.Controls.MetroTextBox();
            this.hashing_encode_button = new MetroFramework.Controls.MetroButton();
            this.hashing_modes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.scfls_user_win = new System.Windows.Forms.Label();
            this.scfls_cpu_win = new System.Windows.Forms.Label();
            this.scfls_timer = new System.Windows.Forms.Label();
            this.scfls_parita = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(648, 382);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.url_spinner);
            this.metroTabPage1.Controls.Add(this.url_short_button);
            this.metroTabPage1.Controls.Add(this.url_to_short);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(640, 343);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "URL shortener";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // url_spinner
            // 
            this.url_spinner.Location = new System.Drawing.Point(474, 153);
            this.url_spinner.Maximum = 100;
            this.url_spinner.Name = "url_spinner";
            this.url_spinner.Size = new System.Drawing.Size(24, 23);
            this.url_spinner.TabIndex = 4;
            this.url_spinner.Visible = false;
            // 
            // url_short_button
            // 
            this.url_short_button.Location = new System.Drawing.Point(393, 153);
            this.url_short_button.Name = "url_short_button";
            this.url_short_button.Size = new System.Drawing.Size(75, 23);
            this.url_short_button.TabIndex = 3;
            this.url_short_button.Text = "Short it!";
            this.url_short_button.Click += new System.EventHandler(this.url_short_button_Click);
            // 
            // url_to_short
            // 
            this.url_to_short.Location = new System.Drawing.Point(74, 153);
            this.url_to_short.Name = "url_to_short";
            this.url_to_short.PromptText = "Your URL here; Example https://www.google.com";
            this.url_to_short.Size = new System.Drawing.Size(313, 23);
            this.url_to_short.TabIndex = 2;
            this.url_to_short.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.cipher_keybox);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.cipher_decode_button);
            this.metroTabPage2.Controls.Add(this.cipher_encode_button);
            this.metroTabPage2.Controls.Add(this.cipher_modes);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.cipher_output);
            this.metroTabPage2.Controls.Add(this.cipher_input);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(640, 343);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Cifratura";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // cipher_keybox
            // 
            this.cipher_keybox.Location = new System.Drawing.Point(262, 97);
            this.cipher_keybox.Name = "cipher_keybox";
            this.cipher_keybox.PromptText = "Key";
            this.cipher_keybox.Size = new System.Drawing.Size(121, 23);
            this.cipher_keybox.TabIndex = 10;
            this.cipher_keybox.TextChanged += new System.EventHandler(this.cipher_keybox_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(407, 6);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Output";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Input";
            // 
            // cipher_decode_button
            // 
            this.cipher_decode_button.Enabled = false;
            this.cipher_decode_button.Location = new System.Drawing.Point(262, 160);
            this.cipher_decode_button.Name = "cipher_decode_button";
            this.cipher_decode_button.Size = new System.Drawing.Size(121, 28);
            this.cipher_decode_button.TabIndex = 7;
            this.cipher_decode_button.Text = "Decode";
            this.cipher_decode_button.Click += new System.EventHandler(this.cipher_decode_button_Click);
            // 
            // cipher_encode_button
            // 
            this.cipher_encode_button.Enabled = false;
            this.cipher_encode_button.Location = new System.Drawing.Point(262, 126);
            this.cipher_encode_button.Name = "cipher_encode_button";
            this.cipher_encode_button.Size = new System.Drawing.Size(121, 28);
            this.cipher_encode_button.TabIndex = 6;
            this.cipher_encode_button.Text = "Encode";
            this.cipher_encode_button.Click += new System.EventHandler(this.cipher_encode_button_Click);
            // 
            // cipher_modes
            // 
            this.cipher_modes.FormattingEnabled = true;
            this.cipher_modes.ItemHeight = 23;
            this.cipher_modes.Items.AddRange(new object[] {
            "Cesare"});
            this.cipher_modes.Location = new System.Drawing.Point(262, 62);
            this.cipher_modes.Name = "cipher_modes";
            this.cipher_modes.Size = new System.Drawing.Size(121, 29);
            this.cipher_modes.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(262, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Metodo di cifratura";
            // 
            // cipher_output
            // 
            this.cipher_output.Location = new System.Drawing.Point(407, 28);
            this.cipher_output.Multiline = true;
            this.cipher_output.Name = "cipher_output";
            this.cipher_output.ReadOnly = true;
            this.cipher_output.Size = new System.Drawing.Size(230, 319);
            this.cipher_output.TabIndex = 3;
            // 
            // cipher_input
            // 
            this.cipher_input.Location = new System.Drawing.Point(3, 28);
            this.cipher_input.Multiline = true;
            this.cipher_input.Name = "cipher_input";
            this.cipher_input.Size = new System.Drawing.Size(230, 319);
            this.cipher_input.TabIndex = 2;
            this.cipher_input.TextChanged += new System.EventHandler(this.cipher_input_TextChanged);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.hashing_encode_button);
            this.metroTabPage3.Controls.Add(this.hashing_modes);
            this.metroTabPage3.Controls.Add(this.metroLabel6);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.metroLabel5);
            this.metroTabPage3.Controls.Add(this.hashing_output);
            this.metroTabPage3.Controls.Add(this.hashing_input);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(640, 343);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Hashing";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(407, 6);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Output";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(4, 3);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Input";
            // 
            // hashing_output
            // 
            this.hashing_output.Location = new System.Drawing.Point(407, 28);
            this.hashing_output.Multiline = true;
            this.hashing_output.Name = "hashing_output";
            this.hashing_output.ReadOnly = true;
            this.hashing_output.Size = new System.Drawing.Size(230, 319);
            this.hashing_output.TabIndex = 11;
            // 
            // hashing_input
            // 
            this.hashing_input.Location = new System.Drawing.Point(3, 28);
            this.hashing_input.Multiline = true;
            this.hashing_input.Name = "hashing_input";
            this.hashing_input.Size = new System.Drawing.Size(230, 319);
            this.hashing_input.TabIndex = 10;
            this.hashing_input.TextChanged += new System.EventHandler(this.hashing_input_TextChanged);
            // 
            // hashing_encode_button
            // 
            this.hashing_encode_button.Enabled = false;
            this.hashing_encode_button.Location = new System.Drawing.Point(262, 97);
            this.hashing_encode_button.Name = "hashing_encode_button";
            this.hashing_encode_button.Size = new System.Drawing.Size(121, 28);
            this.hashing_encode_button.TabIndex = 16;
            this.hashing_encode_button.Text = "Encode";
            this.hashing_encode_button.Click += new System.EventHandler(this.hashing_encode_button_Click);
            // 
            // hashing_modes
            // 
            this.hashing_modes.FormattingEnabled = true;
            this.hashing_modes.ItemHeight = 23;
            this.hashing_modes.Items.AddRange(new object[] {
            "SHA256",
            "MD5"});
            this.hashing_modes.Location = new System.Drawing.Point(262, 62);
            this.hashing_modes.Name = "hashing_modes";
            this.hashing_modes.Size = new System.Drawing.Size(121, 29);
            this.hashing_modes.TabIndex = 15;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(262, 40);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(119, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Metodo di hashing";
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.scfls_parita);
            this.metroTabPage4.Controls.Add(this.scfls_timer);
            this.metroTabPage4.Controls.Add(this.scfls_cpu_win);
            this.metroTabPage4.Controls.Add(this.scfls_user_win);
            this.metroTabPage4.Controls.Add(this.label1);
            this.metroTabPage4.Controls.Add(this.pictureBox6);
            this.metroTabPage4.Controls.Add(this.metroLabel8);
            this.metroTabPage4.Controls.Add(this.pictureBox5);
            this.metroTabPage4.Controls.Add(this.pictureBox4);
            this.metroTabPage4.Controls.Add(this.pictureBox3);
            this.metroTabPage4.Controls.Add(this.pictureBox2);
            this.metroTabPage4.Controls.Add(this.pictureBox1);
            this.metroTabPage4.Controls.Add(this.metroLabel7);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(640, 343);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "SCFLS";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(195, 22);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(212, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Sasso-Carta-Forbice-Lizard-Spock";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(42, 83);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(72, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Tua scelta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "CPU:";
            // 
            // scfls_user_win
            // 
            this.scfls_user_win.AutoSize = true;
            this.scfls_user_win.BackColor = System.Drawing.Color.White;
            this.scfls_user_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scfls_user_win.ForeColor = System.Drawing.Color.Green;
            this.scfls_user_win.Location = new System.Drawing.Point(476, 94);
            this.scfls_user_win.Name = "scfls_user_win";
            this.scfls_user_win.Size = new System.Drawing.Size(97, 26);
            this.scfls_user_win.TabIndex = 11;
            this.scfls_user_win.Text = "Vincitore";
            this.scfls_user_win.Visible = false;
            // 
            // scfls_cpu_win
            // 
            this.scfls_cpu_win.AutoSize = true;
            this.scfls_cpu_win.BackColor = System.Drawing.Color.White;
            this.scfls_cpu_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scfls_cpu_win.ForeColor = System.Drawing.Color.Green;
            this.scfls_cpu_win.Location = new System.Drawing.Point(476, 242);
            this.scfls_cpu_win.Name = "scfls_cpu_win";
            this.scfls_cpu_win.Size = new System.Drawing.Size(97, 26);
            this.scfls_cpu_win.TabIndex = 12;
            this.scfls_cpu_win.Text = "Vincitore";
            this.scfls_cpu_win.Visible = false;
            // 
            // scfls_timer
            // 
            this.scfls_timer.AutoSize = true;
            this.scfls_timer.BackColor = System.Drawing.Color.White;
            this.scfls_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scfls_timer.ForeColor = System.Drawing.Color.Black;
            this.scfls_timer.Location = new System.Drawing.Point(284, 180);
            this.scfls_timer.Name = "scfls_timer";
            this.scfls_timer.Size = new System.Drawing.Size(29, 31);
            this.scfls_timer.TabIndex = 13;
            this.scfls_timer.Text = "3";
            this.scfls_timer.Visible = false;
            // 
            // scfls_parita
            // 
            this.scfls_parita.AutoSize = true;
            this.scfls_parita.BackColor = System.Drawing.Color.White;
            this.scfls_parita.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scfls_parita.ForeColor = System.Drawing.Color.Green;
            this.scfls_parita.Location = new System.Drawing.Point(476, 180);
            this.scfls_parita.Name = "scfls_parita";
            this.scfls_parita.Size = new System.Drawing.Size(73, 26);
            this.scfls_parita.TabIndex = 14;
            this.scfls_parita.Text = "Parita\'";
            this.scfls_parita.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(275, 232);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(249, 108);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "lizard";
            this.pictureBox5.DoubleClick += new System.EventHandler(this.user_ha_scelto);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(305, 108);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "spock";
            this.pictureBox4.DoubleClick += new System.EventHandler(this.user_ha_scelto);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(330, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "carta";
            this.pictureBox3.DoubleClick += new System.EventHandler(this.user_ha_scelto);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(275, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "forbice";
            this.pictureBox2.DoubleClick += new System.EventHandler(this.user_ha_scelto);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(219, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "sasso";
            this.pictureBox1.DoubleClick += new System.EventHandler(this.user_ha_scelto);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 468);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Hacktoberfest2019";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox url_to_short;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton url_short_button;
        private MetroFramework.Controls.MetroProgressSpinner url_spinner;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox cipher_output;
        private MetroFramework.Controls.MetroTextBox cipher_input;
        private MetroFramework.Controls.MetroComboBox cipher_modes;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton cipher_decode_button;
        private MetroFramework.Controls.MetroButton cipher_encode_button;
        private MetroFramework.Controls.MetroTextBox cipher_keybox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox hashing_output;
        private MetroFramework.Controls.MetroTextBox hashing_input;
        private MetroFramework.Controls.MetroButton hashing_encode_button;
        private MetroFramework.Controls.MetroComboBox hashing_modes;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label scfls_user_win;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.Label scfls_cpu_win;
        public System.Windows.Forms.Label scfls_timer;
        public System.Windows.Forms.Label scfls_parita;
        public MetroFramework.Controls.MetroLabel metroLabel8;
    }
}

