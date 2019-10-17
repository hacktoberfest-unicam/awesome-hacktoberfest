using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] _bytes;
        byte[] _Cryptedbytes;
        string _songPath = String.Empty;
        string _outpath;
        private void buttonImporta_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "MP3 files (*.mp3)|*.mp3";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _songPath = openFileDialog1.FileName;
                _bytes = File.ReadAllBytes(openFileDialog1.FileName);
                button1.Enabled = true;
                button2.Enabled = true;
            }

        }

        public static byte[] GetBytes(string bitString)
        {
            return Enumerable.Range(0, bitString.Length / 8).
                Select(pos => Convert.ToByte(
                    bitString.Substring(pos * 8, 8),
                    2)
                ).ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (richTextBox1.Text.Length > 0 && !richTextBox1.Text.Contains("<EOS>"))
            {
                Crittografia steg = new Crittografia(_bytes, richTextBox1.Text + "<EOS>");
                string _CryptedString = steg.Crypt();

                if (!_CryptedString.Contains("Errore"))
                {
                    
                    _Cryptedbytes = GetBytes(_CryptedString);

                    try
                    {
                        using (MemoryStream ms = new MemoryStream(_Cryptedbytes))
                        {
                            FileStream file = new FileStream(_outpath, FileMode.Create, FileAccess.Write);
                            ms.WriteTo(file);
                            file.Close();
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    axWindowsMediaPlayer1.URL = _outpath;
                    button1.Enabled = false;
                }
                else
                {
                    MessageBox.Show(_CryptedString, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }else
            {
                MessageBox.Show("Inserisci un testo valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Crittografia steg = new Crittografia(_bytes,null);
            string _DecryptedString = steg.Decrypt().Replace("<EOS>", "");

            if(!_DecryptedString.Contains("Errore"))
            {
                richTextBox2.Text = _DecryptedString;
                button2.Enabled = false;
            }else
            {
                MessageBox.Show(_DecryptedString, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Numero Caratteri: " + richTextBox1.Text.Length + " / 6000";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/Crypted"))
            {
                Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/Crypted");
            }
            _outpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/Crypted/CryptedMp3.mp3";
        }
    }
}
