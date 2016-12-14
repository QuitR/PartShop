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
    public partial class ChooseCategory : Form
    {
        public int UserId { get; set; }
        BuyItem bi = new BuyItem();
        public ChooseCategory()
        {
            InitializeComponent();
            Load += CatCh_Load;
            bi.Hide();
            bi.VisibleChanged += Bi_VisibleChanged;
        }

        private void Bi_VisibleChanged(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void categorySetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            categorySetBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(databaseDataSet);
        }

        private void CatCh_Load(object sender, EventArgs e)
        {
            categorySetTableAdapter.Fill(databaseDataSet.CategorySet);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            bi.UserId = UserId;
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\bin\Debug\Database.mdf;Integrated Security=True"))
            {
                bool exists = false;
                int id;
                SqlCommand command = new SqlCommand("Select * from dbo.CategorySet", connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if ($"{dr["Name"]}" == CategoryChoose.Text)
                    {
                        int.TryParse(($"{dr["Id"]}"), out id);
                        bi.CategoryId = id;
                        exists = true;
                        bi.Show();
                        Hide();
                    }
                }
                if (!exists)
                {
                    OK.BackColor = Color.IndianRed;
                    OK.Text = "Not found.";
                }
            }
        }

        private void CategoryChoose_Click(object sender, EventArgs e)
        {
            CategoryChoose.Text = "";
        }

        private void ChooseCategory_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
