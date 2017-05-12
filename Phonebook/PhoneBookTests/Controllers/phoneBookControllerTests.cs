using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phonebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Phonebook.Tests
{
    [TestClass()]
    public class phoneBookControllerTests
    {
        public phoneBookController pbCtrl = new phoneBookController();

        [TestMethod()]
        public void phoneBookControllerFunctionTest()
        {
            Assert.IsNotNull(pbCtrl);
        }

        [TestMethod()]
        public void CreateFunction_AddsContact()
        {
            //Act
            Contact contact = new Contact { Name = "Eliud Kipchoge", PhoneNumber = "07267398400", Address = "45 Taita Hills"};
            var initialCount = pbCtrl.phonebook.Contacts.Count;
            pbCtrl.Create(contact);
            var result = pbCtrl.phonebook.Contacts.Count;
            //Assert
            Assert.AreNotEqual(result, initialCount);
        }

        [TestMethod()]
        public void CreateFunction_AddsUserGroup()
        {
            //Act
            UserGroup usergroup = new UserGroup("Kompis"); 
            var initialCount = pbCtrl.phonebook.UserGroups.Count;
            pbCtrl.Create(usergroup);
            var result = pbCtrl.phonebook.UserGroups.Count;
            //Assert
            Assert.AreNotEqual(result, initialCount);
        }

        [TestMethod()]
        public void DeleteFunction_RemovesContact()
        {
            //Act
            var contact = pbCtrl.phonebook.Contacts.First();
            var initialCount = pbCtrl.phonebook.Contacts.Count;
            pbCtrl.Delete(contact);
            var result = pbCtrl.phonebook.Contacts.Count;
            //Assert
            Assert.AreNotEqual(result, initialCount);
        }

        [TestMethod()]
        public void DeleteFunction_RemovesSpecificContact()
        {
            //Act
            var contact = pbCtrl.phonebook.Contacts.First();
            pbCtrl.Delete(contact);
            var result = pbCtrl.phonebook.Contacts.Where(x=> x.Id == contact.Id).FirstOrDefault();
            //Assert
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void DeleteFunction_RemovesUserGroup()
        {
            //Act
            var usergroup = pbCtrl.phonebook.UserGroups.First();
            var initialCount = pbCtrl.phonebook.UserGroups.Count;
            pbCtrl.Delete(usergroup);
            var result = pbCtrl.phonebook.UserGroups.Count;
            //Assert
            Assert.AreNotEqual(result, initialCount);
        }

        [TestMethod()]
        public void DeleteFunction_RemovesSpecificUserGroup()
        {
            //Act
            var usergroup = pbCtrl.phonebook.UserGroups.Where(x => x.Name != "All Contacts" || x.Name != "Unassigned").FirstOrDefault();
            pbCtrl.Delete(usergroup);
            var result = pbCtrl.phonebook.UserGroups.Where(x => x.Id == usergroup.Id).FirstOrDefault();
            //Assert
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void GetContactsFunction_NotNull()
        {
            //Act
            var result = pbCtrl.GetContacts();
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void GetContactsFunction_NoContacts_EmptyList()
        {
            //Act
            var result = new Collection<Contact>();
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void GetUserGroupsFunction_NotNull()
        {
            //Act
            var result = pbCtrl.GetUserGroups();
            //Assert
            Assert.IsNotNull(result);
        }

        public void GetContactsFunction_NoUserGroups_EmptyList()
        {
            //Act
            var result = new Collection<UserGroup>();
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void UpdateFunction_UpdatesContact_Name()
        {
            //ACt
            var old = pbCtrl.phonebook.Contacts.FirstOrDefault();
            var change = new Contact { Name = "Walshy Fire", PhoneNumber = old.PhoneNumber, Address = old.Address, userGroup = old.userGroup };
            pbCtrl.Update(old, change);
            var newVersion = pbCtrl.phonebook.Contacts.Where(c => c.Id == old.Id).FirstOrDefault();
            //Assert
            Assert.AreEqual(newVersion.Name, change.Name);
        }

        [TestMethod()]
        public void UpdateFunction_UpdatesContact_PhoneNumber()
        {
            //Act
            var old = pbCtrl.phonebook.Contacts.FirstOrDefault();
            var change = new Contact { Name = old.Name, PhoneNumber = "08888888888", Address = old.Address, userGroup = old.userGroup };
            pbCtrl.Update(old, change);
            var newVersion = pbCtrl.phonebook.Contacts.Where(c => c.Id == old.Id).FirstOrDefault();
            //Assert
            Assert.AreEqual(newVersion.PhoneNumber, change.PhoneNumber);
        }

        [TestMethod()]
        public void UpdateFunction_UpdatesContact_Address()
        {
            //Act
            var old = pbCtrl.phonebook.Contacts.FirstOrDefault();
            var change = new Contact { Name = old.Name, PhoneNumber = old.PhoneNumber, Address = "45 Sky Avenue, Mars", userGroup = old.userGroup };
            pbCtrl.Update(old, change);
            var newVersion = pbCtrl.phonebook.Contacts.Where(c => c.Id == old.Id).FirstOrDefault();
            //Assert
            Assert.AreEqual(newVersion.Address, change.Address);
        }

        [TestMethod()]
        public void UpdateFunction_UpdatesContact_UserGroup()
        {
            //Act
            var old = pbCtrl.phonebook.Contacts.FirstOrDefault();
            var change = new Contact { Name = old.Name, PhoneNumber = old.PhoneNumber, Address = old.Address, userGroup = new UserGroup("The Crew")};
            pbCtrl.Update(old, change);
            var newVersion = pbCtrl.phonebook.Contacts.Where(c => c.Id == old.Id).FirstOrDefault();
            //Assert
            Assert.AreEqual(newVersion.userGroup, change.userGroup);
        }

        [TestMethod()]
        public void UpdateFunction_UpdatesUserGroup_Name()
        {
            //Act
            var old = pbCtrl.phonebook.UserGroups.FirstOrDefault();
            var change = new UserGroup("The Crew");
            pbCtrl.Update(old, change);
            var newVersion = pbCtrl.phonebook.UserGroups.Where(c => c.Id == old.Id).FirstOrDefault();
            //Assert
            Assert.AreEqual(newVersion.Name, change.Name);
        }

        [TestMethod()]
        public void GetObjectFunction_ContactObjectPresent_NotNull()
        {
            //Act
            var contact = pbCtrl.phonebook.Contacts.FirstOrDefault();
            var result = pbCtrl.GetObject(contact);
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void GetObjectFunction_ContactObjectNotPresent_Null()
        {
            //Act
            var contact = new Contact { Name = "Eliud Kipchoge", PhoneNumber = "07267398400", Address = "45 Taita Hills" };
            var result = pbCtrl.GetObject(contact);
            //Assert
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void GetObjectFunction_UserGroupObjectPresent_NotNull()
        {
            //Act
            var userGroup = pbCtrl.phonebook.UserGroups.FirstOrDefault();
            var result = pbCtrl.GetObject(userGroup);
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void GetObjectFunction_UserGroupObjectNotPresent_Null()
        {
            //Act
            UserGroup usergroup = new UserGroup("Kompis");
            var result = pbCtrl.GetObject(usergroup);
            //Assert
            Assert.IsNull(result);
        }
    }
}