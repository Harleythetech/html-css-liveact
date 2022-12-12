using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj21112022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            address = textBox2.Text;
            birthday = dateTimePicker1.Text;
            string label = " ";
            if (radioButton1.Checked)
            {
                label = label + radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                label = label + radioButton2.Text;
            }
            gender = label;
            new Form2().Show();
            this.Hide();
        }
        // things to call
        public static string name;
        public static string address;
        public static string gender;
        public static string birthday;

        private void button2_Click(object sender, EventArgs e)
        {
            string na = "";
            textBox1.Text = na;
            textBox2.Text = na;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

    }
}
