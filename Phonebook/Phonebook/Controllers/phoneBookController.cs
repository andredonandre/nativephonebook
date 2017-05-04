using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class phoneBookController
    {
        public phoneBook phonebook;
        
        public phoneBookController() {
            phonebook = new phoneBook();
            getDefaults();            
        }

        //functions to create new objects in store
        public void Create(Contact contact) { 
            phonebook.Contacts.Add(contact);
        }

        public void Create(UserGroup usergroup)
        {
            phonebook.UserGroups.Add(usergroup);
        }

        //Delete functions
        public void Delete(Contact contact)
        {
            var selected = GetObject(contact);
            phonebook.Contacts.Remove(selected);
        }

        public void Delete(UserGroup usergroup)
        {
            var selected = GetObject(usergroup.Name);
            phonebook.UserGroups.Remove(selected);
        }


        //functions to get collections of objects
        public Collection<Contact> GetContacts()
        {            
            return phonebook.Contacts;
        }

        public Collection<UserGroup> GetUserGroups()
        {
            return phonebook.UserGroups;
        }

        //functions to update record/object in store
        public void Update(Contact contact, Contact newcontact) {
            contact.Name = newcontact.Name;
            contact.PhoneNumber = newcontact.PhoneNumber;
            contact.Address = newcontact.Address;
            contact.userGroup = newcontact.userGroup;
        }

        public void Update(UserGroup usergroup, UserGroup newusergroup)
        {
            usergroup.Name = newusergroup.Name;
        }

        //functions to get objects from store
        public Contact GetObject(Contact contact) {
            var value = phonebook.Contacts.Where(x => x.Name == contact.Name && x.PhoneNumber == contact.PhoneNumber).FirstOrDefault();
            return value;
        }

        public UserGroup GetObject(string usergroup)
        {
            var value = phonebook.UserGroups.Where(x => x.Name == usergroup).FirstOrDefault();
            return value;
        }

        public UserGroup GetObject(UserGroup usergroup)
        {
            var value = phonebook.UserGroups.Where(x => x.Id == usergroup.Id).FirstOrDefault();
            return value;
        }

        //Setting default Values for program
        void getDefaults()
        {
            UserGroup group = new UserGroup("All Contacts");
            UserGroup group2 = new UserGroup("work");
            UserGroup group3 = new UserGroup("Pals");
            UserGroup group4 = new UserGroup("Unassigned");
            Contact contact = new Person("Gorkem", "Pacaci", "0872899404","55 Bowman's Avenue", group2);
            Contact contact1 = new Person("Niklas", "Wietreck", "4987509095", "55 Bowman's Avenue", group3);
            Contact contact2 = new Person("Craig", "Smith", "0787509095", "55 Bowman's Avenue", group3);
            Contact contact3 = new Person("Ssali", "Steven", "06495054", "55 Bowman's Avenue", group3);
            Contact contact4 = new Person("Mpho", "Sizwe", "1023076853", "55 Bowman's Avenue", group2);
            Contact contact5 = new Person("Jenny", "Green", "4987509095", "55 Bowman's Avenue", group4);
            Contact contact6 = new Company("KFC Delivery", "037849836", "55 Bowman's Avenue", group4);
            Contact contact7 = new Company("Spotify", "038765846", "55 Bowman's Avenue", group2);
            Contact contact8 = new Company("Debonairs Pizza", "2078489793", "55 Bowman's Avenue", group4);

            Create(group);
            Create(group2);
            Create(group3);
            Create(group4);

            Create(contact);
            Create(contact1);
            Create(contact2);
            Create(contact3);
            Create(contact4);
            Create(contact5);
            Create(contact6);
            Create(contact7);
            Create(contact8);
        }

    }
}
