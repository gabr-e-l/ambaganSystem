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
    public partial class SearchForm : Form
    {
        private string officerPosition;

        public SearchForm(string position)
        {
            InitializeComponent();
            officerPosition = position;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string searchName = txtName.Text.Trim().ToLower();

            if (searchName == null || searchName == "")
            {
                MessageBox.Show("Enter a name to search.");
                return;
            }

            var records = AmbaganProcesses.GetAllRecords(searchName);

            if (records.Count == 0)
            {
                MessageBox.Show("No records found.");
                return;
            }

            foreach (var record in records)
            {
                listBox1.Items.Add($"List: {record.ListName}, Name: {record.Name}, Given: {record.AmountGiven}, Ambag: {record.SetAmount}, Change: {record.Change}");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (officerPosition == "Treasurer")
            {
                new MainMenu(officerPosition).Show();
            }
            else
            {
                new LimitedMenu(officerPosition).Show();
            }

            this.Hide();
        }
    }
}
