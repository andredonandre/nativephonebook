using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Phonebook.Controllers
{
    class newContactFormController
    {
        public void open(Main main)
        {
            NewContactForm addNew = new NewContactForm(main.Pb, main);
            addNew.ShowDialog();
        }

        public void addcontact(Contact contact, Main main)
        {
            main.Pb.Create(contact);
            main.UpdateForm();
            valueHelpers.successMessage("Contact succesfully added");
        }

    }
}
