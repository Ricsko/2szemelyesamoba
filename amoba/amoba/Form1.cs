﻿using System;
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
        static string aktualisjel = "X";


        public Form1()
        {
            InitializeComponent();
        }

        private void klikk(object sender, EventArgs e)
        {
            Button klikkelt = sender as Button;
            klikkelt.Text = aktualisjel;

            int sor = Convert.ToInt32(klikkelt.Name.Split('_')[1]);
            int oszlop = Convert.ToInt32(klikkelt.Name.Split('_')[2]);

            tictac[sor, oszlop] = aktualisjel;

            if (aktualisjel == "X")
            {
                aktualisjel = "O";
            }
            else
            {
                aktualisjel = "X";
            }
            klikkelt.Enabled = false;

            soronlevoJatekos();
            jatekLogika();
        }

        private void jatekLogika()
        {
            vizszintesEllenorzes();
            fuggolegesEllenorzes();
            //balAtloEllenorzes();
            jobbAtloEllenorzes();
        }

        private void jobbAtloEllenorzes()
        {
            string xd = "";

            for (int i = 4; i < 10; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (tictac[i, j] != "a" && tictac[i, j] == tictac[i - 1, j + 1])
                    {
                        for (int k = 0; k < ; k++)
                        {

                        }
                    }
                }
            }
            MessageBox.Show(xd);
        }

        private void balAtloEllenorzes()
        {
            /*
            int szamlaloX = 0;
            int szamlaloO = 0;
            

            for (int i = 4; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                   if(tictac[i,j]!="a"&&tictac[i,j])
                }
            }

            if (szamlaloX == 4 || szamlaloO == 4)
            {
                if (jatekos1_jel == "X")
                {
                    MessageBox.Show($"A játék győztese: {jatekos1}");
                }
                else if (jatekos2_jel == "X")
                {
                    MessageBox.Show($"A játék győztese: {jatekos2}");
                }

                else if (jatekos1_jel == "O")
                {
                    MessageBox.Show($"A játék győztese: {jatekos1}");
                }
                else if (jatekos2_jel == "O")
                {
                    MessageBox.Show($"A játék győztese: {jatekos2}");
                }
            }

            szamlaloX = 0;
            szamlaloO = 0;
            */
        }

        private void fuggolegesEllenorzes()
        {
            string xo = "";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    xo += tictac[j, i];
                }
            }
            if (xo.Contains("XXXXX"))
            {
                if (jatekos1_jel == "X")
                {
                    MessageBox.Show($"A játék győztese: {jatekos1}");
                }
                else if (jatekos2_jel == "X")
                {
                    MessageBox.Show($"A játék győztese: {jatekos2}");
                }
            }
            else if (xo.Contains("OOOOO"))
            {
                if (jatekos1_jel == "O")
                {
                    MessageBox.Show($"A játék győztese: {jatekos1}");
                }
                else if (jatekos2_jel == "O")
                {
                    MessageBox.Show($"A játék győztese: {jatekos2}");
                }
            }
        }

        private void vizszintesEllenorzes()
        {
            string xo = "";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    xo += tictac[i, j];
                }
            }
            if (xo.Contains("XXXXX"))
            {
                if(jatekos1_jel == "X")
                {
                    MessageBox.Show($"A játék győztese: {jatekos1}");
                }
                else if (jatekos2_jel == "X")
                {
                    MessageBox.Show($"A játék győztese: {jatekos2}");
                }    
            }
            else if (xo.Contains("OOOOO"))
            {
                if(jatekos1_jel == "O")
                {
                    MessageBox.Show($"A játék győztese: {jatekos1}");
                }
                else if(jatekos2_jel == "O")
                {
                    MessageBox.Show($"A játék győztese: {jatekos2}");
                }
            }
        }

        private void start_BTN_Click(object sender, EventArgs e)
        {
            jatekosNevek();
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
                    button1.Click += new System.EventHandler(this.klikk);
                    button1.Name = $"BTN_{i}_{j}";
                    this.Controls.Add(button1);
                    buttonok[i, j] = button1;
                    tictac[i, j] = "a";

                    x += 50;
                }
                x = 0;
                y += 50;
            }
            this.Size = new Size(530, 600);
        }

        private void soronlevoJatekos()
        {
            if (jatekos1_megjelenito_LBL.Text.Contains(aktualisjel))
            {
                jatekos1_megjelenito_LBL.ForeColor = Color.FromArgb(110, 215, 65);
                jatekos1_megjelenito_LBL.Font = new Font("Microsoft Sans Serif", 10);
                jatekos2_megjelenito_LBL.ForeColor = Color.Black;
                jatekos2_megjelenito_LBL.Font = new Font("Microsoft Sans Serif", 8);
            }
            else if (jatekos2_megjelenito_LBL.Text.Contains(aktualisjel))
            {
                jatekos2_megjelenito_LBL.ForeColor = Color.FromArgb(110, 215, 65);
                jatekos2_megjelenito_LBL.Font = new Font("Microsoft Sans Serif", 10);
                jatekos1_megjelenito_LBL.ForeColor = Color.Black;
                jatekos1_megjelenito_LBL.Font = new Font("Microsoft Sans Serif", 8);
            }
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

        private void jatekosNevek()
        {

            //Nevek ellenörzése

            jatekos1 = jatekos1_TBOX.Text;
            jatekos2 = jatekos2_TBOX.Text;


            if(jatekos1 == "")
            {
                MessageBox.Show("Mond hol van a neved ember?");
            }
            else if(jatekos2 == "")
            {
                MessageBox.Show("Mond hol van a neved ember?");
            }
            else
            {
                RandomJEL();
                

                label1.Visible = false;
                label2.Visible = false;

                jatekos1_TBOX.Visible = false;
                jatekos2_TBOX.Visible = false;
                start_BTN.Visible = false;

                jatekos1_megjelenito_LBL.Text = jatekos1;
                jatekos2_megjelenito_LBL.Text = jatekos2;

                jatekos1_megjelenito_LBL.Text = jatekos1 + " " + jatekos1_jel;
                jatekos2_megjelenito_LBL.Text = jatekos2 + " " + jatekos2_jel;

                soronlevoJatekos();
                gombletrehozas();

            }

        }
    }
}
