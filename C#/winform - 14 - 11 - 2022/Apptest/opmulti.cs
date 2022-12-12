using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apptest
{
    public partial class opmulti : Form
    {
        public opmulti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Computation
            int numfi = Convert.ToInt32(textBox1.Text);
            int numsec = Convert.ToInt32(textBox2.Text);
            int numthi = Convert.ToInt32(textBox3.Text);
            int sum = numfi * numsec * numthi;
            String sumans = sum.ToString();
            label6.Text = sumans;

            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label8.Text = systime;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
