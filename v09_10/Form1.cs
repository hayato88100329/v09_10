using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v09_10
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();

        int[] vx = new int[100];
        int[] vy = new int[100];
        Label[] labels = new Label[100];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                vx[i] = rand.Next(-15, 16);
                vy[i] = rand.Next(-15, 16);
                labels[0] = new Label();
                labels[0].AutoSize = true;
                labels[0].Text = "★";
                Controls.Add(labels[i]);

                labels[i].Left= rand.Next(ClientSize.width-labels[i].width);





            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }
    }
}
