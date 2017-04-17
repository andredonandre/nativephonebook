﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class phoneBook
    {
        private Collection<Contact> Contacts;
        private Collection<UserGroup> UserGroups;
        
        public phoneBook() {
            Contacts = new Collection<Contact>();
            UserGroups = new Collection<UserGroup>();
            getDefaults();
        }

        //functions to create new objects in store
        public void Create(Contact contact) { 
            Contacts.Add(contact);
        }

        public void Create(UserGroup usergroup)
        {
            UserGroups.Add(usergroup);
        }

        //Delete functions
        public void Delete(Contact contact)
        {
            var selected = GetObject(contact);
            Contacts.Remove(selected);
        }

        public void Delete(UserGroup usergroup)
        {
            var selected = GetObject(usergroup.Name);
            UserGroups.Remove(selected);
        }


        //functions to get collections of objects
        public Collection<Contact> GetContacts()
        {            
            return Contacts;
        }

        public Collection<UserGroup> GetUserGroups()
        {
            return UserGroups;
        }

        //functions to update record/object in store
        public void Update(Contact contact, Contact newcontact) {
            contact.Name = newcontact.Name;
            contact.PhoneNumber = newcontact.PhoneNumber;
            contact.userGroup = newcontact.userGroup;
        }

        public void Update(UserGroup usergroup, UserGroup newusergroup)
        {
            usergroup.Name = newusergroup.Name;
        }

        //functions to get objects from store
        public Contact GetObject(Contact contact) {
            var value = Contacts.Where(x => x.Name == contact.Name && x.PhoneNumber == contact.PhoneNumber).FirstOrDefault();
            return value;
        }

        public UserGroup GetObject(string usergroup)
        {
            var value = UserGroups.Where(x => x.Name == usergroup).FirstOrDefault();
            return value;
        }

        public UserGroup GetObject(UserGroup usergroup)
        {
            var value = UserGroups.Where(x => x.Id == usergroup.Id).FirstOrDefault();
            return value;
        }

        //Setting default Values for program
        void getDefaults()
        {
            UserGroup group = new UserGroup("All Contacts");
            UserGroup group2 = new UserGroup("work");
            UserGroup group3 = new UserGroup("Pals");
            UserGroup group4 = new UserGroup("Unassigned");
            Contact contact = new Person("Gorkem", "Pacaci", "0872899404", group2);
            Contact contact1 = new Person("Niklas", "Wietreck", "4987509095", group3);
            Contact contact2 = new Person("Craig", "Smith", "0787509095", group3);
            Contact contact3 = new Person("Ssali", "Steven", "06495054", group3);
            Contact contact4 = new Person("Mpho", "Sizwe", "1023076853", group2);
            Contact contact5 = new Person("Jenny", "Green", "4987509095", group4);
            Contact contact6 = new Company("KFC Delivery", "037849836", group4);
            Contact contact7 = new Company("Spotify", "038765846", group2);
            Contact contact8 = new Company("Debonairs Pizza", "2078489793", group4);

            UserGroups.Add(group);
            UserGroups.Add(group2);
            UserGroups.Add(group3);
            UserGroups.Add(group4);

            Contacts.Add(contact);
            Contacts.Add(contact1);
            Contacts.Add(contact2);
            Contacts.Add(contact3);
            Contacts.Add(contact4);
            Contacts.Add(contact5);
            Contacts.Add(contact6);
            Contacts.Add(contact7);
            Contacts.Add(contact8);
        }

    }
}
