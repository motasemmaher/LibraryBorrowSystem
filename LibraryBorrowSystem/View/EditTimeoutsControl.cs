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
    public partial class EditTimeoutsControl : UserControl
    {
        Controller.BorrowController controller;
        public EditTimeoutsControl(Controller.BorrowController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        public void UpdateTimeoutFields()
        {
            resNumeric.Value = controller.GetTimeout(0)/60;
            notretNumeric.Value = controller.GetTimeout(1)/60;
            overdueNumeric.Value = controller.GetTimeout(2)/60;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            controller.SetTimeout(0, (int)resNumeric.Value*60);
            controller.SetTimeout(1, (int)notretNumeric.Value*60);
            controller.SetTimeout(2, (int)overdueNumeric.Value*60);
            updateMsg("Saved successfully.", false);
        }

        private void updateMsg(string msg, bool error)
        {
            msgText.Text = msg;
            msgText.ForeColor = error ? Color.FromArgb(255, 128, 128) : Color.LightGreen;
        }
    }
}
