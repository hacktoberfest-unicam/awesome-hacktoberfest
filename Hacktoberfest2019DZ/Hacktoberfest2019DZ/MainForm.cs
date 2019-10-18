
using Hacktoberfest2019DZ.Hashing;
using Hacktoberfest2019DZ.EncryptionDZ;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hacktoberfest2019DZ.EncryptionDZ.EncryptionDZ;
using System.Threading;

namespace Hacktoberfest2019DZ
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            cipher_modes.SelectedIndex = 0;
            hashing_modes.SelectedIndex = 0;
            loadImages();
        }

        private void loadImages()
        {
            pictureBox1.Image = Properties.Resources.rock;
            pictureBox2.Image = Properties.Resources.paper;
            pictureBox3.Image = Properties.Resources.scissors;
            pictureBox5.Image = Properties.Resources.lizard;
            pictureBox4.Image = Properties.Resources.spock;
        }

        private void url_short_button_Click(object sender, EventArgs e)
        {
            //if (url_to_short.Text.Length>3&&checkURL(url_to_short.Text))
            //{
            //    _ = shortUrlAsync(url_to_short.Text);
            //}

            if (url_to_short.Text.Length > 3)
            {
                _ = shortUrlAsync(url_to_short.Text);
            }
        }


        private async Task shortUrlAsync(string url)
        {
            HttpClient client = new HttpClient();
            url_spinner.Visible = true;
            var values = new Dictionary<string, string>
                {
                { "url", url }
                };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("https://hideuri.com/api/v1/shorten", content);

            string responseString = await response.Content.ReadAsStringAsync();

            JObject jobj = JObject.Parse(responseString);
            string short_url = (string)jobj["result_url"];
            if (short_url == null)
            {
                url_to_short.Text = "Error";
                url_spinner.Visible = false;
            }
            else
            { 
                url_to_short.Text = short_url;
                url_spinner.Visible = false;
            }

        }
        private bool checkURL(string url)
        {
            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            
        }

        private void cipher_input_TextChanged(object sender, EventArgs e)
        {
            onOffButtonsCipher(cipher_input.Text.Length > 0 && cipher_keybox.Text.Length > 0);
        }

        private void onOffButtonsCipher(bool isON)
        {
            if (isON)
            {
                cipher_decode_button.Enabled = true;
                cipher_encode_button.Enabled = true;
            }
            else
            {
                cipher_decode_button.Enabled = false;
                cipher_encode_button.Enabled = false;
            }
        }

        private void cipher_encode_button_Click(object sender, EventArgs e)
        {
            switch (cipher_modes.SelectedIndex)
            {
                case 0:
                    encode_using_cesare();
                    break;
            }
        }

        private void cipher_decode_button_Click(object sender, EventArgs e)
        {
            switch (cipher_modes.SelectedIndex)
            {
                case 0:
                    decode_using_cesare();
                    break;
            }
        }

        private void decode_using_cesare()
        {
            CaesarCipher cipher = new CaesarCipher(Convert.ToInt32(cipher_keybox.Text));
            cipher_output.Text = cipher.decrypt(cipher_input.Text.Trim());
        }

        private void encode_using_cesare()
        {
            CaesarCipher cipher = new CaesarCipher(Convert.ToInt32(cipher_keybox.Text));
            cipher_output.Text = cipher.encrypt(cipher_input.Text.Trim());
        }

        private void cipher_keybox_TextChanged(object sender, EventArgs e)
        {
            onOffButtonsCipher(cipher_input.Text.Length > 0 && cipher_keybox.Text.Length > 0);
        }

        private void hashing_encode_button_Click(object sender, EventArgs e)
        {
            string responce = null;
            switch (hashing_modes.SelectedIndex)
            {
                case 0:
                    responce = HashingDZ.ComputeSha256Hash(hashing_input.Text.Trim());
                    hashing_output.Text = responce;
                    break;
                case 1:
                    responce = HashingDZ.CreateMD5(hashing_input.Text.Trim());
                    hashing_output.Text = responce;
                    break;
            }
        }

        private void hashing_input_TextChanged(object sender, EventArgs e)
        {
            _ = hashing_input.Text.Length > 0 ? hashing_encode_button.Enabled = true : hashing_encode_button.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void user_ha_scelto(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            
            scfls_user_win.Visible = false;
            scfls_cpu_win.Visible = false;
            scfls_parita.Visible = false;

            SCFLS.PartitaSCFLS partita = new SCFLS.PartitaSCFLS(this, (string)box.Tag);
            //new Thread(() =>
            //{
            //    scfls_timer.Text = "3";
            //    scfls_timer.Visible = true;
            //    int i = 3;
            //    while (3 > 0)
            //    {
            //        Thread.Sleep(1000);
            //        i--;
            //        scfls_timer.Invoke((MethodInvoker)delegate
            //        {
            //            scfls_timer.Text = i + "";
            //        });
            //    }
                

            //}).Start();
        }
    }
}
