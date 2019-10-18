using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacktoberfest2019DZ.SCFLS
{
    class PartitaSCFLS
    {
        MainForm callback;
        string scelta;
        public PartitaSCFLS(MainForm callback, string scelta)
        {
            this.callback = callback;
            this.scelta = scelta;
            start();
        }

        public void start()
        {
            Random rnd = new Random();
            int scelta_cpu = rnd.Next(0, 5);
            loadImage(scelta_cpu);
            switch (scelta)
            {
                case "sasso":
                    callback.metroLabel8.Text = "Tua scelta: sasso";
                    confrontaCon(0, scelta_cpu);
                    break;
                case "carta":
                    callback.metroLabel8.Text = "Tua scelta: carta";
                    confrontaCon(1, scelta_cpu);
                    break;
                case "forbice":
                    callback.metroLabel8.Text = "Tua scelta: forbice";
                    confrontaCon(2, scelta_cpu);
                    break;
                case "lizard":
                    callback.metroLabel8.Text = "Tua scelta: lizard";
                    confrontaCon(3, scelta_cpu);
                    break;
                case "spock":
                    callback.metroLabel8.Text = "Tua scelta: spock";
                    confrontaCon(4, scelta_cpu);
                    break;
            }

        }

        private void loadImage(int scelta_cpu)
        {
            switch (scelta_cpu)
            {
                case 0:
                    callback.pictureBox6.Image = Properties.Resources.rock;
                    break;
                case 1:
                    callback.pictureBox6.Image = Properties.Resources.scissors;
                    break;
                case 2:
                    callback.pictureBox6.Image = Properties.Resources.paper;
                    break;
                case 3:
                    callback.pictureBox6.Image = Properties.Resources.lizard;
                    break;
                case 4:
                    callback.pictureBox6.Image = Properties.Resources.spock;
                    break;
            }
        }

        private void confrontaCon(int v, int scelta_cpu)
        {
            if (v == scelta_cpu)
            {
                parita();
            }
            else if (v == 0 && (scelta_cpu == 3 || scelta_cpu == 1))
            {
                user_win();
            }

            else if (v == 1 && (scelta_cpu == 2 || scelta_cpu == 3))
            {
                user_win();
            }

            else if (v == 2 && (scelta_cpu == 0 || scelta_cpu == 4))
            {
                user_win();
            }

            else if (v == 3 && (scelta_cpu == 4 || scelta_cpu == 2))
            {
                user_win();
            }

            else if (v == 4 && (scelta_cpu == 0 || scelta_cpu == 1))
            {
                user_win();
            }

            else
            {
                cpu_win();
            }

        }

        private void parita()
        {
            callback.scfls_parita.Visible = true;
            callback.scfls_user_win.Visible = false;
            callback.scfls_cpu_win.Visible = false;
        }

        private void user_win()
        {
            callback.scfls_parita.Visible = false;
            callback.scfls_user_win.Visible = true;
            callback.scfls_cpu_win.Visible = false;
        }

        private void cpu_win()
        {
            callback.scfls_parita.Visible = false;
            callback.scfls_user_win.Visible = false;
            callback.scfls_cpu_win.Visible = true;
        }
    }
}
