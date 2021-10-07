using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amoba
{
    public partial class Form1 : Form
    {
        static string jatekos1 = "";
        static string jatekos2 = "";
        static string jatekos1_jel = "";
        static string jatekos2_jel = "";
        static Button[,] buttonok = new Button[10, 10];
        static string[,] tictac = new string[10, 10];


        public Form1()
        {
            InitializeComponent();
        }

        private void gombletrehozas()
        {
            int x = 0;
            int y = 30;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button button1 = new Button();
                    button1.Size = new Size(50, 50);
                    button1.Location = new Point(x + 6, y);
                    button1.BackColor = Color.White;

                    this.Controls.Add(button1);
                    buttonok[i, j] = button1;

                    x += 50;
                }
                x = 0;
                y += 50;
            }
            this.Size = new Size(530, 600);
        }

        private void jatekosNevek()
        {

            jatekos1 = jatekos1_TBOX.Text;
            jatekos2 = jatekos2_TBOX.Text;

            jatekos1_megjelenito_LBL.Text = jatekos1;
            jatekos2_megjelenito_LBL.Text = jatekos2;

            label1.Visible = false;
            label2.Visible = false;
            jatekos1_TBOX.Visible = false;
            jatekos2_TBOX.Visible = false;
            start_BTN.Visible = false;
        }

        private void start_BTN_Click(object sender, EventArgs e)
        {
            gombletrehozas();
            jatekosNevek();
            RandomJEL();

        }

        private void RandomJEL()
        {
            Random r = new Random();
            string[] jelek = new string[2] { "X", "O" };
            int index = r.Next(0, 2);
            jatekos1_jel = jelek[index];
            if(jatekos1_jel == "X")
            {
                jatekos2_jel = "O";
            }
            else
            {
                jatekos2_jel = "X";
            }
        }
    }
}
