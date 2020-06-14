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
    public partial class AddBorrowerControl : UserControl
    {
        Controller.BorrowController controller;
        public AddBorrowerControl(Controller.BorrowController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Model.Borrower borrower = null;

            if (studentRB.Checked)
            {
                borrower = new Model.Student();
                borrower.MaxAllowedItems = 3;
            }
            else
            {
                borrower = new Model.Teacher();
                borrower.MaxAllowedItems = 5;
            }

            try
            {
                borrower.Id = int.Parse(borrowerIdTB.Text);
                borrower.Name = borrowerNameTB.Text;
                borrower.Email = borrowerEmailTB.Text;

                if (controller.AddBorrower(borrower))
                {
                    updateMsg((borrower is Model.Student ? "Student" : "Teacher")+" successfully added.", false);
                }
                else
                {
                    updateMsg("Borrower already exists.", true);
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
