using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptHelper
{
    internal class Scratch


    {
        private void Movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the TabControl object from the sender parameter
            TabControl tabControl = sender as TabControl;

            if (tabControl != null)
            {
                // Get the currently selected tab
                TabPage selectedTab = tabControl.SelectedTab;

                // Display a message box with the selected tab's name
                MessageBox.Show("Selected tab: " + selectedTab.Name);
            }
        }

        private void Movie_Selected(Object sender, TabControlEventArgs e)
        {

            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "TabPage", e.TabPage);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "TabPageIndex", e.TabPageIndex);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Action", e.Action);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "Selected Event");
        }

    }
}
