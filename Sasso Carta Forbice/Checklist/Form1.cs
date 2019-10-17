using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checklist
{
    public partial class Form1 : Form
    {
        char[] scf = { 's','c','f'};
        int punt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInizia_Click(object sender, EventArgs e)
        {
            btnSasso.Visible = true;
            btnCarta.Visible = true;
            btnForbice.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            lblPunt.Text = punt.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSasso.Visible = false;
            btnCarta.Visible = false;
            btnForbice.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void btnSasso_Click(object sender, EventArgs e)
        {
            genera('s');
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            genera('c');
        }

        private void btnForbice_Click(object sender, EventArgs e)
        {
            genera('f');
            
        }

        public void genera(char x)
        {
            char r;
            Random random = new Random();
            int numeroCasuale = random.Next(1, 4);
            if(numeroCasuale==1)
            {
                r = 's';
                lblBot.Text = "sasso";
            }
            else if(numeroCasuale==2)
            {
                r = 'c';
                lblBot.Text = "carta";
            }
            else
            {
                r = 'f';
                lblBot.Text = "forbice";
            }

            if(x=='s')
            {
                if (r == 's')
                    lblris.Text = "nessun vincitore";
                else if (r == 'c')
                {
                    lblris.Text = "hai perso!";
                    punt = punt - 1;
                }
                else
                {
                    lblris.Text = "hai vinto!";
                    punt = punt + 1;
                }
                
            }

            if (x == 'c')
            {
                if (r == 'c')
                    lblris.Text = "nessun vincitore";
                else if (r == 'f')
                {
                    lblris.Text = "hai perso!";
                    punt = punt - 1;
                }
                else
                {
                    lblris.Text = "hai vinto!";
                    punt = punt + 1;
                }
            }

            if (x == 'f')
            {
                if (r == 'f')
                    lblris.Text = "nessun vincitore";
                else if (r == 's')
                {
                    lblris.Text = "hai perso!";
                    punt = punt - 1;
                }
                else
                {
                    lblris.Text = "hai vinto!";
                    punt = punt + 1;
                }
            }
            lblPunt.Text = punt.ToString();

        }
    }
}
