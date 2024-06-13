using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demka2
{
    public partial class HeadOfDepartmentForm : Form
    {
        private int userId;

        public HeadOfDepartmentForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }

        private void shiftsButton_Click(object sender, EventArgs e)
        {
            ShiftsForm shiftsForm = new ShiftsForm();
            shiftsForm.Show();
        }
    }
}
