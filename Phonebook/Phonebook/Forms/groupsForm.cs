﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phonebook.Helpers;

namespace Phonebook
{
    public partial class groupsForm : Form
    {
        Main parentForm;
        UserGroup selectedgroup;
        formControlHelpers formHelp = new formControlHelpers();

        public groupsForm(Main main)
        {
            InitializeComponent();
            parentForm = main;
            setdefaults();
        }
        //##################Event Handlers##################
        #region Event handlers

        private void uglistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uglistBox.SelectedItem != null)
                activateButtons();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (valueHelpers.checknulls(ugtextbox, errorProvider1) == false) {
                add();
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (valueHelpers.checknulls(ugtextbox, errorProvider1) == false) {
                save();
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            cancel();
        }
        #endregion

        #region Functions
        //################## Functions ##################
        
        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (valueHelpers.checknulls(uglistBox, errorProvider1) == false) { delete(); }

        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (valueHelpers.checknulls(uglistBox, errorProvider1) == false) { edit(); }
        }

        void setdefaults(){
            formControlHelpers.loadElement(uglistBox, parentForm.Usergroups);
        }

        void add() {
            var usergroup = new UserGroup(ugtextbox.Text);
            parentForm.Pb.Create(usergroup);
            updateForm();
            ugtextbox.Clear();
        }
        
        void edit() {
            setActiveUsergroup();
            addbutton.Visible = false;
            editbutton.Visible = false;
            deletebutton.Visible = false;
            uglistBox.Enabled = false;
            savebutton.Visible = true;
            cancelbutton.Visible = true;
        }

        void delete() {
            var value = formControlHelpers.select(uglistBox);
            UserGroup usergroup;
            if (value != null && value != "All Contacts" && value != "Unassigned")
            {
                usergroup = new UserGroup(value);
                parentForm.Pb.Delete(usergroup);
                updateForm();
            }
        }

        void save() {
            addbutton.Visible = true;
            editbutton.Visible = true;
            deletebutton.Visible = true;
            uglistBox.Enabled = true;
            savebutton.Visible = false;
            var newname = ugtextbox.Text;
            if (newname != selectedgroup.Name) { saveChanges(newname); }
            updateForm();
        }

        void cancel() {
            noactiveUsergroup();
            addbutton.Visible = true;
            editbutton.Visible = true;
            deletebutton.Visible = true;
            savebutton.Visible = false;
            uglistBox.Enabled = true;
        }

        void setActiveUsergroup() {
            var activegroup = parentForm.Pb.GetObject(formControlHelpers.select(uglistBox));
            selectedgroup = activegroup;
            ugtextbox.Text = selectedgroup.Name;
        }

        void noactiveUsergroup()
        {
            selectedgroup = new UserGroup("");
            ugtextbox.Text = selectedgroup.Name;
        }

        void updateForm() {
            formControlHelpers.loadElement(uglistBox, parentForm.Usergroups);
            parentForm.UpdateForm();
        }

        void activateButtons() {
            deletebutton.Visible = true;
            editbutton.Visible = true;
        }

        void deactivateButtons()
        {
            deletebutton.Visible = false;
            editbutton.Visible = false;
        }    

        private void saveChanges(string value) {
            var newgroup = new UserGroup(value);
            parentForm.Pb.Update(selectedgroup, newgroup);
        }
        #endregion
    }
}
