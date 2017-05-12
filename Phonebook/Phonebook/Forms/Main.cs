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
using Phonebook.Controllers;
using Phonebook.Helpers;

namespace Phonebook
{
    public partial class Main : Form
    {
        public Collection<Contact> Contacts;
        public Collection<UserGroup> Usergroups;
        Collection<Contact> selectedContacts = new Collection<Contact>();

        #region controllers and helpers
        private helpers help = new helpers();
        private formControlHelpers formhelp = new formControlHelpers();
        private groupsFormController groupsCtrl = new groupsFormController();
        private addToFormController addtoCtrl = new addToFormController();
        private newContactFormController newFormCtrl = new newContactFormController();
        private detailsFormController detailsCtrl = new detailsFormController();
        public phoneBookController Pb = new phoneBookController();
        mainController mainCtrl;
        #endregion
        
        public Main(mainController _controller)
        {
            mainCtrl = _controller;
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
            mainCtrl.selectItem(contactGrid);
        }

        private void UsergroupcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateGrid();
        }
        private void addtolink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (selectedContacts != null) { addTo(); }            
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
            formhelp.loadElement(UsergroupcomboBox, Usergroups);
            UsergroupcomboBox.SelectedIndex = 0;
        }
        
        public void UpdateForm() {
            loadContacts();
            formhelp.loadElement(UsergroupcomboBox, Usergroups);
        }

        void updateGrid() {
            var group = formhelp.select(UsergroupcomboBox);
            filterContacts(group);
            loadContacts();
        }
        
        void add() {
            newFormCtrl.open(this);
        }

        private void edit() {
            var contact = mainCtrl.getSelectedObject(contactGrid);
            detailsCtrl.open(this, contact);
        }

        private void delete() {
            var contact = mainCtrl.getSelectedObject(contactGrid);
            Pb.Delete(contact);
            UpdateForm();
            help.successMessage("contact succesfully deleted");
        }

        void addTo() {
            clearSelectedContacts();
            getSelectedContacts();
            addtoCtrl.open(this, selectedContacts);
        }

        void managegroups(){
            groupsCtrl.open(this);
        }

        //Loading Data grid View with Values        
        private void loadContacts()
        {
            mainCtrl.loadContacts(contactGrid, Contacts);
        }
        
        private void activateButtons()
        {
            addtolink.Enabled = true;
        }
        
        private void filterContacts(string group)
        {
            mainCtrl.filterContacts(group,this);
        }

        private Collection<Contact> getSelectedContacts() {
            return formhelp.getSelectedContacts(contactGrid, Pb,selectedContacts);
        }

        public void clearSelectedContacts() {
            selectedContacts.Clear();
        }        
    }
}
