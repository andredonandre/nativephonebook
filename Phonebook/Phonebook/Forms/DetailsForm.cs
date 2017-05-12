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

namespace Phonebook
{
    public partial class DetailsForm : Form
    {
        Contact CurrentContact;
        Main CurrentMain;
        formControlHelpers formhelp = new formControlHelpers();

        public DetailsForm(Contact currentcontact, Main main)
        {
            InitializeComponent();
            CurrentContact = currentcontact;
            CurrentMain = main;
            setDefaults();
        }
        //################## FORM EVENT HANDLING ##################
        private void editbutton_Click(object sender, EventArgs e)
        {
            activateFields();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (checkfornulls() == false) { saveChanges(); }            
        }

        //################## FUNCTIONS ##################
        private void SetValues(Contact contact)
        {
            NametextBox.Text = contact.Name;
            PhonetextBox.Text = contact.PhoneNumber;
            addresstextBox.Text = contact.Address;
            UgcomboBox.Text = contact.userGroup.Name;
        }
        private Contact GetValues()
        {
            Contact contact = new Contact
            {
                Name = NametextBox.Text,
                PhoneNumber = PhonetextBox.Text,
                Address= addresstextBox.Text,
                userGroup = new UserGroup(UgcomboBox.Text)
            };
            return contact;
        }

        private void setDefaults() {
            formControlHelpers.loadElement(UgcomboBox, CurrentMain.Usergroups);
            SetValues(CurrentContact);
            DeactivateFields();
        }

        void saveChanges() {
            var contact = CurrentMain.Pb.GetObject(CurrentContact);
            CurrentMain.Pb.Update(contact, GetValues());
            SetValues(GetValues());
            CurrentContact = GetValues();
            DeactivateFields();
            CurrentMain.UpdateForm();
            valueHelpers.successMessage(" Contact Successfully Updated");
        }

        bool checkfornulls() {
            var value = false;
            if (valueHelpers.checknulls(NametextBox,errorProvider1) == true|| valueHelpers.checknulls(PhonetextBox, errorProvider1)|| valueHelpers.checknulls(UgcomboBox, errorProvider1) == true) {
                value = true;
            }
            return value;
        }

        private void DeactivateFields()
        {
            NametextBox.Enabled = false;
            PhonetextBox.Enabled = false;
            addresstextBox.Enabled = false;
            UgcomboBox.Enabled = false;
            savebutton.Visible = false;
            callbutton.Visible = true;
        }
        private void activateFields()
        {
            NametextBox.Enabled = true;
            PhonetextBox.Enabled = true;
            addresstextBox.Enabled = true;
            UgcomboBox.Enabled = true;
            savebutton.Visible = true;
            callbutton.Visible = false;
        }

        private void callbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is unavailable in your region");
        }

        private void PhonetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            valueHelpers.restrictinput(e);
        }
    }
}
