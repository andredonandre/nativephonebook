using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phonebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook.Tests
{
    [TestClass()]
    public class helpersTests
    {
        // Helpers for testing
        ErrorProvider error = new ErrorProvider();

        // Test methods
        [TestMethod()]
        public void successMessageFunctionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void restrictinputFunctionTest()
        {
            Assert.Fail();
        }

        #region CheckNullsFunction TextBox
        [TestMethod()]
        public void checknullsFunction_textBoxTextIsNull_True()
        {
            // act
            TextBox textBox = new TextBox();
            textBox.Text = "";
            bool result = valueHelpers.checknulls(textBox, error);
            // assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void checknullsFunction_textBoxTextIsNotNull_False()
        {
            // act
            TextBox textBox = new TextBox();
            textBox.Text = "Hello world";
            bool result = valueHelpers.checknulls(textBox, error);
            // assert
            Assert.IsFalse(result);
        }
        #endregion

        #region CheckNullsFunction ComboBox
        [TestMethod()]
        public void checknullsFunction_comboBoxSelectedItemIsNull_True()
        {
            // act
            ComboBox comboBox = new ComboBox();
            comboBox.SelectedItem = null;
            bool result = valueHelpers.checknulls(comboBox, error);
            // assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void checknullsFunction_comboBoxSelectedItemIsNotNull_False()
        {
            // act
            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("Test");
            comboBox.SelectedIndex = 0;
            bool result = valueHelpers.checknulls(comboBox, error);
            // assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void checknullsFunction_comboBoxTextIsNull_True()
        {
            // act
            ComboBox comboBox = new ComboBox();
            comboBox.Text = "";
            bool result = valueHelpers.checknulls(comboBox, error);
            // assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void checknullsFunction_comboBoxTextIsNotNull_False()
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("Test");
            comboBox.SelectedIndex = 0;
            bool result = valueHelpers.checknulls(comboBox, error);
            // assert
            Assert.IsFalse(result);
        }
        #endregion

        #region CheckNullsFunction ListBox
        [TestMethod()]
        public void checknullsFunction_listBoxSelectedItemIsNull_True()
        {
            // act
            ListBox listBox = new ListBox();
            listBox.Items.Add("Test");
            listBox.SelectedIndex = -1;
            bool result = valueHelpers.checknulls(listBox, error);
            // assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void checknullsFunction_listBoxSelectedItemIsNull_False()
        {
            // act
            ListBox listBox = new ListBox();
            listBox.Items.Add("Test");
            listBox.SelectedIndex = 0;
            bool result = valueHelpers.checknulls(listBox, error);
            // assert
            Assert.IsFalse(result);
        }
        #endregion

        #region CheckNullsFunction DataGridView
        [TestMethod()]
        public void checknullsFunction_gridViewAccessibilityObjectIsNull_True()
        {
            // act
            DataGridView dataGrid = new DataGridView();
            dataGrid.CurrentRow.AccessibilityObject.Value = null;
            bool result = valueHelpers.checknulls(dataGrid, error);
            // assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void checknullsFunctionTest7()
        {
            Assert.Fail();
        }
        #endregion
    }
}