using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_12_12_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string tb1;
        public static string tb2;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            tb1 = textBox1.Text;
            tb2 = textBox2.Text;
            if (tb1 == "" || tb2 == "")
            {
                MessageBox.Show("You have entered a wrong User/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
            else if(tb1 == "admin" && tb2 == "admin")
            {

                DialogResult diag = MessageBox.Show("Do you want to login?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (diag == DialogResult.OK)
                {
                    new Form2().Show();
                    this.Hide();
                }
                else if (diag == DialogResult.Cancel)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            else
            {
                MessageBox.Show("You have entered a wrong User/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
