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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            Load += Users_Load;

        }

        private void userSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            this.userSetTableAdapter.Fill(this.databaseDataSet.UserSet);
        }

        private void Users_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
