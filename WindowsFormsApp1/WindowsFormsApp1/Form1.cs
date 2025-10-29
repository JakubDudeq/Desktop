using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			pictureBox1.Image = Image.FromFile(@"C:\Users\jakdu\source\repos\WindowsFormsApp1\WindowsFormsApp1\100-zdjecie.png");
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.Image = Image.FromFile(@"C:\Users\jakdu\source\repos\WindowsFormsApp1\WindowsFormsApp1\100-odcisk.png");
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
		}
	
		private void button1_Click(object sender, EventArgs e)
		{

			string kolor = "";

			if (radioButton1.Checked)
			{
				kolor = radioButton1.Text;
			}
            if (radioButton2.Checked)
            {
                kolor = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                kolor = radioButton3.Text;
            }
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "") {


				MessageBox.Show(textBox2.Text + " " + textBox3.Text + " kolor oczu " + textBox3.Text);
			}
			else
			{
                MessageBox.Show("Wprowadź dane");
            }
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			string val = textBox1.Text;
			if (File.Exists(@"C:\Users\jakdu\source\repos\WindowsFormsApp1\WindowsFormsApp1\" + val + "-zdjecie.png"))
			{
				pictureBox1.Image = Image.FromFile(@"C:\Users\jakdu\source\repos\WindowsFormsApp1\WindowsFormsApp1\" + val + "-zdjecie.png");
			}
			else
			{
				pictureBox1.Image = null;
			}
			if (File.Exists(@"C:\Users\jakdu\source\repos\WindowsFormsApp1\WindowsFormsApp1\" + val + "-odcisk.png"))
			{
				pictureBox2.Image = Image.FromFile(@"C:\Users\jakdu\source\repos\WindowsFormsApp1\WindowsFormsApp1\" + val + "-odcisk.png");
			}
            else
            {
                pictureBox2.Image = null;
            }
        }
	}
}
