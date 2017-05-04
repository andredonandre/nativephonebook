using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class phoneBook
    {
        public Collection<Contact> Contacts { get; set; }
        public Collection<UserGroup> UserGroups { get; set; }
        
        public phoneBook() {
            Contacts = new Collection<Contact>();
            UserGroups = new Collection<UserGroup>();
        } 
    }
}
