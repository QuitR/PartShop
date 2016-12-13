using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartShop.Forms
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            Load += Categories_Load;
        }

        private void categorySetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categorySetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            this.categorySetTableAdapter.Fill(this.databaseDataSet.CategorySet);

        }

        private void Categories_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
