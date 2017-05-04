using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class NewContactForm : Form
    {
        private phoneBookController Pbook;
        private Main MainForm;
        private helpers help = new helpers();
        public NewContactForm(phoneBookController pbook, Main main)
        {
            InitializeComponent();
            Pbook = pbook;
            MainForm = main;
            setdefaults();
        }
        //################## FORM EVENT HANDLING ##################
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
            help.restrictinput(e);
        }

        private void PhonetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            help.restrictinput(e);
        }

        //################## FUNCTIONS ##################
        
        void setdefaults() {
            loadComboboxes();
            ugcomboBox1.SelectedItem = "Unassigned";
            ugcomboBox2.SelectedItem = "Unassigned";
        }

        private void clearFields() {
            FirstNtextBox.Clear();
            LastNtextBox.Clear();
            PhonetextBox.Clear();
            personaddresstextBox.Clear();
            companyaddresstextBox.Clear();
            CompanyNtextBox.Clear();
            CompanyPhonetextBox.Clear();
            ugcomboBox1.SelectedItem = null;
            ugcomboBox2.SelectedItem = null;
        }

        private void loadComboboxes() {
            MainForm.loadElement(ugcomboBox1);
            MainForm.loadElement(ugcomboBox2);
        }
        
        void addcontact(Contact contact) {
            Pbook.Create(contact);
            MainForm.UpdateForm();
            help.successMessage("Contact succesfully added");
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
            if(help.checknulls(FirstNtextBox, errorProvider)== true || help.checknulls(LastNtextBox, errorProvider) == true || help.checknulls(PhonetextBox, errorProvider) == true|| help.checknulls(ugcomboBox1, errorProvider) == true)
            {
                value = true;
            }
            return value;
        }
        bool checkcompanynulls()
        {
            bool value = false;
            if (help.checknulls(CompanyNtextBox, errorProvider) == true || help.checknulls(CompanyPhonetextBox, errorProvider) == true || help.checknulls(ugcomboBox2, errorProvider) == true)
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

        private void addbutton_Click(object sender, EventArgs e)
        {
            switch (addContactTabControl.SelectedIndex) {
                case 0:
                    addPerson();
                    break;
                case 1:
                    addCompany();
                    break;
            } 
        }
        
    }
}
