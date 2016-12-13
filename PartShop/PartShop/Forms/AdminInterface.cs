using PartShop.Forms;
using System;
using System.Windows.Forms;

namespace PartShop
{
    public partial class AdminInterface : Form
    {
        ItemList il = new ItemList();
        AddItem ai = new AddItem();
        EditItem ei = new EditItem();
        DeleteItem di = new DeleteItem();
        Categories cats = new Categories();
        Users users = new Users();
        public AdminInterface()
        {
            InitializeComponent();
            il.Hide();
            ai.Hide();
            ei.Hide();
            di.Hide();
            users.Hide();
            cats.Hide();
            il.VisibleChanged += SomeFormInvisible;
            ai.VisibleChanged += SomeFormInvisible;
            ei.VisibleChanged += SomeFormInvisible;
            di.VisibleChanged += SomeFormInvisible;
            users.VisibleChanged += SomeFormInvisible;
            cats.VisibleChanged += SomeFormInvisible;
        }
        private void SomeFormInvisible(object sender, EventArgs e)
        {
            Show();
        }

        private void CheckItems_Click(object sender, EventArgs e)
        {
            il.Show();
            Hide();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            ai.Show();
            Hide();
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            ei.Show();
            Hide();
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            di.Show();
            Hide();
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            cats.Show();
            Hide();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            users.Show();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdminInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
