using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intersection
{
    public partial class IntersectionForm : Form
    {
        private Graphics graphic;
        int[] array = {0,0,0,0,0,0,0};
        public IntersectionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphic = pictureBox1.CreateGraphics();
            graphic.Clear(Color.White);
            Random rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                array[i] = rand.Next(50, 250);
            }
            while ((array[3] == array[5]) && (array[4] == array[6]))
            {
                array[3] = rand.Next(50, 250);
            }
            textBox1.Text = string.Join(",", array[0]);
            textBox2.Text = string.Join(",", array[1]);
            textBox3.Text = string.Join(",", array[2]);
            textBox4.Text = string.Join(",", array[3]);
            textBox5.Text = string.Join(",", array[4]);
            textBox6.Text = string.Join(",", array[5]);
            textBox7.Text = string.Join(",", array[6]);

            bool inters = geometry.Calculator.intersection(array[0],
                array[1], array[2], array[3], array[4], array[5], array[6]);
            if (inters)
            {
                textBox8.Text = "Yes";
            }
            else
            {
                textBox8.Text = "No";
            }

            Pen crclPen = new Pen(Color.Red);
            Pen sgmntPen = new Pen(Color.Blue);

            Point point1 = new Point(array[3],array[4]);
            Point point2 = new Point(array[5], array[6]); ;

            int edge = array[2] * 2;
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.DrawEllipse(crclPen, array[0] - array[2], array[1] - array[2], edge, edge);
            graphic.DrawLine(sgmntPen, point1, point2);
        }
    }
}
