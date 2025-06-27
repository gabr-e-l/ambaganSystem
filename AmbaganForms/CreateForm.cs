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
    public partial class CreateForm : Form
    {
        List<AmbagData.AmbagEntry> newEntries = new List<AmbagData.AmbagEntry>();
        private string currentListName = "";
        private double setAmount = 0;


        public CreateForm()
        {
            InitializeComponent();
        }

        private void txtListName_TextChanged(object sender, EventArgs e)
        {
            currentListName = txtListName.Text.Trim().ToLower();
            listBox1.Items.Clear();
            newEntries.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim().ToLower();
            if (!double.TryParse(txtGAmount.Text.Trim(), out double givenAmount))
            {
                MessageBox.Show("Invalid amount.");
                return;
            }

            if (currentListName == null || currentListName.Trim() == "" &
                name == null || name.Trim() == "")
            {
                MessageBox.Show("Text Boxes Cannot be Empty.");
                return;
            }

            if (!double.TryParse(txtSAmount.Text.Trim(), out setAmount) || setAmount <= 0)
            {
                MessageBox.Show("Invalid Set Amount.");
                return;
            }
            
            if (givenAmount < setAmount)
            {
                MessageBox.Show("Given Amount is less than Set Amount.");
                return;
            }

            double change = givenAmount - setAmount;

            var entry = new AmbagData.AmbagEntry(currentListName, setAmount, name, givenAmount, change);

            AmbaganProcesses.UpdateList(currentListName, setAmount, name, givenAmount);

            newEntries.Add(entry);

            listBox1.Items.Add($"Name: {name}, Given: {givenAmount}, Change: {change}");

            txtName.Clear();
            txtGAmount.Clear();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }
    }
}
