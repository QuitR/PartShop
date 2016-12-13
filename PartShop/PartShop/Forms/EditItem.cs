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

namespace PartShop.Forms
{
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
        }

        private void Id_Click(object sender, EventArgs e)
        {
            Id.Text = "";
        }

        private void Price_Click(object sender, EventArgs e)
        {
            Price.Text = "";
        }

        private void Make_Click(object sender, EventArgs e)
        {
            Make.Text = "";
        }

        private void Model_Click(object sender, EventArgs e)
        {
            Model.Text = "";
        }

        private void Date_Click(object sender, EventArgs e)
        {
            Date.Text = "";
        }

        private void CountInStorage_Click(object sender, EventArgs e)
        {
            CountInStorage.Text = "";
        }

        private void CategoryId_Click(object sender, EventArgs e)
        {
            CategoryId.Text = "";
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            float price;
            DateTime date;
            int count;
            int category;
            int id;
            if (int.TryParse(CategoryId.Text, out category) &&
            int.TryParse(CountInStorage.Text, out count) &&
            DateTime.TryParse(Date.Text, out date) &&
            float.TryParse(Price.Text, out price) &&
            int.TryParse(Id.Text, out id)
            )
            {
                //Prideti i laikina DB, kad matytusi atnaujinus
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\bin\Debug\Database.mdf;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE dbo.ItemSet SET Price = @price, Make = @make, Model = @model, ReleaseDate = @releaseDate, CountInStorage = @countInStorage, CategoryId = @categoryId Where Id = @Id", connection);
                    command.Parameters.Add("@price", SqlDbType.Float).Value = Math.Round((decimal)price, 2);
                    command.Parameters.Add("@make", SqlDbType.NVarChar).Value = Make.Text;
                    command.Parameters.Add("@model", SqlDbType.NVarChar).Value = Model.Text;
                    command.Parameters.Add("@releaseDate", SqlDbType.DateTime).Value = date;
                    command.Parameters.Add("@countInStorage", SqlDbType.Int).Value = count;
                    command.Parameters.Add("@categoryId", SqlDbType.Int).Value = category;
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
                //Prideti i nuolatine DB, kad isliktu pakeitimai
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\Database.mdf;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE dbo.ItemSet SET Price = @price, Make = @make, Model = @model, ReleaseDate = @releaseDate, CountInStorage = @countInStorage, CategoryId = @categoryId Where Id = @Id", connection);
                    command.Parameters.Add("@price", SqlDbType.Float).Value = Math.Round((decimal)price, 2);
                    command.Parameters.Add("@make", SqlDbType.NVarChar).Value = Make.Text;
                    command.Parameters.Add("@model", SqlDbType.NVarChar).Value = Model.Text;
                    command.Parameters.Add("@releaseDate", SqlDbType.DateTime).Value = date;
                    command.Parameters.Add("@countInStorage", SqlDbType.Int).Value = count;
                    command.Parameters.Add("@categoryId", SqlDbType.Int).Value = category;
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
                Visible = false;
                Id.Text = "ID of item";
                Price.Text = "Price";
                Make.Text = "Make";
                Model.Text = "Model";
                Date.Text = "Date";
                CountInStorage.Text = "Count in storage";
                CategoryId.Text = "Category";
            }
            else
            {
                Edit.BackColor = Color.IndianRed;
                if (!float.TryParse(Price.Text, out price))
                    Edit.Text = "Price should be in float format!";
                if (!DateTime.TryParse(Date.Text, out date))
                    Edit.Text = "Date format in wrong!";
                if (!int.TryParse(CountInStorage.Text, out count))
                    Edit.Text = "Count in storage should be an integer!";
                if (!int.TryParse(CategoryId.Text, out category))
                    Edit.Text = "Category ID should be an integer!";
                if (!int.TryParse(Id.Text, out id))
                    Edit.Text = "ID should be an integer!";
            }
        }
    }
}
