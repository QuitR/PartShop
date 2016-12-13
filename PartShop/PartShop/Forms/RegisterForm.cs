using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data;

namespace PartShop
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegistrationCmplt_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(\S+)$");
            bool username = false;
            bool password = false;
            bool email = false;
            bool unique = true;
            if (regex.IsMatch(Username.Text))
                username = true;
            if (regex.IsMatch(Password.Text) && Password.Text == PasswordRpt.Text)
                password = true;
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\Database.mdf;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand("Select * from dbo.UserSet", connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if ($"{dr["Username"]}" == Username.Text)
                        unique = false;
                }
            }
            try
            {
                var mail = new MailAddress(Email.Text);
                email = true;
            }
            catch
            {
                RegistrationCmplt.BackColor = System.Drawing.Color.Red;
                if (!email)
                    RegistrationCmplt.Text = "Invalid e-mail!";
            }
            if(username && password && email && unique)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\Database.mdf;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO dbo.UserSet (Username, Password, IsAdmin, Email) VALUES (@Username, @Password, @IsAdmin, @Email)", connection);
                    command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Username.Text;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password.Text;
                    command.Parameters.Add("@IsAdmin", SqlDbType.Bit).Value = false;
                    command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email.Text;
                    command.ExecuteNonQuery();
                }
                Close();
            }
            else
            {
                RegistrationCmplt.BackColor = System.Drawing.Color.Red;
                if (!username)
                    RegistrationCmplt.Text = "Invalid username!";
                if (!password)
                    RegistrationCmplt.Text = "Invalid password or typo while repeating!";
                if (!unique)
                    RegistrationCmplt.Text = "Such user already exists!";
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Username_Click(object sender, EventArgs e)
        {
            Username.Text = "";
        }

        private void Email_Click(object sender, EventArgs e)
        {
            Email.Text = "";
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Text = "";
            Password.UseSystemPasswordChar = true;
        }

        private void PasswordRpt_Click(object sender, EventArgs e)
        {
            PasswordRpt.Text = "";
            PasswordRpt.UseSystemPasswordChar = true;
        }
    }
}
