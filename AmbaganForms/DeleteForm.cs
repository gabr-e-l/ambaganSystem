using AmbaganBusinessDataLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace AmbaganForms
{
    public partial class DeleteForm : Form
    {
        private string officerPosition;

        public DeleteForm(string position)
        {
            InitializeComponent();
            AvailableLists();
            officerPosition = position;
        }

        private void AvailableLists()
        {
            listBox1.Items.Clear();

            var listNames = AmbaganProcesses.GetListNames();
            foreach (var list in listNames)
            {
                listBox1.Items.Add(list);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            string listName = txtListName.Text.Trim().ToLower();

            var entries = AmbaganProcesses.GetListEntries(listName);

            if (entries.Count == 0)
            {
                MessageBox.Show("List not found or is empty.");
                return;
            }

            foreach (var entry in entries)
            {
                listBox2.Items.Add($"Name: {entry.Name}, Given: {entry.AmountGiven}, Change: {entry.Change}");
            }
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            string listName = txtListName.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(listName))
            {
                MessageBox.Show("Please enter a list name.");
                return;
            }

            var confirmed = MessageBox.Show($"Are you sure you want to delete the entire list '{listName}'?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmed == DialogResult.Yes)
            {
                if (AmbaganProcesses.RemoveWholeList(listName))
                {
                    MessageBox.Show("List deleted successfully.");

                    AvailableLists();

                    listBox2.Items.Clear();

                    txtListName.Clear();
                    txtName.Clear();
                }
                else
                {
                    MessageBox.Show("List not found.");
                }
            }
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            string listName = txtListName.Text.Trim().ToLower();
            string deleteName = txtName.Text.Trim().ToLower();

            if (listName == null || listName == "" && deleteName == null || deleteName == "")
            {
                MessageBox.Show("Both List Name and Name are required.");
                return;
            }

            if (AmbaganProcesses.RemoveNameFromList(deleteName, listName))
            {
                MessageBox.Show($"'{deleteName}' has been removed from the list.");

                btnView.PerformClick();
            }
            else
            {
                MessageBox.Show($"'{deleteName}' is not found in the list.");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new MainMenu(officerPosition).Show();
            this.Hide();
        }
    }
}
