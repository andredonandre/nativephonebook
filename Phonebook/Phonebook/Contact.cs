using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class Contact
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public UserGroup userGroup { get; set; }

        public Contact() {
            Id = generateID();
        }

        string generateID(){
            return Guid.NewGuid().ToString("N");
        }
    }
}
