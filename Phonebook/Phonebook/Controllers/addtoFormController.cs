using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Phonebook.Controllers
{
    public class addToFormController
    {
        public void open(Main main, Collection<Contact> selectedContacts)
        {
            AddtoForm addform = new AddtoForm(main, selectedContacts);
            addform.ShowDialog();
        }
    }
}
