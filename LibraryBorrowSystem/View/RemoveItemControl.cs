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
    public partial class RemoveItemControl : UserControl
    {
        Controller.BorrowController controller;
        public RemoveItemControl(Controller.BorrowController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (controller.RemoveItem(int.Parse(itemIdTB.Text)))
                {
                    updateMsg("Item successfully deleted.", false);
                }
                else
                {
                    updateMsg("Item does not exist.", true);
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
