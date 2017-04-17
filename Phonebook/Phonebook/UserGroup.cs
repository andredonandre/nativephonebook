using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class UserGroup 
    {
        public string Name { get; set; }
        public Guid Id { get; set; }

        public UserGroup(string name) {
            Name = name;
        }
    }
}
