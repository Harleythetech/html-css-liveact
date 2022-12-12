using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new name().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Birthday().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Country().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new namsec().Show();
            this.Hide();
        }
    }
}
