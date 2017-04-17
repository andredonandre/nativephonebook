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
    public partial class AddtoForm : Form
    {
        Main parentForm;
        int selectedNumber = 0;
        Collection<Contact> selectedcontacts;
        UserGroup selectedUsergroup;
        public AddtoForm(Main main, Collection<Contact> selected)
        {
            InitializeComponent();
            parentForm = main;
            selectedcontacts = selected;
            getDefaults();
        }

        //################## FORM EVENT HANDLING ##################
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void savebutton_Click(object sender, EventArgs e)
        {
            save();
        }
        //################## FUNCTIONS ##################
        void getDefaults() {
            parentForm.loadElement(Usercombobox);
            loadInterface();
        }
        void getSelectedUserGroup() {
            var selectedvalue = Usercombobox.SelectedItem.ToString();
            if (selectedvalue != null) {
                var usergroup = parentForm.Pb.GetObject(selectedvalue);
                selectedUsergroup = usergroup;
            }
        }
        void loadInterface()
        {
            selectedNumber = selectedcontacts.Count();
            Valuelabel.Text = "(" + selectedNumber.ToString() + ")";
        }

        void save() {
            getSelectedUserGroup();
            foreach (var contact in selectedcontacts)
            {
                var actual = parentForm.Pb.GetObject(contact);
                var newContact = new Contact { Name = actual.Name, PhoneNumber = actual.PhoneNumber, userGroup = selectedUsergroup };
                parentForm.Pb.Update(actual, newContact);
            }
        }

    }
}
