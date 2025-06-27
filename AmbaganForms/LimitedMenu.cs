using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbaganForms
{
    public partial class LimitedMenu : Form
    {
        private string officerPosition;

        public LimitedMenu(string position)
        {
            InitializeComponent();
            officerPosition = position;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new ViewForm(officerPosition).Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new SearchForm(officerPosition).Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
