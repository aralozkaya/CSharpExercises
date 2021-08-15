
namespace PhoneDiary
{
    partial class MainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.contactInfoBox = new System.Windows.Forms.GroupBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.numberBoxLabel = new System.Windows.Forms.Label();
            this.surnameBoxLabel = new System.Windows.Forms.Label();
            this.nameBoxLabel = new System.Windows.Forms.Label();
            this.personalInformationBox = new System.Windows.Forms.GroupBox();
            this.genderSelector = new System.Windows.Forms.ComboBox();
            this.birthdaySelector = new System.Windows.Forms.DateTimePicker();
            this.companyBox = new System.Windows.Forms.TextBox();
            this.companyBoxLabel = new System.Windows.Forms.Label();
            this.birthdaySelectorLabel = new System.Windows.Forms.Label();
            this.genderSelectorLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.contactList = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contactInfoBox.SuspendLayout();
            this.personalInformationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactInfoBox
            // 
            this.contactInfoBox.Controls.Add(this.numberBox);
            this.contactInfoBox.Controls.Add(this.surnameBox);
            this.contactInfoBox.Controls.Add(this.nameBox);
            this.contactInfoBox.Controls.Add(this.numberBoxLabel);
            this.contactInfoBox.Controls.Add(this.surnameBoxLabel);
            this.contactInfoBox.Controls.Add(this.nameBoxLabel);
            this.contactInfoBox.Location = new System.Drawing.Point(12, 36);
            this.contactInfoBox.Name = "contactInfoBox";
            this.contactInfoBox.Size = new System.Drawing.Size(300, 150);
            this.contactInfoBox.TabIndex = 0;
            this.contactInfoBox.TabStop = false;
            this.contactInfoBox.Text = "Contact Information";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(94, 106);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(191, 31);
            this.numberBox.TabIndex = 5;
            this.numberBox.TextChanged += new System.EventHandler(this.checkIfSufficent);
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(94, 71);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(191, 31);
            this.surnameBox.TabIndex = 4;
            this.surnameBox.TextChanged += new System.EventHandler(this.checkIfSufficent);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(94, 36);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(191, 31);
            this.nameBox.TabIndex = 3;
            this.nameBox.TextChanged += new System.EventHandler(this.checkIfSufficent);
            // 
            // numberBoxLabel
            // 
            this.numberBoxLabel.AutoSize = true;
            this.numberBoxLabel.Location = new System.Drawing.Point(6, 110);
            this.numberBoxLabel.Name = "numberBoxLabel";
            this.numberBoxLabel.Size = new System.Drawing.Size(77, 25);
            this.numberBoxLabel.TabIndex = 2;
            this.numberBoxLabel.Text = "Number";
            // 
            // surnameBoxLabel
            // 
            this.surnameBoxLabel.AutoSize = true;
            this.surnameBoxLabel.Location = new System.Drawing.Point(6, 73);
            this.surnameBoxLabel.Name = "surnameBoxLabel";
            this.surnameBoxLabel.Size = new System.Drawing.Size(82, 25);
            this.surnameBoxLabel.TabIndex = 1;
            this.surnameBoxLabel.Text = "Surname";
            // 
            // nameBoxLabel
            // 
            this.nameBoxLabel.AutoSize = true;
            this.nameBoxLabel.Location = new System.Drawing.Point(6, 36);
            this.nameBoxLabel.Name = "nameBoxLabel";
            this.nameBoxLabel.Size = new System.Drawing.Size(59, 25);
            this.nameBoxLabel.TabIndex = 0;
            this.nameBoxLabel.Text = "Name";
            // 
            // personalInformationBox
            // 
            this.personalInformationBox.Controls.Add(this.genderSelector);
            this.personalInformationBox.Controls.Add(this.birthdaySelector);
            this.personalInformationBox.Controls.Add(this.companyBox);
            this.personalInformationBox.Controls.Add(this.companyBoxLabel);
            this.personalInformationBox.Controls.Add(this.birthdaySelectorLabel);
            this.personalInformationBox.Controls.Add(this.genderSelectorLabel);
            this.personalInformationBox.Location = new System.Drawing.Point(12, 192);
            this.personalInformationBox.Name = "personalInformationBox";
            this.personalInformationBox.Size = new System.Drawing.Size(300, 150);
            this.personalInformationBox.TabIndex = 1;
            this.personalInformationBox.TabStop = false;
            this.personalInformationBox.Text = "Personal Information";
            // 
            // genderSelector
            // 
            this.genderSelector.FormattingEnabled = true;
            this.genderSelector.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderSelector.Location = new System.Drawing.Point(94, 102);
            this.genderSelector.Name = "genderSelector";
            this.genderSelector.Size = new System.Drawing.Size(191, 33);
            this.genderSelector.TabIndex = 13;
            // 
            // birthdaySelector
            // 
            this.birthdaySelector.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdaySelector.Location = new System.Drawing.Point(94, 66);
            this.birthdaySelector.MaxDate = new System.DateTime(2021, 8, 4, 20, 36, 39, 408);
            this.birthdaySelector.Name = "birthdaySelector";
            this.birthdaySelector.Size = new System.Drawing.Size(191, 31);
            this.birthdaySelector.TabIndex = 12;
            this.birthdaySelector.Value = new System.DateTime(2021, 8, 4, 20, 36, 39, 408);
            // 
            // companyBox
            // 
            this.companyBox.Location = new System.Drawing.Point(94, 30);
            this.companyBox.Name = "companyBox";
            this.companyBox.Size = new System.Drawing.Size(191, 31);
            this.companyBox.TabIndex = 9;
            // 
            // companyBoxLabel
            // 
            this.companyBoxLabel.AutoSize = true;
            this.companyBoxLabel.Location = new System.Drawing.Point(6, 30);
            this.companyBoxLabel.Name = "companyBoxLabel";
            this.companyBoxLabel.Size = new System.Drawing.Size(89, 25);
            this.companyBoxLabel.TabIndex = 6;
            this.companyBoxLabel.Text = "Company";
            // 
            // birthdaySelectorLabel
            // 
            this.birthdaySelectorLabel.AutoSize = true;
            this.birthdaySelectorLabel.Location = new System.Drawing.Point(6, 67);
            this.birthdaySelectorLabel.Name = "birthdaySelectorLabel";
            this.birthdaySelectorLabel.Size = new System.Drawing.Size(77, 25);
            this.birthdaySelectorLabel.TabIndex = 7;
            this.birthdaySelectorLabel.Text = "Birthday";
            // 
            // genderSelectorLabel
            // 
            this.genderSelectorLabel.AutoSize = true;
            this.genderSelectorLabel.Location = new System.Drawing.Point(6, 104);
            this.genderSelectorLabel.Name = "genderSelectorLabel";
            this.genderSelectorLabel.Size = new System.Drawing.Size(69, 25);
            this.genderSelectorLabel.TabIndex = 8;
            this.genderSelectorLabel.Text = "Gender";
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(165, 348);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(147, 34);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(12, 385);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 34);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 348);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 34);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // contactList
            // 
            this.contactList.AllowUserToAddRows = false;
            this.contactList.AllowUserToDeleteRows = false;
            this.contactList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contactList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactList.EnableHeadersVisualStyles = false;
            this.contactList.Location = new System.Drawing.Point(318, 48);
            this.contactList.Name = "contactList";
            this.contactList.ReadOnly = true;
            this.contactList.RowHeadersVisible = false;
            this.contactList.RowHeadersWidth = 62;
            this.contactList.RowTemplate.Height = 33;
            this.contactList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactList.Size = new System.Drawing.Size(895, 370);
            this.contactList.TabIndex = 5;
            this.contactList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactList_RowEnter);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(165, 385);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(147, 34);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDatabaseFileToolStripMenuItem,
            this.exportDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openDatabaseFileToolStripMenuItem
            // 
            this.openDatabaseFileToolStripMenuItem.Name = "openDatabaseFileToolStripMenuItem";
            this.openDatabaseFileToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.openDatabaseFileToolStripMenuItem.Text = "Open Database File...";
            this.openDatabaseFileToolStripMenuItem.Click += new System.EventHandler(this.openDatabaseFileToolStripMenuItem_Click);
            // 
            // exportDatabaseToolStripMenuItem
            // 
            this.exportDatabaseToolStripMenuItem.Name = "exportDatabaseToolStripMenuItem";
            this.exportDatabaseToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.exportDatabaseToolStripMenuItem.Text = "Export Database...";
            this.exportDatabaseToolStripMenuItem.Click += new System.EventHandler(this.exportDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(172, 34);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileName = "database";
            this.saveFileDialog1.Filter = "Contact Database|*.csv";
            this.saveFileDialog1.Title = "Export Database";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "csv";
            this.openFileDialog1.FileName = "database";
            this.openFileDialog1.Filter = "Database Files|*.csv";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 430);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.contactList);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.personalInformationBox);
            this.Controls.Add(this.contactInfoBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainApp";
            this.Text = "Sample Contacts Application";
            this.contactInfoBox.ResumeLayout(false);
            this.contactInfoBox.PerformLayout();
            this.personalInformationBox.ResumeLayout(false);
            this.personalInformationBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox contactInfoBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label numberBoxLabel;
        private System.Windows.Forms.Label surnameBoxLabel;
        private System.Windows.Forms.Label nameBoxLabel;
        private System.Windows.Forms.GroupBox personalInformationBox;
        private System.Windows.Forms.DateTimePicker birthdaySelector;
        private System.Windows.Forms.TextBox companyBox;
        private System.Windows.Forms.Label companyBoxLabel;
        private System.Windows.Forms.Label birthdaySelectorLabel;
        private System.Windows.Forms.Label genderSelectorLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView contactList;
        private System.Windows.Forms.ComboBox genderSelector;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

