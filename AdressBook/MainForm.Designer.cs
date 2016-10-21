namespace AdressBook {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ContactInfoNameField = new System.Windows.Forms.TextBox();
            this.ContactInfoAdressField = new System.Windows.Forms.TextBox();
            this.ContactInfoCityField = new System.Windows.Forms.TextBox();
            this.ContactInfoZIPField = new System.Windows.Forms.TextBox();
            this.ContactInfoNameLabel = new System.Windows.Forms.Label();
            this.ContactInfoAdressLabel = new System.Windows.Forms.Label();
            this.ContactInfoZIPLabel = new System.Windows.Forms.Label();
            this.ContactInfoCityLabel = new System.Windows.Forms.Label();
            this.ContactInfoMailLabel = new System.Windows.Forms.Label();
            this.ContactInfoPhoneLabel = new System.Windows.Forms.Label();
            this.ContactInfoMailField = new System.Windows.Forms.TextBox();
            this.ContactInfoPhoneField = new System.Windows.Forms.TextBox();
            this.ContactList = new System.Windows.Forms.ListBox();
            this.ContactInfoCancelButton = new System.Windows.Forms.Button();
            this.ContactListAddButton = new System.Windows.Forms.Button();
            this.ContactListRemoveButton = new System.Windows.Forms.Button();
            this.contactInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.cmdSaveContact = new System.Windows.Forms.Button();
            this.ContactListGroupBox = new System.Windows.Forms.GroupBox();
            this.contactListSearchField = new System.Windows.Forms.TextBox();
            this.cmdSearchContacts = new System.Windows.Forms.Button();
            this.contactInfoGroupBox.SuspendLayout();
            this.ContactListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactInfoNameField
            // 
            this.ContactInfoNameField.Location = new System.Drawing.Point(52, 21);
            this.ContactInfoNameField.Name = "ContactInfoNameField";
            this.ContactInfoNameField.Size = new System.Drawing.Size(189, 20);
            this.ContactInfoNameField.TabIndex = 4;
            this.ContactInfoNameField.TextChanged += new System.EventHandler(this.NameField_TextChanged);
            // 
            // ContactInfoAdressField
            // 
            this.ContactInfoAdressField.Location = new System.Drawing.Point(52, 47);
            this.ContactInfoAdressField.Name = "ContactInfoAdressField";
            this.ContactInfoAdressField.Size = new System.Drawing.Size(189, 20);
            this.ContactInfoAdressField.TabIndex = 5;
            this.ContactInfoAdressField.TextChanged += new System.EventHandler(this.AdressField_TextChanged);
            // 
            // ContactInfoCityField
            // 
            this.ContactInfoCityField.Location = new System.Drawing.Point(52, 99);
            this.ContactInfoCityField.Name = "ContactInfoCityField";
            this.ContactInfoCityField.Size = new System.Drawing.Size(189, 20);
            this.ContactInfoCityField.TabIndex = 7;
            this.ContactInfoCityField.TextChanged += new System.EventHandler(this.CityField_TextChanged);
            // 
            // ContactInfoZIPField
            // 
            this.ContactInfoZIPField.Location = new System.Drawing.Point(52, 73);
            this.ContactInfoZIPField.Name = "ContactInfoZIPField";
            this.ContactInfoZIPField.Size = new System.Drawing.Size(189, 20);
            this.ContactInfoZIPField.TabIndex = 6;
            this.ContactInfoZIPField.TextChanged += new System.EventHandler(this.ZIPField_TextChanged);
            // 
            // ContactInfoNameLabel
            // 
            this.ContactInfoNameLabel.AutoSize = true;
            this.ContactInfoNameLabel.Location = new System.Drawing.Point(11, 24);
            this.ContactInfoNameLabel.Name = "ContactInfoNameLabel";
            this.ContactInfoNameLabel.Size = new System.Drawing.Size(35, 13);
            this.ContactInfoNameLabel.TabIndex = 4;
            this.ContactInfoNameLabel.Text = "Name";
            // 
            // ContactInfoAdressLabel
            // 
            this.ContactInfoAdressLabel.AutoSize = true;
            this.ContactInfoAdressLabel.Location = new System.Drawing.Point(11, 50);
            this.ContactInfoAdressLabel.Name = "ContactInfoAdressLabel";
            this.ContactInfoAdressLabel.Size = new System.Drawing.Size(39, 13);
            this.ContactInfoAdressLabel.TabIndex = 5;
            this.ContactInfoAdressLabel.Text = "Adress";
            // 
            // ContactInfoZIPLabel
            // 
            this.ContactInfoZIPLabel.AutoSize = true;
            this.ContactInfoZIPLabel.Location = new System.Drawing.Point(11, 76);
            this.ContactInfoZIPLabel.Name = "ContactInfoZIPLabel";
            this.ContactInfoZIPLabel.Size = new System.Drawing.Size(24, 13);
            this.ContactInfoZIPLabel.TabIndex = 6;
            this.ContactInfoZIPLabel.Text = "ZIP";
            // 
            // ContactInfoCityLabel
            // 
            this.ContactInfoCityLabel.AutoSize = true;
            this.ContactInfoCityLabel.Location = new System.Drawing.Point(11, 102);
            this.ContactInfoCityLabel.Name = "ContactInfoCityLabel";
            this.ContactInfoCityLabel.Size = new System.Drawing.Size(24, 13);
            this.ContactInfoCityLabel.TabIndex = 7;
            this.ContactInfoCityLabel.Text = "City";
            // 
            // ContactInfoMailLabel
            // 
            this.ContactInfoMailLabel.AutoSize = true;
            this.ContactInfoMailLabel.Location = new System.Drawing.Point(11, 154);
            this.ContactInfoMailLabel.Name = "ContactInfoMailLabel";
            this.ContactInfoMailLabel.Size = new System.Drawing.Size(35, 13);
            this.ContactInfoMailLabel.TabIndex = 11;
            this.ContactInfoMailLabel.Text = "E-mail";
            // 
            // ContactInfoPhoneLabel
            // 
            this.ContactInfoPhoneLabel.AutoSize = true;
            this.ContactInfoPhoneLabel.Location = new System.Drawing.Point(11, 128);
            this.ContactInfoPhoneLabel.Name = "ContactInfoPhoneLabel";
            this.ContactInfoPhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.ContactInfoPhoneLabel.TabIndex = 10;
            this.ContactInfoPhoneLabel.Text = "Phone";
            // 
            // ContactInfoMailField
            // 
            this.ContactInfoMailField.Location = new System.Drawing.Point(52, 151);
            this.ContactInfoMailField.Name = "ContactInfoMailField";
            this.ContactInfoMailField.Size = new System.Drawing.Size(189, 20);
            this.ContactInfoMailField.TabIndex = 9;
            this.ContactInfoMailField.TextChanged += new System.EventHandler(this.MailField_TextChanged);
            // 
            // ContactInfoPhoneField
            // 
            this.ContactInfoPhoneField.Location = new System.Drawing.Point(52, 125);
            this.ContactInfoPhoneField.Name = "ContactInfoPhoneField";
            this.ContactInfoPhoneField.Size = new System.Drawing.Size(189, 20);
            this.ContactInfoPhoneField.TabIndex = 8;
            this.ContactInfoPhoneField.TextChanged += new System.EventHandler(this.PhoneField_TextChanged);
            // 
            // ContactList
            // 
            this.ContactList.FormattingEnabled = true;
            this.ContactList.Location = new System.Drawing.Point(5, 19);
            this.ContactList.Name = "ContactList";
            this.ContactList.Size = new System.Drawing.Size(176, 160);
            this.ContactList.TabIndex = 1;
            this.ContactList.SelectedIndexChanged += new System.EventHandler(this.ContactList_SelectedIndexChanged);
            // 
            // ContactInfoCancelButton
            // 
            this.ContactInfoCancelButton.Location = new System.Drawing.Point(150, 182);
            this.ContactInfoCancelButton.Name = "ContactInfoCancelButton";
            this.ContactInfoCancelButton.Size = new System.Drawing.Size(91, 23);
            this.ContactInfoCancelButton.TabIndex = 11;
            this.ContactInfoCancelButton.Text = "Cancel";
            this.ContactInfoCancelButton.UseVisualStyleBackColor = true;
            this.ContactInfoCancelButton.Click += new System.EventHandler(this.CmdCancelButton_Click);
            // 
            // ContactListAddButton
            // 
            this.ContactListAddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ContactListAddButton.Location = new System.Drawing.Point(5, 182);
            this.ContactListAddButton.Name = "ContactListAddButton";
            this.ContactListAddButton.Size = new System.Drawing.Size(83, 23);
            this.ContactListAddButton.TabIndex = 2;
            this.ContactListAddButton.Text = "Add";
            this.ContactListAddButton.UseVisualStyleBackColor = true;
            this.ContactListAddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ContactListRemoveButton
            // 
            this.ContactListRemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ContactListRemoveButton.Location = new System.Drawing.Point(98, 182);
            this.ContactListRemoveButton.Name = "ContactListRemoveButton";
            this.ContactListRemoveButton.Size = new System.Drawing.Size(83, 23);
            this.ContactListRemoveButton.TabIndex = 3;
            this.ContactListRemoveButton.Text = "Remove";
            this.ContactListRemoveButton.UseVisualStyleBackColor = true;
            this.ContactListRemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // contactInfoGroupBox
            // 
            this.contactInfoGroupBox.Controls.Add(this.cmdSaveContact);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoCancelButton);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoNameField);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoAdressField);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoZIPField);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoCityField);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoMailLabel);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoNameLabel);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoPhoneLabel);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoAdressLabel);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoMailField);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoZIPLabel);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoPhoneField);
            this.contactInfoGroupBox.Controls.Add(this.ContactInfoCityLabel);
            this.contactInfoGroupBox.Location = new System.Drawing.Point(212, 35);
            this.contactInfoGroupBox.Name = "contactInfoGroupBox";
            this.contactInfoGroupBox.Size = new System.Drawing.Size(260, 214);
            this.contactInfoGroupBox.TabIndex = 1;
            this.contactInfoGroupBox.TabStop = false;
            this.contactInfoGroupBox.Text = "Contact Info";
            // 
            // cmdSaveContact
            // 
            this.cmdSaveContact.Location = new System.Drawing.Point(53, 182);
            this.cmdSaveContact.Name = "cmdSaveContact";
            this.cmdSaveContact.Size = new System.Drawing.Size(91, 23);
            this.cmdSaveContact.TabIndex = 10;
            this.cmdSaveContact.Text = "Save";
            this.cmdSaveContact.UseVisualStyleBackColor = true;
            this.cmdSaveContact.Click += new System.EventHandler(this.CmdSaveContact_Click);
            // 
            // ContactListGroupBox
            // 
            this.ContactListGroupBox.Controls.Add(this.ContactListRemoveButton);
            this.ContactListGroupBox.Controls.Add(this.ContactList);
            this.ContactListGroupBox.Controls.Add(this.ContactListAddButton);
            this.ContactListGroupBox.Location = new System.Drawing.Point(12, 35);
            this.ContactListGroupBox.Name = "ContactListGroupBox";
            this.ContactListGroupBox.Size = new System.Drawing.Size(194, 214);
            this.ContactListGroupBox.TabIndex = 0;
            this.ContactListGroupBox.TabStop = false;
            this.ContactListGroupBox.Text = "Contact List";
            // 
            // contactListSearchField
            // 
            this.contactListSearchField.Location = new System.Drawing.Point(17, 12);
            this.contactListSearchField.Name = "contactListSearchField";
            this.contactListSearchField.Size = new System.Drawing.Size(366, 20);
            this.contactListSearchField.TabIndex = 0;
            // 
            // cmdSearchContacts
            // 
            this.cmdSearchContacts.Location = new System.Drawing.Point(389, 12);
            this.cmdSearchContacts.Name = "cmdSearchContacts";
            this.cmdSearchContacts.Size = new System.Drawing.Size(83, 20);
            this.cmdSearchContacts.TabIndex = 4;
            this.cmdSearchContacts.Text = "Search";
            this.cmdSearchContacts.UseVisualStyleBackColor = true;
            this.cmdSearchContacts.Click += new System.EventHandler(this.CmdSearchContacts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 257);
            this.Controls.Add(this.cmdSearchContacts);
            this.Controls.Add(this.contactListSearchField);
            this.Controls.Add(this.contactInfoGroupBox);
            this.Controls.Add(this.ContactListGroupBox);
            this.MaximumSize = new System.Drawing.Size(513, 296);
            this.MinimumSize = new System.Drawing.Size(513, 296);
            this.Name = "MainForm";
            this.Text = "Adress Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Close);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contactInfoGroupBox.ResumeLayout(false);
            this.contactInfoGroupBox.PerformLayout();
            this.ContactListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContactInfoNameField;
        private System.Windows.Forms.TextBox ContactInfoAdressField;
        private System.Windows.Forms.TextBox ContactInfoCityField;
        private System.Windows.Forms.TextBox ContactInfoZIPField;
        private System.Windows.Forms.Label ContactInfoNameLabel;
        private System.Windows.Forms.Label ContactInfoAdressLabel;
        private System.Windows.Forms.Label ContactInfoZIPLabel;
        private System.Windows.Forms.Label ContactInfoCityLabel;
        private System.Windows.Forms.Label ContactInfoMailLabel;
        private System.Windows.Forms.Label ContactInfoPhoneLabel;
        private System.Windows.Forms.TextBox ContactInfoMailField;
        private System.Windows.Forms.TextBox ContactInfoPhoneField;
        private System.Windows.Forms.ListBox ContactList;
        private System.Windows.Forms.Button cmdSaveContact;
        private System.Windows.Forms.Button ContactInfoCancelButton;
        private System.Windows.Forms.Button ContactListAddButton;
        private System.Windows.Forms.Button ContactListRemoveButton;
        private System.Windows.Forms.GroupBox contactInfoGroupBox;
        private System.Windows.Forms.GroupBox ContactListGroupBox;
        private System.Windows.Forms.TextBox contactListSearchField;
        private System.Windows.Forms.Button cmdSearchContacts;
    }
}

