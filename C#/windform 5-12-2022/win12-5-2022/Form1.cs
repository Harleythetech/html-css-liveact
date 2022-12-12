using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win12_5_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string tb1;
        public static string tb2;
        public static string gender;
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb1 = textBox1.Text;
            tb2 = textBox2.Text;
            String list = "";
            if (radioButton1.Checked)
            {
                list = list + radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                list = list + radioButton2.Text;
            }
            gender = list;

            //Confirmation
            if (tb1 == "" || tb2 == "" || radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Please enter a value.","Error: Value Undefined", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                
                DialogResult diag = MessageBox.Show("Are you sure?", "User Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                if(diag == DialogResult.OK)
                {
                    new Form2().Show();
                    this.Hide();
                }
                else if(diag == DialogResult.Cancel)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
