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
    public partial class BorrowerInfoControl : UserControl
    {
        Controller.BorrowController controller;
        public BorrowerInfoControl(Controller.BorrowController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Borrower borrower = comboBox1.SelectedItem as Model.Borrower;
            idL.Text = borrower.Id.ToString();
            nameL.Text = borrower.Name;
            typeL.Text = borrower is Model.Student ? "Student" : "Teacher";
            emailL.Text = borrower.Email;
            stateL.Text = borrower.MaxAllowedItems.ToString();

            dataGridView1.DataSource = borrower.BorrowedItems.Select(x => new { ItemId = x }).ToList();
        }
        public void UpdateComboBox()
        {
            var q = from Model.Borrower b in controller.GetAllBorrowers()
                    orderby b.Id
                    select b;

            comboBox1.DataSource = q.ToList();
        }
    }
}
