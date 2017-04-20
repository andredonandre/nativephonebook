using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Person : Contact 
    {
        private string LastName { get; set; }
        private string FirstName { get; set; }
        public Person(string firstName, string lastName, string phoneNumber, string address, UserGroup group) {
            LastName = lastName;
            FirstName = firstName;
            Name = firstName +" "+ LastName;            
            PhoneNumber = phoneNumber;
            Address = address;
            userGroup = group;
        }
    }
}
