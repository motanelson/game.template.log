using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace motor
{
    public partial class Form1 : Form
    {
        private Image i; Bitmap b; int value = 0; int value2 = 0; int xx = 0; int yy = 0; Graphics ee; int xxx = 0; int yyy = 0; int xxxx = 10; int xxx1 = 0; int xxxx1 = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            xxx = pictureBox1.Width / 2;
            yyy = pictureBox1.Height / 2;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            double v = Math.PI / 11.00 * ((double)value);
            double rrr = 100.00;
            ee = Graphics.FromImage(b);
            Pen a = new Pen(Color.FromArgb(0, 0, 0));
            Pen c = new Pen(Color.FromArgb(255, 255, 255));
            SolidBrush rBrush = new SolidBrush(Color.FromArgb(60, 60, 60));
            SolidBrush rrBrush = new SolidBrush(Color.FromArgb(0, 0, 0));
            SolidBrush raBrush = new SolidBrush(Color.FromArgb(100, 100, 100));
            Rectangle f = new Rectangle(((int)rrr), ((int)rrr), 60, 60);
            Rectangle f1 = new Rectangle(((int)rrr) + 20 - ((int)(Math.Sin(v) * rrr)), ((int)rrr) + 20 + ((int)(Math.Cos(v) * rrr)), 30, 30);
            Rectangle f2 = new Rectangle(((int)rrr) + 55 - ((int)(Math.Sin(v) * rrr)), ((int)rrr) + 5 + ((int)(Math.Cos(v) * rrr)), 40, 20);
            ee.Clear(Color.FromArgb(0, 0, 255));

            ee.FillEllipse(rBrush, f);
            ee.FillEllipse(rBrush, f1);



            a.Dispose();
            c.Dispose();
            ee.Dispose();
            rBrush.Dispose();
            rrBrush.Dispose();
            raBrush.Dispose();
            pictureBox1.Refresh();
            value++;
            if (value > 21) value = 0;


        }

    }
}
