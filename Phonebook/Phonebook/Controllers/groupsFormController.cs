using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phonebook.Helpers;

namespace Phonebook.Controllers
{
    class groupsFormController
    {
        public void open(Main main)
        {
            groupsForm groups = new groupsForm(main);
            groups.ShowDialog();
        }

        private void saveChanges(string value, UserGroup selected, Main main)
        {
            var newgroup = new UserGroup(value);
            main.Pb.Update(selected, newgroup);
        }
    }
}
