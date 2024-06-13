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
    public partial class AddShiftForm : Form
    {
        public AddShiftForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            string connectionString = "Data Source = DESKTOP-RJGLL1R\\SQLEXPRESS; Initial catalog=demka2; Integrated Security=true";
            string query = "SELECT userid, firstname, lastname FROM [demka2].[dbo].[user]";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        usersListBox.Items.Add(new
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1) + " " + reader.GetString(2)
                        });
                    }
                    usersListBox.DisplayMember = "Name";
                    usersListBox.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке пользователей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (dateStartPicker.Value >= dateEndPicker.Value)
            {
                MessageBox.Show("Дата начала смены должна быть раньше даты окончания", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source = DESKTOP-RJGLL1R\\SQLEXPRESS; Initial catalog=demka2; Integrated Security=true";
            string insertShiftQuery = "INSERT INTO [demka2].[dbo].[shift] (datestart, dateend) OUTPUT INSERTED.shiftid VALUES (@datestart, @dateend)";
            string insertUserShiftQuery = "INSERT INTO [demka2].[dbo].[userlist] (userid, shiftid) VALUES (@userid, @shiftid)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand shiftCommand = new SqlCommand(insertShiftQuery, connection);
                    shiftCommand.Parameters.AddWithValue("@datestart", dateStartPicker.Value);
                    shiftCommand.Parameters.AddWithValue("@dateend", dateEndPicker.Value);

                    int shiftId = (int)shiftCommand.ExecuteScalar();

                    foreach (var selectedItem in usersListBox.SelectedItems)
                    {
                        int userId = (int)selectedItem.GetType().GetProperty("Id").GetValue(selectedItem, null);

                        SqlCommand userShiftCommand = new SqlCommand(insertUserShiftQuery, connection);
                        userShiftCommand.Parameters.AddWithValue("@userid", userId);
                        userShiftCommand.Parameters.AddWithValue("@shiftid", shiftId);
                        userShiftCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Смена и пользователи успешно добавлены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении смены: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
