using System;
using System.Windows.Forms;
using System.Linq;

namespace AdressBook
{
    public partial class MainForm : Form
    {
        public string name = "";
        public string adress = "";
        public string zipCode = "";
        public string city = "";
        public string phone = "";
        public string mail = "";
        User user = new User();

        public MainForm()
        {
            InitializeComponent();
        }

        #region Contact Info controls
        private void CmdSaveContact_Click(object sender, EventArgs e)
        {
            user.UpdateUser(name, adress, zipCode, city, phone, mail);
            DataManager.SaveAllUsers();
            // todo update the name in ContactList
            ContactList.Text = "name";
            
        }
        private void CmdCancelButton_Click(object sender, EventArgs e)
        {
            LoadUserInfo(user);
        }
        private void ZIPField_TextChanged(object sender, EventArgs e)
        {
            zipCode = ContactInfoZIPField.Text;

        }
        private void NameField_TextChanged(object sender, EventArgs e)
        {
            name = ContactInfoNameField.Text;
        }
        private void AdressField_TextChanged(object sender, EventArgs e)
        {
            adress = ContactInfoAdressField.Text;
        }
        private void CityField_TextChanged(object sender, EventArgs e)
        {
            city = ContactInfoCityField.Text;
        }
        private void PhoneField_TextChanged(object sender, EventArgs e)
        {
            phone = ContactInfoPhoneField.Text;
        }
        private void MailField_TextChanged(object sender, EventArgs e)
        {
            mail = ContactInfoMailField.Text;
        }
        #endregion

        #region FileManager
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowAllUsers();
        }

        private void ShowAllUsers()
        {
            if(DataManager.userList.Count <= 0)
            {
                DataManager.userList = DataManager.SetupUsers();
            }
            foreach(User user in DataManager.userList)
            {
                try
                {
                    ContactList.Items.Add(user.name);
                }
                catch(ArgumentNullException)
                {
                    MessageBox.Show("User.name is null");
                    throw;
                }
            }
        }

        private void LoadUserInfo(User user)
        {
            ContactInfoNameField.Text = name = user.name;
            ContactInfoAdressField.Text = adress = user.adress;
            ContactInfoZIPField.Text = zipCode = user.zip;
            ContactInfoCityField.Text = city = user.city;
            ContactInfoPhoneField.Text = phone = user.phone;
            ContactInfoMailField.Text = mail = user.email;
        }
        private void MainForm_Close(object sender, FormClosedEventArgs e)
        {
            DataManager.SaveAllUsers();
        }
        #endregion

        #region Manage ContactList
        private void AddButton_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            DataManager.userList.Add(newUser);
            ContactList.Items.Add(newUser);
            ContactList.SetSelected(ContactList.Items.Count - 1, true);
            ContactList.Text = newUser.name;
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ContactList.Items.RemoveAt(ContactList.SelectedIndex);
            DataManager.userList.Remove(user);
            ContactInfoNameField.Text = name = "";
            ContactInfoZIPField.Text = zipCode = "";
            ContactInfoPhoneField.Text = phone = "";
            ContactInfoMailField.Text = mail = "";
            ContactInfoAdressField.Text = adress = "";
            ContactInfoCityField.Text = city = "";
            DataManager.SaveAllUsers();
        }
        #endregion

        private void CmdSearchContacts_Click(object sender, EventArgs e)
        {
            ContactList.Items.Clear();

            var searchFilter = contactListSearchField.Text.ToLower();
            if(searchFilter != "")
            {
                var usersNameFilter = from User name in DataManager.userList where name.name.Contains(searchFilter) select name;
                var usersCityFilter = from User city in DataManager.userList where city.city.Contains(searchFilter) select city;
                var filteredUsers = usersNameFilter.Concat(usersCityFilter);
                foreach(User user in filteredUsers)
                {
                    ContactList.Items.Add(user.name);
                }
            }
            else
            {
                ShowAllUsers();
            }

        }
        private void ContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(ContactList.SelectedIndex >= 0)
                {
                    user = DataManager.userList[ContactList.SelectedIndex];
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Could not select user, due to being out of range");
            }
            LoadUserInfo(user);
        }
    }
}
