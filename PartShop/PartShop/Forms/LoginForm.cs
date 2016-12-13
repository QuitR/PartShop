using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartShop
{
    public partial class LoginForm : Form
    {
        AdminInterface ai = new AdminInterface();
        UserInterface UI = new UserInterface();
        public LoginForm()
        {
            InitializeComponent();
            ai.Hide();
            UI.Hide();
            ai.FormClosed += SomeFormClosed;
        }
        private void SomeFormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
        private void Username_Click(object sender, EventArgs e)
        {
            Username.Text = "";
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Text = "";
            Password.UseSystemPasswordChar = true;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\Database.mdf;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand("Select * from dbo.UserSet", connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if ($"{dr["Username"]}" == Username.Text && $"{dr["Password"]}" == Password.Text && $"{dr["IsAdmin"]}" == "True")
                    {
                        Hide();
                        ai.Show();
                    }
                    else if ($"{dr["Username"]}" == Username.Text && $"{dr["Password"]}" == Password.Text && $"{dr["IsAdmin"]}" == "False")
                    {
                        Hide();
                        UI.Show();
                    }
                    else
                        Login.Text = "Invalid data!";

                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
