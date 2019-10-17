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
            btnSpock.Visible = true;
            btnLizard.Visible = true;
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
            btnSpock.Visible = false;
            btnLizard.Visible = false;
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

        private void btnLizard_Click(object sender, EventArgs e)
        {
            genera('l');
        }

        private void btnSpock_Click(object sender, EventArgs e)
        {
            genera('p');
        }

        public void genera(char x)
        {
            char r=' ';
            Random random = new Random();
            int numeroCasuale = random.Next(1, 6);
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
            else if(numeroCasuale==3)
            {
                r = 'f';
                lblBot.Text = "forbice";
            }
            else if (numeroCasuale==4)
            {
                r = 'l';
                lblBot.Text = "lizard";
            }
            else if (numeroCasuale == 5)
            {
                r = 'p';
                lblBot.Text = "spock";
            }

            if (x=='s')
            {
                if (r == 's')
                    lblris.Text = "nessun vincitore";
                else if (r == 'c')
                {
                    lblris.Text = "hai perso!";
                    punt = punt - 1;
                }
                else if (r == 'f')
                {
                    lblris.Text = "hai vinto!";
                    punt = punt + 1;
                }
                else if (r == 'l')
                {
                    lblris.Text = "hai vinto!";
                    punt = punt + 1;
                }
                else if (r == 'p')
                {
                    lblris.Text = "hai perso!";
                    punt = punt - 1;
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
                else if (r == 's')
                {
                    lblris.Text = "hai vinto!";
                    punt = punt + 1;
                }
                else if (r == 'l')
                {
                    lblris.Text = "hai perso!";
                    punt = punt - 1;
                }
                else if (r == 'p')
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
                else if (r== 'c')
                {
                    lblris.Text = "hai vinto!";
                    punt = punt + 1;
                }
                else if (r == 'l')
                {
                    lblris.Text = "hai vinto!";
                    punt = punt + 1;
                }
                else if (r == 'p')
                {
                    lblris.Text = "hai perso!";
                    punt = punt - 1;
                }
            }
            if (x == 'l')
            {
                if (r == 'l')
                    lblris.Text = "nessun vincitore";
                else if (r == 's')
                {
                    lblris.Text = "hai perso!";
                    punt = punt - 1;
                }
                else if (r == 'c')
                {
                    lblris.Text = "hai vinto!";
                    punt = punt + 1;
                }
                else if (r == 'f')
                {
                    lblris.Text = "hai perso!";
                    punt = punt - 1;
                }
                else if (r == 'p')
                {
                    lblris.Text = "hai vinto!";
                    punt = punt + 1;
                }
            }
            if (x == 'p')
            {
                if (r == 'p')
                    lblris.Text = "nessun vincitore";
                else if (r == 's')
                {
                    lblris.Text = "hai vinto!";
                    punt = punt + 1;
                }
                else if (r == 'c')
                {
                    lblris.Text = "hai perso!";
                    punt = punt - 1;
                }
                else if (r == 'f')
                {
                    lblris.Text = "hai vinto!";
                    punt = punt + 1;
                }
                else if (r == 'l')
                {
                    lblris.Text = "hai perso!";
                    punt = punt - 1;
                }
            }
                lblPunt.Text = punt.ToString();

        }
    }
}
