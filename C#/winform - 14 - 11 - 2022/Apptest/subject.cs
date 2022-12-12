using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apptest
{
    public partial class subject : Form
    {
        public subject()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String list = " ";
            if (checkBox1.Checked)
            {
                list = list + " " + checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                list = list + " " + checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                list = list + " " + checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                list = list + " " + checkBox4.Text;
            }
            if (checkBox5.Checked)
            {
                list = list + " " + checkBox5.Text;
            }
            if (checkBox6.Checked)
            {
                list = list + " " + checkBox6.Text;
            }
            if (checkBox7.Checked)
            {
                list = list + " " + checkBox7.Text;
            }
            if (checkBox8.Checked)
            {
                list = list + " " + checkBox8.Text;
            }
            label3.Text = list + " ";

            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label5.Text = systime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
