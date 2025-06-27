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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new CreateForm().Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new ViewForm().Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new DeleteForm().Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
