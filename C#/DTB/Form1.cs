using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


         
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            DataGridViewRow selrow = this.dataGridView1.Rows[ind];
            textBox1.Text = selrow.Cells[0].Value.ToString();
            textBox2.Text = selrow.Cells[1].Value.ToString();
            textBox3.Text = selrow.Cells[2].Value.ToString();
            dateTimePicker1.Text = selrow.Cells[3].Value.ToString();
            if (selrow.Cells[4].Value.ToString() == "Male")
            {
                radioButton1.Checked = true;
            }
            if (selrow.Cells[4].Value.ToString() == "Female")
            {
                radioButton2.Checked = true;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView1);
            newRow.Cells[0].Value = textBox1.Text;
            newRow.Cells[1].Value = textBox2.Text;
            newRow.Cells[2].Value = textBox3.Text;
            newRow.Cells[3].Value = dateTimePicker1.Text;

            //Gender Identification
            String list = " ";
            if (radioButton1.Checked){
                list = list + radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                list = list + radioButton2.Text;
            }
            newRow.Cells[4].Value = list;
            //End of GI

            dataGridView1.Rows.Add(newRow);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            row.Cells[0].Value = textBox1.Text;
            row.Cells[1].Value = textBox2.Text;
            row.Cells[2].Value = textBox2.Text;
            row.Cells[3].Value = dateTimePicker1.Text;

            //Gender Identification
            String list = " ";
            if (radioButton1.Checked)
            {
                list = list + radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                list = list + radioButton2.Text;
            }
            //End of GI
            row.Cells[4].Value = list;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
