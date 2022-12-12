using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apptest
{
    public partial class color : Form
    {
        public color()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Violet;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label3.Text = systime;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Brown;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label3.Text = systime;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label3.Text = systime;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Coral;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label3.Text = systime;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label3.Text = systime;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label3.Text = systime;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label3.Text = systime;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label3.Text = systime;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label3.Text = systime;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label3.Text = systime;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label3.Text = systime;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            //Time 
            DateTime time = DateTime.Now;
            String systime = time.ToString();
            label3.Text = systime;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
