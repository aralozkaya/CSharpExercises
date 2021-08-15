using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDiary
{
    public partial class MainApp : Form
    {
        string database = "";
        static string expectedLine = "Name;Surname;Number;Company;Birthday;Gender";
        public MainApp(string selectedDatabase = "contacts.csv")
        {
            InitializeComponent();
            this.database = selectedDatabase;
            this.genderSelector.SelectedIndex = 0;
            this.addButton.Enabled = false;
            this.addToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Enabled = false;
            this.birthdaySelector.CustomFormat = "dd/MM/yyyy";

            if (!File.Exists(database))
            {
                var tempFile = File.CreateText(database);
                tempFile.WriteLine("Name;Surname;Number;Company;Birthday;Gender");
                tempFile.Close();

            }
            else
            {
                var tempfile = new StreamReader(database);
                if(tempfile.ReadLine() != expectedLine)
                {
                    raiseError("Corrupted Database File Detected!\nThe application will close.");
                    this.Close();
                }

            }
            var contactsFile = new StreamReader(database);
            var contact = contactsFile.ReadLine().Split(';');
            foreach (var header in contact)
            {
                var column = new DataGridViewTextBoxColumn();
                column.HeaderText = header;
                this.contactList.Columns.Add(column);
            }
            contactsFile.Close();
            UpdateTable();
        }

        private void UpdateTable()
        {
            this.contactList.Rows.Clear();
            var contactsFile = new StreamReader(database, true);
            var contact = contactsFile.ReadLine().Split(';');
            while (!contactsFile.EndOfStream)
            {
                contact = contactsFile.ReadLine().Split(';');
                this.contactList.Rows.Add(contact);
            }
            contactsFile.Close();

            if (contactList.RowCount == 0)
            {
                this.editButton.Enabled = false;
                this.editToolStripMenuItem1.Enabled = false;
                this.deleteButton.Enabled = false;
                this.deleteToolStripMenuItem.Enabled = false;
            }
            resetInputs();
        }

        public void checkIfSufficent(object sender, EventArgs e)
        {
            bool result = true;
            var textBoxes = new List<TextBox>() {
                            nameBox,
                            surnameBox,
                            numberBox
            };
            foreach (var item in textBoxes)
            {
                if(item.Text == "")
                {
                    result = false;
                }
            }
            if (result)
            {
                this.addButton.Enabled = true;
                this.addToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.addButton.Enabled = false;
                this.addToolStripMenuItem.Enabled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt64(numberBox.Text);
                var contactsFile = new StreamWriter(database, true);
                contactsFile.WriteLine($"{nameBox.Text};{surnameBox.Text};{numberBox.Text};{companyBox.Text};{birthdaySelector.Text};{genderSelector.SelectedItem}");
                contactsFile.Close();
                UpdateTable();
            }
            catch (FormatException)
            {
                raiseError("You can only enter numberical values in the 'Number' field!");
                resetInputs();
            }
            catch (Exception)
            {
                raiseError("Unexpected error occured!");
                resetInputs();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selected = contactList.SelectedRows;
            string query = "";
            foreach (DataGridViewRow row in selected)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    query += cell.Value + ";";
                }
                query.Remove(query.Length - 1);
            }
            var tempFile = new StreamWriter("temp.csv", true);
            var contactsFile = new StreamReader(database);
            var contact = contactsFile.ReadLine();
            while (!contactsFile.EndOfStream)
            {
                if(string.Compare(contact, query) != 0)
                {
                    tempFile.WriteLine(contact);
                }
                contact = contactsFile.ReadLine();
            }
            tempFile.Close();
            contactsFile.Close();
            File.Move("temp.csv", database, true);
            UpdateTable();
        }

        private void contactList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.editButton.Enabled = true;
            this.deleteButton.Enabled = true;
            this.editToolStripMenuItem1.Enabled = true;
            this.deleteToolStripMenuItem.Enabled = true; 
        }

        string editQuery = "";
        private void editButton_Click(object sender, EventArgs e)
        {
            this.nameBox.TextChanged -= checkIfSufficent;
            this.surnameBox.TextChanged -= checkIfSufficent;
            this.numberBox.TextChanged -= checkIfSufficent;
            if (editButton.Text == "Edit")
            {
                var rows = contactList.SelectedRows;
                if (rows.Count == 1)
                {
                    this.editButton.Text = "Save";
                    this.saveToolStripMenuItem.Enabled = true;
                    this.editToolStripMenuItem1.Enabled = false;
                    this.deleteButton.Enabled = false;
                    this.addButton.Enabled = false;
                    var cells = rows[0].Cells;
                    this.nameBox.Text = cells[0].Value.ToString();
                    this.surnameBox.Text = cells[1].Value.ToString();
                    this.numberBox.Text = cells[2].Value.ToString();
                    this.companyBox.Text = cells[3].Value.ToString();
                    this.birthdaySelector.Value = Convert.ToDateTime(cells[4].Value);
                    this.genderSelector.SelectedItem = cells[5].Value;
                    this.editQuery = $"{nameBox.Text};{surnameBox.Text};{numberBox.Text};{companyBox.Text};{birthdaySelector.Text};{genderSelector.SelectedItem}";
                }
                else
                {
                    raiseError("You can only select one entry when editting!");
                }
            }
            else
            {
                string updatedQuery = $"{nameBox.Text};{surnameBox.Text};{numberBox.Text};{companyBox.Text};{birthdaySelector.Text};{genderSelector.SelectedItem}";
                var tempFile = new StreamWriter("temp.csv", true);
                var contactsFile = new StreamReader(database);
                var contact = contactsFile.ReadLine();
                tempFile.WriteLine(contact);
                while (!contactsFile.EndOfStream)
                {
                    contact = contactsFile.ReadLine();
                    if (contact != editQuery)
                    {
                        tempFile.WriteLine(contact);
                    }
                    else
                    {
                        tempFile.WriteLine(updatedQuery);
                    }
                }
                tempFile.Close();
                contactsFile.Close();
                File.Move("temp.csv", database, true);
                UpdateTable();
                this.nameBox.TextChanged += checkIfSufficent;
                this.surnameBox.TextChanged += checkIfSufficent;
                this.numberBox.TextChanged += checkIfSufficent;
                this.editButton.Text = "Edit";
                this.saveToolStripMenuItem.Enabled = false;
                this.editToolStripMenuItem1.Enabled = true;
            }
        }

        private void resetInputs()
        {
            this.nameBox.ResetText();
            this.surnameBox.ResetText();
            this.numberBox.ResetText();
            this.companyBox.ResetText();
            this.birthdaySelector.Value = birthdaySelector.MaxDate;
            this.genderSelector.SelectedIndex = 0;
        }
        private void raiseError(string message)
        {
            MessageBox.Show(message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            var file = this.saveFileDialog1.FileName;
            File.Copy(database, file, true);
        }

        private void openDatabaseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var file = this.openFileDialog1.FileName;
            Process secondProc = new Process();
            secondProc.StartInfo.FileName = Application.ExecutablePath;
            secondProc.StartInfo.Arguments = file;
            secondProc.Start();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The app was created by İbrahim Aral Özkaya for C# exercise purposes\n\nCopyright ©2021", "About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
