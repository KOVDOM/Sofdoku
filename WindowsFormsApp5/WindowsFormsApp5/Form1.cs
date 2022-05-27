using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length==i*i)
            {
                MessageBox.Show("A feladvány megfelelő hosszúságú!");
            }
            else if (textBox2.Text.Length>i*i)
            {
                MessageBox.Show("A feladvány hosszú: törlendő " + (textBox2.Text.Length > i * i)+" számjegy");
            }
            else if (true)
            {
                MessageBox.Show("A feladvány túl rövid: törlendő " + (i * i - textBox2.Text.Length) + " számjegy");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i < 9)
            {
                i++;
                textBox1.Text = i.ToString();
            }
        }

        int i = 4;  
        private void button2_Click(object sender, EventArgs e)
        {
            if (i>4)
            {
                i--;
                textBox1.Text = i.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "Hossz: " + textBox2.Text.Length;
        }
    }
}
