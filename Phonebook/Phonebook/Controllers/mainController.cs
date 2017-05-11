using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Phonebook.Controllers
{
    public class mainController
    {
        public void loadContacts(DataGridView grid, Collection<Contact> list)
        {
            grid.Rows.Clear();
            foreach (Contact c in list)
            {
                grid.Rows.Add(c.Name, c.PhoneNumber);
            }
        }

        public void filterContacts(string group, Main main)
        {
            var newlist = new Collection<Contact>();
            if (group == "All Contacts")
            {
                main.Contacts = main.Pb.GetContacts();
            }
            else
            {
                main.Contacts = main.Pb.GetContacts();
                foreach (Contact contact in main.Contacts)
                {
                    if (contact.userGroup.Name.ToString() == group)
                        newlist.Add(contact);
                }
                main.Contacts = newlist;
            }
        }
               
    }
}
