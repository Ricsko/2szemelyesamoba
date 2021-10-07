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
        }
    }
}
