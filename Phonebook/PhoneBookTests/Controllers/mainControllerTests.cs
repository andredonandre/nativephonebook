using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phonebook.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Phonebook.Controllers.Tests
{
    [TestClass()]
    public class mainControllerTests
    {
        mainController ctrl = new mainController();
        Main Form;

            public mainControllerTests() {
            Form = new Main(ctrl);
        }

        [TestMethod()]
        public void loadContactsFunction_DataGrid_RowsGenerated()
        {
            //Arrange
            DataGridView grid = new DataGridView();
            grid.Columns.Add("col1", "Name");
            grid.Columns.Add("col2", "PhoneNumber");
            //Act
            ctrl.loadContacts(grid, Form.Contacts);
            var result = grid.Rows.Count;
            //Assert
            Assert.AreNotEqual(0,result);
        }

        [TestMethod()]
        public void loadContactsFunction_DataGrid_RowsHaveContacts()
        {
            //Arrange
            DataGridView grid = new DataGridView();
            grid.Columns.Add("col1", "Name");
            grid.Columns.Add("col2", "PhoneNumber");
            //Act
            ctrl.loadContacts(grid, Form.Contacts);
            var Namecell = grid[0,0];
            var PhoneCell = grid[1, 0];
            var result1 = Namecell.Value.ToString();
            var result2 = PhoneCell.Value.ToString();
            //Assert
            Assert.AreNotEqual("", result1);
            Assert.AreNotEqual("", result2);
        }

        [TestMethod()]
        public void loadContactsFunction_DataGrid_EmptyGridIfnoContacts()
        {
            //Arrange
            DataGridView grid = new DataGridView();
            grid.Columns.Add("col1", "Name");
            grid.Columns.Add("col2", "PhoneNumber");
            //Act
            ctrl.loadContacts(grid, new Collection<Contact>());
            var result = grid[0, 0].Value;
            //Assert
            Assert.AreEqual(null, result);
        }

        [TestMethod()]
        public void selectItemFunction_datagrid_SelectsCurrentItem()
        {
            //Arrange
            DataGridView grid = new DataGridView();
            grid.Columns.Add("col1", "Name");
            grid.Columns.Add("col2", "PhoneNumber");            
            ctrl.loadContacts(grid, Form.Contacts);
            grid.CurrentCell = grid[0, 1];
            //Act
            var result = ctrl.selectItem(grid);
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void getSelectedObjectFunction_NameAndPhoneMatch()
        {
            //Arrange
            DataGridView grid = new DataGridView();
            grid.Columns.Add("col1", "Name");
            grid.Columns.Add("col2", "PhoneNumber");
            ctrl.loadContacts(grid, Form.Contacts);
            grid.CurrentCell = grid[0, 1];
            var Namecell = grid[0, 1].Value.ToString();
            var PhoneCell = grid[1, 1].Value.ToString();
            //Act
            var result = ctrl.getSelectedObject(grid);
            //Assert
            Assert.AreEqual(result.Name,Namecell);
            Assert.AreEqual(result.PhoneNumber, PhoneCell);
        }

        [TestMethod()]
        public void ExtractContactDetailsFunctionTest()
        {
            //Arrange
            string details = "Andrew Rick;0893998493";
            //Act
            var result = ctrl.ExtractContactDetails(details);
            //Assert
            Assert.AreEqual("Andrew Rick", result.Name);
            Assert.AreEqual("0893998493", result.PhoneNumber);
        }

        [TestMethod()]
        public void filterContactsFunction_AllContactsGroup_ReturnsAllContacts()
        {
            //Arrange
            var allContacts = Form.Contacts;
            //Act
            ctrl.filterContacts("All Contacts", Form);
            var result = Form.Contacts;
            //Assert
            Assert.AreEqual(allContacts, result);
        }

        [TestMethod()]
        public void filterContactsFunction_SpecificGroup_DoesnotReturnAllContacts()
        {
            //Arrange
            var allContacts = Form.Contacts;
            //Act
            ctrl.filterContacts("work", Form);
            var result = Form.Contacts;
            //Assert
            Assert.AreNotEqual(allContacts, result);
        }

        [TestMethod()]
        public void filterContactsFunction_SpecificGroup_OnlyContactsBelongingTogroup()
        {
            //Arrange
            var allContacts = Form.Contacts;
            //Act
            ctrl.filterContacts("work", Form);
            foreach (var c in Form.Contacts) {
                //Assert
                Assert.AreEqual("work", c.userGroup.Name);
            };
        }

        [TestMethod()]
        public void filterContactsFunction_NoContactsForGroup()
        {
            //Act
            ctrl.filterContacts("Kompis", Form);
            var result = Form.Contacts.Count;
            //Assert
            Assert.AreEqual(0,result);            
        }

        [TestMethod()]
        public void clearSelectedContacts_ListIsCleared()
        {
            //Arrange
            Form.selectedContacts.Add(new Contact { Name = "Eliud Kipchoge", PhoneNumber = "07267398400", Address = "45 Taita Hills" });
            Form.selectedContacts.Add(new Contact { Name = "Chris Keino", PhoneNumber = "0758908400", Address = "42 Taita Hills" });
            var oldCount = Form.selectedContacts.Count();
            //Act
            ctrl.clearSelectedContacts(Form);
            var result = Form.selectedContacts.Count();
            //Assert
            Assert.AreNotEqual(oldCount, result);
            Assert.AreEqual(0,result);
        }

        [TestMethod()]
        public void clearSelectedContacts_EmptyListStaysEmpty()
        {
            //Arrange
            var oldCount = Form.selectedContacts.Count();
            //Act
            ctrl.clearSelectedContacts(Form);
            var result = Form.selectedContacts.Count();
            //Assert
            Assert.AreEqual(oldCount, result);
            Assert.AreEqual(0, result);
        }
    }
}