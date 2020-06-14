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
    public partial class ReserveControl : UserControl
    {
        Controller.BorrowController controller;
        public ReserveControl(Controller.BorrowController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Item item = controller.GetItem(int.Parse(itemIdTB.Text.Trim()));
                if (item == null)
                {
                    updateMsg("The requested item does not exist.", true);
                    return;
                }
                Model.Borrower borrower = controller.GetBorrower(int.Parse(borrowerIdTB.Text.Trim()));
                if (borrower == null)
                {
                    updateMsg(string.Format("A customer with the id {0}\r\ndoes not exist.", borrowerIdTB.Text), true);
                    return;
                }
                Model.State itemState = item.State;
                if (itemState == Model.State.Available)
                {
                    updateMsg("The requested item is currently available.", true);
                }
                else
                {
                    controller.Reserve(borrower.Id, item.ItemId);
                    updateMsg("Reserved successfully.", false);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.StackTrace);
                updateMsg("Invalid input format.", true);
            }
        }
        private void updateMsg(string msg, bool error)
        {
            msgText.Text = msg;
            msgText.ForeColor = error ? Color.FromArgb(255, 128, 128) : Color.LightGreen;
        }
    }
}
