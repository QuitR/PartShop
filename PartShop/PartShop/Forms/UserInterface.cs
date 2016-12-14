using PartShop.Forms;
using System;
using System.Windows.Forms;

namespace PartShop
{
    public partial class UserInterface : Form
    {
        public int UserId { get; set; }
        ChooseCategory ChCat = new ChooseCategory();
        ShoppingCart cart = new ShoppingCart();
        MostPopular mp = new MostPopular();
        public UserInterface()
        {
            InitializeComponent();
            ChCat.Hide();
            cart.Hide();
            mp.Hide();
            ChCat.VisibleChanged += ChCat_VisibleChanged;
            cart.VisibleChanged += ChCat_VisibleChanged;
        }

        private void ChCat_VisibleChanged(object sender, EventArgs e)
        {
            Show();
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            ChCat.UserId = UserId;
            Hide();
            ChCat.Show();
        }

        private void Bought_Click(object sender, EventArgs e)
        {
            cart.UserId = UserId;
            Hide();
            cart.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void UserInterface_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void MostPopular_Click(object sender, EventArgs e)
        {
            mp.Show();
            Hide();
        }
    }
}
