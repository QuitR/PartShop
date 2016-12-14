using PartShop.DatabaseDataSetTableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PartShop.Forms
{
    public partial class BuyItem : Form
    {
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        private ProductSetTableAdapter productSetTableAdapter;
        public BuyItem()
        {
            InitializeComponent();
            Load += BuyItem_Load;
            productSetTableAdapter = new ProductSetTableAdapter();
        }

        private void itemSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void BuyItem_Load(object sender, EventArgs e)
        {
            itemSetTableAdapter.FillByCategory(databaseDataSet.ItemSet, CategoryId);
        }

        private void ItemId_Click(object sender, EventArgs e)
        {
            ItemId.Text = "";
        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\Database.mdf;Integrated Security=True"))
            {
                connection.Open();
                bool exists = false;
                int id, newcount;
                int.TryParse(ItemId.Text, out id);
                SqlCommand command = new SqlCommand("Select * from dbo.ItemSet", connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if ($"{dr["Id"]}" == ItemId.Text)
                    {
                        exists = true;
                        int.TryParse(($"{dr["CountInStorage"]}"), out newcount);
                        newcount--;
                        SqlCommand update = new SqlCommand("UPDATE dbo.ItemSet SET CountInStorage = @newCount WHERE Id = @id", connection);
                        update.Parameters.Add("@newCount", SqlDbType.Int).Value = newcount;
                        update.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        update.ExecuteNonQuery();
                        productSetTableAdapter.Fill(databaseDataSet.ProductSet);
                        var article =
                            (from products in databaseDataSet.ProductSet
                             where products.ItemId == id && products.IsNull("UserId")
                             select products
                            ).First();
                        SqlCommand StockUpdate = new SqlCommand("UPDATE dbo.ProductSet SET UserId = @UserId WHERE Article = @article", connection);
                        StockUpdate.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;
                        StockUpdate.Parameters.Add("@article", SqlDbType.Int).Value = article.Article;
                        StockUpdate.ExecuteNonQuery();
                        SqlCommand Insert = new SqlCommand("INSERT INTO dbo.BoughtStuffSet (Users, Price, Make, Model, ReleaseDate) VALUES (@user, @price, @make, @model, @date)", connection);
                        Insert.Parameters.Add("@user", SqlDbType.Int).Value = UserId;
                        Insert.Parameters.Add("@price", SqlDbType.Float).Value = Math.Round(float.Parse($"{dr["Price"]}"), 2);
                        Insert.Parameters.Add("@make", SqlDbType.NVarChar).Value = ($"{dr["Make"]}");
                        Insert.Parameters.Add("@model", SqlDbType.NVarChar).Value = ($"{dr["Model"]}");
                        Insert.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Parse($"{dr["ReleaseDate"]}");
                        Insert.ExecuteNonQuery();
                        Visible = false;
                    }
                }
                if (!exists)
                {
                    Purchase.BackColor = Color.IndianRed;
                    Purchase.Text = "Not found.";
                }
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\bin\Debug\Database.mdf;Integrated Security=True"))
            {
                connection.Open();
                bool exists = false;
                int id, newcount;
                int.TryParse(ItemId.Text, out id);
                SqlCommand command = new SqlCommand("Select * from dbo.ItemSet", connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if ($"{dr["Id"]}" == ItemId.Text)
                    {
                        exists = true;
                        int.TryParse(($"{dr["CountInStorage"]}"), out newcount);
                        newcount--;
                        SqlCommand update = new SqlCommand("UPDATE dbo.ItemSet SET CountInStorage = @newCount WHERE Id = @id", connection);
                        update.Parameters.Add("@newCount", SqlDbType.Int).Value = newcount;
                        update.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        update.ExecuteNonQuery();
                        productSetTableAdapter.Fill(databaseDataSet.ProductSet);
                        var article =
                            (from products in databaseDataSet.ProductSet
                             where products.ItemId == id && products.IsNull("UserId")
                             select products
                            ).First();
                        SqlCommand StockUpdate = new SqlCommand("UPDATE dbo.ProductSet SET UserId = @UserId WHERE Article = @article", connection);
                        StockUpdate.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;
                        StockUpdate.Parameters.Add("@article", SqlDbType.Int).Value = article.Article;
                        StockUpdate.ExecuteNonQuery();
                        SqlCommand Insert = new SqlCommand("INSERT INTO dbo.BoughtStuffSet (Users, Price, Make, Model, ReleaseDate) VALUES (@user, @price, @make, @model, @date)", connection);
                        Insert.Parameters.Add("@user", SqlDbType.Int).Value = UserId;
                        Insert.Parameters.Add("@price", SqlDbType.Float).Value = Math.Round(float.Parse($"{dr["Price"]}"), 2);
                        Insert.Parameters.Add("@make", SqlDbType.NVarChar).Value = ($"{dr["Make"]}");
                        Insert.Parameters.Add("@model", SqlDbType.NVarChar).Value = ($"{dr["Model"]}");
                        Insert.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Parse($"{dr["ReleaseDate"]}");
                        Insert.ExecuteNonQuery();
                        Visible = false;
                    }
                    if (!exists)
                    {
                        Purchase.BackColor = Color.IndianRed;
                        Purchase.Text = "Not found.";
                    }
                }
            }
            /*productSetTableAdapter.Fill(databaseDataSet.ProductSet);
            itemSetTableAdapter.Fill(databaseDataSet.ItemSet);
            foreach (var table in databaseDataSet.ProductSet)
            {
                int id;
                int.TryParse(ItemId.Text, out id);
                if (!table.IsNull("UserID") && table.UserId == UserId && table.ItemId == id)
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\Database.mdf;Integrated Security=True"))
                    {
                        connection.Open();
                        SqlCommand insert = new SqlCommand("INSERT INTO dbo.BoughtStuffSet (Users, Price, Make, Model, ReleaseDate) VALUES (@user, @price, @make, @model, @date)", connection);
                        insert.Parameters.Add("@price", SqlDbType.Float).Value = table.ItemSetRow.Price;
                        insert.Parameters.Add("@make", SqlDbType.NVarChar).Value = table.ItemSetRow.Make;
                        insert.Parameters.Add("@model", SqlDbType.NVarChar).Value = table.ItemSetRow.Model;
                        insert.Parameters.Add("@date", SqlDbType.DateTime).Value = table.ItemSetRow.ReleaseDate;
                        insert.Parameters.Add("@user", SqlDbType.Int).Value = UserId;
                        insert.ExecuteNonQuery();
                    }
                }
            }*/
        }

        private void BuyItem_VisibleChanged(object sender, EventArgs e)
        {
        }
    }
}
