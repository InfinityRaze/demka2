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
    public partial class TechnicianForm : Form
    {
        public TechnicianForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            string connectionString = "Data Source = DESKTOP-RJGLL1R\\SQLEXPRESS; Initial catalog=demka2; Integrated Security=true";
            string query = "SELECT orderid, nameconference, orderstatus FROM [demka2].[dbo].[order]";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    ordersGridView.DataSource = dataTable;
                    ordersGridView.Columns["orderid"].HeaderText = "ID заказа";
                    ordersGridView.Columns["nameconference"].HeaderText = "Название конференции";
                    ordersGridView.Columns["orderstatus"].HeaderText = "Статус заказа";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке заказов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            if (ordersGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите заказ для обновления статуса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedStatus = statusComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedStatus))
            {
                MessageBox.Show("Пожалуйста, выберите новый статус.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedOrderId = (int)ordersGridView.SelectedRows[0].Cells["orderid"].Value;

            string connectionString = "Data Source = DESKTOP-RJGLL1R\\SQLEXPRESS; Initial catalog=demka2; Integrated Security=true";
            string updateQuery = "UPDATE [demka2].[dbo].[order] SET orderstatus = @orderstatus WHERE orderid = @orderid";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@orderstatus", selectedStatus);
                    command.Parameters.AddWithValue("@orderid", selectedOrderId);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Статус заказа успешно обновлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении статуса заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
