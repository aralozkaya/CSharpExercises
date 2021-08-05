using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        static string expectedLine = "Name;Surname;Number;Company;Birthday;Gender";
        public MainApp()
        {
            InitializeComponent();
            genderSelector.SelectedIndex = 0;
            addButton.Enabled = false;
            birthdaySelector.CustomFormat = "dd/MM/yyyy";

            if (!File.Exists("contacts.csv"))
            {
                var tempFile = File.CreateText("contacts.csv");
                tempFile.WriteLine("Name;Surname;Number;Company;Birthday;Gender");
                tempFile.Close();

            }
            else
            {
                var tempfile = new StreamReader("contacts.csv");
                if(tempfile.ReadLine() != expectedLine)
                {
                    raiseError("Corrupted Database File Detected!\nThe application will close.");
                    this.Close();
                }

            }
            var contactsFile = new StreamReader("contacts.csv");
            var contact = contactsFile.ReadLine().Split(';');
            foreach (var header in contact)
            {
                var column = new DataGridViewTextBoxColumn();
                column.HeaderText = header;
                contactList.Columns.Add(column);
            }
            contactsFile.Close();
            UpdateTable();
        }

        private void UpdateTable()
        {
            contactList.Rows.Clear();
            var contactsFile = new StreamReader("contacts.csv",true);
            var contact = contactsFile.ReadLine().Split(';');
            while (!contactsFile.EndOfStream)
            {
                contact = contactsFile.ReadLine().Split(';');
                contactList.Rows.Add(contact);
            }
            contactsFile.Close();

            if (contactList.RowCount == 0)
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
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
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt64(numberBox.Text);
                var contactsFile = new StreamWriter("contacts.csv", true);
                contactsFile.WriteLine($"{nameBox.Text};{surnameBox.Text};{numberBox.Text};{companyBox.Text};{birthdaySelector.Text};{genderSelector.SelectedItem}");
                contactsFile.Close();
                UpdateTable();
            }
            catch (Exception)
            {
                raiseError("You can only enter numberical values in the 'Number' field!");
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
            var contactsFile = new StreamReader("contacts.csv");
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
            File.Move("temp.csv", "contacts.csv", true);
            UpdateTable();
        }

        private void contactList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        string editQuery = "";
        private void editButton_Click(object sender, EventArgs e)
        {
            nameBox.TextChanged -= checkIfSufficent;
            surnameBox.TextChanged -= checkIfSufficent;
            numberBox.TextChanged -= checkIfSufficent;
            if (editButton.Text == "Edit")
            {
                var rows = contactList.SelectedRows;
                if (rows.Count == 1)
                {
                    editButton.Text = "Save";
                    deleteButton.Enabled = false;
                    addButton.Enabled = false;
                    var cells = rows[0].Cells;
                    nameBox.Text = cells[0].Value.ToString();
                    surnameBox.Text = cells[1].Value.ToString();
                    numberBox.Text = cells[2].Value.ToString();
                    companyBox.Text = cells[3].Value.ToString();
                    birthdaySelector.Value = Convert.ToDateTime(cells[4].Value);
                    genderSelector.SelectedItem = cells[5].Value;
                    editQuery = $"{nameBox.Text};{surnameBox.Text};{numberBox.Text};{companyBox.Text};{birthdaySelector.Text};{genderSelector.SelectedItem}";
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
                var contactsFile = new StreamReader("contacts.csv");
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
                File.Move("temp.csv", "contacts.csv", true);
                UpdateTable();
                nameBox.TextChanged += checkIfSufficent;
                surnameBox.TextChanged += checkIfSufficent;
                numberBox.TextChanged += checkIfSufficent;
                editButton.Text = "Edit";
            }
        }

        private void resetInputs()
        {
            nameBox.ResetText();
            surnameBox.ResetText();
            numberBox.ResetText();
            companyBox.ResetText();
            birthdaySelector.Value = birthdaySelector.MaxDate;
            genderSelector.SelectedIndex = 0;
        }
        private void raiseError(string message)
        {
            MessageBox.Show(message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
