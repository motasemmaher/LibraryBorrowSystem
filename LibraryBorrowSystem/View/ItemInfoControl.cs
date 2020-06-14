using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBorrowSystem.View
{
    public partial class ItemInfoControl : UserControl
    {
        Controller.BorrowController controller;
        public ItemInfoControl(Controller.BorrowController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Item item = comboBox1.SelectedItem as Model.Item;
            idL.Text = item.ItemId.ToString();
            nameL.Text = item.Name;
            categoryL.Text = item.Category.ToString();
            priceL.Text = item.Price.ToString();
            stateL.Text = item.State.ToString();
            resTimeL.Text = (item.ReservationTimeout / 60) + " hours";
            notRetL.Text = (item.NotReturnedTimeout / 60) + " hours";
            overdueL.Text = (item.OverdueTimeout / 60) + " hours";
            
            dataGridView1.DataSource = item.WaitingList.Select(x => new { BorrowerId = x }).ToList();
        }
        public void UpdateComboBox()
        {
            var q = from Model.Item i in controller.GetAllItems()
                    orderby i.ItemId
                    select i;

            comboBox1.DataSource = q.ToList();
        }
    }
}
