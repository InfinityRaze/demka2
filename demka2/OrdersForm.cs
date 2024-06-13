using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demka2
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            string connectionString = "Data Source = DESKTOP-RJGLL1R\\SQLEXPRESS; Initial catalog=demka2; Integrated Security=true";
            string query = "SELECT orderid, nameconference, datecreation, orderstatus, paymentstatus FROM [demka2].[dbo].[order]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                dataGridView1.Columns["orderid"].HeaderText = "Номер заказа";
                dataGridView1.Columns["nameconference"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
