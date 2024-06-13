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
    public partial class CreateOrderForm : Form
    {
        public CreateOrderForm()
        {
            InitializeComponent();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            string nameConference = nameConferenceTextBox.Text;
            int amountGuests = (int)amountGuestsNumericUpDown.Value;
            string equipment = equipmentTextBox.Text;

            if (string.IsNullOrEmpty(nameConference) || string.IsNullOrEmpty(equipment))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source = DESKTOP-RJGLL1R\\SQLEXPRESS; Initial catalog=demka2; Integrated Security=true";
            string query = "INSERT INTO [order] (nameconference, amountguests, equipment, orderstatus, paymentstatus, datecreation) VALUES (@nameconference, @amountguests, @equipment, '-', 'оплачен', GETDATE())";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nameconference", nameConference);
                    command.Parameters.AddWithValue("@amountguests", amountGuests);
                    command.Parameters.AddWithValue("@equipment", equipment);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Заказ успешно создан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
