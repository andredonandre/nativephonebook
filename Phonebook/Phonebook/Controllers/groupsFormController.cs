using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook.Controllers
{
    class groupsFormController
    {
        public void open(Main main)
        {
            groupsForm groups = new groupsForm(main);
            groups.ShowDialog();
        }
    }
}
