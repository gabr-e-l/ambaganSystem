using DataLayer;

namespace AmbaganForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            var accNumber = txtAccNumber.Text;
            var pin = txtPIN.Text;

            OfficerAccountsService service = new OfficerAccountsService();

            var result = service.ValidateAccount(accNumber, pin);

            if (result)
            {
                var position = service.GetOfficerPosition(accNumber);

                if (position == "Treasurer")
                {
                    new MainMenu().Show();
                }

                else
                {
                    new LimitedMenu().Show();
                }

                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
