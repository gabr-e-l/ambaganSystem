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

namespace AmbaganForms
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
            AvailableLists();
        }

        private void AvailableLists()
        {
            listBox1.Items.Clear();

            var listNames = AmbaganProcesses.GetListNames();

            if (listNames.Count == 0)
            {
                listBox1.Items.Add("No available lists.");
                return;
            }

            foreach (var name in listNames)
            {
                listBox1.Items.Add(name);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            string listName = txtListName.Text.ToLower().Trim();

            if (listName == null || listName.Trim() == "")
            {
                MessageBox.Show("Please enter a list name.");
                return;
            }

            var entries = AmbaganProcesses.GetListEntries(listName);

            if (entries.Count == 0)
            {
                MessageBox.Show("No entries found for this list.");
                return;
            }

            foreach (var entry in entries)
            {
                string item = $"Name: {entry.Name}, Given: {entry.AmountGiven}, " +
                              $"Ambag: {entry.SetAmount}, Change: {entry.Change}";
                listBox2.Items.Add(item);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

    }
}
