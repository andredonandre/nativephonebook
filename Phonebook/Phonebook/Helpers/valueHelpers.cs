using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public class valueHelpers
    {
        public static void successMessage(string text)
        {
            MessageBox.Show(text);
        }

        public static void restrictinput(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)43)))
            {
                e.Handled = true;
            }
        }

        public static bool checknulls(TextBox textbox, ErrorProvider error)
        {
            bool value = false;
            if (textbox.Text == "")
            {
                error.SetError(textbox, "Please Type something");
                value = true;
            }
            return value;
        }

        public static bool checknulls(ComboBox combobox, ErrorProvider error)
        {
            bool value = false;
            if (combobox.SelectedItem == null || combobox.Text == "")
            {
                error.SetError(combobox, "Please select something");
                value = true;
            }

            return value;
        }

        public static bool checknulls(ListBox listbox, ErrorProvider error)
        {
            bool value = false;
            if (listbox.SelectedItem == null)
            {
                error.SetError(listbox, "Please select something");
                value = true;
            }
            return value;
        }

        public static bool checknulls(DataGridView grid, ErrorProvider error)
        {
            bool value = false;
            if (grid.CurrentRow.AccessibilityObject.Value == null || grid.CurrentCell.AccessibilityObject.Value == null )
            {
                error.SetError(grid, "Please select something");
                value = true;
            }
            return value;
        }
    }
}
