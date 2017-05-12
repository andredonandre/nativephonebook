using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Controllers
{
    public class detailsFormController
    {
        public void open(Main main, Contact selected)
        {
            DetailsForm details = new DetailsForm(main.Pb.GetObject(selected), main);
            details.ShowDialog();
        }
    }
}
