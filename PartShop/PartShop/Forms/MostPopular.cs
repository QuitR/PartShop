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
    public partial class MostPopular : Form
    {
        public MostPopular()
        {
            InitializeComponent();
            GetMostPopular();
        }
        public void GetMostPopular()
        {
            boughtStuffSetTableAdapter1.Fill(databaseDataSet1.BoughtStuffSet);
            itemSetTableAdapter1.Fill(databaseDataSet1.ItemSet);
            var query =
                (from products in databaseDataSet1.BoughtStuffSet
                 join items in databaseDataSet1.ItemSet on products.Price equals items.Price
                 where products.ReleaseDate == items.ReleaseDate
                 select new { Price = products.Price, Make = products.Make, Model = products.Model, Id = items.Id }
                );
            int max = 0, identifier = 0;
            foreach (var item in query)
            {
                int counter = 0;
                foreach (var item2 in query)
                {
                    if (item.Id == item2.Id)
                    {
                        counter++;
                    }
                }
                if (counter > max)
                {
                    max = counter;
                    identifier = item.Id;
                }
            }
            itemSetTableAdapter1.FillMostPopular(databaseDataSet1.ItemSet, identifier);
        }

        private void itemSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemSetBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.databaseDataSet1);

        }

        private void itemSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.itemSetBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.databaseDataSet1);

        }
    }
}
