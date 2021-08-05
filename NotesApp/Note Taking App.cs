using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Note.myNotes;
        }

        private void ResetForm()
        {
            this.textBox1.ResetText();
            this.textBox2.ResetText();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditMode(bool isInEditMode, DataGridViewRow row)
        {
            if (isInEditMode)
            {
                button1.Click -= button1_Click_Add;
                button1.Click += button1_Click_Apply;
                button1.Text = "Apply";
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
            }
        }

        private void EditMode(bool isInEditMode)
        {
            if (!isInEditMode)
            {
                button1.Click += button1_Click_Add;
                button1.Click -= button1_Click_Apply;
                button1.Text = "Add";
            }
        }
        private void button1_Click_Add(object sender, EventArgs e)
        {
            Note NewNote = new Note(textBox1.Text,textBox2.Text);
            this.ResetForm();
        }

        private void button1_Click_Apply(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            Note theNote = (Note)row.DataBoundItem;
            theNote.Title = textBox1.Text;
            theNote.Text = textBox2.Text;
            EditMode(false);
            this.ResetForm();
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Note.myNotes.Remove((Note)row.DataBoundItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            EditMode(true, row);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Note.myNotes.Count == 0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else if(button2.Enabled == false || button3.Enabled == false)
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }
    }
    
}
