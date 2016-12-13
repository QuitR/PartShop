using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PartShop
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
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
        private void ReleaseDate_Click(object sender, EventArgs e)
        {
            ReleaseDate.Text = "";
        }
        private void CountInStorage_Click(object sender, EventArgs e)
        {
            CountInStorage.Text = "";
        }
        private void CategoryName_Click(object sender, EventArgs e)
        {
            CategoryName.Text = "";
        }

        private void AddAnItem_Click(object sender, EventArgs e)
        {
            float price;
            DateTime date;
            int count;
            int category;
            if (int.TryParse(CategoryName.Text, out category) &&
            int.TryParse(CountInStorage.Text, out count) &&
            DateTime.TryParse(ReleaseDate.Text, out date) &&
            float.TryParse(Price.Text, out price))
            {
                //Prideti i laikina DB, kad matytusi atnaujinus
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\bin\Debug\Database.mdf;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO dbo.ItemSet (Price, Make, Model, ReleaseDate, CountInStorage, CategoryId) VALUES (@price, @make, @model, @releaseDate, @countInStorage, @categoryId)", connection);
                    command.Parameters.Add("@price", SqlDbType.Float).Value = Math.Round((decimal)price, 2);
                    command.Parameters.Add("@make", SqlDbType.NVarChar).Value = Make.Text;
                    command.Parameters.Add("@model", SqlDbType.NVarChar).Value = Model.Text;
                    command.Parameters.Add("@releaseDate", SqlDbType.DateTime).Value = date;
                    command.Parameters.Add("@countInStorage", SqlDbType.Int).Value = count;
                    command.Parameters.Add("@categoryId", SqlDbType.Int).Value = category;
                    command.ExecuteNonQuery();
                }
                //Prideti i nuolatine DB, kad isliktu pakeitimai
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\Database.mdf;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO dbo.ItemSet (Price, Make, Model, ReleaseDate, CountInStorage, CategoryId) VALUES (@price, @make, @model, @releaseDate, @countInStorage, @categoryId)", connection);
                    command.Parameters.Add("@price", SqlDbType.Float).Value = Math.Round((decimal)price, 2);
                    command.Parameters.Add("@make", SqlDbType.NVarChar).Value = Make.Text;
                    command.Parameters.Add("@model", SqlDbType.NVarChar).Value = Model.Text;
                    command.Parameters.Add("@releaseDate", SqlDbType.DateTime).Value = date;
                    command.Parameters.Add("@countInStorage", SqlDbType.Int).Value = count;
                    command.Parameters.Add("@categoryId", SqlDbType.Int).Value = category;
                    command.ExecuteNonQuery();
                }
                Visible = false;
                Price.Text = "Price";
                Make.Text = "Make";
                Model.Text = "Model";
                ReleaseDate.Text = "Release Date";
                CountInStorage.Text = "Count in storage";
                CategoryName.Text = "Category id";
            }
            else
            {
                AddAnItem.BackColor = Color.IndianRed;
                if (!float.TryParse(Price.Text, out price))
                    AddAnItem.Text = "Price should be in float format!";
                if (!DateTime.TryParse(ReleaseDate.Text, out date))
                    AddAnItem.Text = "Date format in wrong!";
                if (!int.TryParse(CountInStorage.Text, out count))
                    AddAnItem.Text = "Count in storage should be an integer!";
                if (!int.TryParse(CategoryName.Text, out category))
                    AddAnItem.Text = "Category ID should be an integer!";
            }
        }

        private void AddItem_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
