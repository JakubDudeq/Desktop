using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public int r, g, b = 255;

        public Form1()
        {
            InitializeComponent();
        }

        public void changeColor(int r, int g, int b)
        {
            panel1.BackColor = Color.FromArgb(r, g, b);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            r = trackBar1.Value;
            changeColor(r, g, b);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            g = trackBar2.Value;
            changeColor(r, g, b);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            b = trackBar3.Value;
            changeColor(r, g, b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(r, g, b);
            label8.Text = (r + ", " + g + ", " + b);
        }
    }
}
