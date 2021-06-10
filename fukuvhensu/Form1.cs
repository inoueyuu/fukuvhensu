using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvhensu
{
    public partial class Form1 : Form
    {
        int vx = 0;
        int vy = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "0";
            //textBox2.Text = "-1";
            vx = 0;
            vy = -1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "-1";
            //textBox2.Text = "0";
            vx = -1;
            vy = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "1";
            //textBox2.Text = "0";
            vx = 1;
            vy = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Top += int.Parse(textBox2.Text);
            //label1.Left += int.Parse(textBox1.Text);
            label1.Top = vy;
            label1.Left = vx;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "0";
            //textBox2.Text = "1";
            vx = 0;
            vy = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
