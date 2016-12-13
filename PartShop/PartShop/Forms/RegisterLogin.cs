using System;
using System.Windows.Forms;

namespace PartShop
{
    public partial class RegisterLogin : Form
    {
        RegisterForm Registration = new RegisterForm();
        LoginForm LoginF = new LoginForm();
        public RegisterLogin()
        {
            InitializeComponent();
            Registration.Hide();
            LoginF.Hide();
            Show();
            Registration.FormClosed += SomeFormClosed;
            LoginF.FormClosed += SomeFormClosed;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Hide();
            Registration.Show();
        }
        private void SomeFormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginF.Show();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
