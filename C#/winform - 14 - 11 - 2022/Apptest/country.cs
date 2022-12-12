using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apptest
{
    public partial class country : Form
    {
        public country()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String list = " ";
            if (radioButton1.Checked)
            {
                list = list + " " + radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                list = list + " " + radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                list = list + " " + radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                list = list + " " + radioButton4.Text;
            }
            if (radioButton5.Checked)
            {
                list = list + " " + radioButton5.Text;
            }
            if (radioButton6.Checked)
            {
                list = list + " " + radioButton6.Text;
            }
            label3.Text = list;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label5.Text = systime;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
