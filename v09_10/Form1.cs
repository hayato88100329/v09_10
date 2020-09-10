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

        int[] vx = new int[3];
        int[] vy = new int[3];
        Label[] labels = new Label[3];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                vx[i] = rand.Next(-15, 16);
                vy[i] = rand.Next(-15, 16);

                labels[0] = new Label();
                labels[0].AutoSize = true;
                labels[0].Text = "★";

                labels[i].Left = rand.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = rand.Next(ClientSize.Width - labels[i].Width);
                Controls.Add(labels[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx[0];
            label1.Top += vy[0];

            if (label1.Left < 0)
            {
                vx[0] = Math.Abs(vx[0]);
            }
            if (label1.Top < 0)
            {
                vy[0] = Math.Abs(vy[0]);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx[0] = -Math.Abs(vx[0]);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy[0] = -Math.Abs(vy[0]);
            }

            label2.Left += vx[1];
            label2.Top += vy[1];

            if (label2.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            if (label2.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            if (label2.Right > ClientSize.Width)
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            if (label2.Bottom > ClientSize.Height)
            {
                vy[1] = -Math.Abs(vy[1]);
            }

            label3.Left += vx[2];
            label3.Top += vy[2];

            if (label3.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            if (label3.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            if (label3.Right > ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
            }
            Point mp = PointToClient(MousePosition);
            if ((mp.X >= label1.Left)
                 && (mp.X < label1.Right)
                 && (mp.Y >= label1.Top)
                 && (mp.Y < label1.Bottom)
              )
            {
                timer1.Enabled = false;
            }
        }
    }
}
