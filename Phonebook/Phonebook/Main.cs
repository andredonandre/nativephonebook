using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Main : Form
    {
        Collection<Contact> Contacts;
        Collection<Contact> selectedContacts = new Collection<Contact>();
        Collection<UserGroup> Usergroups;
        private helpers help = new helpers();
        public phoneBook Pb = new phoneBook();

        public Main()
        {
            InitializeComponent();
            setDefaults();
        }
        //################## FORM EVENT HANDLING ##################
        private void addbutton_Click(object sender, EventArgs e)
        {
            add();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (help.checknulls(contactGrid, errorProvider1) == false) { edit(); }
        }

        private void contactGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (help.checknulls(contactGrid, errorProvider1) == false) { edit(); }            
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (help.checknulls(contactGrid, errorProvider1) == false) { delete(); };
        }

        private void contactGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select(contactGrid);
        }

        private void UsergroupcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateGrid();
        }
        private void addtolink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addTo();
        }

        private void groupsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            managegroups();
        }
        
        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //################## FUNCTIONS ##################
        void setDefaults() {
            Contacts = Pb.GetContacts();
            Usergroups = Pb.GetUserGroups();
            loadContacts();
            loadElement(UsergroupcomboBox);
            UsergroupcomboBox.SelectedIndex = 0;
        }

        //Helpers to load objects in elements
        public void loadElement(ComboBox combobox)
        {
            combobox.Items.Clear();
            foreach (UserGroup ug in Usergroups){
                combobox.Items.Add(ug.Name);
            }
        }

        public void loadElement(ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (UserGroup ug in Usergroups)
            {
                listbox.Items.Add(ug.Name);
            }
        }

        public void UpdateForm() {
            loadContacts();
            loadElement(UsergroupcomboBox);
        }

        void updateGrid() {
            var group = UsergroupcomboBox.SelectedItem.ToString();
            filterContacts(group);
            loadContacts();
        }

        private string select(DataGridView grid) {
            var value = grid.CurrentRow.AccessibilityObject.Value;
            activateButtons();
            return value;
        }

        void add() {
            New addNew = new New(Pb, this);
            addNew.ShowDialog();
        }

        private void edit() {

            var value = select(contactGrid);
            Contact contact;
            DetailsForm details;
            if (value != null)
            {
                var content = value.Split(';');
                contact = new Contact { PhoneNumber = content[1], Name =content[0], userGroup =new UserGroup("") };
                details = new DetailsForm(Pb.GetObject(contact), this);
                details.ShowDialog();
            }
        }

        private void delete() {
            var value = select(contactGrid);
            Contact contact;
            if (value != null)
            {
                var content = value.Split(';');
                contact = new Company(content[1], content[0]," ", new UserGroup(""));
                Pb.Delete(contact);
                UpdateForm();
                help.successMessage("contact succesfully deleted");
            }
        }

        void addTo() {
            clearSelectedContacts();
            getSelectedContacts();
            AddtoForm addform = new AddtoForm(this, selectedContacts);
            addform.ShowDialog();
        }

        void managegroups(){
            groupsForm groups = new groupsForm(this);
            groups.ShowDialog();
        }
        //Loading Data grid View with Values
        private void loadContacts()
        {
            contactGrid.Rows.Clear();
            foreach (Contact c in Contacts)
            {
                contactGrid.Rows.Add(c.Name, c.PhoneNumber);
            }
        }
        
        private void activateButtons()
        {
            addtolink.Enabled = true;
        }
        
        private void filterContacts(string group)
        {
            var newlist = new Collection<Contact>();
            if (group == "All Contacts")
            {
                Contacts = Pb.GetContacts();
            }
            else
            {
                Contacts = Pb.GetContacts();
                foreach (Contact contact in Contacts)
                {
                    if (contact.userGroup.Name.ToString() == group)
                        newlist.Add(contact);
                }
                Contacts = newlist;
            }
        }

        private Collection<Contact> getSelectedContacts() {
            var selected = contactGrid.SelectedRows.OfType<DataGridViewRow>();
            foreach (var row in selected) {
                var contact = new Contact
                {
                    Name = row.Cells[0].Value.ToString(),
                    PhoneNumber = row.Cells[1].Value.ToString(),
                    userGroup = new UserGroup("")
                };
                var contactdetails = Pb.GetObject(contact);
                selectedContacts.Add(contactdetails);
            }
            return selectedContacts;
        }

        public void clearSelectedContacts() {
            selectedContacts.Clear();
        }
    }
}
