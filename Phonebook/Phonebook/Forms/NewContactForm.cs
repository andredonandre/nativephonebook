using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phonebook.Helpers;
using Phonebook.Controllers;

namespace Phonebook
{
    public partial class NewContactForm : Form
    {

        private Main MainForm;
        #region Controllers

        private phoneBookController Pbook;
        private newContactFormController NewCtrl = new newContactFormController();

        #endregion

        public NewContactForm(phoneBookController pbook, Main main)
        {
            InitializeComponent();
            Pbook = pbook;
            MainForm = main;
            setdefaults();
        }
        //################## Event Handler ##################
        #region Event Handlers

        private void AddPbutton_Click(object sender, EventArgs e)
        {
            addPerson();
        }

        private void addCompanyButton_Click(object sender, EventArgs e)
        {
            addCompany();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CompanyPhonetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            valueHelpers.restrictinput(e);
        }

        private void PhonetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            valueHelpers.restrictinput(e);
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            switch (addContactTabControl.SelectedIndex)
            {
                case 0:
                    addPerson();
                    break;
                case 1:
                    addCompany();
                    break;
            }
        }
        #endregion
        
        //################## Functions ##################
        #region functions

        void setdefaults() {
            loadComboboxes();
            ugcomboBox1.SelectedItem = "Unassigned";
            ugcomboBox2.SelectedItem = "Unassigned";
        }

        private void clearFields() {
            formControlHelpers.clearElement(FirstNtextBox);
            formControlHelpers.clearElement(LastNtextBox);
            formControlHelpers.clearElement(PhonetextBox);
            formControlHelpers.clearElement(personaddresstextBox);
            formControlHelpers.clearElement(companyaddresstextBox);
            formControlHelpers.clearElement(CompanyNtextBox);
            formControlHelpers.clearElement(CompanyPhonetextBox);

            formControlHelpers.clearSelection(ugcomboBox1);
            formControlHelpers.clearSelection(ugcomboBox2);
        }

        private void loadComboboxes() {
            formControlHelpers.loadElement(ugcomboBox1, MainForm.Usergroups);
            formControlHelpers.loadElement(ugcomboBox2, MainForm.Usergroups);
        }
        
        void addcontact(Contact contact) {
            NewCtrl.addcontact(contact, MainForm);
            clearFields();
        }

        void addPerson() {
            if (checkpersonnulls() == false) {
                var contact = setpersonvalues();
                addcontact(contact);
            }
        }

        void addCompany()
        {
            if (checkcompanynulls()== false) {
                var contact = setcompanyvalues();
                addcontact(contact);
            }
        }
        
        bool checkpersonnulls()
        {
            bool value = false;
            if(valueHelpers.checknulls(FirstNtextBox, errorProvider)== true || valueHelpers.checknulls(LastNtextBox, errorProvider) == true || valueHelpers.checknulls(PhonetextBox, errorProvider) == true|| valueHelpers.checknulls(ugcomboBox1, errorProvider) == true)
            {
                value = true;
            }
            return value;
        }

        bool checkcompanynulls()
        {
            bool value = false;
            if (valueHelpers.checknulls(CompanyNtextBox, errorProvider) == true || valueHelpers.checknulls(CompanyPhonetextBox, errorProvider) == true || valueHelpers.checknulls(ugcomboBox2, errorProvider) == true)
            {
                value = true;
            }
            return value;
        }

        Contact setcompanyvalues()
        {
            var group = Pbook.GetObject(ugcomboBox2.SelectedItem.ToString());
            var contact = new Company(CompanyNtextBox.Text,CompanyPhonetextBox.Text,companyaddresstextBox.Text, group);
            return contact;
        }

        Contact setpersonvalues()
        {
            var group = Pbook.GetObject(ugcomboBox1.SelectedItem.ToString());
            var contact = new Person(FirstNtextBox.Text, LastNtextBox.Text, PhonetextBox.Text, personaddresstextBox.Text, group);
            return contact;
        }

        #endregion 
    }
}
