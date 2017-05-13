using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phonebook.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Phonebook.Helpers.Tests
{
    [TestClass()]
    public class formControlHelpersTests
    {
        phoneBookController phoneBook = new phoneBookController();

        #region loadElementFunction
        [TestMethod()]
        public void loadElementFunction_comboBox_valuesPresent()
        {
            // arrange
            ComboBox comboBox = new ComboBox();
            // act
            formControlHelpers.loadElement(comboBox, phoneBook.GetUserGroups());
            var result = comboBox.Items.Count;
            // assert
            Assert.AreNotEqual(0, result);
        }

        [TestMethod()]
        public void loadElementFunction_listBox_valuesPresent()
        {
            // arrange
            ListBox listBox = new ListBox();
            // act
            formControlHelpers.loadElement(listBox, phoneBook.GetUserGroups());
            var result = listBox.Items.Count;
            // assert
            Assert.AreNotEqual(0, result);
        }
        #endregion

        #region clearElements & clearSelection functions
        [TestMethod()]
        public void clearElementFunction_textBox_textCleared()
        {
            // arrange
            TextBox textBox = new TextBox();
            textBox.Text = "test text";
            // act
            formControlHelpers.clearElement(textBox);
            var result = textBox.Text;
            // assert
            Assert.AreEqual("", result);
        }

        [TestMethod()]
        public void clearSelectionFunction_comboBox_nothingSelected()
        {
            // arrange
            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("Test");
            comboBox.SelectedIndex = 0;
            // act
            formControlHelpers.clearSelection(comboBox);
            var result = comboBox.SelectedValue;
            // assert
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void clearSelectionFunction_listBox_nothingSelected()
        {
            // arrange
            ListBox listBox = new ListBox();
            listBox.Items.Add("test1");
            listBox.SelectedIndex = 0;
            // act
            formControlHelpers.clearSelection(listBox);
            var result = listBox.SelectedValue;
            // assert
            Assert.IsNull(result);
        }
        #endregion

        #region getSelectedContactsFunction
        [TestMethod()]
        public void getSelectedContactsFunction_selectedOneContact_ReturnOne()
        {
            // arrange
            DataGridView gridView = new DataGridView();
            var contacts = new Collection<Contact>();
            gridView.Columns.Add("Column1", "Name");
            gridView.Columns.Add("Column2", "Number");
            gridView.Rows.Add("Gorkem", "0872899404");
            gridView.Rows[0].Selected = true;
            // act
            Collection<Contact> result = formControlHelpers.getSelectedContacts(gridView, phoneBook, contacts);
            // assert
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod()]
        public void getSelectedContactsFunction_selectedManyContacts_ReturnSameAmount()
        {
            // arrange
            DataGridView gridView = new DataGridView();
            var contacts = new Collection<Contact>();
            gridView.Columns.Add("Column1", "Name");
            gridView.Columns.Add("Column2", "Number");
            gridView.Rows.Add("Gorkem", "0872899404");
            gridView.Rows.Add("Niklas", "4987509095");
            gridView.Rows.Add("Craig", "0787509095");
            gridView.Rows.Add("Ssali", "06495054");
            gridView.Rows.Add("Mpho", "1023076853");
            gridView.Rows[0].Selected = true;
            gridView.Rows[1].Selected = true;
            gridView.Rows[2].Selected = true;
            gridView.Rows[3].Selected = true;
            gridView.Rows[4].Selected = true;
            // act
            Collection<Contact> result = formControlHelpers.getSelectedContacts(gridView, phoneBook, contacts);
            // assert
            Assert.AreEqual(5, result.Count);
        }
        #endregion

        #region SelectFunctions { ComboBox, DataGridView & ListBox }
        [TestMethod()]
        public void selectFunction_comboBoxSelectedItem_ItemMatches()
        {
            // arrange
            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("Test");
            comboBox.SelectedIndex = 0;
            // act
            string result = formControlHelpers.select(comboBox);
            // assert
            Assert.AreEqual("Test", result);
        }

        [TestMethod()]
        public void selectFunction_dataGridViewSelectedValue_ValueMatches()
        {
            // arrange
            DataGridView gridView = new DataGridView();
            gridView.Columns.Add("Column1", "Name");
            gridView.Rows.Add("Test");
            gridView.CurrentCell = gridView[0,0];
            // act
            string result = formControlHelpers.select(gridView);
            // assert
            Assert.AreEqual("Test", result);
        }

        [TestMethod()]
        public void selectFunction_listBoxSelectedItem_ItemMatches()
        {
            // arrange
            ListBox listBox = new ListBox();
            listBox.Items.Add("Test");
            listBox.SelectedIndex = 0;
            // act
            string result = formControlHelpers.select(listBox);
            // assert
            Assert.AreEqual("Test", result);
        }
        #endregion
    }
}