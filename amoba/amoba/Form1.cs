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
        public Form1()
        {
            InitializeComponent();

            gombletrehozas();
        }

        private void gombletrehozas()
        {
            int x = 200;
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
                x = 200;
                y += 50;
            }
        }
    }
}
