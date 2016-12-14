using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PartShop.Forms
{
    public partial class ShoppingCart : Form
    {
        public int UserId { get; set; }
        public ShoppingCart()
        {
            InitializeComponent();
            Load += ShoppingCart_Load;
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            this.boughtStuffSetTableAdapter.FillByUser(this.databaseDataSet.BoughtStuffSet, UserId);
        }

        /*private void Refresh_Click(object sender, EventArgs e)
        {
            this.boughtStuffSetTableAdapter.FillByUser(this.databaseDataSet.BoughtStuffSet, UserId);
        }*/

        private void Back_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void ShoppingCart_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
