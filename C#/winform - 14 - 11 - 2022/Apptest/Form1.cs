using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apptest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void plusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new opadd().Show();
        }

        private void divideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new opdiv().Show();
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new opminus().Show();

        }

        private void multiplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new opmulti().Show();
        }

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new subject().Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new color().Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new country().Show();
        }
    }
}
