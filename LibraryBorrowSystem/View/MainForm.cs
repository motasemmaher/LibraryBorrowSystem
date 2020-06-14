using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBorrowSystem.View
{
    public partial class MainForm : Form
    {

        private Controller.BorrowController controller = new Controller.BorrowController();
        private Control mainDataGrid;
        private Control borrowControl;
        private Control reserveControl;
        private Control returnControl;
        private Control addItemControl;
        private Control removeItemControl;
        private Control addBorrowerControl;
        private Control removeBorrowerControl;
        private Control itemInfoControl;
        private Control borrowerInfoControl;
        private Control editTimeoutsControl;

        public MainForm()
        {
            InitializeComponent();
            mainDataGrid = dataGridView1;
            borrowControl = new BorrowControl(controller);
            reserveControl = new ReserveControl(controller);
            returnControl = new ReturnControl(controller);
            addItemControl = new AddItemControl(controller);
            removeItemControl = new RemoveItemControl(controller);
            addBorrowerControl = new AddBorrowerControl(controller);
            removeBorrowerControl = new RemoveBorrowerControl(controller);
            itemInfoControl = new ItemInfoControl(controller);
            borrowerInfoControl = new BorrowerInfoControl(controller);
            editTimeoutsControl = new EditTimeoutsControl(controller);
        }

        #region WindowDrag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragArea_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            showExitDialog();
        }
        private void showExitDialog()
        {
            DialogResult res = MessageBox.Show("Save before exiting?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                controller.SaveData();
                controller.Terminate();
                Application.Exit();
            }
            else if (res == DialogResult.No)
            {
                controller.Terminate();
                Application.Exit();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadItems("all");
        }

        private void loadItems(string arg)
        {
            List<Model.Item> items = new List<Model.Item>();
            if (arg == "all")
            {
                items = controller.GetAllItems();
            }
            else if (arg == "late")
            {
                items = controller.GetLateItems();
            }
            else if (arg == "borrowed")
            {
                items = (from Model.Item i in controller.GetAllItems()
                         where i.State == Model.State.Unavailable
                         select i).ToList();
            }
            dataGridView1.DataSource = items;
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(borrowControl);
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(returnControl);
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(reserveControl);
        }

        private void viewAllBtn_Click(object sender, EventArgs e)
        {
            loadItems("all");
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(mainDataGrid);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controller.SaveData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showExitDialog();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(borrowControl);
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(returnControl);
        }

        private void reserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(reserveControl);
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadItems("all");
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(mainDataGrid);
        }

        private void borrowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadItems("borrowed");
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(mainDataGrid);
        }

        private void lateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadItems("late");
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(mainDataGrid);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(addItemControl);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(removeItemControl);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            (itemInfoControl as ItemInfoControl).UpdateComboBox();
            viewContainer.Controls.Add(itemInfoControl);
        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            (borrowerInfoControl as BorrowerInfoControl).UpdateComboBox();
            viewContainer.Controls.Add(borrowerInfoControl);
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(addBorrowerControl);
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(removeBorrowerControl);
        }

        private void editTimeoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewContainer.Controls.Clear();
            (editTimeoutsControl as EditTimeoutsControl).UpdateTimeoutFields();
            viewContainer.Controls.Add(editTimeoutsControl);
        }
    }
}
