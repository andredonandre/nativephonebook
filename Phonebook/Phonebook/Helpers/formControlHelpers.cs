using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Phonebook.Helpers
{
    public class formControlHelpers
    {
        public void loadElement(ComboBox combobox, Collection<UserGroup> List)
        {
            combobox.Items.Clear();
            foreach (UserGroup ug in List)
            {
                combobox.Items.Add(ug.Name);
            }
        }
        
        public void loadElement(ListBox listbox, Collection<UserGroup> List)
        {
            listbox.Items.Clear();
            foreach (UserGroup ug in List)
            {
                listbox.Items.Add(ug.Name);
            }
        }        

        public Collection<Contact> getSelectedContacts(DataGridView grid, phoneBookController Pb, Collection<Contact> contacts)
        {
            var selected = grid.SelectedRows.OfType<DataGridViewRow>();
            foreach (var row in selected)
            {
                var contact = new Contact
                {
                    Name = row.Cells[0].Value.ToString(),
                    PhoneNumber = row.Cells[1].Value.ToString(),
                    userGroup = new UserGroup("")
                };
                var contactdetails = Pb.GetObject(contact);
                contacts.Add(contactdetails);
            }
            return contacts;
        }

        public string select(ComboBox combobox) {
            return combobox.SelectedItem.ToString();
        }

        public string select(DataGridView grid)
        {
            var value = grid.CurrentRow.AccessibilityObject.Value;
            return value;
        }
    }
}
