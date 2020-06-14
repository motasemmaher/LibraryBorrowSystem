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
    public partial class AddItemControl : UserControl
    {
        Controller.BorrowController controller;
        public AddItemControl(Controller.BorrowController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Model.Item item = new Model.Item();
            try
            {
                item.ItemId = int.Parse(itemIdTB.Text);
                item.Name = itemNameTB.Text;
                item.Category = bookRB.Checked ? Model.Category.Book : Model.Category.CD;
                item.Price = (double)priceNumeric.Value;
                item.ReservationTimeout = controller.GetTimeout(0);
                item.NotReturnedTimeout = controller.GetTimeout(1);
                item.OverdueTimeout = controller.GetTimeout(2);

                if (controller.AddItem(item))
                {
                    updateMsg("Item successfully added.", false);
                }
                else
                {
                    updateMsg("Item already exists.", true);
                }
            }
            catch (FormatException ex)
            {
                updateMsg("Invalid Format", true);
            }
        }
        private void updateMsg(string msg, bool error)
        {
            msgText.Text = msg;
            msgText.ForeColor = error ? Color.FromArgb(255, 128, 128) : Color.LightGreen;
        }
    }
}
