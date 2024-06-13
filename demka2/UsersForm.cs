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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            string connectionString = "Data Source = DESKTOP-RJGLL1R\\SQLEXPRESS; Initial catalog=demka2; Integrated Security=true";
            string query = "SELECT userid, lastname + ' ' + firstname + ' ' + middlename FROM [demka2].[dbo].[user] WHERE status IS NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    usersListBox.Items.Add(new { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                }
            }
        }
    
        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void fireUserButton_Click(object sender, EventArgs e)
        {
            if (usersListBox.SelectedItem != null)
            {
                var selectedUser = (dynamic)usersListBox.SelectedItem;
                int userId = selectedUser.Id;

                string connectionString = "Data Source = DESKTOP-RJGLL1R\\SQLEXPRESS; Initial catalog=demka2; Integrated Security=true";
                string query = "UPDATE [demka2].[dbo].[user] SET status = 'уволен' WHERE userid = @userid";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userid", userId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                usersListBox.Items.Remove(usersListBox.SelectedItem);
            }
        }   
    }
}
