using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PartShop.Forms
{
    public partial class DeleteItem : Form
    {
        public DeleteItem()
        {
            InitializeComponent();
        }

        private void Changed_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(Id.Text, out id))
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\bin\Debug\Database.mdf;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE from dbo.ItemSet Where Id = @Id", connection);
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\Database.mdf;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE from dbo.ItemSet Where Id = @Id", connection);
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Delete.BackColor = System.Drawing.Color.IndianRed;
                Delete.Text = "ID should be an integer!";
            }
            Visible = false;
            Id.Text = "ID of item";
        }

        private void Id_Click(object sender, EventArgs e)
        {
            Id.Text = "";
        }

        private void DeleteItem_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
