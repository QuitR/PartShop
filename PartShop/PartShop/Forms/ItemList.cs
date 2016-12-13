using System;
using System.Windows.Forms;

namespace PartShop
{
    public partial class ItemList : Form
    {
        public ItemList()
        {
            InitializeComponent();
            Load += ItemList_Load;
        }

        private void itemSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            BindingSource.EndEdit();
            AdapterManager.UpdateAll(Data);
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            TableAdapter.Fill(Data.ItemSet);
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void ItemList_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void RefreshItems_Click(object sender, EventArgs e)
        {
            TableAdapter.Fill(Data.ItemSet);
        }
    }
}
