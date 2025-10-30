using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label5.Text = textBox2.Text;
        }

        private void panel2_Paint(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
        }

        private void panel5_Paint(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
        }

        private void panel7_Paint(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Yellow;
            label5.ForeColor = Color.Yellow;
        }

        private void panel3_Paint(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
            label5.ForeColor = Color.Red;
        }

        private void panel4_Paint(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Magenta;
            label5.ForeColor = Color.Magenta;
        }

        private void panel6_Paint(object sender, EventArgs e)
        {
            label4.ForeColor = Color.MediumTurquoise;
            label5.ForeColor = Color.MediumTurquoise;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog win = new OpenFileDialog();

            if (win.ShowDialog() == DialogResult.OK)
            {
                panel1.BackgroundImage = Image.FromFile(win.FileName);
            }
        }
    }
}
