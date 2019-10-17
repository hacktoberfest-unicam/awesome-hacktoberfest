using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_RadioButton
{
    public partial class Form1 : Form
    {
        string testo;
        char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        int g, k, i;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCifra_Click(object sender, EventArgs e)
        {
            testo=txtTesto.Text.ToUpper();
            char[] charArr = testo.ToCharArray();
            char[] cifrato = testo.ToCharArray();
                for(i=0;i<testo.Length;i++)
                {
                    for(k=0;k<alfabeto.Length;k++)
                    {
                        if(charArr[i]==alfabeto[k])
                        {
                            if(k==23)
                                g=0;
                            else if(k==24)
                                g=1;
                            else if(k==25)
                                g=2;
                            else
                                g=k+3;                           

                            cifrato[i]=alfabeto[g];
                        }
                    }                 
                }
                string cifr = new string(cifrato);
                lblRisultato.Text=cifr.ToString();

        }

        private void btnDecifra_Click(object sender, EventArgs e)
        {
            testo = txtTesto.Text.ToUpper();
            char[] charArr = testo.ToCharArray();
            char[] decifrato = testo.ToCharArray();
            for (int i = 0; i < testo.Length; i++)
            {
                for (int k = 0; k < alfabeto.Length; k++)
                {
                    if (charArr[i] == alfabeto[k])
                    {
                        if (k == 0)
                            g = 23;
                        else if (k == 1)
                            g = 24;
                        else if (k == 2)
                            g = 25;
                        else
                            g = k - 3;

                        decifrato[i] = alfabeto[g];
                    }
                }
            }
            string decifr = new string(decifrato);
            lblDecript.Text = decifr.ToString();
        }
    }
}
