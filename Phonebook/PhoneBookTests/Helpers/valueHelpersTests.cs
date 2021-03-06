﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void checknullsFunction_gridViewAccessibilityObjectNotNull_False()
        {
            
            //Arrange
            DataGridView grid = new DataGridView();
            grid.Columns.Add("col1", "Name");
            grid.Columns.Add("col2", "PhoneNumber");
            grid.Rows.Add("Phil Collins", "028987409505");
            grid.CurrentCell = grid[0,0];
            // act
            bool result = valueHelpers.checknulls(grid, error);
            // assert
            Assert.IsFalse(result);
        }

        #endregion
    }
}