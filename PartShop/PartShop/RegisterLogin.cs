using System;
using System.Windows.Forms;

namespace PartShop
{
    public partial class RegisterLogin : Form
    {
        RegisterForm Registration = new RegisterForm();
        public RegisterLogin()
        {
            InitializeComponent();
            Registration.Hide();
            Show();
            Registration.FormClosed += RegistrationClosed;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Hide();
            Registration.Show();
        }
        private void RegistrationClosed(object sender, EventArgs e)
        {
            Show();
        }
    }
}
